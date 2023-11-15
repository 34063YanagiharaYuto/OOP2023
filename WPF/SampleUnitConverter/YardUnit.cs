using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleUnitConverter {
    public class YardUnit : DistanceUnit{
        private static List<YardUnit> units = new List<YardUnit> {
            new YardUnit{ Name = "g", Coefficient = 1, },
            new YardUnit{ Name = "kg", Coefficient = 1 * 1000, },
        };

        public static ICollection<YardUnit> Units { get { return units; } }

        /// <summary>
        /// メートル単位からヤード単位に変換します
        /// </summary>
        /// <param name="unit"> メートル単位 </param>
        /// <param name="value"> 値 </param>
        /// <returns> 変換値 </returns>
        public double FromPondUnit(PondUnit unit, double value) {
            return (value * unit.Coefficient) * 453.59237 / this.Coefficient;
        }
    }
}
