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
    public partial class CustomCriterionSlide : UserControl
    {
        public CustomCriterionSlide(String criteriaName)
        {
            InitializeComponent();
            this.label1.Text = criteriaName;
        }

        public void setTrackValue(int value)
        {
            trackBar1.Value = value;
        }

        public int getTrackValue()
        {
            return trackBar1.Value;
        }
    }
}
