using Senai.Optus.WebApi.Domains;
using Senai.Optus.WebApi.ViewModels;
using System.Linq;

namespace Senai.Optus.WebApi.Controllers
{
    public class UsuarioRepository
    {
        public Usuarios BuscarPorEmailESenha(LoginViewModel login)
        {
            using (OptusContext ctx = new OptusContext())
            {
                Usuarios UsuarioBuscado = ctx.Usuarios.FirstOrDefault(x => x.Email == login.Email && x.Senha == login.Senha);

                if (UsuarioBuscado == null)
                {
                    return null;
                }
                return UsuarioBuscado;
            }
        }
    }
}