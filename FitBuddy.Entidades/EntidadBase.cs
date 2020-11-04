using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection;

namespace FitBuddy.Entidades
{
    /// <summary>
    /// Define una entidad con la capacidad de contener su propio hash.
    /// </summary>
    public abstract class EntidadBase
    {
        [Key, Column(Order = 0)]
        public int Id { get; set; }

        public string Md5Hash { get; set; }

        public virtual string Key() // concatena todas las propiedades de la entidad para hacer el hash
        {
            var valueTypeProperties = GetType().GetProperties()
                .Where(p => EsPropiedadHasheable(p)) // string o int
                .OrderBy(p => p.Name)
                .Select(p => p.GetValue(this) == null ? string.Empty : p.GetValue(this).ToString());

            return string.Join(string.Empty, valueTypeProperties);
        }

        private static bool EsPropiedadHasheable(PropertyInfo p)
        {
            var esTipoDeDatoValorOString = p.PropertyType.IsValueType || p.PropertyType == typeof(string);
            var esClavePrimaria = p.Name == "Id" || p.GetCustomAttributes(false).OfType<KeyAttribute>().Any();
            var esElHash = p.Name == "Md5Hash";

            return esTipoDeDatoValorOString && !esClavePrimaria && !esElHash;
        }
    }
}
