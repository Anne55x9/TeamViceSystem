using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamViceSystem.Model
{
    public class AppartAssignOverviewSingleton
    {
        private static AppartAssignOverviewSingleton instance;

        public static AppartAssignOverviewSingleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AppartAssignOverviewSingleton();
                }
                return instance; 
            }
        }

        public ObservableCollection<AppartmentAssignment> AppartAssignOverview { get; set; }

        public AppartAssignOverviewSingleton()
        {
            AppartAssignOverview = new ObservableCollection<AppartmentAssignment>();
        }

    }
}
