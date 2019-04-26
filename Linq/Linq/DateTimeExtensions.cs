using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public static class DateTimeExtensions
    {
        public static int AniosDeEdad(this DateTime value)
        {
            var anios = DateTime.Today.Year - value.Year;
            return value > DateTime.Today.AddYears(-anios) ? anios - 1 : anios;
        }
    }
}
