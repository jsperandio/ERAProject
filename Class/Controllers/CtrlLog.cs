using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERAProject.Class.Controllers
{
    class CtrlLog
    {
        public Binding GetLogBinding(string controlPropertyName, string objectProperty)
        {
            return new Binding(controlPropertyName, GlobalVariables.LogTrack, objectProperty);
        }

        public void ConstructLog()
        {
            GlobalVariables.LogTrack = new ObservableCollection<Log>();
        }

        public bool SetOnChangedEvent(NotifyCollectionChangedEventHandler method)
        {
            bool result;
            try
            {
                GlobalVariables.LogTrack.CollectionChanged += method;
                result=true;
            }
            catch(Exception e)
            {
                result=false;
            }
            return result;
        }
    }
}
