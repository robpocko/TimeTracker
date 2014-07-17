using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTracker.EF
{
    public partial class People
    {
        public string WholeName
        {
            get { return string.Format("{0} {1}", FirstName, LastName); }
        }
    }
}
