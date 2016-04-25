using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Expert
{
    public partial class CustomTimeBox : UserControl
    {
        public enum DeviceType {Sensor, Motor, None};
        private bool[] bValues = new bool[30];
        System.Collections.ArrayList arrayList = new System.Collections.ArrayList();
        System.Collections.ArrayList arrayListDisabled = new System.Collections.ArrayList();
        List<int> connections = new List<int>(30);
        private DeviceType deviceType;
        public CustomTimeBox(String lineName, Expert.CustomTimeBox.DeviceType aDeviceType, int width, int LineCount)
        {
            InitializeComponent();

            for (int i = 0; i < width; i++)
            {
                this.dataGridView1.Columns.Add("column" + LineCount.ToString() + i.ToString(),"");
            }
            this.label1.Text = lineName;
            this.label2.Text = LineCount.ToString();
            connections.Add(LineCount);
            deviceType = aDeviceType;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewCell arrayElement in arrayList)
            {
                arrayElement.Selected = true;
            }
        }

        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell != null)
            {
                if (arrayList.Contains(dataGridView1.CurrentCell))
                {
                    arrayList.Remove(dataGridView1.CurrentCell);
                    dataGridView1.CurrentCell.Selected = false;
                }
                else
                {
                    arrayList.Add(dataGridView1.CurrentCell);
                    dataGridView1.CurrentCell.Selected = true;
                }
            }
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            if (deviceType == DeviceType.Sensor)
            {
                label1.DoDragDrop(connections[0].ToString(), DragDropEffects.All);
            }
            else
            {
                MessageBox.Show("Перетаскивать движетели нельзя");
            }
        }

        private void label1_DragDrop(object sender, DragEventArgs e)
        {
            int income = int.Parse(e.Data.GetData(DataFormats.Text).ToString());
            if ( !itemExists(income) )
            {
                connections.Add(income);
                this.label2.Text = concatConnections();
                
            }
            else if (income == connections[0])
            {

            }
            else
            {
                MessageBox.Show("Устройства уже соединены.");
            }
            
        }
        
        
        private bool itemExists(int input)
        {
            foreach (int connection in connections)
            {
                if (input == connection) return true;
            }
            return false;
        }

        private bool itemItself(int input)
        {
         
            if (input == connections[0]) return true;
            
            return false;
        }

        private String concatConnections()
        {
            List<String> s = new List<String>(30);
            foreach (int connection in connections)
            {
                s.Add(connection.ToString() + " ");
            }
            return string.Concat(s);
        }

        private void label1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text)&!(itemItself( int.Parse(e.Data.GetData(DataFormats.Text).ToString()))))
                e.Effect = DragDropEffects.Move;
            else
                e.Effect = DragDropEffects.None;
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }




    }
}
