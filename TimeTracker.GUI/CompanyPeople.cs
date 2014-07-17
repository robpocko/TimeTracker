using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeTracker.GUI
{
    public partial class CompanyPeople : Form
    {
        public CompanyPeople()
        {
            InitializeComponent();
        }

        private void companiesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.companiesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.trackerDataSet);

        }

        private void CompanyPeople_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'trackerDataSet.People' table. You can move, or remove it, as needed.
            this.peopleTableAdapter.Fill(this.trackerDataSet.People);
            // TODO: This line of code loads data into the 'trackerDataSet.Companies' table. You can move, or remove it, as needed.
            this.companiesTableAdapter.Fill(this.trackerDataSet.Companies);

        }
    }
}
