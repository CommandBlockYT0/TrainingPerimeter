using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerimeterAp
{
    interface IModel
    {
        /// <summary>
        /// Периметр
        /// </summary>
        /// <param name="a">А</param>
        /// <param name="b">Б</param>
        /// <returns>Периметр</returns>
        double P(double a, double b);
    }
}
