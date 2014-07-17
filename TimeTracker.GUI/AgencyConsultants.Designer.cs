namespace TimeTracker.GUI
{
    partial class AgencyConsultants
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgencyConsultants));
            this.agenciesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.agenciesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.nameLabel1 = new System.Windows.Forms.Label();
            this.consultantsDataGridView = new System.Windows.Forms.DataGridView();
            this.agenciesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trackerDataSet = new TimeTracker.GUI.TrackerDataSet();
            this.agenciesTableAdapter = new TimeTracker.GUI.TrackerDataSetTableAdapters.AgenciesTableAdapter();
            this.tableAdapterManager = new TimeTracker.GUI.TrackerDataSetTableAdapters.TableAdapterManager();
            this.consultantsTableAdapter = new TimeTracker.GUI.TrackerDataSetTableAdapters.ConsultantsTableAdapter();
            this.consultantsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKAgenciesConsultantsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            nameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.agenciesBindingNavigator)).BeginInit();
            this.agenciesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.consultantsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agenciesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultantsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKAgenciesConsultantsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(12, 40);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(46, 13);
            nameLabel.TabIndex = 1;
            nameLabel.Text = "Agency:";
            // 
            // agenciesBindingNavigator
            // 
            this.agenciesBindingNavigator.AddNewItem = null;
            this.agenciesBindingNavigator.BindingSource = this.agenciesBindingSource;
            this.agenciesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.agenciesBindingNavigator.DeleteItem = null;
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
            this.agenciesBindingNavigatorSaveItem});
            this.agenciesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.agenciesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.agenciesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.agenciesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.agenciesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.agenciesBindingNavigator.Name = "agenciesBindingNavigator";
            this.agenciesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.agenciesBindingNavigator.Size = new System.Drawing.Size(739, 25);
            this.agenciesBindingNavigator.TabIndex = 0;
            this.agenciesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            this.agenciesBindingNavigatorSaveItem.Click += new System.EventHandler(this.agenciesBindingNavigatorSaveItem_Click_1);
            // 
            // nameLabel1
            // 
            this.nameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agenciesBindingSource, "Name", true));
            this.nameLabel1.Location = new System.Drawing.Point(64, 40);
            this.nameLabel1.Name = "nameLabel1";
            this.nameLabel1.Size = new System.Drawing.Size(100, 23);
            this.nameLabel1.TabIndex = 2;
            this.nameLabel1.Text = "label1";
            // 
            // consultantsDataGridView
            // 
            this.consultantsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.consultantsDataGridView.AutoGenerateColumns = false;
            this.consultantsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.consultantsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.consultantsDataGridView.DataSource = this.fKAgenciesConsultantsBindingSource;
            this.consultantsDataGridView.Location = new System.Drawing.Point(12, 66);
            this.consultantsDataGridView.Name = "consultantsDataGridView";
            this.consultantsDataGridView.Size = new System.Drawing.Size(715, 202);
            this.consultantsDataGridView.TabIndex = 3;
            // 
            // agenciesBindingSource
            // 
            this.agenciesBindingSource.DataMember = "Agencies";
            this.agenciesBindingSource.DataSource = this.trackerDataSet;
            // 
            // trackerDataSet
            // 
            this.trackerDataSet.DataSetName = "TrackerDataSet";
            this.trackerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // agenciesTableAdapter
            // 
            this.agenciesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AddressesTableAdapter = null;
            this.tableAdapterManager.AgenciesTableAdapter = this.agenciesTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CompaniesTableAdapter = null;
            this.tableAdapterManager.ConsultantsTableAdapter = this.consultantsTableAdapter;
            this.tableAdapterManager.EngagementsTableAdapter = null;
            this.tableAdapterManager.LogsTableAdapter = null;
            this.tableAdapterManager.PeopleTableAdapter = null;
            this.tableAdapterManager.ProjectsTableAdapter = null;
            this.tableAdapterManager.TasksTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TimeTracker.GUI.TrackerDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // consultantsTableAdapter
            // 
            this.consultantsTableAdapter.ClearBeforeFill = true;
            // 
            // consultantsBindingSource
            // 
            this.consultantsBindingSource.DataMember = "Consultants";
            this.consultantsBindingSource.DataSource = this.trackerDataSet;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FirstName";
            this.dataGridViewTextBoxColumn2.HeaderText = "FirstName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "LastName";
            this.dataGridViewTextBoxColumn3.HeaderText = "LastName";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "PhoneNumber";
            this.dataGridViewTextBoxColumn4.HeaderText = "PhoneNumber";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn5.HeaderText = "Email";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 300;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "AgenciesId";
            this.dataGridViewTextBoxColumn6.HeaderText = "AgenciesId";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // fKAgenciesConsultantsBindingSource
            // 
            this.fKAgenciesConsultantsBindingSource.DataMember = "FK_AgenciesConsultants";
            this.fKAgenciesConsultantsBindingSource.DataSource = this.agenciesBindingSource;
            // 
            // AgencyConsultants
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 280);
            this.Controls.Add(this.consultantsDataGridView);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameLabel1);
            this.Controls.Add(this.agenciesBindingNavigator);
            this.Name = "AgencyConsultants";
            this.Text = "Agency Consultants";
            this.Load += new System.EventHandler(this.AgencyConsultants_Load);
            ((System.ComponentModel.ISupportInitialize)(this.agenciesBindingNavigator)).EndInit();
            this.agenciesBindingNavigator.ResumeLayout(false);
            this.agenciesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.consultantsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agenciesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultantsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKAgenciesConsultantsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TrackerDataSet trackerDataSet;
        private System.Windows.Forms.BindingSource agenciesBindingSource;
        private TrackerDataSetTableAdapters.AgenciesTableAdapter agenciesTableAdapter;
        private TrackerDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator agenciesBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton agenciesBindingNavigatorSaveItem;
        private System.Windows.Forms.Label nameLabel1;
        private TrackerDataSetTableAdapters.ConsultantsTableAdapter consultantsTableAdapter;
        private System.Windows.Forms.BindingSource consultantsBindingSource;
        private System.Windows.Forms.DataGridView consultantsDataGridView;
        private System.Windows.Forms.BindingSource fKAgenciesConsultantsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;




    }
}