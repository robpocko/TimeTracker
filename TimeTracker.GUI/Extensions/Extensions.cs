using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTracker.EF;

namespace TimeTracker.GUI.Extensions
{
    public static class Extensions
    {
        public static string FullName(this Consultants consultant)
        {
            return consultant.FirstName + " " + consultant.LastName;
        }
    }
}
