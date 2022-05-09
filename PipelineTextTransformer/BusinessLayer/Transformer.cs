using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace PipelineTextTransformer
{
    [Serializable]
    public abstract class Transformer: INotifyPropertyChanged
    {
        public Transformer()
        {
            objType = this.GetType().FullName;
        }
        public abstract string Transform(string indata);
        
        [Browsable(false)] // Should not be shown in propertygrid view.
        public string objType { get; set; }

        public string Comment
        {
            get { return comment; }
            set { comment = value;
                OnPropertyChanged("Comment");
            }
        }
        private string comment;

        // Event that fires on property change.
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            OnPropertyChanged(new PropertyChangedEventArgs(propertyName));
        }
        protected void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
                handler(this, e);
        }

        public static PipelineTransformer RecursiveParentFinder(PipelineTransformer root, Transformer testobj)
        {
            foreach (Transformer item in root.Children)
            {
                if (item == testobj)
                {
                    return root;
                }
                if (item is PipelineTransformer)
                {
                    PipelineTransformer temp = RecursiveParentFinder(item as PipelineTransformer, testobj);
                    if (temp != null) return temp;
                }
            }
            return null;
        }
    }

}
