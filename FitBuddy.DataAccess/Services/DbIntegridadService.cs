using Common.Bitacora;
using FitBuddy.Entidades;
using System;
using System.Linq;
using System.Security.Cryptography;

namespace FitBuddy.DataAccess.Services
{
    public interface IDbIntegridadService
    {
        bool DbTieneIntegridad();
    }

    public class DbIntegridadService : IDbIntegridadService
    {
        private readonly AppDbContext _dbContext;
        private readonly IBitacora<DbIntegridadService> _bitacora;

        public DbIntegridadService(AppDbContext dbContext, IBitacora<DbIntegridadService> bitacora)
        {
            _dbContext = dbContext;
            _bitacora = bitacora;
        }

        public bool DbTieneIntegridad()
        {
            var dbTieneIntegridad = true;

            _bitacora.Debug("Verificando integridad de la base de datos.");

            var assemblies = AppDomain.CurrentDomain.GetAssemblies();
            var entidadesConIntegridad = assemblies
                .Single(assembly => assembly.FullName.StartsWith("FitBuddy.Entidades"))
                .GetTypes()
                .Where(type => type.IsSubclassOf(typeof(EntidadBase)));

            _bitacora.Debug($"Cantidad de entidades encontradas que contienen un hash MD5: {entidadesConIntegridad.Count()}.");

            using (var md5 = MD5.Create())
            {
                foreach (var entidadConIntegridad in entidadesConIntegridad)
                {
                    _bitacora.Debug($"Verificando entidad '{entidadConIntegridad.Name}'.");

                    var elementosConIntegridad = _dbContext.Set(entidadConIntegridad);

                    foreach (EntidadBase elemento in elementosConIntegridad)
                    {
                        var md5Hash = Md5HashingService.CalcularHash(md5, elemento);

                        if (elemento.Md5Hash != md5Hash)
                        {
                            _bitacora.Advertencia($"La fila con Id = {elemento.Id} en la tabla de {entidadConIntegridad.Name} indica el hash {elemento.Md5Hash}, pero su valor verdadero es {md5Hash}.");

                            dbTieneIntegridad = false;
                            break;
                        }
                    }

                    if (!dbTieneIntegridad)
                        break;

                    _bitacora.Debug($"Entidad '{entidadConIntegridad.Name}' verificada con éxito.");
                }
            }

            if (dbTieneIntegridad)
                _bitacora.Info("Integridad de la base de datos verificada con éxito.");

            return dbTieneIntegridad;
        }
    }
}
