using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    // インチとメートルの単位変換クラス
    public static class InchConverter {
        // 定数
        private const double ratio = 0.0254;
        // public static readonly double ratio = 0.3048;

        // メートルからインチを求める
        public static double FromMeter(int meter) {
            return meter / ratio;
        }
        
        // インチからメートルを求める
        public static double ToMeter(int inch) {
            return inch * ratio;
        }
    }
}
