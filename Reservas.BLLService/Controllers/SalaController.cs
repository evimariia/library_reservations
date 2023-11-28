using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Reservas.BLL;
using Reservas.MODEL;

namespace Reservas.BLLService.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class SalaController : ControllerBase
    {
        [HttpGet(Name = "GetSala")]
        public ActionResult<List<Sala>> GetSala()
        {
            try
            {
                List<Sala> list = SalaRepository.GetAll();

                if (list != null) { return Ok(list); }
                return NotFound();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("{Id}", Name = "GetSalaById")]
        public ActionResult<Sala> GetSalaById(int Id)
        {
            Sala _sala = SalaRepository.GetById(Id);

            try
            {
                if (_sala != null)
                {
                    return Ok(_sala);
                }
                return NotFound();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("{Numero}", Name = "GetSalaByNumero")]
        public ActionResult<Sala> GetSalaByNumero(int Numero)
        {
            Sala _sala = SalaRepository.GetByNumero(Numero);

            try
            {
                if (_sala != null)
                {
                    return Ok(_sala);
                }
                return NotFound();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost(Name = "AddSala")]
        public ActionResult<Sala> AddSala(Sala sala)
        {
            try
            {
                Sala _sala = SalaRepository.Add(sala);
                return _sala == null ? NotFound() : Ok(_sala);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPut(Name = "UpdateSala")]
        public ActionResult<Sala> UpdateSala(Sala sala)
        {
            try
            {
                if (sala != null)
                {
                    Sala _sala = new Sala();
                    _sala.Id = sala.Id;
                    _sala.Numero = sala.Numero;
                    _sala.Modalidade = sala.Modalidade;
                    _sala.QtdePessoas = sala.QtdePessoas;
                    SalaRepository.Update(_sala);
                    return Ok(_sala);
                }
                return NotFound();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpDelete(Name = "DeleteSala")]
        public ActionResult DeleteSala(int id)
        {
            try
            {
                var sala = SalaRepository.GetById(id);
                SalaRepository.Excluir(sala);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
      
    }
}