using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace PipelineTextTransformer
{
    public class ForEachBetweenTransormer:PipelineTransformer
    {
        public ForEachBetweenTransormer()
        {
            delimiter = "\"";
            escapeChar = "\\";
            outsideDelimiters = false;
        }
        public string Delimiter
        {
            get { return delimiter; }
            set { delimiter = value; OnPropertyChanged("Delimiter"); }
        }
        private string escapeChar;

        public string EscapeChar
        {
            get { return escapeChar; }
            set { escapeChar = value; OnPropertyChanged("EscapeChar"); }
        }
        private bool outsideDelimiters;

        public bool OutsideDelimiters
        {
            get { return outsideDelimiters; }
            set { outsideDelimiters = value; OnPropertyChanged("OutsideDelimiters"); }
        }

        public override string ToString()
        {
            return "For each between \"" + delimiter + "\"";
        }
        public override string Transform(string indata)
        {
            int temp = Children.Count;
            return TranformLogic(indata, ref temp);
        }
        //public new string Transform(string indata, int steps)
        //{
        //    return TranformLogic(indata, ref steps);
        //}
        private string delimiter;
        //internal override string TranformLogic(string indata, ref int steps)
        //{
        //    string stringBuild = "";
        //    int delimiterStart = 0;
        //    int delimiterEnd = 0;
        //    int inBetween_num = -1;
        //    //bool inBetween = false;
        //    bool escapeNext = false;
        //    for (int i = 0; i < indata.Length; i++)
        //    {
        //        if (!escapeNext && indata[i] == delimiter[0]) // non escaped delimiter found
        //        {
        //            inBetween_num = (inBetween_num + 1) % 3;
        //            //inBetween = !inBetween;
        //            if (inBetween_num == 1)
        //            {
        //                // Just entered a sequence 
        //                delimiterStart = i;

        //                // Save the delimiter characters
        //                //int length = delimiterStart - delimiterEnd;
        //                int _strStart = Math.Min(indata.Length, delimiterStart + 1);
        //                stringBuild += indata.Substring(delimiterEnd, _strStart - delimiterEnd);
        //            }
        //            else if (inBetween_num == 0)
        //            {
        //                // End of sequence found
        //                delimiterEnd = i;

        //                int strstart = Math.Min(indata.Length - 1, delimiterStart + 1);
        //                int strend = Math.Min(indata.Length - 1, delimiterEnd);

        //                //int length = Math.Min(delimiterEnd-delimiterStart-2, indata.Length-delimiterStart-1);
        //                string curSubstr = indata.Substring(strstart, strend - strstart);

        //                // perform the trnsformations from the children
        //                string tempStr = indata;
        //                for (int j = 0; j < Children.Count && j < steps; j++)
        //                {
        //                    tempStr = (Children[j] as Transformer).Transform(curSubstr);
        //                }
        //                stringBuild += tempStr;

        //            }
        //        }
        //        escapeNext = false;
        //        if (indata[i] == escapeChar[0]) escapeNext = true;

        //    }
        //    int strStart = 0;
        //    if (inBetween_num != 0) strStart = delimiterStart + 1;
        //    else strStart = delimiterEnd;

        //    int strEnd = indata.Length - 1;
        //    string lastBit = indata.Substring(strStart, strEnd - strStart + 1);
        //    stringBuild += lastBit;

        //    return stringBuild;
        //}
        //internal override string TranformLogic(string indata, ref int steps)
        //{
        //    if (OutsideDelimiters)
        //    {
        //        indata = "\"" + indata + "\""; 
        //    }


        //    string stringBuild = "";
        //    int delimiterStart = 0;
        //    int delimiterEnd = 0;
        //    bool inBetween = false;
        //    bool escapeNext = false;
        //    for (int i = 0; i < indata.Length; i++)
        //    {
        //        if (!escapeNext && indata[i] == delimiter[0]) // non escaped delimiter found
        //        {
        //            inBetween = !inBetween;
        //            if (inBetween)
        //            {
        //                // Just entered a sequence
        //                delimiterStart = i;

        //                // Save the delimiter characters
        //                //int length = delimiterStart - delimiterEnd;
        //                int _strStart = Math.Min(indata.Length, delimiterStart + 1);
        //                stringBuild += indata.Substring(delimiterEnd, _strStart - delimiterEnd);
        //            }
        //            else
        //            {
        //                // End of sequence found
        //                delimiterEnd = i;

        //                int strstart = Math.Min(indata.Length - 1, delimiterStart + 1);
        //                int strend = Math.Min(indata.Length - 1, delimiterEnd);

        //                //int length = Math.Min(delimiterEnd-delimiterStart-2, indata.Length-delimiterStart-1);
        //                string curSubstr = indata.Substring(strstart, strend - strstart);

        //                // perform the trnsformations from the children
        //                string tempStr = indata;
        //                for (int j = 0; j < Children.Count && j < steps; j++)
        //                {
        //                    tempStr = (Children[j] as Transformer).Transform(curSubstr);
        //                }
        //                stringBuild += tempStr;

        //            }
        //        }



        //        escapeNext = false;
        //        if (indata[i] == escapeChar[0]) escapeNext = true;

        //    }
        //    int strStart = 0;
        //    if (inBetween) strStart = delimiterStart + 1;
        //    else strStart = delimiterEnd;

        //    int strEnd = indata.Length - 1;
        //    string lastBit = indata.Substring(strStart, strEnd - strStart + 1);
        //    stringBuild += lastBit;


        //    //string tempStr = indata;
        //    //for (int i = 0; i < Children.Count && i < steps; i++)
        //    //{
        //    //    tempStr = (Children[i] as Transformer).Transform(tempStr);
        //    //}
        //    return stringBuild;
        //}
        private int[] GetDelimiterIndexes(string indata, string delimiter_internal)
        {
            List<int> indexes = new List<int>();

            for (int i = delimiter_internal.Length - 1; i < indata.Length; i++)
            {
                if (indata.Substring(i - delimiter_internal.Length + 1, delimiter_internal.Length) == delimiter_internal) // checking if i is at end of delimiter
                {
                    int escapeTestIndex = i - delimiter_internal.Length;
                    bool excaped = false;
                    if (escapeTestIndex > 0)
                    {
                        if (indata[escapeTestIndex] == EscapeChar[0])
                        {
                            excaped = true;
                        }
                    }
                    if (excaped == false)
                    {
                        indexes.Add(i);

                    }
                }
            }

            return indexes.ToArray();

        }
        internal override string TranformLogic(string indata, ref int steps)
        {
            string unescapedDelimiter = Regex.Unescape(delimiter);
            string stringBuild = "";
            int substrStart = 0; // initialized with 0 for the first value

            int[] delimiters = GetDelimiterIndexes(indata, unescapedDelimiter);
            bool isBetween = this.OutsideDelimiters;

            int steps_line = steps; // A given remainig number of transformer steps can be used for each line.

            for (int i = 0; i < delimiters.Length + 1; i++)
            {
                int substrEnd;
                if (i == delimiters.Length) // last iteration
                {
                    substrEnd = indata.Length; // set to end of string for the last substring
                }
                else
                {
                    substrEnd = delimiters[i] - unescapedDelimiter.Length + 1;
                }
                int segLen = substrEnd - substrStart;
                string curStr = indata.Substring(substrStart, segLen); // find the current substring

                if (isBetween) // we have found a substring we want to edit
                {
                    // ########### Edit substring
                    string tempStr = curStr;

                    steps_line = steps;
                    for (int j = 0; j < Children.Count && steps_line > 0; j++)
                    {
                        if (Children[j] is PipelineTransformer)
                        {
                            tempStr = (Children[j] as PipelineTransformer).Transform(tempStr, ref steps_line);
                        }
                        else
                        {
                            tempStr = (Children[j] as Transformer).Transform(tempStr);
                        }
                        steps_line -= 1; // Count one down for the current transformer.
                    }
                    stringBuild += tempStr;

                    
                    // ########### Edit substring done
                    //stringBuild += curStr.ToUpper();
                }
                else
                {
                    stringBuild += curStr; // Leave the data unchanged
                }
                

                substrStart = substrEnd + unescapedDelimiter.Length;
                if (i < delimiters.Length)
                {
                    stringBuild += unescapedDelimiter;
                }

                isBetween = !isBetween; // Toggle the status
            }

            steps = steps_line; // the value from the last iteration is used for simplicity.
            return stringBuild;
        }
    }
}
