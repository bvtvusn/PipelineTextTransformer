using PipelineTextTransformer.BusinessLayer;
using PipelineTextTransformer.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace PipelineTextTransformer
{
    public class BL
    {
        // Business layer
        //public readonly PipelineTransformer mainTransformer;

        public ProjectContainer project;

        public string sourceText;
        public DAL dal;

        public Transformer selectedTransformer_tree2 { get; internal set; }

        public string copyBoard;
        //public int selectedIndex = 0;
        public BL(DAL dal)
        {
            PipelineTransformer mainTransformer = new PipelineTransformer();
            project = new ProjectContainer(mainTransformer);
            this.dal = dal;
            mainTransformer.PropertyChanged += MainTransformer_PropertyChanged;

        }

        private void MainTransformer_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (project.mainTransformer_2.Children.Count == 0)
            {
                selectedTransformer_tree2 = null;
            }
            
        }

        //string PerformTransform()
        //{

        //}

        public void TestSelectedTransformer(object selectedObject)
        {
            Transformer mytr = (Transformer)selectedObject;
            if (mytr is ReplaceTransformer)
            {
                ((ReplaceTransformer)mytr).TestParameters();
            }
        }
        public void OpenFile()
        {
            project = dal.OpenFile();
        }
        internal void moveTransformer(Transformer selected, int v)
        {
            //int posChange = mainTransformer.MoveTransformer(selected, v);
            //selectedIndex += posChange;
        }
        internal void InsertTransformerBelowParent(Transformer insertion, PipelineTransformer parent)
        {
            this.selectedTransformer_tree2 = insertion;
            parent.Children.Add(insertion);
        }
        internal void InsertTransformerAfterSelected(Transformer insertion)
        {
            Transformer previousSelected = selectedTransformer_tree2;
            selectedTransformer_tree2 = insertion;
            PipelineTransformer parent = project.mainTransformer_2; // initial guess
            int index = -1; // initial guess

            if (previousSelected != null)
            {
                parent = Transformer.RecursiveParentFinder(project.mainTransformer_2, previousSelected);
                index = parent.Children.IndexOf(previousSelected);
            }
            
            parent.Children.Insert(index + 1, insertion);
            //parent.Children.Add(insertion);
        }

        internal void AddChildTransformer(Transformer myNew)
        {
            PipelineTransformer parent = (PipelineTransformer)selectedTransformer_tree2;
            selectedTransformer_tree2 = myNew;
            
            parent.Children.Add(myNew);
            
        }

        internal void CopySelected()
        {
            Type t = selectedTransformer_tree2.GetType();
            copyBoard = dal.SerializeTransformer(selectedTransformer_tree2, t);
        }

        internal void Paste()
        {
            PipelineTransformer parent = project.mainTransformer_2;
            int index = 0;

            if(selectedTransformer_tree2 != null)
            {
                parent = Transformer.RecursiveParentFinder(project.mainTransformer_2, selectedTransformer_tree2);
                index = parent.Children.IndexOf(selectedTransformer_tree2);
            }

            
            Transformer pasted = dal.DeserializeTransfromer(copyBoard);

            parent.Children.Insert(index + 1, pasted);
            //project.mainTransformer_2.Children.Add(pasted);
        }
    }

}