using PipelineTextTransformer.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PipelineTextTransformer
{


    // ######## Ideer ######### //
    //Ideer: Forskjellige datasources: Text, file content.
    //Forskjellige transformers: Replace text(with escape chars, pattern wildcard), tokenizer(symbol in between), number formatter, Insert at pattern(wildcard).
    // Propertygrid brukes til å endre parametere på transformers/pipelines. En pipeline skal kunne inneholde en annen pipeline.
    //Elementer i pipelinen kan legges i en flowlayoutpanel.
    //en trackbar velger hvor mye av pipelinen som skal være aktiv.
    //Preview av datasource og output.
    // Drag and drop in listbox? (To reorder)

    // Number formatter
    // Transposer

    // Event for pipeline changed that catches all types of changes.

    public partial class Form1 : Form
    {
        //PipelineTransformer mainPipeline;

        BL bl; // = new BL();
        public Form1()
        {
            InitializeComponent();
            DAL dal = new DAL();
            bl = new BL(dal);

            bl.project.mainTransformer_2.Children.Add(new ReplaceTransformer("hei","hade"));
            bl.project.mainTransformer_2.Children.Add(new ReplaceTransformer(",", "."));

            //foreach (Control control in flowLayoutPanel1.Controls)
            //{
            //    control.MouseDown += flowLayoutPanel1_MouseDown;
            //}

            //mainPipeline = new PipelineTransformer();
            //mainPipeline.Children.Add(new ReplaceTransformer(".",":"));
            //mainPipeline.Children.Add(new ReplaceTransformer("a", "b"));
            ////mainPipeline.
            //flowLayoutPanel1.Controls.Add(new TransformerControl(mainPipeline.Children[0]));

            
        }

        //as a reusable method/function
        

        private void btnEditWindow_Click(object sender, EventArgs e)
        {
            bl.sourceText = txtPreviewSource.Text;

            Form editform = new EditForm(bl);
            editform.ShowDialog();
        }


        //flowLayoutPanel1.DragEnter += new DragEventHandler(flowLayoutPanel_DragEnter);



        //private void flowLayoutPanel1_DragEnter(object sender, DragEventArgs e)
        //{
        //    e.Effect = DragDropEffects.All;
        //}

        //this.flowLayoutPanel1.DragDrop += new DragEventHandler(flowLayoutPanel_DragDrop);

        //void flowLayoutPanel1_DragDrop(object sender, DragEventArgs e)
        //{
        //    Label data = (Label)e.Data.GetData(typeof(Label));
        //    FlowLayoutPanel _destination = (FlowLayoutPanel)sender;
        //    FlowLayoutPanel _source = (FlowLayoutPanel)data.Parent;

        //    if (_source != _destination)
        //    {
        //        // Add control to panel
        //        _destination.Controls.Add(data);
        //        data.Size = new Size(_destination.Width, 50);

        //        // Reorder
        //        Point p = _destination.PointToClient(new Point(e.X, e.Y));
        //        var item = _destination.GetChildAtPoint(p);
        //        int index = _destination.Controls.GetChildIndex(item, false);
        //        _destination.Controls.SetChildIndex(data, index);

        //        // Invalidate to paint!
        //        _destination.Invalidate();
        //        _source.Invalidate();
        //    }
        //    else
        //    {
        //        // Just add the control to the new panel.
        //        // No need to remove from the other panel,
        //        // this changes the Control.Parent property.
        //        Point p = _destination.PointToClient(new Point(e.X, e.Y));
        //        var item = _destination.GetChildAtPoint(p);
        //        int index = _destination.Controls.GetChildIndex(item, false);
        //        _destination.Controls.SetChildIndex(data, index);
        //        _destination.Invalidate();
        //    }
        //}



        //private void flowLayoutPanel1_DragDrop(object sender, DragEventArgs e)
        //{
        //    MyWrapper wrapper = (MyWrapper)e.Data.GetData(typeof(MyWrapper));
        //    Control source = wrapper.Control;

        //    Point mousePosition = flowLayoutPanel1.PointToClient(new Point(e.X, e.Y));
        //    Control destination = flowLayoutPanel1.GetChildAtPoint(mousePosition);

        //    int indexDestination = flowLayoutPanel1.Controls.IndexOf(destination);
        //    if (flowLayoutPanel1.Controls.IndexOf(source) < indexDestination)
        //        indexDestination--;

        //    flowLayoutPanel1.Controls.SetChildIndex(source, indexDestination);
        //}

        //private void txtPreviewSource_TextChanged(object sender, EventArgs e)
        //{
        //    txtPreviewResult.Text =  mainPipeline.Transform(txtPreviewSource.Text);
        //}
    }
    class MyWrapper
    {
        private Control control;

        public MyWrapper(Control control)
        {
            this.control = control;
        }

        public Control Control
        {
            get { return control; }
        }
    }
}
