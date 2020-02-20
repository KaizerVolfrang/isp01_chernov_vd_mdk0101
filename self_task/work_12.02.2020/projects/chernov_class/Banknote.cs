using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chernov_Gladskih_ISP_1
{
    class Banknote
    {
        private int SeriesAndNumber
        { get; set; }

        private int FaceValue
        { get; set; }

        private string ParValue
        { get; set; }

        public Banknote(int seriesAndNumber, int faceValue, string parValue)
        {
            SeriesAndNumber = seriesAndNumber;
            FaceValue = faceValue;
            ParValue = parValue;
        }

        public override string ToString()
        {
            return ($" Banknote: {SeriesAndNumber}, {FaceValue}, {ParValue}");
        }
    }
}
