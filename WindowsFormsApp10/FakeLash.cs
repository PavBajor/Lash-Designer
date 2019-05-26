using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp10
{
    public class FakeLash : Lashes
    {
        public enum LashCurve { J, C, D }
        private LashCurve lashCurve;

        public LashCurve LashCurve1 { get => lashCurve; set => lashCurve = value; }
    }
}
