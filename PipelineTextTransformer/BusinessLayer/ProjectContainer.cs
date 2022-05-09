using System;
using System.Collections.Generic;
using System.Text;

namespace PipelineTextTransformer.BusinessLayer
{
    [Serializable]
    public class ProjectContainer
    {
        //public PipelineTransformer lmainTransformer_2;
        public string projectPath;
        public PipelineTransformer mainTransformer_2 { get; set; }

        // bool savelocation_set?
        //public int Slettes { get; set; }
        public ProjectContainer(PipelineTransformer pipeline)
        {
            this.mainTransformer_2 = pipeline;
        }
        public ProjectContainer()
        {
            this.mainTransformer_2 = new PipelineTransformer();
        }
    }
}
