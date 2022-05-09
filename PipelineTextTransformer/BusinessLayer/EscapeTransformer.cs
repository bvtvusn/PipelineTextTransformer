using System.Text.RegularExpressions;

namespace PipelineTextTransformer
{
    public class EscapeTransformer : Transformer
    {
        public override string Transform(string indata)
        {
            return Regex.Escape(indata);
        }
        public override string ToString()
        {
            return "Escape regex characters";
        }
    }

}
