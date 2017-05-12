using System;
using System.Collections.Generic;
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


    }
}
