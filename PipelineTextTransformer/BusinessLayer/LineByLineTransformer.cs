using System;
using System.Text.RegularExpressions;

namespace PipelineTextTransformer
{
    public class LineByLineTransformer : PipelineTransformer
    {
        public string Delimiter
        {
            get { return delimiter; }
            set { delimiter = value; OnPropertyChanged("Delimiter"); }
        }
        private string delimiter;
        public LineByLineTransformer()
        {
            delimiter = @"\r\n";
        }
        public override string Transform(string indata)
        {
            int temp = Children.Count;
            return TranformLogic(indata, ref temp);
        }
        public override string ToString()
        {
            return "Line by line. Separator: " + delimiter;
        }
        internal override string TranformLogic(string indata, ref int steps)
        {
            string delimiter_unescaped = Regex.Unescape(delimiter);
            string[] lines = indata.Split(    
                new string[] { delimiter_unescaped },
                StringSplitOptions.None
            );
            string output = "";
            int steps_line = 0; // A given remainig number of transformer steps can be used for each line.

            for (int j = 0; j < lines.Length; j++)
            {
                string tempStr = lines[j];

                steps_line = steps;
                for (int i = 0; i < Children.Count && steps_line > 0; i++)
                {
                    if (Children[i] is PipelineTransformer)
                    {
                        tempStr = (Children[i] as PipelineTransformer).Transform(tempStr, ref steps_line);
                    }
                    else
                    {
                        tempStr = (Children[i] as Transformer).Transform(tempStr);
                    }
                    steps_line -= 1; // Count one down for the current transformer.
                }
                output += tempStr;

                if (j < lines.Length-1)
                {
                    output += delimiter_unescaped;
                }
            }

            steps = steps_line; // the value from the last iteration is used for simplicity.
            return output;
        }
    }
}
