
namespace LocalDB
{
    partial class btnLocalDB
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
            System.Windows.Forms.Label idnoLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label courseLabel;
            System.Windows.Forms.Label levelLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(btnLocalDB));
            this.studentInformationBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.studentInformationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.modelDataSet = new LocalDB.ModelDataSet();
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
            this.studentInformationBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idnoTextBox = new System.Windows.Forms.TextBox();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.courseTextBox = new System.Windows.Forms.TextBox();
            this.levelTextBox = new System.Windows.Forms.TextBox();
            this.studentInformationDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentInformationTableAdapter = new LocalDB.ModelDataSetTableAdapters.StudentInformationTableAdapter();
            this.tableAdapterManager = new LocalDB.ModelDataSetTableAdapters.TableAdapterManager();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            idnoLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            firstNameLabel = new System.Windows.Forms.Label();
            courseLabel = new System.Windows.Forms.Label();
            levelLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.studentInformationBindingNavigator)).BeginInit();
            this.studentInformationBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentInformationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInformationDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // idnoLabel
            // 
            idnoLabel.AutoSize = true;
            idnoLabel.BackColor = System.Drawing.Color.Transparent;
            idnoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idnoLabel.Location = new System.Drawing.Point(17, 71);
            idnoLabel.Name = "idnoLabel";
            idnoLabel.Size = new System.Drawing.Size(50, 20);
            idnoLabel.TabIndex = 1;
            idnoLabel.Text = "Idno:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.BackColor = System.Drawing.Color.Transparent;
            lastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lastNameLabel.Location = new System.Drawing.Point(17, 103);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(106, 20);
            lastNameLabel.TabIndex = 3;
            lastNameLabel.Text = "Last Name:";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.BackColor = System.Drawing.Color.Transparent;
            firstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            firstNameLabel.Location = new System.Drawing.Point(18, 137);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(108, 20);
            firstNameLabel.TabIndex = 5;
            firstNameLabel.Text = "First Name:";
            // 
            // courseLabel
            // 
            courseLabel.AutoSize = true;
            courseLabel.BackColor = System.Drawing.Color.Transparent;
            courseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            courseLabel.Location = new System.Drawing.Point(18, 169);
            courseLabel.Name = "courseLabel";
            courseLabel.Size = new System.Drawing.Size(75, 20);
            courseLabel.TabIndex = 7;
            courseLabel.Text = "Course:";
            courseLabel.Click += new System.EventHandler(this.courseLabel_Click);
            // 
            // levelLabel
            // 
            levelLabel.AutoSize = true;
            levelLabel.BackColor = System.Drawing.Color.Transparent;
            levelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            levelLabel.Location = new System.Drawing.Point(18, 204);
            levelLabel.Name = "levelLabel";
            levelLabel.Size = new System.Drawing.Size(60, 20);
            levelLabel.TabIndex = 9;
            levelLabel.Text = "Level:";
            // 
            // studentInformationBindingNavigator
            // 
            this.studentInformationBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.studentInformationBindingNavigator.BindingSource = this.studentInformationBindingSource;
            this.studentInformationBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.studentInformationBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.studentInformationBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.studentInformationBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.studentInformationBindingNavigatorSaveItem});
            this.studentInformationBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.studentInformationBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.studentInformationBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.studentInformationBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.studentInformationBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.studentInformationBindingNavigator.Name = "studentInformationBindingNavigator";
            this.studentInformationBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.studentInformationBindingNavigator.Size = new System.Drawing.Size(820, 27);
            this.studentInformationBindingNavigator.TabIndex = 0;
            this.studentInformationBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // studentInformationBindingSource
            // 
            this.studentInformationBindingSource.DataMember = "StudentInformation";
            this.studentInformationBindingSource.DataSource = this.modelDataSet;
            // 
            // modelDataSet
            // 
            this.modelDataSet.DataSetName = "ModelDataSet";
            this.modelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // studentInformationBindingNavigatorSaveItem
            // 
            this.studentInformationBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.studentInformationBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("studentInformationBindingNavigatorSaveItem.Image")));
            this.studentInformationBindingNavigatorSaveItem.Name = "studentInformationBindingNavigatorSaveItem";
            this.studentInformationBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.studentInformationBindingNavigatorSaveItem.Text = "Save Data";
            this.studentInformationBindingNavigatorSaveItem.Click += new System.EventHandler(this.studentInformationBindingNavigatorSaveItem_Click);
            // 
            // idnoTextBox
            // 
            this.idnoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentInformationBindingSource, "Idno", true));
            this.idnoTextBox.Location = new System.Drawing.Point(137, 69);
            this.idnoTextBox.Name = "idnoTextBox";
            this.idnoTextBox.Size = new System.Drawing.Size(214, 22);
            this.idnoTextBox.TabIndex = 2;
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentInformationBindingSource, "LastName", true));
            this.LastNameTextBox.Location = new System.Drawing.Point(137, 101);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(214, 22);
            this.LastNameTextBox.TabIndex = 4;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentInformationBindingSource, "FirstName", true));
            this.firstNameTextBox.Location = new System.Drawing.Point(137, 137);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(214, 22);
            this.firstNameTextBox.TabIndex = 6;
            // 
            // courseTextBox
            // 
            this.courseTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentInformationBindingSource, "Course", true));
            this.courseTextBox.Location = new System.Drawing.Point(137, 204);
            this.courseTextBox.Name = "courseTextBox";
            this.courseTextBox.Size = new System.Drawing.Size(214, 22);
            this.courseTextBox.TabIndex = 8;
            // 
            // levelTextBox
            // 
            this.levelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentInformationBindingSource, "Level", true));
            this.levelTextBox.Location = new System.Drawing.Point(137, 169);
            this.levelTextBox.Name = "levelTextBox";
            this.levelTextBox.Size = new System.Drawing.Size(214, 22);
            this.levelTextBox.TabIndex = 10;
            // 
            // studentInformationDataGridView
            // 
            this.studentInformationDataGridView.AutoGenerateColumns = false;
            this.studentInformationDataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.studentInformationDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.studentInformationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentInformationDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.studentInformationDataGridView.DataSource = this.studentInformationBindingSource;
            this.studentInformationDataGridView.GridColor = System.Drawing.Color.Black;
            this.studentInformationDataGridView.Location = new System.Drawing.Point(373, 45);
            this.studentInformationDataGridView.Name = "studentInformationDataGridView";
            this.studentInformationDataGridView.RowHeadersWidth = 51;
            this.studentInformationDataGridView.RowTemplate.Height = 24;
            this.studentInformationDataGridView.Size = new System.Drawing.Size(429, 277);
            this.studentInformationDataGridView.TabIndex = 11;
            this.studentInformationDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.studentInformationDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Idno";
            this.dataGridViewTextBoxColumn1.HeaderText = "Idno";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "LastName";
            this.dataGridViewTextBoxColumn2.HeaderText = "LastName";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "FirstName";
            this.dataGridViewTextBoxColumn3.HeaderText = "FirstName";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Course";
            this.dataGridViewTextBoxColumn4.HeaderText = "Course";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Level";
            this.dataGridViewTextBoxColumn5.HeaderText = "Level";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // studentInformationTableAdapter
            // 
            this.studentInformationTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.StudentInformationTableAdapter = this.studentInformationTableAdapter;
            this.tableAdapterManager.UpdateOrder = LocalDB.ModelDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAdd.Location = new System.Drawing.Point(32, 256);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 42);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDelete.Location = new System.Drawing.Point(195, 256);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 42);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.ForestGreen;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.Control;
            this.btnUpdate.Location = new System.Drawing.Point(114, 256);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 42);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.IndianRed;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCancel.Location = new System.Drawing.Point(276, 256);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 42);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnLocalDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(820, 339);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.studentInformationDataGridView);
            this.Controls.Add(idnoLabel);
            this.Controls.Add(this.idnoTextBox);
            this.Controls.Add(lastNameLabel);
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(firstNameLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(courseLabel);
            this.Controls.Add(this.courseTextBox);
            this.Controls.Add(levelLabel);
            this.Controls.Add(this.levelTextBox);
            this.Controls.Add(this.studentInformationBindingNavigator);
            this.Name = "btnLocalDB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LocalDB";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentInformationBindingNavigator)).EndInit();
            this.studentInformationBindingNavigator.ResumeLayout(false);
            this.studentInformationBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentInformationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInformationDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ModelDataSet modelDataSet;
        private System.Windows.Forms.BindingSource studentInformationBindingSource;
        private ModelDataSetTableAdapters.StudentInformationTableAdapter studentInformationTableAdapter;
        private ModelDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator studentInformationBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton studentInformationBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idnoTextBox;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox courseTextBox;
        private System.Windows.Forms.TextBox levelTextBox;
        private System.Windows.Forms.DataGridView studentInformationDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCancel;
    }
}

