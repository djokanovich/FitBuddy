using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;

namespace FitBuddy.Entidades
{
    public abstract class EntidadBase
    {
        public int Id { get; set; }

        public string Md5Hash { get; set; }

        public virtual string Key()
        {
            var valueTypeProperties = GetType().GetProperties()
                .Where(p => EsPropiedadHasheable(p))
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
