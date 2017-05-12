using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamViceSystem.Model;

namespace TeamViceSystem.ViewModel
{
    public class AppartAssignViewModel: INotifyPropertyChanged
    {
        public ObservableCollection<AppartmentAssignment> AppartAssignVMList { get; set; }

        public AppartAssignViewModel()
        {
            AppartAssignVMList = new ObservableCollection<AppartmentAssignment>();
        }

        #region INotifyPropertyChanged Interfaset
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyname)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyname));
            }
        }

        #endregion


    }
}
