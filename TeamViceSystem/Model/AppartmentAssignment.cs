using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamViceSystem.Model
{
    public class AppartmentAssignment
    {
        /// <summary>
        /// Attributterne som matcher tabellen i Vice database. 
        /// </summary>
     
        public int AppartmentNo { get; set; }
    
        public string AssignTitle { get; set; }

        public string AssignText { get; set; }

        public int AssignRankNo { get; set; }

        public int EmployeeID { get; set; }

        public int AppartmentPhone1 { get; set; }

        public string AppartmentOwner { get; set; }

        public string Comment { get; set; }

        public override string ToString()
        {
            return AppartmentNo + AssignTitle + AssignText + AssignRankNo + AppartmentPhone1; 
        }
    }
}
