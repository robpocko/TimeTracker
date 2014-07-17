namespace TimeTracker.GUI
{
    partial class CompanyView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label stateIDLabel1;
            System.Windows.Forms.Label suburbLabel;
            System.Windows.Forms.Label postcodeLabel;
            System.Windows.Forms.Label street3Label;
            System.Windows.Forms.Label street1Label;
            System.Windows.Forms.Label street2Label;
            System.Windows.Forms.Label nameLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompanyView));
            this.addAddress = new System.Windows.Forms.LinkLabel();
            this.addressGroupbox = new System.Windows.Forms.GroupBox();
            this.street1TextBox = new System.Windows.Forms.TextBox();
            this.suburbTextBox = new System.Windows.Forms.TextBox();
            this.stateIDComboBox = new System.Windows.Forms.ComboBox();
            this.street3TextBox = new System.Windows.Forms.TextBox();
            this.postcodeTextBox = new System.Windows.Forms.TextBox();
            this.street2TextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.companiesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.agenciesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.companiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            stateIDLabel1 = new System.Windows.Forms.Label();
            suburbLabel = new System.Windows.Forms.Label();
            postcodeLabel = new System.Windows.Forms.Label();
            street3Label = new System.Windows.Forms.Label();
            street1Label = new System.Windows.Forms.Label();
            street2Label = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            this.addressGroupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.companiesBindingNavigator)).BeginInit();
            this.companiesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.companiesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // stateIDLabel1
            // 
            stateIDLabel1.AutoSize = true;
            stateIDLabel1.Location = new System.Drawing.Point(24, 126);
            stateIDLabel1.Name = "stateIDLabel1";
            stateIDLabel1.Size = new System.Drawing.Size(35, 13);
            stateIDLabel1.TabIndex = 19;
            stateIDLabel1.Text = "State:";
            // 
            // suburbLabel
            // 
            suburbLabel.AutoSize = true;
            suburbLabel.Location = new System.Drawing.Point(24, 100);
            suburbLabel.Name = "suburbLabel";
            suburbLabel.Size = new System.Drawing.Size(44, 13);
            suburbLabel.TabIndex = 17;
            suburbLabel.Text = "Suburb:";
            // 
            // postcodeLabel
            // 
            postcodeLabel.AutoSize = true;
            postcodeLabel.Location = new System.Drawing.Point(24, 153);
            postcodeLabel.Name = "postcodeLabel";
            postcodeLabel.Size = new System.Drawing.Size(55, 13);
            postcodeLabel.TabIndex = 7;
            postcodeLabel.Text = "Postcode:";
            // 
            // street3Label
            // 
            street3Label.AutoSize = true;
            street3Label.Location = new System.Drawing.Point(24, 74);
            street3Label.Name = "street3Label";
            street3Label.Size = new System.Drawing.Size(44, 13);
            street3Label.TabIndex = 15;
            street3Label.Text = "Street3:";
            // 
            // street1Label
            // 
            street1Label.AutoSize = true;
            street1Label.Location = new System.Drawing.Point(24, 22);
            street1Label.Name = "street1Label";
            street1Label.Size = new System.Drawing.Size(44, 13);
            street1Label.TabIndex = 11;
            street1Label.Text = "Street1:";
            // 
            // street2Label
            // 
            street2Label.AutoSize = true;
            street2Label.Location = new System.Drawing.Point(24, 48);
            street2Label.Name = "street2Label";
            street2Label.Size = new System.Drawing.Size(44, 13);
            street2Label.TabIndex = 13;
            street2Label.Text = "Street2:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(13, 40);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 23;
            nameLabel.Text = "Name:";
            // 
            // addAddress
            // 
            this.addAddress.AutoSize = true;
            this.addAddress.Location = new System.Drawing.Point(324, 66);
            this.addAddress.Name = "addAddress";
            this.addAddress.Size = new System.Drawing.Size(67, 13);
            this.addAddress.TabIndex = 28;
            this.addAddress.TabStop = true;
            this.addAddress.Text = "Add Address";
            this.addAddress.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.addAddress_LinkClicked);
            // 
            // addressGroupbox
            // 
            this.addressGroupbox.Controls.Add(this.street1TextBox);
            this.addressGroupbox.Controls.Add(stateIDLabel1);
            this.addressGroupbox.Controls.Add(this.suburbTextBox);
            this.addressGroupbox.Controls.Add(this.stateIDComboBox);
            this.addressGroupbox.Controls.Add(suburbLabel);
            this.addressGroupbox.Controls.Add(postcodeLabel);
            this.addressGroupbox.Controls.Add(this.street3TextBox);
            this.addressGroupbox.Controls.Add(this.postcodeTextBox);
            this.addressGroupbox.Controls.Add(street3Label);
            this.addressGroupbox.Controls.Add(street1Label);
            this.addressGroupbox.Controls.Add(this.street2TextBox);
            this.addressGroupbox.Controls.Add(street2Label);
            this.addressGroupbox.Location = new System.Drawing.Point(16, 98);
            this.addressGroupbox.Name = "addressGroupbox";
            this.addressGroupbox.Size = new System.Drawing.Size(390, 180);
            this.addressGroupbox.TabIndex = 27;
            this.addressGroupbox.TabStop = false;
            this.addressGroupbox.Text = "Address";
            // 
            // street1TextBox
            // 
            this.street1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.companiesBindingSource, "Address.Street1", true));
            this.street1TextBox.Location = new System.Drawing.Point(84, 19);
            this.street1TextBox.Name = "street1TextBox";
            this.street1TextBox.Size = new System.Drawing.Size(291, 20);
            this.street1TextBox.TabIndex = 12;
            // 
            // suburbTextBox
            // 
            this.suburbTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.companiesBindingSource, "Address.Suburb", true));
            this.suburbTextBox.Location = new System.Drawing.Point(84, 97);
            this.suburbTextBox.Name = "suburbTextBox";
            this.suburbTextBox.Size = new System.Drawing.Size(171, 20);
            this.suburbTextBox.TabIndex = 18;
            // 
            // stateIDComboBox
            // 
            this.stateIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.companiesBindingSource, "Address.StateID", true));
            this.stateIDComboBox.FormattingEnabled = true;
            this.stateIDComboBox.Location = new System.Drawing.Point(84, 123);
            this.stateIDComboBox.Name = "stateIDComboBox";
            this.stateIDComboBox.Size = new System.Drawing.Size(113, 21);
            this.stateIDComboBox.TabIndex = 20;
            // 
            // street3TextBox
            // 
            this.street3TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.companiesBindingSource, "Address.Street3", true));
            this.street3TextBox.Location = new System.Drawing.Point(84, 71);
            this.street3TextBox.Name = "street3TextBox";
            this.street3TextBox.Size = new System.Drawing.Size(291, 20);
            this.street3TextBox.TabIndex = 16;
            // 
            // postcodeTextBox
            // 
            this.postcodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.companiesBindingSource, "Address.Postcode", true));
            this.postcodeTextBox.Location = new System.Drawing.Point(84, 150);
            this.postcodeTextBox.Name = "postcodeTextBox";
            this.postcodeTextBox.Size = new System.Drawing.Size(53, 20);
            this.postcodeTextBox.TabIndex = 8;
            // 
            // street2TextBox
            // 
            this.street2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.companiesBindingSource, "Address.Street2", true));
            this.street2TextBox.Location = new System.Drawing.Point(84, 45);
            this.street2TextBox.Name = "street2TextBox";
            this.street2TextBox.Size = new System.Drawing.Size(291, 20);
            this.street2TextBox.TabIndex = 14;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.companiesBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(100, 37);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(306, 20);
            this.nameTextBox.TabIndex = 24;
            // 
            // companiesBindingNavigator
            // 
            this.companiesBindingNavigator.AddNewItem = this.toolStripButton2;
            this.companiesBindingNavigator.BindingSource = this.companiesBindingSource;
            this.companiesBindingNavigator.CountItem = this.toolStripLabel1;
            this.companiesBindingNavigator.DeleteItem = this.toolStripButton3;
            this.companiesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton4,
            this.toolStripButton5,
            this.toolStripSeparator1,
            this.toolStripTextBox1,
            this.toolStripLabel1,
            this.toolStripSeparator2,
            this.toolStripButton6,
            this.toolStripButton7,
            this.toolStripSeparator3,
            this.toolStripButton2,
            this.toolStripButton3,
            this.agenciesBindingNavigatorSaveItem});
            this.companiesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.companiesBindingNavigator.MoveFirstItem = this.toolStripButton4;
            this.companiesBindingNavigator.MoveLastItem = this.toolStripButton7;
            this.companiesBindingNavigator.MoveNextItem = this.toolStripButton6;
            this.companiesBindingNavigator.MovePreviousItem = this.toolStripButton5;
            this.companiesBindingNavigator.Name = "companiesBindingNavigator";
            this.companiesBindingNavigator.PositionItem = this.toolStripTextBox1;
            this.companiesBindingNavigator.Size = new System.Drawing.Size(418, 25);
            this.companiesBindingNavigator.TabIndex = 30;
            this.companiesBindingNavigator.Text = "bindingNavigator1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.RightToLeftAutoMirrorImage = true;
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Add new";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel1.Text = "of {0}";
            this.toolStripLabel1.ToolTipText = "Total number of items";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.RightToLeftAutoMirrorImage = true;
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "Delete";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.RightToLeftAutoMirrorImage = true;
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "Move first";
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.RightToLeftAutoMirrorImage = true;
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "Move previous";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AccessibleName = "Position";
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(50, 23);
            this.toolStripTextBox1.Text = "0";
            this.toolStripTextBox1.ToolTipText = "Current position";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.RightToLeftAutoMirrorImage = true;
            this.toolStripButton6.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton6.Text = "Move next";
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.RightToLeftAutoMirrorImage = true;
            this.toolStripButton7.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton7.Text = "Move last";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // agenciesBindingNavigatorSaveItem
            // 
            this.agenciesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.agenciesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("agenciesBindingNavigatorSaveItem.Image")));
            this.agenciesBindingNavigatorSaveItem.Name = "agenciesBindingNavigatorSaveItem";
            this.agenciesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.agenciesBindingNavigatorSaveItem.Text = "Save Data";
            this.agenciesBindingNavigatorSaveItem.Click += new System.EventHandler(this.agenciesBindingNavigatorSaveItem_Click);
            // 
            // companiesBindingSource
            // 
            this.companiesBindingSource.DataSource = typeof(TimeTracker.EF.Companies);
            this.companiesBindingSource.CurrentChanged += new System.EventHandler(this.companiesBindingSource_CurrentChanged);
            // 
            // CompanyView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 288);
            this.Controls.Add(this.companiesBindingNavigator);
            this.Controls.Add(this.addAddress);
            this.Controls.Add(this.addressGroupbox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Name = "CompanyView";
            this.Text = "Company View";
            this.Load += new System.EventHandler(this.CompanyView_Load);
            this.addressGroupbox.ResumeLayout(false);
            this.addressGroupbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.companiesBindingNavigator)).EndInit();
            this.companiesBindingNavigator.ResumeLayout(false);
            this.companiesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.companiesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel addAddress;
        private System.Windows.Forms.GroupBox addressGroupbox;
        private System.Windows.Forms.TextBox street1TextBox;
        private System.Windows.Forms.TextBox suburbTextBox;
        private System.Windows.Forms.ComboBox stateIDComboBox;
        private System.Windows.Forms.TextBox street3TextBox;
        private System.Windows.Forms.TextBox postcodeTextBox;
        private System.Windows.Forms.TextBox street2TextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.BindingSource companiesBindingSource;
        private System.Windows.Forms.BindingNavigator companiesBindingNavigator;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton agenciesBindingNavigatorSaveItem;
    }
}