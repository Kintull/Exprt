using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expert
{
    /// <summary>
    /// Handle logic of exact device.
    /// </summary>
    public class logicItem
    {
        private List<string> namesList;
        private int[] truthTable;
        private string sepA = " && ";
        private string sepB = " || ";
        public logicItem( List<string> theNamesList , int[] theTruthTable )
        {
            namesList = theNamesList;
            truthTable = theTruthTable;
        }

        private List<int> calculateMinRows()
        {
            int falsesCount = 0;
            int truesCount = 0;
            List<int> Falses = new List<int>(50);
            List<int> Trues = new List<int>(50);
            for ( int i = 0; i < truthTable.Length; i++ )
            {
                if (truthTable[i] == -1)
                {
                    continue;
                }
                else if ( Convert.ToBoolean(truthTable[i] ))
                {
                    Trues.Add(i);
                    truesCount++;
                }
                else
                {
                    Falses.Add(i);
                    falsesCount++;
                }
            }
            if ( truesCount <= falsesCount ) return Trues;
            else return Falses;

        }
        public string createLogicString()
        {
            int columns = namesList.Count;
            List<int> minRows = calculateMinRows();
            int rows = truthTable.Length;
            List<string> rowStrings = new List<string>(rows);
            bool lessTrue = false;
            string logicString = "";
            for ( int i = 0; i < rows; i++ )
            {
                foreach (int minRow in minRows)
                {
                    if(i == minRow)
                    {
                        if (Convert.ToBoolean(truthTable[i]) == true )
                        {
                            lessTrue = true;
                            List<string> lineStrings = new List<string>(columns - 1);
                            for ( int j = 0; j < columns - 1; j++ )
                            {
                                //if (Convert.ToBoolean(( i & ( columns - 1 - j ) )))
                                int n = ( Convert.ToInt32(Math.Pow(2 , j)) );
                                if ( Convert.ToBoolean(( i & ( Convert.ToInt32(Math.Pow(2,j)) ) )))
                                {
                                    lineStrings.Add("!" + namesList[j]);
                                }
                                else
                                {
                                    lineStrings.Add(namesList[j]);
                                }

                            }
                            string lineString = " ( " + String.Join(" && " , lineStrings) + " ) ";
                            rowStrings.Add(lineString);
                        }
                        else
                        {
                            lessTrue = false;
                            List<string> lineStrings = new List<string>(columns - 1);
                            for ( int j = 0; j < columns - 1; j++ )
                            {
                                if (Convert.ToBoolean(( i & ( Convert.ToInt32(Math.Pow(2 , j)) ) )) )
                                {
                                    lineStrings.Add("!" + namesList[j]);
                                }
                                else
                                {
                                    lineStrings.Add(namesList[j]);
                                }

                            }
                            string lineString = " ( " + String.Join(" || " , lineStrings) + " ) ";
                            rowStrings.Add(lineString);
                        }
                    }
                }
            }

            if (lessTrue)
            {
                logicString = String.Join(" || " , rowStrings);
            }
            else
            {
                logicString = String.Join(" && " , rowStrings);
            }
            
            return logicString;
        }

    }
}
