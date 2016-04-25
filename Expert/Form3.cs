using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Expert
{
    public partial class Form3 : Form
    {
        private const int CS_DROPSHADOW = 0x20000;
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        private static extern bool ReleaseCapture();

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }

        public Form3()
        {
            InitializeComponent();

        }

        private String GetName()
        {
            return this.editNewCycleName.Text;
        }

        private Expert.CustomTimeBox.DeviceType GetDeviceType()
        {
            if (this.radioMechanizm.Checked) return Expert.CustomTimeBox.DeviceType.Motor;
            else if (this.radioSensor.Checked) return Expert.CustomTimeBox.DeviceType.Sensor;
            else return Expert.CustomTimeBox.DeviceType.None;
        }


        private void confirmDialogCycleInfoBtn_Click(object sender, EventArgs e)
        {
            if (this.editNewCycleName.Text == ""||(!(this.radioMechanizm.Checked)&!(this.radioSensor.Checked)))
            {
                MessageBox.Show("You missed something!");
                return;
            }
            Form2 master = this.Owner as Form2;
            if (master != null)
            {
                master.CreateNewLine(GetName(),GetDeviceType());
            }

            this.Close();
        }

        private void closeDialogCycleInfoBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void confirmDialogCycleInfoBtn_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void confirmDialogCycleInfoBtn_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pan_cycle_info_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Form3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                confirmDialogCycleInfoBtn_Click(sender,e);
            }
            if (e.KeyCode == Keys.Escape)
            {
                closeDialogCycleInfoBtn_Click(sender, e);
            }
        }

        public class roundButton : UserControl
        {
            protected override void OnPaint(PaintEventArgs e)
            {
                Graphics graphics = e.Graphics;
                Pen myPen = new Pen(Color.Black);
                // Draw the button in the form of a circle
                graphics.DrawEllipse(myPen, 0, 0, 20, 20);
                myPen.Dispose();

            }
        }
        void roundButton_Click(Object sender, System.EventArgs e)
        {
            MessageBox.Show("Click");
        }

    }
}
