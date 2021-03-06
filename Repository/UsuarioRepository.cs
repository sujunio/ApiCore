using System.Collections.Generic;
using System.Linq;
using ApiCore.Models;

namespace ApiCore.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly UsuarioDbContext _contexto;
        public UsuarioRepository(UsuarioDbContext cxt)
        {
            _contexto = cxt;

        }
        public void Add(Usuario usuario)
        {
            _contexto.Usuarios.Add(usuario);
            _contexto.SaveChanges();

        }

        public Usuario Find(long id)
        {
            return _contexto.Usuarios.FirstOrDefault(x => x.UsuarioID == id);
        }

        public IEnumerable<Usuario> GetAll()
        {
            return _contexto.Usuarios.ToList();
        }

        public void Remove(long id)
        {
            var entity = _contexto.Usuarios.First(x => x.UsuarioID == id);
            _contexto.Usuarios.Remove(entity);
            _contexto.SaveChanges();

        }

        public void Update(Usuario Usuario)
        {
            _contexto.Usuarios.Update(Usuario);
            _contexto.SaveChanges();

        }
    }
}