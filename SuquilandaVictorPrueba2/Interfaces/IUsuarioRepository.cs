using SuquilandaVictorPrueba2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuquilandaVictorPrueba2.Interfaces
{
    public interface IUsuarioRepository
    {
        List<Usuario> GetListUsuarios();
        Usuario GetUsuario(int Id);
        Boolean CrearUsuario(Usuario usuario);
        Boolean ActualizarUsuario(Usuario usuario);
        Boolean EliminarUsuario(int Id);
    }
}
