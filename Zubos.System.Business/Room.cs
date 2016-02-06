using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zubos.System.Business
{
    /// <summary>
    /// Room object class.
    /// </summary>
    public class Room
    {
        public int                              ID { get; }
        public SortedList<int, Customer>        myCustomers { get; set; }


        /// <summary>
        /// Default constructor for Room object.
        /// </summary>
        /// <param name="ID_Param"></param>
        public Room(int ID_Param)
        {
            ID = ID_Param;
            
        }
    }
}
