using System.Text.RegularExpressions;

namespace PipelineTextTransformer
{
    public class UnescapeTransformer : Transformer
    {
        public override string Transform(string indata)
        {
            return Regex.Unescape(indata);
        }
        public override string ToString()
        {
            return "Unescape regex characters";
        }
    }

}
