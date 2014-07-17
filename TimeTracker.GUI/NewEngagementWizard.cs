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
using TimeTracker.GUI.Extensions;

namespace TimeTracker.GUI
{
    public partial class NewEngagementWizard : Form
    {
        TimeTrackerModelContainer context;
        int stepNumber = 1;

        public NewEngagementWizard()
        {
            InitializeComponent();
            context = new TimeTrackerModelContainer();
            var dbQuery = context.Engagements.Where(id => id.Id < 0).ToArray();
        }

        private void NewEngagementWizard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'trackerDataSet.People' table. You can move, or remove it, as needed.
            this.peopleTableAdapter.Fill(this.trackerDataSet.People);
            // TODO: This line of code loads data into the 'trackerDataSet.Consultants' table. You can move, or remove it, as needed.
            this.consultantsTableAdapter.Fill(this.trackerDataSet.Consultants);
            // TODO: This line of code loads data into the 'trackerDataSet.Companies' table. You can move, or remove it, as needed.
            this.companiesTableAdapter.Fill(this.trackerDataSet.Companies);
            // TODO: This line of code loads data into the 'trackerDataSet.Agencies' table. You can move, or remove it, as needed.
            this.agenciesTableAdapter.Fill(this.trackerDataSet.Agencies);

            engagementsBindingSource.DataSource = context.Engagements.Local;
            engagementsBindingSource.AddNew();
            
            panel1.Top = panel2.Top = panel3.Top = 2000;
            panel1.Left = panel2.Left = panel3.Left = 12;
            prevButton.Enabled = nextButton.Enabled = cancelButton.Enabled = true;
            saveButton.Enabled = false;

            agenciesList.SelectedIndex = 0;
            companiesList.SelectedIndex = 0;

            FormatForStep(1, 0);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {

        }

        private void FormatForStep(int stepNumber, int fromStepNumber)
        {
            switch (stepNumber)
            {
                case 1:
                    prevButton.Enabled = false;
                    panel1.Top = 12;
                    nextButton.Enabled = consultantsList.Items.Count > 0;
                    break;
                case 2:
                    prevButton.Enabled = true;
                    panel2.Top = 12;
                    nextButton.Enabled = peopleDataGridView.RowCount > 0;
                    break;
                case 3:
                    nextButton.Enabled = false;
                    panel3.Top = 12;
                    break;
            }

            switch (fromStepNumber)
            {
                case 0:
                    break;
                case 1:
                    panel1.Top = 2000;
                    break;
                case 2:
                    panel2.Top = 2000;
                    break;
                case 3:
                    panel3.Top = 2000;
                    break;
            }
        }

        private void prevButton_Click(object sender, EventArgs e)
        {
            stepNumber--;
            FormatForStep(stepNumber, stepNumber + 1);
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            stepNumber++;
            FormatForStep(stepNumber, stepNumber - 1);
        }

        private void agenciesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            nextButton.Enabled = consultantsList.Items.Count > 0 && consultantsList.SelectedIndex > -1;
        }

        private void companiesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            nextButton.Enabled = peopleDataGridView.RowCount > 0;
            if (companiesList.SelectedItem != null)
            {
                addressesIdTextBox.Text = ((System.Data.DataRowView)(companiesList.SelectedItem)).Row["Address_Id"].ToString();
            }
        }

        private void peopleDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (((System.Windows.Forms.DataGridView)sender).SelectedRows.Count > 0)
            {
                peopleIdTextBox.Text = ((System.Windows.Forms.DataGridView)sender).SelectedRows[0].Cells[0].Value.ToString();
            }
            else
            {
                peopleIdTextBox.Text = string.Empty;
            }
        }

        private void consultantsDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (((System.Windows.Forms.DataGridView)sender).SelectedRows.Count > 0)
            { 
                consultantsIdTextBox.Text = ((System.Windows.Forms.DataGridView)sender).SelectedRows[0].Cells[0].Value.ToString();
            }
            else
            {
                consultantsIdTextBox.Text = string.Empty;
            }
            
        }

    }
}
