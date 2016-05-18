using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using System.Runtime.InteropServices;

namespace Expert
{
    public partial class Form2 : Form
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

        private List<CustomTimeBox> listOfUserControls = new List<CustomTimeBox>(100);

        public void CreateNewLine(String lineName, deviceItem.DeviсeType deviceType)
        {
            CustomTimeBox NewLine = new CustomTimeBox(lineName, deviceType, 30, listOfUserControls.Count);
            NewLine.Width = 91 + 21 * 30 + 10;
            NewLine.Location = new System.Drawing.Point(10, 10 + 30 * listOfUserControls.Count);
            this.pan_cycle_main.Controls.Add(NewLine);
            listOfUserControls.Add(NewLine);
        }


        public Form2()
        {
            InitializeComponent();
        }

        private void btnAddNewCycle_Click(object sender, EventArgs e)
        {
            Form3 dialog = new Form3();
            dialog.StartPosition = FormStartPosition.CenterScreen;
            dialog.Owner = this;
            dialog.ShowDialog();
        }


        private void pan_header_cycle_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void closeBox_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 master = this.Owner as Form1;
            if (master != null)
            {
                master.cyclogramForm = null;
            }
        }
    }
}
