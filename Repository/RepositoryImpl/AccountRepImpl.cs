using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net.Mail;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Fundoo.Model;
using Microsoft.IdentityModel.Tokens;
using Model.Model;
using Repository.Context;
using StackExchange.Redis;
using sun.security.util;

namespace Repository.Repository
{
    public class AccountRepImpl : IAccountRep
    {

        private readonly UserContext context;
        private readonly object Jwtsetting;

        //   private readonly Iconfigure iconfigure;
        public AccountRepImpl(UserContext userContext)
        {
            this.context = userContext;
        }

        public Task<int> CreateRegister(RegisterModel registerModel)
        {
            RegisterModel model = new RegisterModel()
            {
                FirstName = registerModel.FirstName,
                LastName = registerModel.LastName,
                Email = registerModel.Email,
                Password = registerModel.Password,
                Id = registerModel.Id,
            };
            this.context.registers.Add(model);
            return Task.Run(() => context.SaveChanges());


        }

        public string Login(LoginModel loginModel)
        {
            LoginModel model = new LoginModel();
            var result = FindEmail(loginModel.Email);
            var check = CheckPassword(loginModel.Email, loginModel.Password);

            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
               {
                   new Claim("Name", loginModel.Email),
                    new Claim("Password",loginModel.Password)
               }),
            };
            var tokenDiscripter = tokenHandler.CreateToken(tokenDescriptor);
            var securityToken = tokenHandler.WriteToken(tokenDiscripter);
            return securityToken;
            //if (result == null && check == null)
            //{
            //    return false;
            //}
            //return true;


        }
        public bool FindEmail(string email)
        {
            var result = context.registers.Where(opt => opt.Email == email).SingleOrDefault();
            if (result != null)
            {
                return true;
            }
            return false;
        }
        public bool CheckPassword(string email, string password)
        {
            var result = context.registers.Where(opt => opt.Email == email && opt.Password == password).SingleOrDefault();
            if (result != null)
            {
                return true;
            }
            return false;
        }
        public async Task<string> ForgotPassword(ForgotPasswordModel forgotPassword)
        {
            string email = forgotPassword.Email;
            if (email != null)
            {
                RegisterModel user = this.context.registers.Where<RegisterModel>(Item => Item.Email == email).FirstOrDefault();
                if (user != null)
                {

                    string password = this.NawPassword();
                    var fromAddress = new MailAddress("raghavimr15@gmail.com");
                    var fromPassword = "ragavi";
                    var toAddress = new MailAddress(forgotPassword.Email);
                    string subject = "New Password";
                    string body = "Your new password is" + " " + password;
                    SmtpClient smtp = new SmtpClient
                    {
                        Host = "smtp.gmail.com",
                        Port = 587,
                        EnableSsl = true,
                        DeliveryMethod = SmtpDeliveryMethod.Network,
                        UseDefaultCredentials = false,
                        Credentials = new System.Net.NetworkCredential(fromAddress.Address, fromPassword)
                    };
                    using (var message = new MailMessage(fromAddress, toAddress)
                    {
                        Subject = subject,
                        Body = body
                    })
                    {
                        try
                        {
                            smtp.Send(message);
                        }
                        catch (Exception e)
                        {
                            throw new Exception(e.Message);
                        }
                    }

                    user.Password = password;
                    this.context.Update(user);
                    await Task.Run(() => this.context.SaveChangesAsync());
                    return "success";
                }

                return null;
            }

            return null;
        }

        private string NawPassword()
        {
            string ch = "asdfghjklqwertyuiopzxcvbnm1234567890@";
            Random random = new Random();
            char[] chars = new char[ch.Length];
            for (int i = 0; i < ch.Length; i++)
            {
                chars[i] = ch[random.Next(0, ch.Length)];
            }
            return new string(chars);
        }

        public async Task<string> ResetPassWord(ResetPassWord reset)
        {
            string password = reset.Password;
            RegisterModel result = this.context.registers.Where<RegisterModel>(op => op.Password == password).FirstOrDefault();
            if (result != null)
            {
                string passwords = reset.Confirmpassword;
                result.Password = passwords;
                this.context.Update(result);
                await Task.Run(() => this.context.SaveChangesAsync());
                return "success";
            }
            return null;
        }
        public async Task<RegisterModel> EmailLogin(LoginModel loginModel)
        {
            var Jwtsettings = new Jwtsetting();
            var result = this.context.registers.Where(op => op.Email == loginModel.Email).SingleOrDefault();
            if (result != null)
            {
                try
                {
                    var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Jwtsettings.Secret));
                    var credential = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
                    var token = new JwtSecurityToken(
                        expires: DateTime.Now.AddDays(1),
                        signingCredentials: credential);

                    var cacheKey = loginModel.Email;

                    ConnectionMultiplexer connection = ConnectionMultiplexer.Connect("127.0.0.1:6379");
                    IDatabase database = connection.GetDatabase();
                    database.StringSet(cacheKey, token.ToString());
                    database.StringGet(cacheKey);

                    result.Status = true;
                    await this.context.SaveChangesAsync();
                    return result;
                }
                catch (Exception c)
                {
                    throw new Exception(c.Message);
                }
            }
            return null;
        }
         public async Task<RegisterModel> FaceBookLogin(LoginModel loginModel)
            {
                Jwtsetting jwt = new Jwtsetting();
                var result = this.context.registers.Where(r => r.Email == loginModel.Email).SingleOrDefault();
                if (result != null)
                {
                    try
                    {
                        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwt.Secret));
                        var credential = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
                        var token = new JwtSecurityToken(
                            expires: DateTime.Now.AddDays(1),
                            signingCredentials: credential);

                        var cacheKey = loginModel.Email;

                        ConnectionMultiplexer connection = ConnectionMultiplexer.Connect("127.0.0.1:6379");
                        IDatabase database = connection.GetDatabase();
                        database.StringSet(cacheKey, token.ToString());
                        database.StringGet(cacheKey);

                        result.Status = true;
                        await this.context.SaveChangesAsync();
                        return result;
                    }
                    catch (Exception e)
                    {
                        throw new Exception(e.Message);
                    }
                }

                return null;
            }
    }
}

