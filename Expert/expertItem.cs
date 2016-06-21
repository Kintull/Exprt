using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expert
{
    class expertItem
    {
        private string name;
        private List<int> marks = new List<int>(10);

        public void setExpertMarks(List<int> aMarks)
        {
            marks = aMarks;
        }

        public void setExpertName(string aname)
        {
            name = aname;
        }

        public List<int> getExperMarks()
        {
            if (marks.Count == 0)
            {
                return null;
            }

            else
            {
                return marks;
            }
        }

        public int getExperMark(int position)
        { 
            return marks[position];
        }

        public List<int> getExperMark()
        {
            return marks;
        }


    }
}
