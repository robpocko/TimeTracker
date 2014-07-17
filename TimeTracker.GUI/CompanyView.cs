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
    public partial class CompanyView : Form
    {
        TimeTrackerModelContainer context;

        public CompanyView()
        {
            InitializeComponent();

            context = new TimeTrackerModelContainer();
            var dbQuery = context.Companies.Where(id => id.Id >= 0).ToArray();
        }

        private void CompanyView_Load(object sender, EventArgs e)
        {
            companiesBindingSource.DataSource = context.Companies.Local;
            stateIDComboBox.DataSource = Enum.GetValues(typeof(StateName));
        }

        private void agenciesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            context.SaveChanges();
        }

        private void companiesBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            addressGroupbox.Visible = !(addAddress.Visible = (((Companies)companiesBindingSource.Current).Address == null));
        }

        private void addAddress_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (((Companies)companiesBindingSource.Current).Id > 0)
            {
                Addresses newAddress = new Addresses();

                ((Companies)companiesBindingSource.Current).Address = newAddress;
                companiesBindingSource.ResetBindings(false);

                addressGroupbox.Visible = !(addAddress.Visible = false);
            }
            else
            {
                MessageBox.Show("You must save the Company record first");
            }
        }
    }
}
