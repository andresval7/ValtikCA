using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using ValtikCA.Application.Interfaces;
using ValtikCA.Application.Requests;
using ValtikCA.Application.Responses;
using ValtikCA.Domain.Entities;

namespace ValtikCA.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TokenController : ControllerBase
    {
        private readonly IAutorizacionesService _service;

        public TokenController(IAutorizacionesService service)
        {
            _service = service;
        }

        [HttpPost]
            public IActionResult GetToken(UserLoginRequest loginRequest)
            {
                //Validar si el usuario existe en la BD y la contraseña es correcta
                var isValidUser = ValidateUser(loginRequest);
                if (!isValidUser)
                    return Unauthorized();

                //Si el usuario es valido genero el token de autenticación
                var token = GenerateToken(loginRequest.UserName);
                return Ok(new { token });
            }

            
            private bool ValidateUser(UserLoginRequest loginRequest)
            {
            // TODO: Ir a la BD y validar el usuario
                AutorizacionResponse autorizacionExistente = _service.GetAutorizacionByUser(loginRequest.UserName);
                

                //if (loginRequest.UserName == "admin" && loginRequest.PasswordAuth == "abc123")
                if(autorizacionExistente.UserName == loginRequest.UserName 
                    && autorizacionExistente.PasswordAuth == loginRequest.PasswordAuth)
                    return true;

                return false;
            }

            private string GenerateToken(string userName)
            {
                //Header
                var privateKey = "Valtik2022&Ciaasdasfasdfadsffdsgas";
                var symmetricSecurityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(privateKey));
                var signingCredentials = new SigningCredentials(symmetricSecurityKey, SecurityAlgorithms.HmacSha256);
                var header = new JwtHeader(signingCredentials);

                //Payload
                var claims = new[]
                {
                new Claim(ClaimTypes.NameIdentifier, userName),
                new Claim(ClaimTypes.Role, "Administrador"),
            };

                var payload = new JwtPayload
                (
                    "https://localhost:7194", // Issuer
                    "https://localhost:7194", // Audience
                    claims,
                    DateTime.Now, // Fecha de generación del token
                    DateTime.Now.AddMinutes(5) // Fecha expiración del token
                );


                //Signature
                var token = new JwtSecurityToken(header, payload);
                var jwtToken = new JwtSecurityTokenHandler().WriteToken(token);
                return jwtToken;
            }
    }
}
