using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace Zubos.System.Business
{
    /// <summary>
    /// Global static class, top level.
    /// </summary>
    public static class Global
    {
        public static SortedList<int, RoomContainer> AllRoomContainers { get; }
        public static SortedList<int, Customer> AllCustomers { get; }

    }
}
