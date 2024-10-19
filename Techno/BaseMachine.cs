using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Techno
{
    public abstract class BaseMachine
    {
        public DateTime _ProductionDate;
        public int SerialNo { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string OperationSystem { get; set; }

        public DateTime ProductionDate
        { 
            get { return DateTime.Now; }
        
        }

        public virtual void DisplayInfo()
        {
        }

        public abstract void GetProductName() ;
    }
}

