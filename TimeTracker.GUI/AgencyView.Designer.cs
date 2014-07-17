namespace TimeTracker.GUI
{
    partial class AgencyView
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
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label phoneNumberLabel;
            System.Windows.Forms.Label postcodeLabel;
            System.Windows.Forms.Label street1Label;
            System.Windows.Forms.Label street2Label;
            System.Windows.Forms.Label street3Label;
            System.Windows.Forms.Label suburbLabel;
            System.Windows.Forms.Label stateIDLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgencyView));
            this.agenciesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.agenciesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.postcodeTextBox = new System.Windows.Forms.TextBox();
            this.street1TextBox = new System.Windows.Forms.TextBox();
            this.street2TextBox = new System.Windows.Forms.TextBox();
            this.street3TextBox = new System.Windows.Forms.TextBox();
            this.suburbTextBox = new System.Windows.Forms.TextBox();
            this.stateIDComboBox = new System.Windows.Forms.ComboBox();
            this.addressGroupbox = new System.Windows.Forms.GroupBox();
            this.addAddress = new System.Windows.Forms.LinkLabel();
            this.agenciesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            nameLabel = new System.Windows.Forms.Label();
            phoneNumberLabel = new System.Windows.Forms.Label();
            postcodeLabel = new System.Windows.Forms.Label();
            street1Label = new System.Windows.Forms.Label();
            street2Label = new System.Windows.Forms.Label();
            street3Label = new System.Windows.Forms.Label();
            suburbLabel = new System.Windows.Forms.Label();
            stateIDLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.agenciesBindingNavigator)).BeginInit();
            this.agenciesBindingNavigator.SuspendLayout();
            this.addressGroupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.agenciesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(13, 40);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 1;
            nameLabel.Text = "Name:";
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Location = new System.Drawing.Point(13, 66);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new System.Drawing.Size(81, 13);
            phoneNumberLabel.TabIndex = 3;
            phoneNumberLabel.Text = "Phone Number:";
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
            // street3Label
            // 
            street3Label.AutoSize = true;
            street3Label.Location = new System.Drawing.Point(24, 74);
            street3Label.Name = "street3Label";
            street3Label.Size = new System.Drawing.Size(44, 13);
            street3Label.TabIndex = 15;
            street3Label.Text = "Street3:";
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
            // stateIDLabel1
            // 
            stateIDLabel1.AutoSize = true;
            stateIDLabel1.Location = new System.Drawing.Point(24, 126);
            stateIDLabel1.Name = "stateIDLabel1";
            stateIDLabel1.Size = new System.Drawing.Size(35, 13);
            stateIDLabel1.TabIndex = 19;
            stateIDLabel1.Text = "State:";
            // 
            // agenciesBindingNavigator
            // 
            this.agenciesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.agenciesBindingNavigator.BindingSource = this.agenciesBindingSource;
            this.agenciesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.agenciesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.agenciesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.agenciesBindingNavigatorSaveItem});
            this.agenciesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.agenciesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.agenciesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.agenciesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.agenciesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.agenciesBindingNavigator.Name = "agenciesBindingNavigator";
            this.agenciesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.agenciesBindingNavigator.Size = new System.Drawing.Size(418, 25);
            this.agenciesBindingNavigator.TabIndex = 0;
            this.agenciesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
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
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agenciesBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(100, 37);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(306, 20);
            this.nameTextBox.TabIndex = 2;
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agenciesBindingSource, "PhoneNumber", true));
            this.phoneNumberTextBox.Location = new System.Drawing.Point(100, 63);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(113, 20);
            this.phoneNumberTextBox.TabIndex = 4;
            // 
            // postcodeTextBox
            // 
            this.postcodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agenciesBindingSource, "Address.Postcode", true));
            this.postcodeTextBox.Location = new System.Drawing.Point(84, 150);
            this.postcodeTextBox.Name = "postcodeTextBox";
            this.postcodeTextBox.Size = new System.Drawing.Size(53, 20);
            this.postcodeTextBox.TabIndex = 8;
            // 
            // street1TextBox
            // 
            this.street1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agenciesBindingSource, "Address.Street1", true));
            this.street1TextBox.Location = new System.Drawing.Point(84, 19);
            this.street1TextBox.Name = "street1TextBox";
            this.street1TextBox.Size = new System.Drawing.Size(291, 20);
            this.street1TextBox.TabIndex = 12;
            // 
            // street2TextBox
            // 
            this.street2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agenciesBindingSource, "Address.Street2", true));
            this.street2TextBox.Location = new System.Drawing.Point(84, 45);
            this.street2TextBox.Name = "street2TextBox";
            this.street2TextBox.Size = new System.Drawing.Size(291, 20);
            this.street2TextBox.TabIndex = 14;
            // 
            // street3TextBox
            // 
            this.street3TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agenciesBindingSource, "Address.Street3", true));
            this.street3TextBox.Location = new System.Drawing.Point(84, 71);
            this.street3TextBox.Name = "street3TextBox";
            this.street3TextBox.Size = new System.Drawing.Size(291, 20);
            this.street3TextBox.TabIndex = 16;
            // 
            // suburbTextBox
            // 
            this.suburbTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agenciesBindingSource, "Address.Suburb", true));
            this.suburbTextBox.Location = new System.Drawing.Point(84, 97);
            this.suburbTextBox.Name = "suburbTextBox";
            this.suburbTextBox.Size = new System.Drawing.Size(171, 20);
            this.suburbTextBox.TabIndex = 18;
            // 
            // stateIDComboBox
            // 
            this.stateIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agenciesBindingSource, "Address.StateID", true));
            this.stateIDComboBox.FormattingEnabled = true;
            this.stateIDComboBox.Location = new System.Drawing.Point(84, 123);
            this.stateIDComboBox.Name = "stateIDComboBox";
            this.stateIDComboBox.Size = new System.Drawing.Size(113, 21);
            this.stateIDComboBox.TabIndex = 20;
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
            this.addressGroupbox.TabIndex = 21;
            this.addressGroupbox.TabStop = false;
            this.addressGroupbox.Text = "Address";
            // 
            // addAddress
            // 
            this.addAddress.AutoSize = true;
            this.addAddress.Location = new System.Drawing.Point(324, 66);
            this.addAddress.Name = "addAddress";
            this.addAddress.Size = new System.Drawing.Size(67, 13);
            this.addAddress.TabIndex = 22;
            this.addAddress.TabStop = true;
            this.addAddress.Text = "Add Address";
            this.addAddress.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.addAddress_LinkClicked);
            // 
            // agenciesBindingSource
            // 
            this.agenciesBindingSource.DataSource = typeof(TimeTracker.EF.Agencies);
            this.agenciesBindingSource.CurrentChanged += new System.EventHandler(this.agenciesBindingSource_CurrentChanged);
            // 
            // AgencyView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 288);
            this.Controls.Add(this.addAddress);
            this.Controls.Add(this.addressGroupbox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(phoneNumberLabel);
            this.Controls.Add(this.phoneNumberTextBox);
            this.Controls.Add(this.agenciesBindingNavigator);
            this.Name = "AgencyView";
            this.Text = "Agency View";
            this.Load += new System.EventHandler(this.AgencyView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.agenciesBindingNavigator)).EndInit();
            this.agenciesBindingNavigator.ResumeLayout(false);
            this.agenciesBindingNavigator.PerformLayout();
            this.addressGroupbox.ResumeLayout(false);
            this.addressGroupbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.agenciesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource agenciesBindingSource;
        private System.Windows.Forms.BindingNavigator agenciesBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton agenciesBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.TextBox postcodeTextBox;
        private System.Windows.Forms.TextBox street1TextBox;
        private System.Windows.Forms.TextBox street2TextBox;
        private System.Windows.Forms.TextBox street3TextBox;
        private System.Windows.Forms.TextBox suburbTextBox;
        private System.Windows.Forms.ComboBox stateIDComboBox;
        private System.Windows.Forms.GroupBox addressGroupbox;
        private System.Windows.Forms.LinkLabel addAddress;
    }
}