// --------------------------------------------------------------------------------------------------------------------
// <copyright file=AccountController.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="R Ragavi"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Configuration;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net.Mail;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using Experimental.System.Messaging;
using Fundoo.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Model.Model;
using Repository.Context;
using StackExchange.Redis;

namespace Repository.Repository
{
    public class AccountRep : IAccountRep
    {
        /// <summary>
        /// purpose:get the UserContext using database connections.
        /// </summary>
        private readonly UserContext context;
        private readonly IConfiguration configuration;
        public AccountRep(UserContext userContext, IConfiguration configurations)
        {
            context = userContext;
            this.configuration = configurations;
        }
        public AccountRep()
        {
        }
        /// <summary>
        /// Purpose:create the register.
        /// </summary>
        /// <param name="registerModel"></param>
        /// <returns></returns>
        public Task<int> CreateRegister(RegisterModel registerModel)
        {
            RegisterModel model = new RegisterModel()
            {
                FirstName = registerModel.FirstName,
                LastName = registerModel.LastName,
                Email = registerModel.Email,
                Password = registerModel.Password,
               // Id = registerModel.Id,
                ProfilePicture=registerModel.ProfilePicture
            };
           this.context.registers.Add(model);
             return Task.Run(() => context.SaveChanges());
           // return default;
        }
        /// <summary>
        /// Purpose:create the Login.
        /// </summary>
        /// <param name="loginModel"></param>
        /// <returns></returns>
        public async Task<String> Login(LoginModel loginModel)
        {
            if (FindEmail(loginModel.Email))
            {
                //var Jwtsettings = new Jwtsetting();
                if (CheckPassword(loginModel.Email, loginModel.Password))
                {
                    //var key = configuration["Jwt:Key"];
                    // var secretkey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key));
                    var SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["Jwt:Key"])), SecurityAlgorithms.HmacSha256);
                    var token = new JwtSecurityToken(
                        issuer: configuration["Jwt:url"],
                        audience: configuration["Jwt:url"],
                        expires: DateTime.Now.AddMilliseconds(60),
                        signingCredentials: SigningCredentials);
                    var securitytoken = new JwtSecurityTokenHandler().WriteToken(token);
                   // this.context.SaveChanges();
                    return securitytoken;

                }
            }
            /*LoginModel model = new LoginModel();
            var result = this.context.registers.Where(op => op.Email == model.Email).SingleOrDefault();
            if (result != null) {
                try {
                    var check = CheckPassword(loginModel.Email, loginModel.Password);
                    var key = configuration["Jwt:Key"];
                    var tokenDescriptor = new SecurityTokenDescriptor
                    {
                        Subject = new ClaimsIdentity(new Claim[]
                        {

                   new Claim("Name", loginModel.Email.ToString()),
                    new Claim("Password",loginModel.Password.ToString())
                       }),
                        Expires = DateTime.UtcNow.AddDays(1),
                        SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key)), SecurityAlgorithms.HmacSha256)
                    };
                    var tokenHandler = new JwtSecurityTokenHandler();
                    var tokenDiscripter = tokenHandler.CreateToken(tokenDescriptor);
                    var securityToken = tokenHandler.WriteToken(tokenDiscripter);
                   // var cachekey = loginModel.Email;

                   *//* ConnectionMultiplexer connectionMultiplexer = ConnectionMultiplexer.Connect("127.0.0.1:6379");
                    IDatabase database = connectionMultiplexer.GetDatabase();
                    database.StringSet(key: cachekey, securityToken);
                    database.StringGet(cachekey);*/
                   /* result.Status = true;
                    var data = new Adminlist()
                    {
                        Email = loginModel.Email,
                        Logintime = DateTime.Now
                    };*//*


                    //this.context.Adminlists.Add(data);
                    // Task.Run(() => context.SaveChanges());
                    return securityToken;
                }
                catch(Exception s)
                {
                    throw new Exception(s.Message);
                }
               
            }*/
            return "Invalid";
        }
        /// <summary>
        /// purpose:create the FindMail.
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public bool FindEmail(string email)
        {
            var result = context.registers.Where(opt => opt.Email == email).SingleOrDefault();
            if (result != null)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Purpose:create the Checkpassword.
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool CheckPassword(string email, string password)
        {
            var result = context.registers.Where(opt => opt.Email == email && opt.Password == password).SingleOrDefault();
            if (result != null)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Purpose:create the ForgotPassword.send the mail.
        /// </summary>
        /// <param name="forgotPassword"></param>
        /// <returns></returns>
        public async Task<string> ForgotPassword(ForgotPasswordModel forgotPassword)
        {
            
            string email = forgotPassword.Email;
            if (email != null)
            {
                string msg = email;
                MessageQueue Myqueue;
                ////Get a MessageQueue
                if (MessageQueue.Exists(@".\private$\Myqueue"))
                {
                    Myqueue = new MessageQueue(@".\private$\Myqueue");
                }
                else
                {
                    Myqueue = MessageQueue.Create(@".\private$\Myqueue");
                }
                Message message = new Message();
                message.Formatter = new BinaryMessageFormatter();
                message.Body = msg;
                message.Label = "MsmqMessage";
                if (msg.Contains(email))
                {
                    message.Priority = MessagePriority.High;
                }
                else
                {
                    message.Priority = MessagePriority.Low;
                }
                
                RegisterModel user = this.context.registers.Where<RegisterModel>(Item => Item.Email == email).FirstOrDefault();
                if (user != null)
                {
                    string password = this.NewPassword();
                    var FromAddress = new MailAddress("raghavimr15@gmail.com");
                    var ToAddress = new MailAddress(email);
                    string subject = "New Password";
                    string body = "Your new password is" + password ;
                    SmtpClient smtp = new SmtpClient
                    {
                        Host = "smtp.gmail.com",
                        Port = 587,
                        EnableSsl = true,
                        DeliveryMethod = SmtpDeliveryMethod.Network,
                        UseDefaultCredentials = false,
                        Credentials = new System.Net.NetworkCredential("youremailid", "yourpasword")
                    };
                    using (var messaging = new MailMessage(FromAddress, ToAddress)
                    {

                        Subject = subject,
                        Body = body
                    })
                    {
                        try
                        {
                            Myqueue.Send(msg);
                            smtp.Send(messaging);
                        }
                        catch (Exception e)
                        {
                            throw new Exception(e.Message);
                        }
                    }
                    user.Password = password;
                    this.context.Update(user);
                    await Task.Run(() => this.context.SaveChanges());
                    return "success";
                }
                return null;
            }
           return null;
        }
        /// <summary>
        /// Purpose:create the NewPassword.
        /// </summary>
        /// <returns></returns>
        private string NewPassword()
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
        /// <summary>
        /// Purpose:create the ResetPassword.
        /// </summary>
        /// <param name="reset"></param>
        /// <returns></returns>
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
        /// <summary>
        /// purpose:create the EmailLogin.
        /// </summary>
        /// <param name="loginModel"></param>
        /// <returns></returns>
        public async Task<RegisterModel> EmailLogin(LoginModel loginModel)
        {
            var Jwtsettings = new Jwtsetting();
            var result = this.context.registers.Where(op => op.Email == loginModel.Email).SingleOrDefault();
            if (result != null)
            {
                try
                {
                    var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("Jwtsettings.Secret"));
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
        /// <summary>
        /// Purpose:create the FaceBookLogin.
        /// </summary>
        /// <param name="loginModel"></param>
        /// <returns></returns>
         public async Task<RegisterModel> FaceBookLogin(LoginModel loginModel)
         { 
                Jwtsetting jwt = new Jwtsetting();
                var result = this.context.registers.Where(r => r.Email == loginModel.Email).SingleOrDefault();
                if (result != null)
                {
                    try
                    {
                        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("jwt.Secret"));
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

        public async Task<string> Logout(string email)
        {
            var result = this.context.registers.Where(op => op.Email == email).FirstOrDefault();
            if (result != null)
            {
                    string cachekey = email;
                    ConnectionMultiplexer connectionMultiplexer = ConnectionMultiplexer.Connect("127.0.0.1:6379");
                    IDatabase database = connectionMultiplexer.GetDatabase();
                    database.KeyDelete(cachekey);
                    result.Status = false;
                    await this.context.SaveChangesAsync();
                    return "success";
                
            }
            return null;

        }

        public string ProfilePicture(string email, IFormFile image)
        {
            try
            {
                var result = image.OpenReadStream();
                var name = image.FileName;
                Account account = new Account("dxizbs2aq", "572583872924614", "572583872924614");
                Cloudinary cloudinary = new Cloudinary(account);
                var UploadFile = new ImageUploadParams()
                {
                    File = new FileDescription(name, result)
                };
                var uploadResult = cloudinary.Upload(UploadFile);

                var data = this.context.registers.Where(Op => Op.Email == email).SingleOrDefault();
                data.ProfilePicture = uploadResult.Uri.ToString();
                this.context.SaveChanges();
                return data.ProfilePicture;
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
      
    }
}

