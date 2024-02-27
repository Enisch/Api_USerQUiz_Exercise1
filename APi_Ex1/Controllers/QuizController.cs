using ContextoBd;
using Infradata.Domain_.Models_Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace APi_Ex1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class QuizController : Controller
    {
        private readonly ContextDb db;
        public QuizController(ContextDb db)
        {
            this.db = db;
        }
        [HttpGet("Test Use.")]
        public ActionResult<string> RetornoSimples()
        {

            var Fala = "TextoDeUsoUnico";
            return Ok(Fala);
        }


        [HttpGet("Search for all Users registered on DB")]
        public async Task<ActionResult<Usuario>> NomeUsuario()
        {//No users registered in the database yet.
            var  UsuarioReturn= await db.UsuariosDoQuiz.ToListAsync();

            return Ok(UsuarioReturn);
        }

       

        [HttpGet("Get through user{id}")]
        public async Task<ActionResult<Usuario>> GetUserForID(int ID)
        {
            var USerID = await db.UsuariosDoQuiz.Where(x => x.Id == ID).FirstOrDefaultAsync();

            if (USerID == null)
                return NotFound("USer not found.\nTry with another id.");

            return Ok(USerID);
        }
    }
}
