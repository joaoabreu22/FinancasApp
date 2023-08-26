using FinancasApp.Data.Contexts;
using FinancasApp.Data.Entities;

namespace FinancasApp.Data.Repositories
{
    public class UsuarioRepository
    {
        public void Create(Usuario usuario)
        {
            using (var dataContext = new DataContext())
            {
                dataContext.Add(usuario);
                dataContext.SaveChanges();
            }
        }

        public void Update(Usuario usuario)
        {
            using (var dataContext = new DataContext())
            {
                dataContext.Update(usuario);
                dataContext.SaveChanges();
            }
        }

        public void Delete(Usuario usuario)
        {
            using (var dataContext = new DataContext())
            {
                dataContext.Remove(usuario);
                dataContext.SaveChanges();
            }
        }

        public List<Usuario> GetAll(Usuario usuario)
        {
            using (var dataContext = new DataContext())
            {
                return dataContext.Usuario.OrderBy(u => u.Nome).ToList();
            }
        }

        public Usuario? GetUsuario(Guid Id)
        {
            using (var dataContext = new DataContext())
            {
                return dataContext.Usuario.Where(u => u.Id == Id).FirstOrDefault();
            }
        }

        public Usuario? GetByEmail(string Email)
        {
            using (var dataContext = new DataContext())
            {
                return dataContext.Usuario.Where(u => u.Email == Email).FirstOrDefault();
            }
        }

        public Usuario? GetByEmailAndSenha(string Email, string Senha)
        {
            using (var dataContext = new DataContext())
            {
                return dataContext.Usuario.Where(u => u.Email == Email && u.Senha == Senha).FirstOrDefault();
            }
        }
    }
}