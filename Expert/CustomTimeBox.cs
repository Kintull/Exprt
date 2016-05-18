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
       
        System.Collections.ArrayList arrayList = new System.Collections.ArrayList();
        
        private deviceItem currentDevice = new deviceItem();
        
        public CustomTimeBox(string lineName, deviceItem.DeviсeType aDeviceType, int width, int currentLineNumber)
        {
            InitializeComponent();

            for (int i = 0; i < width; i++)
            {
                this.dataGridView1.Columns.Add("column" + currentLineNumber.ToString() + i.ToString(),"");
            }
            this.label1.Text = lineName;
            this.label2.Text = currentLineNumber.ToString();
            currentDevice.addConnection(currentLineNumber);
            currentDevice.setDeviceType(aDeviceType);
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            List<int> activeBoxes = new List<int>(100);
            activeBoxes.Clear();
            foreach (DataGridViewCell arrayElement in arrayList)
            {
                arrayElement.Selected = true;
                activeBoxes.Add(arrayElement.ColumnIndex);
            }
            currentDevice.setActiveBoxes(activeBoxes);
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
            if (currentDevice.getDeviceType() == deviceItem.DeviсeType.SENSOR)
            {
                label1.DoDragDrop(currentDevice.deviceNumber.ToString(), DragDropEffects.All);
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
                currentDevice.addConnection(income);
                this.label2.Text = concatConnections();
                
            }
            else if (income == currentDevice.deviceNumber)
            {

            }
            else
            {
                MessageBox.Show("Устройства уже соединены.");
            }
            
        }
        
        
        private bool itemExists(int input)
        {
            foreach (int connection in currentDevice.getConnections())
            {
                if (input == connection) return true;
            }
            return false;
        }

        private bool itemItself(int input)
        {
         
            if (input == currentDevice.deviceNumber) return true;
            
            return false;
        }

        private String concatConnections()
        {
            List<String> s = new List<String>(30);
            foreach (int connection in currentDevice.getConnections())
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
