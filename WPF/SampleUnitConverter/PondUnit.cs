using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleUnitConverter {
    public class PondUnit : DistanceUnit{
        private static List<PondUnit> units = new List<PondUnit> {
            new PondUnit{ Name = "ld", Coefficient = 1, },
            new PondUnit{ Name = "oz", Coefficient = 1 / 16, },
        };

        public static ICollection<PondUnit> Units { get { return units; } }

        /// <summary>
        /// メートル単位からヤード単位に変換します
        /// </summary>
        /// <param name="unit"> メートル単位 </param>
        /// <param name="value"> 値 </param>
        /// <returns> 変換値 </returns>
        public double FromYardUnit(YardUnit unit, double value) {
            return (value * unit.Coefficient) / 0.0625 / this.Coefficient;
        }
    }
}
