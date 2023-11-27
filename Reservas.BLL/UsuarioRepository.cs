using Reservas.MODEL;
using Microsoft.EntityFrameworkCore;

namespace Reservas.BLL
{
    public class UsuarioRepository
    {
        public static Usuario Add(Usuario _usuario)
        {

            using (var dbContext = new CTrabalhofinalLpiiiReservasDalDatabaseDatabaseMdfContext())
            {
                dbContext.Add(_usuario);
                dbContext.SaveChanges();
            }
            return _usuario;
        }

        public static Usuario GetById(int Id)
        {

            using (var dbContext = new CTrabalhofinalLpiiiReservasDalDatabaseDatabaseMdfContext())
            {
                try
                {
                    var usuario = dbContext.Usuarios.Single(p => p.Id == Id);
                    return usuario;
                }
                catch
                {
                    return null;

                }
            }
        }

        public static List<Usuario> GetAll()
        {

            using (var dbContext = new CTrabalhofinalLpiiiReservasDalDatabaseDatabaseMdfContext())
            {
                var usuario = dbContext.Usuarios.ToList();
                return usuario;

            }
        }

        public static void Excluir(Usuario _usuario)
        {
            using (var dbContext = new CTrabalhofinalLpiiiReservasDalDatabaseDatabaseMdfContext())
            {
                var usuario = dbContext.Usuarios.Single(p => p.Id == _usuario.Id);
                dbContext.Remove(usuario);
                dbContext.SaveChanges();
            }
        }

        public static void Update(Usuario _usuario)
        {
            using (var dbContext = new CTrabalhofinalLpiiiReservasDalDatabaseDatabaseMdfContext())
            {
                var usuario = dbContext.Usuarios.Single(p => p.Id == _usuario.Id);
                usuario.Ra = _usuario.Ra;
                usuario.Nome = _usuario.Nome;
                usuario.Curso = _usuario.Curso;
                usuario.Semestre = _usuario.Semestre;
                usuario.Senha = _usuario.Senha;
                dbContext.SaveChanges();
            }
        }

        public static List<Usuario> QuerySQL()
        {
            using (var dbContext = new CTrabalhofinalLpiiiReservasDalDatabaseDatabaseMdfContext())
            {
                var query = dbContext.Usuarios.FromSqlRaw("SELECT * FROM usuario");
                List<Usuario> usuarios = query.ToList<Usuario>();
                return usuarios;
            }

        }

    }
}