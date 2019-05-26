using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


namespace WindowsFormsApp10
{
    public class LashPattern
    {
        PictureBox _lashPatterns;
        FakeLash fake;
        ClientLash client;
        public LashPattern(PictureBox picture, FakeLash fake, ClientLash client)
        {
            this._lashPatterns = picture;
            this.fake = fake;
            this.client = client;
        }

        private string patternInfo;
        public string ShowPatternInfo()
        {
            if (whatLashes(client.LashVolume(), fake.LashVolume())==0)
            {
                patternInfo = "";
            }
            else
            {
                patternInfo = "";
                patternInfo += "Do rzęsy o grubości " + client._LashWidth + "możesz przykleić max " + whatLashes(client.LashVolume(), fake.LashVolume());
            }
                       
            return patternInfo;
        }
        
        public void ShowPattern()
        {
            if (client.EyeShape1==ClientLash.EyeShape.Upturned)
            {
                _lashPatterns.Image = Image.FromFile("C:\\Users\\Pablo\\source\\repos\\WindowsFormsApp10\\WindowsFormsApp10\\Pattern2.jpg");
            }
            else if (client.EyeShape1==ClientLash.EyeShape.Round)
            {
                _lashPatterns.Image = Image.FromFile("C:\\Users\\Pablo\\source\\repos\\WindowsFormsApp10\\WindowsFormsApp10\\Pattern4.jpg");
            }
            else if (client.EyeShape1 == ClientLash.EyeShape.Monolid)
            {
                _lashPatterns.Image = Image.FromFile("C:\\Users\\Pablo\\source\\repos\\WindowsFormsApp10\\WindowsFormsApp10\\Pattern5.jpg");
            }
            else if (client.EyeShape1 == ClientLash.EyeShape.Hooded)
            {
                _lashPatterns.Image = Image.FromFile("C:\\Users\\Pablo\\source\\repos\\WindowsFormsApp10\\WindowsFormsApp10\\Pattern3.jpg");
            }
            else if (client.EyeShape1 == ClientLash.EyeShape.Downturned)
            {
                _lashPatterns.Image = Image.FromFile("C:\\Users\\Pablo\\source\\repos\\WindowsFormsApp10\\WindowsFormsApp10\\Pattern1.jpg");
            }
            
        }




        public int whatLashes(double vol1, double vol2)
        {
            if (vol1>0&&vol2>0)
            {
                return Convert.ToInt32(vol1 / vol2);
            }
            else
            {
                MessageBox.Show("Wprowadz wartosci większe od 0");
                return 0;
            }
        }
    }
}
