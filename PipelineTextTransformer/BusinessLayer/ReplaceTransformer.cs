using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace PipelineTextTransformer
{
    [Serializable]
    public class ReplaceTransformer:Transformer
    {
        public ReplaceTransformer(string FindWhat, string ReplaceWith):base()
        {
            this.FindWhat = FindWhat;
            this.ReplaceWith = ReplaceWith;
        }
        public ReplaceTransformer()
        {
            findWhat = "";
            replaceWith = "";
            //typeName2 = "Replace Transformer"; // Probably unnescessary
            //objType = this.GetType();
        }

        public void TestParameters()
        {
            string indata = "Once upon a";
            string findUnescaped = Regex.Unescape(findWhat);
            string replacementUnescaped = Regex.Unescape(replaceWith);
            Regex.Replace(indata, findUnescaped, replacementUnescaped);
        }
        public override string Transform(string indata)
        {
            if (FindWhat != null && ReplaceWith != null )
            {
                if (FindWhat == "")
                {
                    return indata;
                }
                string findUnescaped;
                string replacementUnescaped;
                
                if (UseRegex)
                {
                    findUnescaped = Regex.Unescape(findWhat);
                    replacementUnescaped = Regex.Unescape(replaceWith);
                    string result = Regex.Replace(indata, findUnescaped, replacementUnescaped);
                    return result;
                }
                else
                {
                    findUnescaped = findWhat;
                    replacementUnescaped = replaceWith;
                    return indata.Replace(findWhat, replaceWith);
                }
            }
            return indata;
        }
        public override string ToString()
        {
            return "Replace \"" +FindWhat + "\" with \"" + ReplaceWith + "\"";
        }
        public string FindWhat { 
            get 
            {
                return findWhat; } 
            set 
            {
                findWhat = value;
                OnPropertyChanged("FindWhat");
            } 
        }
        private string findWhat;
        private string replaceWith;
        public string ReplaceWith
        {
            get
            { return replaceWith;/*Regex.Escape(replaceWith ?? "");*/ }
            set
            {
                replaceWith = value; /* Regex.Unescape(value);*/
                OnPropertyChanged("ReplaceWith");
            }
        }
        private bool useRegex;
        public bool UseRegex {
            get
            { 
                return useRegex; 
            }
            set
            {
                useRegex = value; 
                OnPropertyChanged("UseRegex");
            }
        }

    }
    
}
