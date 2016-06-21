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
        private static extern int SendMessage( IntPtr hWnd , int Msg , int wParam , int lParam );
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

        public void CreateNewLine( String lineName , deviceItem.DeviсeType deviceType )
        {
            CustomTimeBox NewLine = new CustomTimeBox(lineName , deviceType , 30 , listOfUserControls.Count);
            NewLine.Width = 91 + 21 * 30 + 10;
            NewLine.Location = new System.Drawing.Point(10 , 10 + 30 * listOfUserControls.Count);
            this.pan_cycle_main.Controls.Add(NewLine);
            listOfUserControls.Add(NewLine);
        }

        public List<string> parseDevices( List<CustomTimeBox> theListOfUserControls )
        {
            List<string> logicStrings = new List<string>(30);
            foreach ( CustomTimeBox timeBox in theListOfUserControls )
            {
                if ( timeBox.Device.deviceType != deviceItem.DeviсeType.SENSOR )
                {
                    logicStrings.Add(calculateLogic(timeBox.Device.getConnections() , 30).createLogicString());
                }
            }
            return logicStrings;
        }



        public logicItem calculateLogic( List<int> connections , int width )
        {
            int N = connections.Count;
            int[] truthTable = new int[Convert.ToInt32(Math.Pow(2 , N - 1))]; //N-1 exclude machine
            for ( int i = 0; i < truthTable.Length; i++ )
            {
                truthTable[i] = -1;
            }
                int currentTruthRow = 0x00;
            List<string> deviceNames = new List<string>(N);
            // k for step on the timeline
            for ( int k = 0; k < width; k++ )
            {
                currentTruthRow = 0x00;
                // i for every device except current
                for ( int i = 1; i < N; i++ )
                {
                    int currentDeviceId = connections[i];
                    bool currentDeviceValue = listOfUserControls[currentDeviceId].Device.getBoxes()[k];
                    currentTruthRow = currentTruthRow | Convert.ToInt32(currentDeviceValue) * Convert.ToInt32(Math.Pow(2 , ( i - 1 )));
                }
                truthTable[currentTruthRow] = Convert.ToInt32(listOfUserControls[N - 1].Device.getBoxes()[k]);
            }


            for ( int i = 0; i < N; i++ )
            {
                deviceNames.Add(listOfUserControls[i].Device.getName());
            }
            logicItem currentLogicItem = new logicItem(deviceNames , truthTable);
            return currentLogicItem;
        }

        public Form2()
        {
            InitializeComponent();
        }

        private void btnAddNewCycle_Click( object sender , EventArgs e )
        {
            Form3 dialog = new Form3();
            dialog.StartPosition = FormStartPosition.CenterScreen;
            dialog.Owner = this;
            dialog.ShowDialog();
        }


        private void pan_header_cycle_MouseDown( object sender , MouseEventArgs e )
        {
            if ( e.Button == MouseButtons.Left )
            {
                ReleaseCapture();
                SendMessage(Handle , WM_NCLBUTTONDOWN , HT_CAPTION , 0);
            }
        }

        private void closeBox_Click( object sender , EventArgs e )
        {
            Close();
        }

        private void pictureBox1_MouseDown( object sender , MouseEventArgs e )
        {
            if ( e.Button == MouseButtons.Left )
            {
                ReleaseCapture();
                SendMessage(Handle , WM_NCLBUTTONDOWN , HT_CAPTION , 0);
            }
        }

        private void label1_MouseDown( object sender , MouseEventArgs e )
        {
            if ( e.Button == MouseButtons.Left )
            {
                ReleaseCapture();
                SendMessage(Handle , WM_NCLBUTTONDOWN , HT_CAPTION , 0);
            }
        }

        private void panel1_MouseDown( object sender , MouseEventArgs e )
        {
            if ( e.Button == MouseButtons.Left )
            {
                ReleaseCapture();
                SendMessage(Handle , WM_NCLBUTTONDOWN , HT_CAPTION , 0);
            }
        }

        private void Form2_FormClosed( object sender , FormClosedEventArgs e )
        {
            Form1 master = this.Owner as Form1;
            if ( master != null )
            {
                master.cyclogramForm = null;
            }
        }

        private void button1_Click( object sender , EventArgs e )
        {
            Form6 form6 = new Form6();
            form6.Show();
            parseDevices(listOfUserControls);
        }
    }
}
