using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SistemaVenta.BLL.Interfaces;
using SistemaVenta.Entity;
using SistemaVenta.DAL;

using Firebase.Auth;
using Firebase.Storage;
using SistemaVenta.DAL.Interfaces;

namespace SistemaVenta.BLL.Implementacion
{
    public class FirebaseService : IFirebaseService
    {

        private readonly IGenericRepository<Configuracion> _repository;

        public FirebaseService(IGenericRepository<Configuracion> repository)
        {
            _repository = repository;
        }



        public Task<string> SubirStorage(Stream StreamArchivo, string CarpetaDestino, string NombreArchivo)
        {
            string urlImagen = "";

            try
            {

            }catch(Exception ex)
            {

            }
        }
        public Task<string> EliminarStorage(string CarpetaDestino, string NombreArchivo)
        {
            throw new NotImplementedException();
        }


    }
}
