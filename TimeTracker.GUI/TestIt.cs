using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeTracker.EF;

namespace TimeTracker.GUI
{
    public partial class TestIt : Form
    {
        TimeTrackerModelContainer context;

        public TestIt()
        {
            InitializeComponent();
            context = new TimeTrackerModelContainer();
            var dbQuery = context.Companies.Where(id => id.Id >= 0).ToArray();
        }



        private void TestIt_Load(object sender, EventArgs e)
        {
            companiesBindingSource.DataSource = context.Companies.Local;

        }
    }
}
