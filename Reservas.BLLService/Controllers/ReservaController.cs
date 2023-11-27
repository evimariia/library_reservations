using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Reservas.BLL;
using Reservas.MODEL;

namespace Reservas.BLLService.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ReservaController : ControllerBase
    {
        [HttpGet(Name = "GetReserva")]
        public ActionResult<List<Reserva>> GetReserva()
        {
            try
            {
                List<Reserva> list = ReservaRepository.GetAll();

                if (list != null) { return Ok(list); }
                return NotFound();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("{Id}", Name = "GetReservaById")]
        public ActionResult<Reserva> GetReservaById(int Id)
        {
            Reserva _reserva = ReservaRepository.GetById(Id);
            try
            {
                if (_reserva != null)
                {
                    return Ok(_reserva);
                }
                return NotFound();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost(Name = "AddReserva")]
        public ActionResult<Reserva> AddReserva(Reserva reserva)
        {
            try
            {
                Reserva _reserva = ReservaRepository.Add(reserva);
                return _reserva == null ? NotFound() : Ok(_reserva);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPut(Name = "UpdateReserva")]
        public ActionResult<Reserva> UpdateReserva(Reserva reserva)
        {
            try
            {
                if (reserva != null)
                {
                    Reserva _reserva = new Reserva();
                    _reserva.Id = reserva.Id;
                    _reserva.IdSala = reserva.IdSala;
                    _reserva.IdUsuario = reserva.IdUsuario;
                    _reserva.Data = reserva.Data;
                    ReservaRepository.Update(_reserva);
                    return Ok(_reserva);
                }
                return NotFound();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpDelete(Name = "DeleteReserva")]
        public ActionResult DeleteReserva(int id)
        {
            try
            {
                var reserva = ReservaRepository.GetById(id);
                ReservaRepository.Excluir(reserva);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

    }
}
