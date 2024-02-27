using AutoMapper;
using ContextoBd;
using Dtos__Mappings.Dto____Mappings;
using Dtos__Mappings.Interface;
using Infradata.Domain_.InterfacesRepositories;
using Infradata.Domain_.LoginModel;
using Infradata.Domain_.Models_Entities;
using Microsoft.AspNetCore.Mvc;
using Repositories.HashPasswordRepository;
using Repositories.Repositories;
using Services_DependencyInjection.TokenJWTGenerator;

namespace APi_Ex1.Controllers
{
    [ApiController]
    [Route("Api/(Controller)")]
    public class UsuarioController : Controller
    {
        private readonly IMapperUsuarioDto usuarioDto;
        private readonly IUsuario user;
        private readonly JwtTokenGenerator jwtToken;

        public UsuarioController(IMapperUsuarioDto usuarioDto, IUsuario user, JwtTokenGenerator jwtToken)
        {
            this.usuarioDto = usuarioDto;
            this.user = user;
            this.jwtToken = jwtToken;
            
        }

        [HttpGet("GetAllUSer's")]
        public async Task<ActionResult<DtosUsuario>> GetAllUsers()
        {
            var AllUSers = await user.GetAllUSers();

            if (AllUSers == null)
                return NotFound();

            return Ok(AllUSers);
        }

        [HttpPost("Sign-up")]//Como o Usuario não possui construtor Parameteless não é possivel instancialo em runtime.
        public async Task<ActionResult> CadastroUsuario(DtosUsuario Usuario)
        {
            var NewUser = await usuarioDto.CadastraUSuario(Usuario);

            if (NewUser != null)
            {
                return Ok("USer Registered sucessfuly.");
            }

            return BadRequest("Error.\nTry again. ");
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<DtosUsuario>> GetUserByID(int id)
        {
            var USerByID = await user.GetUserByID(id);

            if (USerByID == null)
                return BadRequest("User not Founded ");

            return Ok(USerByID);
        }


        [HttpPost("Sign-In")]
        public async Task<ActionResult<TokenJWT>> UserLogin(LoginModels login)
        {
            var Confirm_one = await jwtToken.CheckEmailAvailability(login.Email!);

            if (!Confirm_one)
                return Unauthorized();

            var confirm_two= await jwtToken.CheckIfUserIsReal(login.Email!,login.Password!);

            if(!confirm_two)
                return Unauthorized();

            var User = await jwtToken.GetUserByEmail(login.Email!);

            var Token = jwtToken.TokenGenerator(User.Id, User.Email!);

            return new TokenJWT
            { Token = Token };
        }
    }
}
