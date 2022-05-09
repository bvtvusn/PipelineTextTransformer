using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PipelineTextTransformer
{
    public partial class TransformerControl : UserControl
    {
        Transformer attachedTransformer;
        public TransformerControl(Transformer transformer)
        {
            attachedTransformer = transformer;
            InitializeComponent();
            lblComment.Text = attachedTransformer.Comment;
            //lblFunction.Text = attachedTransformer.Function;
            //lblType.Text = attachedTransformer.TypeName2;
        }
    }
}
