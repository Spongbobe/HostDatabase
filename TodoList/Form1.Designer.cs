
namespace TodoList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label ageLabel;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label orderNumberLabel;
            System.Windows.Forms.Label personIDLabel;
            this.studentDbDataSet = new TodoList.StudentDbDataSet();
            this.orderTbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderTbTableAdapter = new TodoList.StudentDbDataSetTableAdapters.OrderTbTableAdapter();
            this.tableAdapterManager = new TodoList.StudentDbDataSetTableAdapters.TableAdapterManager();
            this.orderTbBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.orderTbBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.studentTbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentTbTableAdapter = new TodoList.StudentDbDataSetTableAdapters.StudentTbTableAdapter();
            this.studentTbDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.orderTbBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.orderTbDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.orderNumberTextBox = new System.Windows.Forms.TextBox();
            this.personIDTextBox = new System.Windows.Forms.TextBox();
            firstNameLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            ageLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            orderNumberLabel = new System.Windows.Forms.Label();
            personIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.studentDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderTbBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderTbBindingNavigator)).BeginInit();
            this.orderTbBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentTbBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentTbDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderTbBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderTbDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // studentDbDataSet
            // 
            this.studentDbDataSet.DataSetName = "StudentDbDataSet";
            this.studentDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orderTbBindingSource
            // 
            this.orderTbBindingSource.DataMember = "OrderTb";
            this.orderTbBindingSource.DataSource = this.studentDbDataSet;
            // 
            // orderTbTableAdapter
            // 
            this.orderTbTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.OrderTbTableAdapter = this.orderTbTableAdapter;
            this.tableAdapterManager.StudentTbTableAdapter = this.studentTbTableAdapter;
            this.tableAdapterManager.UpdateOrder = TodoList.StudentDbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // orderTbBindingNavigator
            // 
            this.orderTbBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.orderTbBindingNavigator.BindingSource = this.orderTbBindingSource;
            this.orderTbBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.orderTbBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.orderTbBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.orderTbBindingNavigatorSaveItem});
            this.orderTbBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.orderTbBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.orderTbBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.orderTbBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.orderTbBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.orderTbBindingNavigator.Name = "orderTbBindingNavigator";
            this.orderTbBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.orderTbBindingNavigator.Size = new System.Drawing.Size(820, 25);
            this.orderTbBindingNavigator.TabIndex = 0;
            this.orderTbBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 14);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // orderTbBindingNavigatorSaveItem
            // 
            this.orderTbBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.orderTbBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("orderTbBindingNavigatorSaveItem.Image")));
            this.orderTbBindingNavigatorSaveItem.Name = "orderTbBindingNavigatorSaveItem";
            this.orderTbBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.orderTbBindingNavigatorSaveItem.Text = "Save Data";
            this.orderTbBindingNavigatorSaveItem.Click += new System.EventHandler(this.orderTbBindingNavigatorSaveItem_Click);
            // 
            // studentTbBindingSource
            // 
            this.studentTbBindingSource.DataMember = "StudentTb";
            this.studentTbBindingSource.DataSource = this.studentDbDataSet;
            // 
            // studentTbTableAdapter
            // 
            this.studentTbTableAdapter.ClearBeforeFill = true;
            // 
            // studentTbDataGridView
            // 
            this.studentTbDataGridView.AutoGenerateColumns = false;
            this.studentTbDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentTbDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.studentTbDataGridView.DataSource = this.studentTbBindingSource;
            this.studentTbDataGridView.Location = new System.Drawing.Point(355, 12);
            this.studentTbDataGridView.Name = "studentTbDataGridView";
            this.studentTbDataGridView.Size = new System.Drawing.Size(445, 220);
            this.studentTbDataGridView.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "PersonID";
            this.dataGridViewTextBoxColumn4.HeaderText = "PersonID";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "FirstName";
            this.dataGridViewTextBoxColumn5.HeaderText = "FirstName";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "LastName";
            this.dataGridViewTextBoxColumn6.HeaderText = "LastName";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Age";
            this.dataGridViewTextBoxColumn7.HeaderText = "Age";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new System.Drawing.Point(68, 183);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(60, 13);
            firstNameLabel.TabIndex = 9;
            firstNameLabel.Text = "First Name:";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentTbBindingSource, "FirstName", true));
            this.firstNameTextBox.Location = new System.Drawing.Point(134, 180);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.firstNameTextBox.TabIndex = 10;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new System.Drawing.Point(67, 232);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(61, 13);
            lastNameLabel.TabIndex = 10;
            lastNameLabel.Text = "Last Name:";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentTbBindingSource, "LastName", true));
            this.lastNameTextBox.Location = new System.Drawing.Point(134, 229);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.lastNameTextBox.TabIndex = 11;
            // 
            // ageLabel
            // 
            ageLabel.AutoSize = true;
            ageLabel.Location = new System.Drawing.Point(99, 275);
            ageLabel.Name = "ageLabel";
            ageLabel.Size = new System.Drawing.Size(29, 13);
            ageLabel.TabIndex = 11;
            ageLabel.Text = "Age:";
            // 
            // ageTextBox
            // 
            this.ageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentTbBindingSource, "Age", true));
            this.ageTextBox.Location = new System.Drawing.Point(134, 272);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(100, 20);
            this.ageTextBox.TabIndex = 12;
            // 
            // orderTbBindingSource1
            // 
            this.orderTbBindingSource1.DataMember = "FK_OrderTb_StudentTb";
            this.orderTbBindingSource1.DataSource = this.studentTbBindingSource;
            // 
            // orderTbDataGridView
            // 
            this.orderTbDataGridView.AutoGenerateColumns = false;
            this.orderTbDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderTbDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.orderTbDataGridView.DataSource = this.orderTbBindingSource1;
            this.orderTbDataGridView.Location = new System.Drawing.Point(355, 260);
            this.orderTbDataGridView.Name = "orderTbDataGridView";
            this.orderTbDataGridView.Size = new System.Drawing.Size(300, 220);
            this.orderTbDataGridView.TabIndex = 12;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "OrderNumber";
            this.dataGridViewTextBoxColumn2.HeaderText = "OrderNumber";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PersonID";
            this.dataGridViewTextBoxColumn3.HeaderText = "PersonID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(52, 87);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 12;
            idLabel.Text = "Id:";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderTbBindingSource1, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(134, 84);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 13;
            // 
            // orderNumberLabel
            // 
            orderNumberLabel.AutoSize = true;
            orderNumberLabel.Location = new System.Drawing.Point(52, 113);
            orderNumberLabel.Name = "orderNumberLabel";
            orderNumberLabel.Size = new System.Drawing.Size(76, 13);
            orderNumberLabel.TabIndex = 14;
            orderNumberLabel.Text = "Order Number:";
            // 
            // orderNumberTextBox
            // 
            this.orderNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderTbBindingSource1, "OrderNumber", true));
            this.orderNumberTextBox.Location = new System.Drawing.Point(134, 110);
            this.orderNumberTextBox.Name = "orderNumberTextBox";
            this.orderNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.orderNumberTextBox.TabIndex = 15;
            // 
            // personIDLabel
            // 
            personIDLabel.AutoSize = true;
            personIDLabel.Location = new System.Drawing.Point(52, 139);
            personIDLabel.Name = "personIDLabel";
            personIDLabel.Size = new System.Drawing.Size(57, 13);
            personIDLabel.TabIndex = 16;
            personIDLabel.Text = "Person ID:";
            // 
            // personIDTextBox
            // 
            this.personIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderTbBindingSource1, "PersonID", true));
            this.personIDTextBox.Location = new System.Drawing.Point(134, 136);
            this.personIDTextBox.Name = "personIDTextBox";
            this.personIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.personIDTextBox.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 749);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(orderNumberLabel);
            this.Controls.Add(this.orderNumberTextBox);
            this.Controls.Add(personIDLabel);
            this.Controls.Add(this.personIDTextBox);
            this.Controls.Add(this.orderTbDataGridView);
            this.Controls.Add(ageLabel);
            this.Controls.Add(this.ageTextBox);
            this.Controls.Add(lastNameLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(firstNameLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.studentTbDataGridView);
            this.Controls.Add(this.orderTbBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderTbBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderTbBindingNavigator)).EndInit();
            this.orderTbBindingNavigator.ResumeLayout(false);
            this.orderTbBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentTbBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentTbDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderTbBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderTbDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private StudentDbDataSet studentDbDataSet;
        private System.Windows.Forms.BindingSource orderTbBindingSource;
        private StudentDbDataSetTableAdapters.OrderTbTableAdapter orderTbTableAdapter;
        private StudentDbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator orderTbBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton orderTbBindingNavigatorSaveItem;
        private StudentDbDataSetTableAdapters.StudentTbTableAdapter studentTbTableAdapter;
        private System.Windows.Forms.BindingSource studentTbBindingSource;
        private System.Windows.Forms.DataGridView studentTbDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox ageTextBox;
        private System.Windows.Forms.BindingSource orderTbBindingSource1;
        private System.Windows.Forms.DataGridView orderTbDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox orderNumberTextBox;
        private System.Windows.Forms.TextBox personIDTextBox;
    }
}

