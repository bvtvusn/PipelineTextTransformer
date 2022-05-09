using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace PipelineTextTransformer
{
    [Serializable]
    public class PipelineTransformer : Transformer
    {
        //public int NumActiveSteps { 
        //    get { return numActiveSteps; } 
        //    set { numActiveSteps = value;

        //    } }
        //private int numActiveSteps;

        //[Browsable(false)]
        //public Transformer SelectedTransformer { get { return (Transformer)Children[selectedIndex]; } }

        [Browsable(false)]
        //public Transformer SelectedTransformer_Treeview { get; set; } // Should be moved out of this class. Probably to the projectContainer class.


        public int selectedIndex;
        public PipelineTransformer()
        {
            Children = new ObservableCollection<object>();
            selectedIndex = -1;
            //NumActiveSteps = 1000000;
            Children.CollectionChanged += Children_CollectionChanged;
        }

        private void Children_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            if (Children.Count == 0)
            {
                selectedIndex = -1;
                //SelectedTransformer_Treeview = null;
            }
            else if (Children.Count == 1)
            {
                selectedIndex = 0;
                //SelectedTransformer_Treeview = (Transformer)this.Children[0];
            }
            //NumActiveSteps = Children.Count;

            if (e.NewItems != null)
            {
                foreach (Transformer item in e.NewItems)
                {
                    item.PropertyChanged += PipelineTransformer_PropertyChanged;
                }
            }
            
            OnPropertyChanged("Child transformer added / removed");
        }

        private void PipelineTransformer_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            OnPropertyChanged("Child transformer Changed");
        }

        public override string ToString()
        {
            if (this.Comment == null)
            {
                return "A sequence of transformers";
            }
            else
            {
                return this.Comment;
            }
        }

        //public override string Transform(string indata)
        //{
        //    //string tempStr = indata;
        //    //for (int i = 0; i < Children.Count && i < NumActiveSteps; i++)
        //    //{
        //    //    tempStr = (Children[i] as Transformer).Transform(tempStr);
        //    //}

        //    return TranformLogic(indata,Children.Count);
        //}
        public override string Transform(string indata)
        {
            int num = Children.Count;
            return TranformLogic(indata, ref num);
        }
        public string Transform(string indata, ref int steps)
        {
            return TranformLogic(indata, ref steps);
        }

        internal virtual string TranformLogic(string indata, ref int steps)
        {
            string tempStr = indata;
            for (int i = 0; i < Children.Count && steps > 0; i++)
            {
                if (Children[i] is PipelineTransformer)
                {
                    tempStr = (Children[i] as PipelineTransformer).Transform(tempStr, ref steps);
                }
                else
                {
                    tempStr = (Children[i] as Transformer).Transform(tempStr);
                }
                steps -= 1; // Count one down for the current transformer.
            }
            return tempStr;
        }

        //public List<Transformer> Children { get; set; }
        public ObservableCollection<object> Children { get; set; }  // The datatype must be object because if not, the serializer will always use the Type when serializing.


        public int MoveTransformer(Transformer tr,int relIndex, PipelineTransformer parentTrans)
        {
            if (parentTrans.Children.Count < 1)
            {
                return 0;
            }
            int curInd = parentTrans.Children.IndexOf(tr);
            int nextInd = curInd + relIndex;
            if (nextInd >= parentTrans.Children.Count) nextInd = parentTrans.Children.Count - 1;
            if (nextInd < 0) nextInd = 0;
            parentTrans.Children.Move(curInd, nextInd);
            //selectedIndex = nextInd;
            return nextInd - curInd;





            //if (Children.Count < 1)
            //{
            //    return 0;
            //}
            //int curInd = Children.IndexOf(tr);
            //int nextInd = curInd + relIndex;
            //if (nextInd >= Children.Count) nextInd = Children.Count - 1;
            //if (nextInd < 0) nextInd = 0;
            //Children.Move(curInd, nextInd);
            //selectedIndex = nextInd;
            //return nextInd - curInd;
        }

        //internal void InsertItemAfterSelectedIndex(Transformer myNew)
        //{
        //    Children.Insert(selectedIndex + 1, myNew);
        //}

        //internal void Remove_At(int index)
        //{
        //    if (selectedIndex > Children.Count - 2)
        //    {
        //        selectedIndex = Children.Count - 2;
        //    }
        //    Children.RemoveAt(index);
        //}

        internal void ReattachChildrenEventhandlers()
        {
            Children.CollectionChanged += Children_CollectionChanged;

            foreach (Transformer item in Children)
            {
                item.PropertyChanged -= PipelineTransformer_PropertyChanged;
                item.PropertyChanged += PipelineTransformer_PropertyChanged;

                if(item is PipelineTransformer)
                {
                    (item as PipelineTransformer).ReattachChildrenEventhandlers();
                }
            }
        }

        internal int CountAllChildren()
        {
            int myCounter = 0;
            foreach (Transformer item in Children)
            {
                if (item is PipelineTransformer)
                {
                    myCounter += (item as PipelineTransformer).CountAllChildren() + 1;
                }
                else
                {
                    myCounter += 1;
                }
            }
            return myCounter;
        }
    }
}
