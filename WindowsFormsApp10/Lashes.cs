using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp10
{
    public class Lashes
    {
        public double _LashWidth;
        public double _LashLength;

        public void UpdateValues(double width, double length)
        {
            this._LashWidth = width;
            this._LashLength = length;
        }


        public double LashVolume()
        {
            return (Math.PI * Math.Pow((0.5 * _LashWidth), 2) * _LashLength) / 3;
        }
    }
}
