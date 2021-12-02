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
                //a condição para login é inserir um email existente
                //baseUser = await _repository.FindByLogin(user.Email);
                baseUser = new UserEntity{
                    Email = "ffersants@ok.com",
                    Name = "Fernando",
                    Id = new Guid()
                };
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
                    //informações acerca do usuário que serão envolvidas no token
                    ClaimsIdentity identity = new ClaimsIdentity
                    (
                        //Claims are statements about an entity(typically, the user) and additional data.
                        new GenericIdentity(user.Email),
                        new[]
                        {
                            /*
                           The "jti" (JWT ID) claim provides a unique identifier for the JWT.
                           The identifier value MUST be assigned in a manner that ensures that
                           there is a negligible probability that the same value will be
                           accidentally assigned to a different data object; if the application
                           uses multiple issuers, collisions MUST be prevented among values
                           produced by different issuers as well.  The "jti" claim can be used
                           to prevent the JWT from being replayed.  The "jti" value is a case-
                           sensitive string.  Use of this claim is OPTIONAL.
                            */
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
            //criando o jwt
            var securityToken = handler.CreateToken
                (
                    new SecurityTokenDescriptor
                    {
                        Issuer = _tokenConfigurations.Issuer,
                        /*
                          The "aud" (audience) claim identifies the recipients that the JWT is
                          intended for. 
                         */
                        Audience = _tokenConfigurations.Audience,
                        //algoritmo
                        SigningCredentials = _signingConfigurations.SigningCredentials,
                        /*
                            The "sub" (subject) claim identifies the principal that is the
                            subject of the JWT.  The claims in a JWT are normally statements
                            about the subject.
                         */
                        Subject = identity,
                        NotBefore = createDate,
                        /*
                           The "exp" (expiration time) claim identifies the expiration time on
                           or after which the JWT MUST NOT be accepted for processing.  The
                           processing of the "exp" claim requires that the current date/time
                           MUST be before the expiration date/time listed in the "exp" claim.
                         */
                        Expires = expirationDate
                    }
                );
            /*
             If there is an inner token, the inner token's payload will be used.
             If SigningCredentials is set, the JWT will be signed. 
            */
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
