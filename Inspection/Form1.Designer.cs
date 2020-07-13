namespace Inspection
{
    partial class Form1
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
            System.Windows.Forms.Label complaint_idLabel;
            System.Windows.Forms.Label complaint_customer_first_nameLabel;
            System.Windows.Forms.Label complaint_customer_last_nameLabel;
            System.Windows.Forms.Label complaint_adressLabel;
            System.Windows.Forms.Label complaint_cosesLabel;
            System.Windows.Forms.Label complaint_filing_dateLabel;
            System.Windows.Forms.Label complaint_deadline_dateLabel;
            System.Windows.Forms.Label complaint_ispector_idLabel;
            System.Windows.Forms.Label complaint_typeLabel;
            System.Windows.Forms.Label complaint_statusLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.inspectorDBDataSet = new Inspection.InspectorDBDataSet();
            this.complaintBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.complaintTableAdapter = new Inspection.InspectorDBDataSetTableAdapters.ComplaintTableAdapter();
            this.tableAdapterManager = new Inspection.InspectorDBDataSetTableAdapters.TableAdapterManager();
            this.inspectionTableAdapter = new Inspection.InspectorDBDataSetTableAdapters.InspectionTableAdapter();
            this.complaintBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.complaintBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.complaintDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inspectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inspectionDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.complaint_idTextBox = new System.Windows.Forms.TextBox();
            this.complaint_customer_first_nameTextBox = new System.Windows.Forms.TextBox();
            this.complaint_customer_last_nameTextBox = new System.Windows.Forms.TextBox();
            this.complaint_adressTextBox = new System.Windows.Forms.TextBox();
            this.complaint_cosesTextBox = new System.Windows.Forms.TextBox();
            this.complaint_filing_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.complaint_deadline_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.complaint_ispector_idTextBox = new System.Windows.Forms.TextBox();
            this.complaint_typeTextBox = new System.Windows.Forms.TextBox();
            this.complaint_statusTextBox = new System.Windows.Forms.TextBox();
            this.scanbutton = new System.Windows.Forms.Button();
            this.openscan = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.vievcomplaintbutton = new System.Windows.Forms.Button();
            complaint_idLabel = new System.Windows.Forms.Label();
            complaint_customer_first_nameLabel = new System.Windows.Forms.Label();
            complaint_customer_last_nameLabel = new System.Windows.Forms.Label();
            complaint_adressLabel = new System.Windows.Forms.Label();
            complaint_cosesLabel = new System.Windows.Forms.Label();
            complaint_filing_dateLabel = new System.Windows.Forms.Label();
            complaint_deadline_dateLabel = new System.Windows.Forms.Label();
            complaint_ispector_idLabel = new System.Windows.Forms.Label();
            complaint_typeLabel = new System.Windows.Forms.Label();
            complaint_statusLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.inspectorDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.complaintBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.complaintBindingNavigator)).BeginInit();
            this.complaintBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.complaintDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // complaint_idLabel
            // 
            complaint_idLabel.AutoSize = true;
            complaint_idLabel.Location = new System.Drawing.Point(831, 216);
            complaint_idLabel.Name = "complaint_idLabel";
            complaint_idLabel.Size = new System.Drawing.Size(66, 13);
            complaint_idLabel.TabIndex = 3;
            complaint_idLabel.Text = "complaint id:";
            // 
            // complaint_customer_first_nameLabel
            // 
            complaint_customer_first_nameLabel.AutoSize = true;
            complaint_customer_first_nameLabel.Location = new System.Drawing.Point(831, 242);
            complaint_customer_first_nameLabel.Name = "complaint_customer_first_nameLabel";
            complaint_customer_first_nameLabel.Size = new System.Drawing.Size(149, 13);
            complaint_customer_first_nameLabel.TabIndex = 5;
            complaint_customer_first_nameLabel.Text = "complaint customer first name:";
            // 
            // complaint_customer_last_nameLabel
            // 
            complaint_customer_last_nameLabel.AutoSize = true;
            complaint_customer_last_nameLabel.Location = new System.Drawing.Point(831, 268);
            complaint_customer_last_nameLabel.Name = "complaint_customer_last_nameLabel";
            complaint_customer_last_nameLabel.Size = new System.Drawing.Size(149, 13);
            complaint_customer_last_nameLabel.TabIndex = 7;
            complaint_customer_last_nameLabel.Text = "complaint customer last name:";
            // 
            // complaint_adressLabel
            // 
            complaint_adressLabel.AutoSize = true;
            complaint_adressLabel.Location = new System.Drawing.Point(831, 294);
            complaint_adressLabel.Name = "complaint_adressLabel";
            complaint_adressLabel.Size = new System.Drawing.Size(89, 13);
            complaint_adressLabel.TabIndex = 9;
            complaint_adressLabel.Text = "complaint adress:";
            // 
            // complaint_cosesLabel
            // 
            complaint_cosesLabel.AutoSize = true;
            complaint_cosesLabel.Location = new System.Drawing.Point(831, 320);
            complaint_cosesLabel.Name = "complaint_cosesLabel";
            complaint_cosesLabel.Size = new System.Drawing.Size(86, 13);
            complaint_cosesLabel.TabIndex = 11;
            complaint_cosesLabel.Text = "complaint coses:";
            // 
            // complaint_filing_dateLabel
            // 
            complaint_filing_dateLabel.AutoSize = true;
            complaint_filing_dateLabel.Location = new System.Drawing.Point(831, 347);
            complaint_filing_dateLabel.Name = "complaint_filing_dateLabel";
            complaint_filing_dateLabel.Size = new System.Drawing.Size(103, 13);
            complaint_filing_dateLabel.TabIndex = 13;
            complaint_filing_dateLabel.Text = "complaint filing date:";
            // 
            // complaint_deadline_dateLabel
            // 
            complaint_deadline_dateLabel.AutoSize = true;
            complaint_deadline_dateLabel.Location = new System.Drawing.Point(831, 373);
            complaint_deadline_dateLabel.Name = "complaint_deadline_dateLabel";
            complaint_deadline_dateLabel.Size = new System.Drawing.Size(122, 13);
            complaint_deadline_dateLabel.TabIndex = 15;
            complaint_deadline_dateLabel.Text = "complaint deadline date:";
            // 
            // complaint_ispector_idLabel
            // 
            complaint_ispector_idLabel.AutoSize = true;
            complaint_ispector_idLabel.Location = new System.Drawing.Point(831, 398);
            complaint_ispector_idLabel.Name = "complaint_ispector_idLabel";
            complaint_ispector_idLabel.Size = new System.Drawing.Size(106, 13);
            complaint_ispector_idLabel.TabIndex = 17;
            complaint_ispector_idLabel.Text = "complaint ispector id:";
            // 
            // complaint_typeLabel
            // 
            complaint_typeLabel.AutoSize = true;
            complaint_typeLabel.Location = new System.Drawing.Point(831, 424);
            complaint_typeLabel.Name = "complaint_typeLabel";
            complaint_typeLabel.Size = new System.Drawing.Size(78, 13);
            complaint_typeLabel.TabIndex = 19;
            complaint_typeLabel.Text = "complaint type:";
            // 
            // complaint_statusLabel
            // 
            complaint_statusLabel.AutoSize = true;
            complaint_statusLabel.Location = new System.Drawing.Point(831, 450);
            complaint_statusLabel.Name = "complaint_statusLabel";
            complaint_statusLabel.Size = new System.Drawing.Size(86, 13);
            complaint_statusLabel.TabIndex = 21;
            complaint_statusLabel.Text = "complaint status:";
            // 
            // inspectorDBDataSet
            // 
            this.inspectorDBDataSet.DataSetName = "InspectorDBDataSet";
            this.inspectorDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // complaintBindingSource
            // 
            this.complaintBindingSource.DataMember = "Complaint";
            this.complaintBindingSource.DataSource = this.inspectorDBDataSet;
            // 
            // complaintTableAdapter
            // 
            this.complaintTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ComplaintTableAdapter = this.complaintTableAdapter;
            this.tableAdapterManager.InspectionTableAdapter = this.inspectionTableAdapter;
            this.tableAdapterManager.UpdateOrder = Inspection.InspectorDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // inspectionTableAdapter
            // 
            this.inspectionTableAdapter.ClearBeforeFill = true;
            // 
            // complaintBindingNavigator
            // 
            this.complaintBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.complaintBindingNavigator.BindingSource = this.complaintBindingSource;
            this.complaintBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.complaintBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.complaintBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.complaintBindingNavigatorSaveItem});
            this.complaintBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.complaintBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.complaintBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.complaintBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.complaintBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.complaintBindingNavigator.Name = "complaintBindingNavigator";
            this.complaintBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.complaintBindingNavigator.Size = new System.Drawing.Size(1218, 25);
            this.complaintBindingNavigator.TabIndex = 0;
            this.complaintBindingNavigator.Text = "bindingNavigator1";
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
            // complaintBindingNavigatorSaveItem
            // 
            this.complaintBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.complaintBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("complaintBindingNavigatorSaveItem.Image")));
            this.complaintBindingNavigatorSaveItem.Name = "complaintBindingNavigatorSaveItem";
            this.complaintBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.complaintBindingNavigatorSaveItem.Text = "Save Data";
            this.complaintBindingNavigatorSaveItem.Click += new System.EventHandler(this.complaintBindingNavigatorSaveItem_Click);
            // 
            // complaintDataGridView
            // 
            this.complaintDataGridView.AutoGenerateColumns = false;
            this.complaintDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.complaintDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewImageColumn1,
            this.dataGridViewTextBoxColumn10});
            this.complaintDataGridView.DataSource = this.complaintBindingSource;
            this.complaintDataGridView.Location = new System.Drawing.Point(0, 28);
            this.complaintDataGridView.Name = "complaintDataGridView";
            this.complaintDataGridView.Size = new System.Drawing.Size(1146, 154);
            this.complaintDataGridView.TabIndex = 1;
            this.complaintDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.complaintDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "complaint_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "complaint_id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "complaint_customer_first_name";
            this.dataGridViewTextBoxColumn2.HeaderText = "complaint_customer_first_name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "complaint_customer_last_name";
            this.dataGridViewTextBoxColumn3.HeaderText = "complaint_customer_last_name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "complaint_adress";
            this.dataGridViewTextBoxColumn4.HeaderText = "complaint_adress";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "complaint_coses";
            this.dataGridViewTextBoxColumn5.HeaderText = "complaint_coses";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "complaint_filing_date";
            this.dataGridViewTextBoxColumn6.HeaderText = "complaint_filing_date";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "complaint_deadline_date";
            this.dataGridViewTextBoxColumn7.HeaderText = "complaint_deadline_date";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "complaint_ispector_id";
            this.dataGridViewTextBoxColumn8.HeaderText = "complaint_ispector_id";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "complaint_type";
            this.dataGridViewTextBoxColumn9.HeaderText = "complaint_type";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "complaint_scan";
            this.dataGridViewImageColumn1.HeaderText = "complaint_scan";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "complaint_status";
            this.dataGridViewTextBoxColumn10.HeaderText = "complaint_status";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // inspectionBindingSource
            // 
            this.inspectionBindingSource.DataMember = "FK_Inspection_ToComplaint";
            this.inspectionBindingSource.DataSource = this.complaintBindingSource;
            // 
            // inspectionDataGridView
            // 
            this.inspectionDataGridView.AutoGenerateColumns = false;
            this.inspectionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inspectionDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14});
            this.inspectionDataGridView.DataSource = this.inspectionBindingSource;
            this.inspectionDataGridView.Location = new System.Drawing.Point(0, 205);
            this.inspectionDataGridView.Name = "inspectionDataGridView";
            this.inspectionDataGridView.Size = new System.Drawing.Size(817, 54);
            this.inspectionDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "act_id";
            this.dataGridViewTextBoxColumn11.HeaderText = "act_id";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "complaint_id";
            this.dataGridViewTextBoxColumn12.HeaderText = "complaint_id";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "inspection_derective";
            this.dataGridViewTextBoxColumn13.HeaderText = "inspection_derective";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "inspection_deadline";
            this.dataGridViewTextBoxColumn14.HeaderText = "inspection_deadline";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // complaint_idTextBox
            // 
            this.complaint_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.complaintBindingSource, "complaint_id", true));
            this.complaint_idTextBox.Location = new System.Drawing.Point(986, 213);
            this.complaint_idTextBox.Name = "complaint_idTextBox";
            this.complaint_idTextBox.Size = new System.Drawing.Size(200, 20);
            this.complaint_idTextBox.TabIndex = 4;
            // 
            // complaint_customer_first_nameTextBox
            // 
            this.complaint_customer_first_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.complaintBindingSource, "complaint_customer_first_name", true));
            this.complaint_customer_first_nameTextBox.Location = new System.Drawing.Point(986, 239);
            this.complaint_customer_first_nameTextBox.Name = "complaint_customer_first_nameTextBox";
            this.complaint_customer_first_nameTextBox.Size = new System.Drawing.Size(200, 20);
            this.complaint_customer_first_nameTextBox.TabIndex = 6;
            // 
            // complaint_customer_last_nameTextBox
            // 
            this.complaint_customer_last_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.complaintBindingSource, "complaint_customer_last_name", true));
            this.complaint_customer_last_nameTextBox.Location = new System.Drawing.Point(986, 265);
            this.complaint_customer_last_nameTextBox.Name = "complaint_customer_last_nameTextBox";
            this.complaint_customer_last_nameTextBox.Size = new System.Drawing.Size(200, 20);
            this.complaint_customer_last_nameTextBox.TabIndex = 8;
            // 
            // complaint_adressTextBox
            // 
            this.complaint_adressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.complaintBindingSource, "complaint_adress", true));
            this.complaint_adressTextBox.Location = new System.Drawing.Point(986, 291);
            this.complaint_adressTextBox.Name = "complaint_adressTextBox";
            this.complaint_adressTextBox.Size = new System.Drawing.Size(200, 20);
            this.complaint_adressTextBox.TabIndex = 10;
            // 
            // complaint_cosesTextBox
            // 
            this.complaint_cosesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.complaintBindingSource, "complaint_coses", true));
            this.complaint_cosesTextBox.Location = new System.Drawing.Point(986, 317);
            this.complaint_cosesTextBox.Name = "complaint_cosesTextBox";
            this.complaint_cosesTextBox.Size = new System.Drawing.Size(200, 20);
            this.complaint_cosesTextBox.TabIndex = 12;
            // 
            // complaint_filing_dateDateTimePicker
            // 
            this.complaint_filing_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.complaintBindingSource, "complaint_filing_date", true));
            this.complaint_filing_dateDateTimePicker.Location = new System.Drawing.Point(986, 343);
            this.complaint_filing_dateDateTimePicker.Name = "complaint_filing_dateDateTimePicker";
            this.complaint_filing_dateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.complaint_filing_dateDateTimePicker.TabIndex = 14;
            // 
            // complaint_deadline_dateDateTimePicker
            // 
            this.complaint_deadline_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.complaintBindingSource, "complaint_deadline_date", true));
            this.complaint_deadline_dateDateTimePicker.Location = new System.Drawing.Point(986, 369);
            this.complaint_deadline_dateDateTimePicker.Name = "complaint_deadline_dateDateTimePicker";
            this.complaint_deadline_dateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.complaint_deadline_dateDateTimePicker.TabIndex = 16;
            // 
            // complaint_ispector_idTextBox
            // 
            this.complaint_ispector_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.complaintBindingSource, "complaint_ispector_id", true));
            this.complaint_ispector_idTextBox.Location = new System.Drawing.Point(986, 395);
            this.complaint_ispector_idTextBox.Name = "complaint_ispector_idTextBox";
            this.complaint_ispector_idTextBox.Size = new System.Drawing.Size(200, 20);
            this.complaint_ispector_idTextBox.TabIndex = 18;
            // 
            // complaint_typeTextBox
            // 
            this.complaint_typeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.complaintBindingSource, "complaint_type", true));
            this.complaint_typeTextBox.Location = new System.Drawing.Point(986, 421);
            this.complaint_typeTextBox.Name = "complaint_typeTextBox";
            this.complaint_typeTextBox.Size = new System.Drawing.Size(200, 20);
            this.complaint_typeTextBox.TabIndex = 20;
            // 
            // complaint_statusTextBox
            // 
            this.complaint_statusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.complaintBindingSource, "complaint_status", true));
            this.complaint_statusTextBox.Location = new System.Drawing.Point(986, 447);
            this.complaint_statusTextBox.Name = "complaint_statusTextBox";
            this.complaint_statusTextBox.Size = new System.Drawing.Size(200, 20);
            this.complaint_statusTextBox.TabIndex = 22;
            // 
            // scanbutton
            // 
            this.scanbutton.Location = new System.Drawing.Point(1048, 486);
            this.scanbutton.Name = "scanbutton";
            this.scanbutton.Size = new System.Drawing.Size(138, 23);
            this.scanbutton.TabIndex = 23;
            this.scanbutton.Text = "Прикрепить скан";
            this.scanbutton.UseVisualStyleBackColor = true;
            this.scanbutton.Click += new System.EventHandler(this.scanbutton_Click);
            // 
            // openscan
            // 
            this.openscan.Location = new System.Drawing.Point(879, 486);
            this.openscan.Name = "openscan";
            this.openscan.Size = new System.Drawing.Size(138, 23);
            this.openscan.TabIndex = 24;
            this.openscan.Text = "Сканировать";
            this.openscan.UseVisualStyleBackColor = true;
            this.openscan.Click += new System.EventHandler(this.openscan_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 268);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(771, 279);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // vievcomplaintbutton
            // 
            this.vievcomplaintbutton.Location = new System.Drawing.Point(879, 523);
            this.vievcomplaintbutton.Name = "vievcomplaintbutton";
            this.vievcomplaintbutton.Size = new System.Drawing.Size(138, 23);
            this.vievcomplaintbutton.TabIndex = 26;
            this.vievcomplaintbutton.Text = "Показать жалобу";
            this.vievcomplaintbutton.UseVisualStyleBackColor = true;
            this.vievcomplaintbutton.Click += new System.EventHandler(this.vievcomplaintbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 630);
            this.Controls.Add(this.vievcomplaintbutton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.openscan);
            this.Controls.Add(this.scanbutton);
            this.Controls.Add(complaint_idLabel);
            this.Controls.Add(this.complaint_idTextBox);
            this.Controls.Add(complaint_customer_first_nameLabel);
            this.Controls.Add(this.complaint_customer_first_nameTextBox);
            this.Controls.Add(complaint_customer_last_nameLabel);
            this.Controls.Add(this.complaint_customer_last_nameTextBox);
            this.Controls.Add(complaint_adressLabel);
            this.Controls.Add(this.complaint_adressTextBox);
            this.Controls.Add(complaint_cosesLabel);
            this.Controls.Add(this.complaint_cosesTextBox);
            this.Controls.Add(complaint_filing_dateLabel);
            this.Controls.Add(this.complaint_filing_dateDateTimePicker);
            this.Controls.Add(complaint_deadline_dateLabel);
            this.Controls.Add(this.complaint_deadline_dateDateTimePicker);
            this.Controls.Add(complaint_ispector_idLabel);
            this.Controls.Add(this.complaint_ispector_idTextBox);
            this.Controls.Add(complaint_typeLabel);
            this.Controls.Add(this.complaint_typeTextBox);
            this.Controls.Add(complaint_statusLabel);
            this.Controls.Add(this.complaint_statusTextBox);
            this.Controls.Add(this.inspectionDataGridView);
            this.Controls.Add(this.complaintDataGridView);
            this.Controls.Add(this.complaintBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inspectorDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.complaintBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.complaintBindingNavigator)).EndInit();
            this.complaintBindingNavigator.ResumeLayout(false);
            this.complaintBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.complaintDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectionDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private InspectorDBDataSet inspectorDBDataSet;
        private System.Windows.Forms.BindingSource complaintBindingSource;
        private InspectorDBDataSetTableAdapters.ComplaintTableAdapter complaintTableAdapter;
        private InspectorDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator complaintBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton complaintBindingNavigatorSaveItem;
        private InspectorDBDataSetTableAdapters.InspectionTableAdapter inspectionTableAdapter;
        private System.Windows.Forms.DataGridView complaintDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.BindingSource inspectionBindingSource;
        private System.Windows.Forms.DataGridView inspectionDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.TextBox complaint_idTextBox;
        private System.Windows.Forms.TextBox complaint_customer_first_nameTextBox;
        private System.Windows.Forms.TextBox complaint_customer_last_nameTextBox;
        private System.Windows.Forms.TextBox complaint_adressTextBox;
        private System.Windows.Forms.TextBox complaint_cosesTextBox;
        private System.Windows.Forms.DateTimePicker complaint_filing_dateDateTimePicker;
        private System.Windows.Forms.DateTimePicker complaint_deadline_dateDateTimePicker;
        private System.Windows.Forms.TextBox complaint_ispector_idTextBox;
        private System.Windows.Forms.TextBox complaint_typeTextBox;
        private System.Windows.Forms.TextBox complaint_statusTextBox;
        private System.Windows.Forms.Button scanbutton;
        private System.Windows.Forms.Button openscan;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button vievcomplaintbutton;
    }
}

