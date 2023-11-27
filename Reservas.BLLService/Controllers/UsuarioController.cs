using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Reservas.BLL;
using Reservas.MODEL;

namespace Reservas.BLLService.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        [HttpGet(Name = "GetUsuario")]
        public ActionResult<List<Usuario>> GetUsuario()
        {
            try
            {
                List<Usuario> list = UsuarioRepository.GetAll();

                if (list != null) { return Ok(list); }
                return NotFound();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("{Id}", Name = "GetUsuarioById")]
        public ActionResult<Usuario> GetUsuarioById(int Id)
        {
            Usuario _usuario = UsuarioRepository.GetById(Id);

            try
            {
                if(_usuario != null)
                {
                    return Ok(_usuario);
                }
                return NotFound();
            }
            catch(Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost(Name = "AddUsuario")]
        public ActionResult<Usuario> AddUsuario(Usuario usuario)
        {
            try
            {
                Usuario _usuario = UsuarioRepository.Add(usuario);
                return _usuario == null ? NotFound() : Ok(_usuario);
            }
            catch(Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPut(Name = "UpdateUsuario")]
        public ActionResult<Usuario> UpdateUsuario(Usuario usuario)
        {
            try
            {
                if(usuario != null)
                {
                    Usuario _usuario = new Usuario();
                    _usuario.Id = usuario.Id;
                    _usuario.Ra = usuario.Ra;
                    _usuario.Nome = usuario.Nome;
                    _usuario.Curso = usuario.Curso;
                    _usuario.Semestre = usuario.Semestre;
                    _usuario.Senha = usuario.Senha;
                    UsuarioRepository.Update(_usuario);

                    return Ok(_usuario);
                }
                return NotFound();
            }
            catch(Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpDelete(Name = "DeleteUsuario")]
        public ActionResult DeleteUsuario(int id)
        {
            try
            {
                var usuario = UsuarioRepository.GetById(id);
                UsuarioRepository.Excluir(usuario);
                return Ok();
            }
            catch(Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
