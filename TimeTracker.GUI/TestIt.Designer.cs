namespace TimeTracker.GUI
{
    partial class TestIt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestIt));
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label idLabel1;
            System.Windows.Forms.Label postcodeLabel;
            System.Windows.Forms.Label stateIDLabel;
            System.Windows.Forms.Label street1Label;
            System.Windows.Forms.Label street2Label;
            System.Windows.Forms.Label street3Label;
            System.Windows.Forms.Label suburbLabel;
            this.companiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.companiesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.companiesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel1 = new System.Windows.Forms.Label();
            this.idTextBox1 = new System.Windows.Forms.TextBox();
            this.postcodeLabel1 = new System.Windows.Forms.Label();
            this.stateIDTextBox = new System.Windows.Forms.TextBox();
            this.street1Label1 = new System.Windows.Forms.Label();
            this.street2Label1 = new System.Windows.Forms.Label();
            this.street3Label1 = new System.Windows.Forms.Label();
            this.suburbLabel1 = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            idLabel1 = new System.Windows.Forms.Label();
            postcodeLabel = new System.Windows.Forms.Label();
            stateIDLabel = new System.Windows.Forms.Label();
            street1Label = new System.Windows.Forms.Label();
            street2Label = new System.Windows.Forms.Label();
            street3Label = new System.Windows.Forms.Label();
            suburbLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.companiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companiesBindingNavigator)).BeginInit();
            this.companiesBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // companiesBindingSource
            // 
            this.companiesBindingSource.DataSource = typeof(TimeTracker.EF.Companies);
            // 
            // companiesBindingNavigator
            // 
            this.companiesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.companiesBindingNavigator.BindingSource = this.companiesBindingSource;
            this.companiesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.companiesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.companiesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.companiesBindingNavigatorSaveItem});
            this.companiesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.companiesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.companiesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.companiesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.companiesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.companiesBindingNavigator.Name = "companiesBindingNavigator";
            this.companiesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.companiesBindingNavigator.Size = new System.Drawing.Size(737, 25);
            this.companiesBindingNavigator.TabIndex = 0;
            this.companiesBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // companiesBindingNavigatorSaveItem
            // 
            this.companiesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.companiesBindingNavigatorSaveItem.Enabled = false;
            this.companiesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("companiesBindingNavigatorSaveItem.Image")));
            this.companiesBindingNavigatorSaveItem.Name = "companiesBindingNavigatorSaveItem";
            this.companiesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.companiesBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(84, 48);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 1;
            idLabel.Text = "Id:";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.companiesBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(128, 45);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 2;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(84, 68);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Name:";
            // 
            // nameLabel1
            // 
            this.nameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.companiesBindingSource, "Name", true));
            this.nameLabel1.Location = new System.Drawing.Point(128, 68);
            this.nameLabel1.Name = "nameLabel1";
            this.nameLabel1.Size = new System.Drawing.Size(100, 23);
            this.nameLabel1.TabIndex = 4;
            this.nameLabel1.Text = "label1";
            // 
            // idLabel1
            // 
            idLabel1.AutoSize = true;
            idLabel1.Location = new System.Drawing.Point(84, 134);
            idLabel1.Name = "idLabel1";
            idLabel1.Size = new System.Drawing.Size(19, 13);
            idLabel1.TabIndex = 5;
            idLabel1.Text = "Id:";
            // 
            // idTextBox1
            // 
            this.idTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.companiesBindingSource, "Address.Id", true));
            this.idTextBox1.Location = new System.Drawing.Point(145, 131);
            this.idTextBox1.Name = "idTextBox1";
            this.idTextBox1.Size = new System.Drawing.Size(100, 20);
            this.idTextBox1.TabIndex = 6;
            // 
            // postcodeLabel
            // 
            postcodeLabel.AutoSize = true;
            postcodeLabel.Location = new System.Drawing.Point(84, 154);
            postcodeLabel.Name = "postcodeLabel";
            postcodeLabel.Size = new System.Drawing.Size(55, 13);
            postcodeLabel.TabIndex = 7;
            postcodeLabel.Text = "Postcode:";
            // 
            // postcodeLabel1
            // 
            this.postcodeLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.companiesBindingSource, "Address.Postcode", true));
            this.postcodeLabel1.Location = new System.Drawing.Point(145, 154);
            this.postcodeLabel1.Name = "postcodeLabel1";
            this.postcodeLabel1.Size = new System.Drawing.Size(100, 23);
            this.postcodeLabel1.TabIndex = 8;
            this.postcodeLabel1.Text = "label1";
            // 
            // stateIDLabel
            // 
            stateIDLabel.AutoSize = true;
            stateIDLabel.Location = new System.Drawing.Point(84, 183);
            stateIDLabel.Name = "stateIDLabel";
            stateIDLabel.Size = new System.Drawing.Size(49, 13);
            stateIDLabel.TabIndex = 9;
            stateIDLabel.Text = "State ID:";
            // 
            // stateIDTextBox
            // 
            this.stateIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.companiesBindingSource, "Address.StateID", true));
            this.stateIDTextBox.Location = new System.Drawing.Point(145, 180);
            this.stateIDTextBox.Name = "stateIDTextBox";
            this.stateIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.stateIDTextBox.TabIndex = 10;
            // 
            // street1Label
            // 
            street1Label.AutoSize = true;
            street1Label.Location = new System.Drawing.Point(84, 203);
            street1Label.Name = "street1Label";
            street1Label.Size = new System.Drawing.Size(44, 13);
            street1Label.TabIndex = 11;
            street1Label.Text = "Street1:";
            // 
            // street1Label1
            // 
            this.street1Label1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.companiesBindingSource, "Address.Street1", true));
            this.street1Label1.Location = new System.Drawing.Point(145, 203);
            this.street1Label1.Name = "street1Label1";
            this.street1Label1.Size = new System.Drawing.Size(100, 23);
            this.street1Label1.TabIndex = 12;
            this.street1Label1.Text = "label1";
            // 
            // street2Label
            // 
            street2Label.AutoSize = true;
            street2Label.Location = new System.Drawing.Point(84, 226);
            street2Label.Name = "street2Label";
            street2Label.Size = new System.Drawing.Size(44, 13);
            street2Label.TabIndex = 13;
            street2Label.Text = "Street2:";
            // 
            // street2Label1
            // 
            this.street2Label1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.companiesBindingSource, "Address.Street2", true));
            this.street2Label1.Location = new System.Drawing.Point(145, 226);
            this.street2Label1.Name = "street2Label1";
            this.street2Label1.Size = new System.Drawing.Size(100, 23);
            this.street2Label1.TabIndex = 14;
            this.street2Label1.Text = "label1";
            // 
            // street3Label
            // 
            street3Label.AutoSize = true;
            street3Label.Location = new System.Drawing.Point(84, 249);
            street3Label.Name = "street3Label";
            street3Label.Size = new System.Drawing.Size(44, 13);
            street3Label.TabIndex = 15;
            street3Label.Text = "Street3:";
            // 
            // street3Label1
            // 
            this.street3Label1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.companiesBindingSource, "Address.Street3", true));
            this.street3Label1.Location = new System.Drawing.Point(145, 249);
            this.street3Label1.Name = "street3Label1";
            this.street3Label1.Size = new System.Drawing.Size(100, 23);
            this.street3Label1.TabIndex = 16;
            this.street3Label1.Text = "label1";
            // 
            // suburbLabel
            // 
            suburbLabel.AutoSize = true;
            suburbLabel.Location = new System.Drawing.Point(84, 272);
            suburbLabel.Name = "suburbLabel";
            suburbLabel.Size = new System.Drawing.Size(44, 13);
            suburbLabel.TabIndex = 17;
            suburbLabel.Text = "Suburb:";
            // 
            // suburbLabel1
            // 
            this.suburbLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.companiesBindingSource, "Address.Suburb", true));
            this.suburbLabel1.Location = new System.Drawing.Point(145, 272);
            this.suburbLabel1.Name = "suburbLabel1";
            this.suburbLabel1.Size = new System.Drawing.Size(100, 23);
            this.suburbLabel1.TabIndex = 18;
            this.suburbLabel1.Text = "label1";
            // 
            // TestIt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(737, 315);
            this.Controls.Add(idLabel1);
            this.Controls.Add(this.idTextBox1);
            this.Controls.Add(postcodeLabel);
            this.Controls.Add(this.postcodeLabel1);
            this.Controls.Add(stateIDLabel);
            this.Controls.Add(this.stateIDTextBox);
            this.Controls.Add(street1Label);
            this.Controls.Add(this.street1Label1);
            this.Controls.Add(street2Label);
            this.Controls.Add(this.street2Label1);
            this.Controls.Add(street3Label);
            this.Controls.Add(this.street3Label1);
            this.Controls.Add(suburbLabel);
            this.Controls.Add(this.suburbLabel1);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameLabel1);
            this.Controls.Add(this.companiesBindingNavigator);
            this.Name = "TestIt";
            this.Text = "TestIt";
            this.Load += new System.EventHandler(this.TestIt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.companiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companiesBindingNavigator)).EndInit();
            this.companiesBindingNavigator.ResumeLayout(false);
            this.companiesBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource companiesBindingSource;
        private System.Windows.Forms.BindingNavigator companiesBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton companiesBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label nameLabel1;
        private System.Windows.Forms.TextBox idTextBox1;
        private System.Windows.Forms.Label postcodeLabel1;
        private System.Windows.Forms.TextBox stateIDTextBox;
        private System.Windows.Forms.Label street1Label1;
        private System.Windows.Forms.Label street2Label1;
        private System.Windows.Forms.Label street3Label1;
        private System.Windows.Forms.Label suburbLabel1;



    }
}