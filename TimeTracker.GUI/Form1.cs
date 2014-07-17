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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgencyView agencyView = new AgencyView();
            agencyView.StartPosition = FormStartPosition.CenterParent;

            agencyView.ShowDialog();
        }

        private void consultantsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgencyConsultants agencyConsultants = new AgencyConsultants();
            agencyConsultants.StartPosition = FormStartPosition.CenterParent;

            agencyConsultants.ShowDialog();
        }

        private void viewToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CompanyView companyView = new CompanyView();
            companyView.StartPosition = FormStartPosition.CenterParent;

            companyView.ShowDialog();
        }

        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompanyPeople companyPeople = new CompanyPeople();
            companyPeople.StartPosition = FormStartPosition.CenterParent;

            companyPeople.ShowDialog();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewEngagementWizard newEngagement = new NewEngagementWizard();
            newEngagement.StartPosition = FormStartPosition.CenterParent;

            newEngagement.ShowDialog();
        }

        private void testItToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TestIt dialog = new TestIt();
            dialog.StartPosition = FormStartPosition.CenterParent;
            dialog.ShowDialog();
        }
    }
}
