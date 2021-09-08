using API.Domain.Entities;
using Domain.Dtos;
using Domain.Interfaces.Services.Users;
using Domain.Repository;
using Domain.Security;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class LoginService : ILoginService
    {
        private IUserRepository _repository;
        private SigningConfigurations _signingConfigurations;
        private TokenConfiguration _tokenConfigurations;
        //para permitir usar conteúdo definido no appsettings.json
        private IConfiguration _configuration;
        public LoginService
         (
            IUserRepository repository,
            SigningConfigurations signingConfigurations,
            TokenConfiguration tokenConfiguration,
            IConfiguration configuration
        )
        {
            _repository = repository;
            _signingConfigurations = signingConfigurations;
            _tokenConfigurations = tokenConfiguration;
            _configuration = configuration;
        }

        public async Task<object> FindByLogin(LoginDto user)
        {
            var baseUser = new UserEntity();
           
            if (user != null && !string.IsNullOrWhiteSpace(user.Email))
            {
                baseUser = await _repository.FindByLogin(user.Email);
                
                if(baseUser == null)
                {
                    return new
                    {
                        authenticated = false,
                        message = "Credenciais de login inválidas."
                    };
                }
                else
                {
                    //implementação do JWT
                    ClaimsIdentity identity = new ClaimsIdentity
                    (
                        new GenericIdentity(user.Email),
                        new[]
                        {
                            //id do token
                            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                            new Claim(JwtRegisteredClaimNames.UniqueName, user.Email)
                        }
                    );

                    DateTime createdDate = DateTime.Now;
                    DateTime expirationDate = createdDate + TimeSpan.FromSeconds(_tokenConfigurations.Seconds);

                    var handler = new JwtSecurityTokenHandler();
                    string token = CreateToken(identity, createdDate, expirationDate, handler);
                    return SuccessObject(createdDate, expirationDate, token, user);
                }
            }
            else
            {
                return null;
            }

        }

        private string CreateToken(ClaimsIdentity identity, DateTime createDate, DateTime expirationDate, JwtSecurityTokenHandler handler)
        {
            var securityToken = handler.CreateToken
                (
                    new SecurityTokenDescriptor
                    {
                        Issuer = _tokenConfigurations.Issuer,
                        Audience = _tokenConfigurations.Audience,
                        SigningCredentials = _signingConfigurations.SigningCredentials,
                        Subject = identity,
                        NotBefore = createDate,
                        Expires = expirationDate
                    }
                );

            var token = handler.WriteToken(securityToken);
            return token;
        }
        private object SuccessObject(DateTime createDate, DateTime expirationDate, string token, LoginDto user)
        {
            return new
            {
                authenticated = true,
                created = createDate.ToString("dd-MM-yyyy HH:mm"),
                expiration = expirationDate.ToString("dd-MM-yyyy HH:mm"),
                accessToken = token,
                userName = user.Email,
                message = "Usuário autenticado!"
            };
        }
    }
}
