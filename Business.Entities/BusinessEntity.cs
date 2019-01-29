using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;

namespace Business.Entities
{
    public class BusinessEntity
    {
        public BusinessEntity()
        {
            this.State = States.New;
        }

        //Distinta forma de declaracion de vars:
        public int ID { get; set; }
        
        public States State { get; set; } 

        public enum States
        {
            Deleted,
            New,
            Modified,
            Unmodified
        }
    }
}
