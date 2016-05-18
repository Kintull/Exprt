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
    public partial class Form4 : Form
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

        private List<expertItem> expertList = new List<expertItem>(100);
        private int expertCounter = 0;
        private List<CustomCriterionSlide> customSlideList = new List<CustomCriterionSlide>(10);
        private int previousExpertNumber = -1;

        public Form4()
        {
            InitializeComponent();
        }

        public void addNewExpert(String expertName)
        {
            this.expertListBox.Items.Add(expertName);
            expertItem expert = new expertItem();
            expert.setExpertName(expertName);
            expertList.Add(expert);
        }
        

        private void plus_expert_button_MouseHover(object sender, EventArgs e)
        {
            plus_expert_button.BackgroundImage = Expert.Properties.Resources.plus_hover;
        }

        private void plus_expert_button_MouseLeave(object sender, EventArgs e)
        {
            plus_expert_button.BackgroundImage = Expert.Properties.Resources.plus;
        }

        private void plus_expert_button_MouseEnter(object sender, EventArgs e)
        {
            plus_expert_button.BackgroundImage = Expert.Properties.Resources.plus_hover;
        }

        private void plus_expert_button_MouseDown(object sender, MouseEventArgs e)
        {
            plus_expert_button.BackgroundImage = Expert.Properties.Resources.plus_down;
        }

        private void plus_expert_button_MouseUp(object sender, MouseEventArgs e)
        {
            plus_expert_button.BackgroundImage = Expert.Properties.Resources.plus_hover;
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            plus_expert_button.BackgroundImage = Expert.Properties.Resources.plus_hover;
        }

        private void minus_expert_button_MouseDown(object sender, MouseEventArgs e)
        {
            minus_expert_button.BackgroundImage = Expert.Properties.Resources.minus_down;
        }

        private void minus_expert_button_MouseEnter(object sender, EventArgs e)
        {
            minus_expert_button.BackgroundImage = Expert.Properties.Resources.minus_hover;
        }

        private void minus_expert_button_MouseLeave(object sender, EventArgs e)
        {
            minus_expert_button.BackgroundImage = Expert.Properties.Resources.minus;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            List<string> listCriterionNames = new List<string>(new string[] { "Производи- \nтельность",
                                                                               "Отказоустой- \nчивость",
                                                                                "Стоимость \nприобритения",
                                                                                "Стоимость \nэксплуатации",
                                                                                "Масса/габариты"});
            int i = 1;
            foreach (string criterionName in listCriterionNames)
            {
                CustomCriterionSlide NewSlide = new CustomCriterionSlide(criterionName);
                NewSlide.Location = new System.Drawing.Point(10, NewSlide.Height * i + 10);
                NewSlide.Enabled = false;
                panel4.Controls.Add(NewSlide);
                customSlideList.Add(NewSlide);

                i++;
            }
        }

        private void disableTracks()
        {
            foreach (CustomCriterionSlide slide in customSlideList)
            {
                slide.Enabled = false;
                slide.setTrackValue(0);
            }
        }

        private void enableTracks()
        {
            foreach (CustomCriterionSlide slide in customSlideList)
            {
                slide.Enabled = true;
            }
        }

        private void setTracks(List<int> values)
        {
            int i = 0;
            foreach (CustomCriterionSlide slide in customSlideList)
            {
                slide.Enabled = true;
                slide.setTrackValue(values[i]);
                i++;
            }
        }

        private void resetTracks()
        {
            foreach (CustomCriterionSlide slide in customSlideList)
            {
                slide.setTrackValue(0);
            }
        }

        private void saveMarks(int expertNumber,List<int> marks)
        {
            if (expertList.Count < expertNumber + 1)
            {
                return;
            }
            expertList[expertNumber].setExpertMarks(marks);
        }

        private List<int> loadAllMarks(int expertNumber)
        {
            if (expertList.Count < expertNumber+1)
            {
                return null;
            }
            return expertList[expertNumber].getExperMarks();
        }

        private List<int> getCurrentMarks()
        {
            List<int> marks = new List<int>(10);
            foreach (CustomCriterionSlide slide in customSlideList)
            {
                marks.Add(slide.getTrackValue());
            }
            return marks;
        }

        private void plus_expert_button_Click(object sender, EventArgs e)
        {
            Form5 dialog = new Form5();
            //dialog.StartPosition = FormStartPosition.CenterScreen;
            dialog.Owner = this;
            dialog.ShowDialog();
        }

        private void minus_expert_button_Click(object sender, EventArgs e)
        {
            int currentIndex = this.expertListBox.SelectedIndex;
            if (currentIndex != -1)
            {
                
                expertListBox.Items.Remove(expertListBox.SelectedItem);

                if (expertList.Count < currentIndex + 1)
                {
                    return;
                }
                else
                {
                    expertList.RemoveAt(currentIndex);
                }
                
            }
                
        }

        private void expertListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if current is empty line
            if (expertListBox.SelectedIndex == -1)
            {
                disableTracks();                     //disable trackBars
                minus_expert_button.Enabled = false; //disable minus button

                //if previous expert was deleted or empty
                if (previousExpertNumber != -1)
                {
                    saveMarks(previousExpertNumber, getCurrentMarks());
                }
            }
            //if current in not empty
            else
            {
                enableTracks();
                minus_expert_button.Enabled = true; //enable trackBars

                //if previous was empty
                if (previousExpertNumber != -1)
                {
                    saveMarks(previousExpertNumber, getCurrentMarks());
                    if (loadAllMarks(expertListBox.SelectedIndex) != null)
                    {
                        setTracks(loadAllMarks(expertListBox.SelectedIndex));
                    }
                    else resetTracks();
                }
                //if previous was normal expert
                else
                {
                    if (loadAllMarks(expertListBox.SelectedIndex) != null)
                    {
                        setTracks(loadAllMarks(expertListBox.SelectedIndex));
                    }
                    else resetTracks();
                }
            }
            previousExpertNumber = expertListBox.SelectedIndex;
        }

        private void panel5_MouseDown(object sender, MouseEventArgs e)
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

        private void closeBox_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
