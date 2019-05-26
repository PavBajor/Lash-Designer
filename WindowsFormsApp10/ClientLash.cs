using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp10
{
    public class ClientLash : Lashes
    {
        public enum EyeShape { Upturned, Round, Monolid, Downturned, Hooded };
        private EyeShape eyeShape;
        public EyeShape EyeShape1 { get => eyeShape; set => eyeShape = value; }
    }
}
