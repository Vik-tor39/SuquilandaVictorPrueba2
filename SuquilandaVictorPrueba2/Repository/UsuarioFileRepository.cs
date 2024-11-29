using Newtonsoft.Json;
using SuquilandaVictorPrueba2.Interfaces;
using SuquilandaVictorPrueba2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuquilandaVictorPrueba2.Repository
{
    internal class UsuarioFileRepository : IUsuarioRepository
    {
        public string _fileName = Path.Combine(FileSystem.AppDataDirectory, "VictorSuquilanda.txt");
        public bool ActualizarUsuario(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public bool CrearUsuario(Usuario usuario)
        {
            try
            {
                string user_json = JsonConvert.SerializeObject(usuario);
                File.WriteAllText(_fileName, user_json);
                return true;
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public bool EliminarUsuario(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Usuario> GetListUsuarios()
        {
            throw new NotImplementedException();
        }

        public Usuario GetUsuario(int Id)
        {
            Usuario usuario= new Usuario();
            if (File.Exists(_fileName))
            {
                string data = File.ReadAllText(_fileName);
                usuario = JsonConvert.DeserializeObject<Usuario>(data);
            }
            return usuario;
        }
    }
}
