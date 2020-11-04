using System;
using System.Collections.Generic;
using FitBuddy.Entidades.Enums;

namespace FitBuddy.Entidades
{
    /// <summary>
    /// Representa una dieta semanal (que es una tabla de doble entrada) como una matriz, donde cada componente es una enumeración.
    /// (Primera componente: día de la semana; segunda componente: desayuno, almuerzo, etc.)
    /// </summary>
    public class DietaSemanal
    {
        private readonly Dictionary<DayOfWeek, Dictionary<TipoComida, string>> _dietaSemanal = new Dictionary<DayOfWeek, Dictionary<TipoComida, string>>();

        public string this[DayOfWeek dayOfWeek, TipoComida tipoComida]
        {
            get
            {
                if (!_dietaSemanal.ContainsKey(dayOfWeek))
                    return string.Empty;
                
                if (!_dietaSemanal[dayOfWeek].ContainsKey(tipoComida))
                    return string.Empty;

                return _dietaSemanal[dayOfWeek][tipoComida];
            }

            set
            {
                if (!_dietaSemanal.ContainsKey(dayOfWeek))
                {
                    _dietaSemanal.Add(dayOfWeek, new Dictionary<TipoComida, string>());
                }

                if (!_dietaSemanal[dayOfWeek].ContainsKey(tipoComida))
                {
                    _dietaSemanal[dayOfWeek].Add(tipoComida, value);
                }
                else
                {
                    _dietaSemanal[dayOfWeek][tipoComida] = value;
                }
            }
        }
    }
}
