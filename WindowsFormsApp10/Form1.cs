using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp10
{
    public partial class Form1 : Form
    {
        ClientLash lash;
        FakeLash fakelash;
        LashPattern pattern;
        string[] eyeShapes;
        string[] curls;


        public Form1()
        {
            
            InitializeComponent();
            lash = new ClientLash();
            fakelash = new FakeLash();
            pattern = new LashPattern(pictureBox1, fakelash, lash);
            eyeShapes = Enum.GetNames(typeof(ClientLash.EyeShape));
            curls = Enum.GetNames(typeof(FakeLash.LashCurve));
            for (int i = 0; i < 4; i++)
            {
                eyeShape.Items.Add(eyeShapes[i]);
            }
            for (int i = 0; i < 3; i++)
            {
                lashCurve.Items.Add(curls[i]);
            }
            
            
        }

        




        private void button1_Click(object sender, EventArgs e)
        {
            lash.UpdateValues((double)numericUpDown2.Value, (double)numericUpDown1.Value);
            fakelash.UpdateValues((double)numericUpDown4.Value, (double)numericUpDown3.Value);

            DisplayInfo();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            eyeShape.Enabled = true;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            lashCurve.Enabled = true;
        }

        private void DisplayInfo()
        {
            
            infoBox.Text = pattern.ShowPatternInfo();
            pattern.ShowPattern();
            
            
        }

        private void eyeShape_SelectedItemChanged(object sender, EventArgs e)
        {
            lash.EyeShape1 = (ClientLash.EyeShape)eyeShape.SelectedIndex;
        }

        private void lashCurve_SelectedItemChanged(object sender, EventArgs e)
        {
            fakelash.LashCurve1 = (FakeLash.LashCurve)lashCurve.SelectedIndex;
        }
    }
}
