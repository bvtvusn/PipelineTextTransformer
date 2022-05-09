using System.Linq;
using System.Text.RegularExpressions;

namespace PipelineTextTransformer
{
    public class TransposeTransformer : Transformer
    {
        public TransposeTransformer()
        {
            columnSeparator = "\\t";
            rowSeparator = "\\r\\n";
        }
        public override string Transform(string indata)
        {
            if (ColumnSeparator == null || RowSeparator == null) return indata;

            string rowUnescaped = Regex.Unescape(RowSeparator);
            string colUnescaped = Regex.Unescape(ColumnSeparator);
            string[] rows = indata.Split(rowUnescaped);
            string[][] test = new string[rows.Length][];
            for (int i = 0; i < rows.Length; i++)
            {
                test[i] = rows[i].Split(colUnescaped);
            }
            string outdata = "";

            int longestRow = test.Max(n => n.Length);
            for (int j_col = 0; j_col < longestRow; j_col++)   // For each column
            {
                for (int i_row = 0; i_row < test.Length; i_row++) // Go through all the rows
                {
                    if (j_col < test[i_row].Length)
                    {
                        outdata += test[i_row][j_col];
                    }
                    
                    if (i_row < test.Length-1) outdata += colUnescaped;
                }

                if (j_col < longestRow-1) outdata += rowUnescaped; // Dont add to last row
            }
            

            return outdata; //Regex.Unescape(indata);
        }
        public override string ToString()
        {
            return "Transpose";
        }
        private string rowSeparator;

        public string RowSeparator
        {
            get { return rowSeparator; }
            set { rowSeparator = value; OnPropertyChanged("Row separator"); }
        }
        private string columnSeparator;

        public string ColumnSeparator
        {
            get { return columnSeparator; }
            set { columnSeparator = value;
                OnPropertyChanged("Column separator");
            }
        }

    }

}
