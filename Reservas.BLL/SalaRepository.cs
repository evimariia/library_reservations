using Microsoft.EntityFrameworkCore;
using Reservas.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservas.BLL
{
    internal class SalaRepository
    {
        public static Sala Add(Sala _sala)
        {

            using (var dbContext = new CTrabalhofinalLpiiiReservasDalDatabaseDatabaseMdfContext())
            {
                dbContext.Add(_sala);
                dbContext.SaveChanges();
            }
            return _sala;
        }

        public static Sala GetById(int Id)
        {

            using (var dbContext = new CTrabalhofinalLpiiiReservasDalDatabaseDatabaseMdfContext())
            {
                try
                {
                    var sala = dbContext.Salas.Single(p => p.Id == Id);
                    return sala;
                }
                catch
                {
                    return null;

                }
            }
        }

        public static List<Sala> GetAll()
        {

            using (var dbContext = new CTrabalhofinalLpiiiReservasDalDatabaseDatabaseMdfContext())
            {
                var sala = dbContext.Salas.ToList();
                return sala;

            }
        }

        public static void Excluir(Sala _sala)
        {
            using (var dbContext = new CTrabalhofinalLpiiiReservasDalDatabaseDatabaseMdfContext())
            {
                var sala = dbContext.Salas.Single(p => p.Id == _sala.Id);
                dbContext.Remove(sala);
                dbContext.SaveChanges();
            }
        }

        public static void Update(Sala _sala)
        {
            using (var dbContext = new CTrabalhofinalLpiiiReservasDalDatabaseDatabaseMdfContext())
            {
                var sala = dbContext.Salas.Single(p => p.Id == _sala.Id);
                sala.Numero = _sala.Numero;
                sala.Modalidade = _sala.Modalidade;
                sala.QtdePessoas = _sala.QtdePessoas;
                dbContext.SaveChanges();
            }
        }

        public static List<Sala> QuerySQL()
        {
            using (var dbContext = new CTrabalhofinalLpiiiReservasDalDatabaseDatabaseMdfContext())
            {
                var query = dbContext.Salas.FromSqlRaw("SELECT * FROM sala");
                List<Sala> salas = query.ToList<Sala>();
                return salas;
            }

        }
    }
}
