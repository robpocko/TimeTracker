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
    public partial class AgencyView : Form
    {
        TimeTrackerModelContainer context;

        public AgencyView()
        {
            InitializeComponent();

            context = new TimeTrackerModelContainer();
            var dbQuery = context.Agencies.Where(id => id.Id >= 0).ToArray();
        }

        private void agenciesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            context.SaveChanges();
        }

        private void AgencyView_Load(object sender, EventArgs e)
        {
            agenciesBindingSource.DataSource = context.Agencies.Local;
            stateIDComboBox.DataSource = Enum.GetValues(typeof(StateName));
        }

        private void agenciesBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            addressGroupbox.Visible = !(addAddress.Visible = (((Agencies)agenciesBindingSource.Current).Address == null));
        }

        private void addAddress_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if ( ((Agencies)agenciesBindingSource.Current).Id > 0)
            {
                Addresses newAddress = new Addresses();
                //{
                //    Street1 = "535 Bourke Street",
                //    Suburb = "Melbourne",
                //    StateID = StateName.Victoria,
                //    Postcode = "3000"
                //};
                
                ((Agencies)agenciesBindingSource.Current).Address = newAddress;
                agenciesBindingSource.ResetBindings(false);

                addressGroupbox.Visible = !(addAddress.Visible = false);
            }
            else
            {
                MessageBox.Show("You must save the Agency record first");
            }
        }
    }
}
