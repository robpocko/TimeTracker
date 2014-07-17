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
    public partial class AgencyConsultants : Form
    {
        //TimeTrackerModelContainer context;

        public AgencyConsultants()
        {
            InitializeComponent();

            //context = new TimeTrackerModelContainer();
           // var dbQuery = context.Agencies.Where(id => id.Id >= 0).ToArray();
        }

        private void AgencyConsultants_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'trackerDataSet.Consultants' table. You can move, or remove it, as needed.
            this.consultantsTableAdapter.Fill(this.trackerDataSet.Consultants);
            // TODO: This line of code loads data into the 'trackerDataSet.Agencies' table. You can move, or remove it, as needed.
            this.agenciesTableAdapter.Fill(this.trackerDataSet.Agencies);
            // TODO: This line of code loads data into the 'trackerDataSet.Agencies' table. You can move, or remove it, as needed.
            this.agenciesTableAdapter.Fill(this.trackerDataSet.Agencies);
            //consultantsBindingSource.DataSource = context.Agencies.Local;
            //agenciesBindingSource.DataSource = context.Agencies.Local;
        }

        private void agenciesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.agenciesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.trackerDataSet);

        }

        private void agenciesBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.agenciesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.trackerDataSet);

        }
    }
}
