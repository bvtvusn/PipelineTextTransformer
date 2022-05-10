using PipelineTextTransformer.BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PipelineTextTransformer
{
    public partial class EditForm : Form
    {
        BL bl;
        public EditForm(BL bl)
        {
            InitializeComponent();
            this.bl = bl;

            // Prepare GUI
            btnArrowUp.Text = char.ConvertFromUtf32(0x2191);
            btnArrowDown.Text = char.ConvertFromUtf32(0x2193);
            foreach (Type type in BVhelper.GetInheritedClasses(typeof(Transformer)))
            {
                //cmbNewType.Items.Add(type.Name);
                lstNewType.Items.Add(type.Name);
            }
            //cmbNewType.SelectedIndex = 0;
            lstNewType.SelectedIndex = 0;

            //BVhelper.GetInheritedClasses(typeof(Transformer).Where(iterator => iterator.Name);
            //cmbNewType.Items.AddRange(B);


            // Update the window content :
            txtPreviewSoure.Text = bl.sourceText;
            //DrawTransformerList();



            // Attach event handlers
            //lstTransformers.SelectedValueChanged += LstTransformers_SelectedValueChanged;
            treeView1.AfterSelect += TreeView1_AfterSelect;
            
            ReloadProject();


            // Testing
            //var k  = treeView1.Nodes;

            //PipelineTransformer pip = new PipelineTransformer();
            //PipelineTransformer pip2 = new PipelineTransformer();
            //ReplaceTransformer rep1 = new ReplaceTransformer();
            //pip2.Children.Add(rep1);
            //pip.Children.Add(pip2);
            //bl.project.mainTransformer_2.Children.Add(pip);

            //treeView1.Nodes.Clear();
            //PopulateTree(treeView1.Nodes, bl.project.mainTransformer_2);
            //string testdata = "tab:\"\t\"tab";
            //string testFind = "\"\t";
            //testdata.Replace(testFind, "-");
            //string result = Regex.Replace(testdata, testFind, "-");

        }

        

        private void MainTransformer_2_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            DrawTransformerList();
            UpdateTrackbar();
            PerformTransform();
        }

        //private void Children_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        //{
        //    //UpdateTrackbar();
        //    //DrawTransformerList();
        //}

        void UpdateTrackbar()
        {
            trackBar1.Minimum = 0;
            trackBar1.Maximum = bl.project.mainTransformer_2.CountAllChildren();
            trackBar1.Value = trackBar1.Minimum;
        }

        private void LstTransformers_SelectedValueChanged(object sender, EventArgs e)
        {
            if ((sender as ListBox).SelectedItem != null)
            {
                object tr = (sender as ListBox).SelectedItem;
                lblTransformertype.Text = tr.GetType().Name;
                propertyGrid1.SelectedObject = tr;

                bl.project.mainTransformer_2.selectedIndex = bl.project.mainTransformer_2.Children.IndexOf((Transformer)tr);
            }
            else
            {
                propertyGrid1.SelectedObject = null;
                bl.project.mainTransformer_2.selectedIndex = -1;
            }
        }
        private void TreeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //e.Node
            //MessageBox.Show("Select");

            if (treeView1.SelectedNode != null)
            {
                object tr = treeView1.SelectedNode.Tag;
                lblTransformertype.Text = tr.GetType().Name;
                propertyGrid1.SelectedObject = tr;

                //bl.project.mainTransformer_2.selectedIndex = bl.project.mainTransformer_2.Children.IndexOf((Transformer)tr);
                //bl.project.mainTransformer_2.SelectedTransformer_Treeview = (Transformer)tr;
                bl.selectedTransformer_tree2 = (Transformer)tr;
            }
            else
            {
                propertyGrid1.SelectedObject = null;
                //bl.project.mainTransformer_2.SelectedTransformer_Treeview = null;
                bl.selectedTransformer_tree2 = null;
            }
        }
        private void btnArrowUp_Click(object sender, EventArgs e)
        {
            //Transformer selected = (Transformer)lstTransformers.SelectedItem;
            //bl.project.mainTransformer_2.MoveTransformer(selected, -1);
            //PipelineTransformer parentTrans = (PipelineTransformer)treeView1.SelectedNode.Parent.Tag;
            PipelineTransformer parentTrans;
            if (treeView1.SelectedNode.Level == 0)
            {
                parentTrans = bl.project.mainTransformer_2;
            }
            else
            {
                parentTrans = (PipelineTransformer)treeView1.SelectedNode.Parent.Tag;
            }
            bl.project.mainTransformer_2.MoveTransformer((Transformer)treeView1.SelectedNode.Tag, -1, parentTrans);
        }
        private void btnArrowDown_Click(object sender, EventArgs e)
        {
            //Transformer selected = (Transformer)lstTransformers.SelectedItem;
            //bl.project.mainTransformer_2.MoveTransformer(selected, 1);

            //Transformer parentTrans = (Transformer)treeView1.SelectedNode.Parent.Tag;
            PipelineTransformer parentTrans;
            if (treeView1.SelectedNode.Level == 0)
            {
                parentTrans = bl.project.mainTransformer_2;
            }
            else
            {
                parentTrans = (PipelineTransformer)treeView1.SelectedNode.Parent.Tag;
            }
            
            bl.project.mainTransformer_2.MoveTransformer((Transformer)treeView1.SelectedNode.Tag, 1, parentTrans);
        }

        private void DrawTransformerList()
        {
            //lstTransformers.Items.Clear();
            //foreach (Transformer item in bl.project.mainTransformer_2.Children)
            //{
            //    string str = item.ToString();
            //    lstTransformers.Items.Add(item);
            //}
            //if (lstTransformers.Items.Count > 0)
            //{
            //    lstTransformers.SelectedIndex = bl.project.mainTransformer_2.selectedIndex;
            //}
            //PerformTransform();



            // Populate treeview:
            treeView1.Nodes.Clear();
            PopulateTree(treeView1.Nodes, bl.project.mainTransformer_2);
            treeView1.ExpandAll();

        }

        public void PopulateTree(TreeNodeCollection root, Transformer transformer_parent)
        {
            
            if (transformer_parent is PipelineTransformer)
            {
                PipelineTransformer pipe = (transformer_parent as PipelineTransformer);
                foreach (Transformer transf in pipe.Children)
                {
                    TreeNode node = new TreeNode(transf.ToString());
                    node.Tag = transf;
                    root.Add(node);
                    if (transf is PipelineTransformer)
                    {
                        PopulateTree(node.Nodes, (PipelineTransformer)transf ); // ((PipelineTransformer)transf).Children
                    }

                    if (transf == bl.selectedTransformer_tree2)
                    {
                        treeView1.SelectedNode = node;
                        //treeView1.Focus();
                    }
                }
            }
        }

        //public void PopulateTree(ref TreeNode root, List<Department> departments)
        //{
        //    if (root == null)
        //    {
        //        root = new TreeNode();
        //        root.Text = "Departments";
        //        root.Tag = null;
        //        // get all departments in the list with parent is null
        //        var details = departments.Where(t => t.Parent == null);
        //        foreach (var detail in details)
        //        {
        //            var child = new TreeNode()
        //            {
        //                Text = detail.Name,
        //                Tage = detail.Id,
        //            };
        //            PopulateTree(ref child, departments);
        //            root.Nodes.Add(child);
        //        }
        //    }
        //    else
        //    {
        //        var id = (int)root.Tag;
        //        var details = departments.Where(t => t.Parent == id);
        //        foreach (var detail in details)
        //        {
        //            var child = new TreeNode()
        //            {
        //                Text = detail.Name,
        //                Tage = detail.Id,
        //            };
        //            PopulateTree(ref child, departments);
        //            root.Nodes.Add(child);
        //        }
        //    }
        //}



        private void btnAddTransformer_Click(object sender, EventArgs e)
        {
            Assembly asm = typeof(Transformer).Assembly;
            string tname = asm.GetName().Name + '.' + (string)lstNewType.SelectedItem;
            Type selType = asm.GetType(tname);
            //Type selType = (Type)cmbNewType.SelectedItem;
            Transformer myNew =  (Transformer)Activator.CreateInstance(selType);
            //bl.project.mainTransformer_2.InsertItemAfterSelectedIndex(myNew);

            bl.InsertTransformerAfterSelected(myNew);
        }

        private void propertyGrid1_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            //try
            //{
                bl.TestSelectedTransformer(propertyGrid1.SelectedObject);
                //DrawTransformerList();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
         }

        private void txtPreviewSoure_TextChanged(object sender, EventArgs e)
        {
            PerformTransform();
        }

        void PerformTransform()
        {
            string input = txtPreviewSoure.Text;
            //txtPreviewResult.Text = bl.mainTransformer.Transform(input);
            //try
            //{
                int steps = trackBar1.Maximum - trackBar1.Value;
                txtPreviewResult.Text = bl.project.mainTransformer_2.Transform(input,ref steps);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bl.dal.SaveAndOverwriteProject(bl.project,false);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bl.OpenFile();
            //bl.project = bl.dal.OpenFile();
            ReloadProject();
        }
        private void ReloadProject()
        {
            //bl.project.mainTransformer_2.Children.CollectionChanged += Children_CollectionChanged;
            

            bl.project.mainTransformer_2.ReattachChildrenEventhandlers();

            bl.project.mainTransformer_2.PropertyChanged += MainTransformer_2_PropertyChanged;

            UpdateTrackbar();
            DrawTransformerList();
            PerformTransform();
        }
        private void btnTest_Click(object sender, EventArgs e)
        {
            //bl.dal.TestDeserialization(bl.project);

            //PipelineTransformer nr1 = new PipelineTransformer();
            //nr1.Children.Add(new PipelineTransformer());
            //((PipelineTransformer)nr1.Children[0]).Children.Add(new ReplaceTransformer());
            //ProjectContainer con = new ProjectContainer();
            //con.mainTransformer_2 = nr1;

            //string test  = bl.dal.Serializeproject(con);
            //ProjectContainer c2 = bl.dal.Deserializeproject(test);

        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bl.dal.SaveAndOverwriteProject(bl.project, true);
        }

        private void btnDeleteTransformer_Click(object sender, EventArgs e)
        {
            //if (lstTransformers.SelectedItem != null)
            //{
            //    int index = bl.project.mainTransformer_2.selectedIndex;
            //    bl.project.mainTransformer_2.Remove_At(index);
            //}
            if (treeView1.SelectedNode != null)
            {
                PipelineTransformer parentTrans;
                if (treeView1.SelectedNode.Level == 0)
                {
                    parentTrans = bl.project.mainTransformer_2;
                }
                else
                {
                    parentTrans = (PipelineTransformer)treeView1.SelectedNode.Parent.Tag;
                }
                parentTrans.Children.Remove(treeView1.SelectedNode.Tag);
                //int index = bl.project.mainTransformer_2.selectedIndex;
                //bl.project.mainTransformer_2.Remove_At(index);
                bl.selectedTransformer_tree2 = null;
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            PerformTransform();
        }

        private void viewHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpWindow helpWindow = new HelpWindow();
            helpWindow.ShowDialog();
        }

        private void lblTransformertype_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnAddAsChild_Click(object sender, EventArgs e)
        {
            if (bl.selectedTransformer_tree2 is PipelineTransformer)
            {
                Assembly asm = typeof(Transformer).Assembly;
                string tname = asm.GetName().Name + '.' + (string)lstNewType.SelectedItem;
                Type selType = asm.GetType(tname);

                //Type selType = (Type)cmbNewType.SelectedItem;
                Transformer myNew = (Transformer)Activator.CreateInstance(selType);
                bl.AddChildTransformer(myNew);
                //((PipelineTransformer)bl.selectedTransformer_tree2).Children.Add(myNew);

                //bl.project.mainTransformer_2.InsertItemAfterSelectedIndex(myNew);
            }
            else
            {
                MessageBox.Show("Parent must be a pipeline");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path;
            txtPreviewSoure.Text = bl.dal.GetFileText(out path);
            txtSourcePath.Text = path;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DrawTransformerList();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtPreviewSoure.WordWrap = checkBox1.Checked;
            txtPreviewResult.WordWrap = checkBox1.Checked;
        }

        private void btnCopySelected_Click(object sender, EventArgs e)
        {
            //bl.copyBoard = bl.dal.SerializeTransformer(bl.selectedTransformer_tree2);
            bl.CopySelected();

            //ProjectContainer cpProj = new ProjectContainer();
            //cpProj.mainTransformer_2 = bl.selectedTransformer_tree2
            //bl.dal.Serializeproject


            //string copy_type = bl.selectedTransformer_tree2.GetType().FullName;
            //var copy_obj = bl.selectedTransformer_tree2;

            //DataObject myDataObject = new DataObject(copy_type, copy_obj);
            //Clipboard.SetDataObject(myDataObject);
        }

        private void btnPaste_Click(object sender, EventArgs e)
        {
            bl.Paste();
            //var d = Clipboard.GetDataObject();
            //var pasted = d.GetData("PipelineTextTransformer.Transformer");
            
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

            // Why is not updates in the children discovered (no events are sent)
            string test = "{\"Children\":[{\"FindWhat\":\"a\",\"ReplaceWith\":\"b\",\"UseRegex\":false,\"objType\":\"PipelineTextTransformer.ReplaceTransformer\",\"Comment\":null}],\"objType\":\"PipelineTextTransformer.PipelineTransformer\",\"Comment\":null}";
            Transformer pasted = bl.dal.DeserializeTransfromer(test);
            bl.project.mainTransformer_2.Children.Insert(0, pasted);
        }
    }
}
