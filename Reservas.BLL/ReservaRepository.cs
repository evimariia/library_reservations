using Microsoft.EntityFrameworkCore;
using Reservas.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservas.BLL
{
    public static class ReservaRepository
    {
        public static Reserva Add(Reserva _reserva)
        {

            using (var dbContext = new CTrabalhofinalLpiiiReservasDalDatabaseDatabaseMdfContext())
            {
                dbContext.Add(_reserva);
                dbContext.SaveChanges();
            }
            return _reserva;
        }

        public static Reserva GetById(int Id)
        {

            using (var dbContext = new CTrabalhofinalLpiiiReservasDalDatabaseDatabaseMdfContext())
            {
                try
                {
                    var reserva = dbContext.Reservas.Single(p => p.Id == Id);
                    return reserva;
                }
                catch
                {
                    return null;

                }
            }
        }

        public static List<Reserva> GetAll()
        {

            using (var dbContext = new CTrabalhofinalLpiiiReservasDalDatabaseDatabaseMdfContext())
            {
                var reserva = dbContext.Reservas.ToList();
                return reserva;

            }
        }

        public static void Excluir(Reserva _reserva)
        {
            using (var dbContext = new CTrabalhofinalLpiiiReservasDalDatabaseDatabaseMdfContext())
            {
                var reserva = dbContext.Reservas.Single(p => p.Id == _reserva.Id);
                dbContext.Remove(reserva);
                dbContext.SaveChanges();
            }
        }

        public static void Update(Reserva _reserva)
        {
            using (var dbContext = new CTrabalhofinalLpiiiReservasDalDatabaseDatabaseMdfContext())
            {
                var reserva = dbContext.Reservas.Single(p => p.Id == _reserva.Id);
                reserva.IdUsuario = _reserva.IdUsuario;
                reserva.IdSala = _reserva.IdSala;
                reserva.Data = _reserva.Data;
                dbContext.SaveChanges();
            }
        }

        public static List<Reserva> QuerySQL()
        {
            using (var dbContext = new CTrabalhofinalLpiiiReservasDalDatabaseDatabaseMdfContext())
            {
                var query = dbContext.Reservas.FromSqlRaw("SELECT * FROM reserva");
                List<Reserva> reservas = query.ToList<Reserva>();
                return reservas;
            }

        }
    }
}
