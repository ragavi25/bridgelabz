using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Fundoo.Model;
using Microsoft.IdentityModel.Tokens;
using Model.Model;
using Repository.Context;

namespace Repository.Repository
{
    public class AccountRepImpl : IAccountRep
    {
        private readonly UserContext context;
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
                Id=registerModel.Id,
            };
            this.context.registers.Add(model);
            return Task.Run(() => context.SaveChanges());


        }

        public bool Login(LoginModel loginModel)
        {
            var result = FindEmail(loginModel.Email, loginModel.Password);
            var check = CheckPassword(loginModel.Email,loginModel.Password );
            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
               {
                   new Claim(ClaimTypes.Name, result.ToString(), check.ToString())
               }),
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            result.Token = tokenHandler.WriteToken(token);
            check.Token = tokenHandler.WriteToken(token);
            if (result == null && check == null)
            {
                return false;
            }
            return true;


        }
         public bool FindEmail(string email,string password)
         {
            var result = context.registers.Where(opt => opt.Email == email && opt.Password == password).SingleOrDefault();
                if(result!=null)
                {
                return true;
                }
            return false;
         }
        public bool CheckPassword(string email,string password)
        {
            var result = context.registers.Where(opt => opt.Email == email && opt.Password == password).SingleOrDefault();
            if(result!=null)
            {
                return true;
            }
            return false;
        }
    }
}

