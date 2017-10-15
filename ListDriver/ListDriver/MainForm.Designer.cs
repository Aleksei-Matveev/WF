namespace ListDriver
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autorMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.clockStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStripIcon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.returnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.initialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuDataGrid = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItemDataGrid = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItemDataGrid = new System.Windows.Forms.ToolStripMenuItem();
            this.driverBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.driverDataSet = new ListDriver.driverDataSet();
            this.groupBoxAll = new System.Windows.Forms.GroupBox();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBoxReport = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBoxDriver = new System.Windows.Forms.GroupBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btdDelete = new System.Windows.Forms.Button();
            this.btnAddDriver = new System.Windows.Forms.Button();
            this.driverTableAdapter = new ListDriver.driverDataSetTableAdapters.DriverTableAdapter();
            this.btnSave = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.contextMenuStripIcon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.contextMenuDataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.driverBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.driverDataSet)).BeginInit();
            this.groupBoxAll.SuspendLayout();
            this.groupBox.SuspendLayout();
            this.groupBoxReport.SuspendLayout();
            this.groupBoxDriver.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuItem,
            this.helpMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(784, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitMenuItem});
            this.fileMenuItem.Name = "fileMenuItem";
            this.fileMenuItem.Size = new System.Drawing.Size(48, 20);
            this.fileMenuItem.Text = "Файл";
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(108, 22);
            this.exitMenuItem.Text = "Выход";
            this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // helpMenuItem
            // 
            this.helpMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autorMenuItem});
            this.helpMenuItem.Name = "helpMenuItem";
            this.helpMenuItem.Size = new System.Drawing.Size(65, 20);
            this.helpMenuItem.Text = "Справка";
            // 
            // autorMenuItem
            // 
            this.autorMenuItem.Name = "autorMenuItem";
            this.autorMenuItem.Size = new System.Drawing.Size(107, 22);
            this.autorMenuItem.Text = "Автор";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clockStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 538);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(784, 23);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // clockStatusLabel
            // 
            this.clockStatusLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.clockStatusLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.clockStatusLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clockStatusLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.clockStatusLabel.Name = "clockStatusLabel";
            this.clockStatusLabel.Size = new System.Drawing.Size(769, 18);
            this.clockStatusLabel.Spring = true;
            this.clockStatusLabel.Text = "data";
            this.clockStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenuStripIcon;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "notifyIcon1";
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // contextMenuStripIcon
            // 
            this.contextMenuStripIcon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.returnToolStripMenuItem});
            this.contextMenuStripIcon.Name = "contextMenuStripIcon";
            this.contextMenuStripIcon.Size = new System.Drawing.Size(136, 26);
            // 
            // returnToolStripMenuItem
            // 
            this.returnToolStripMenuItem.Name = "returnToolStripMenuItem";
            this.returnToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.returnToolStripMenuItem.Text = "Развернуть";
            this.returnToolStripMenuItem.Click += new System.EventHandler(this.returnToolStripMenuItem_Click);
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.IsSplitterFixed = true;
            this.splitContainer.Location = new System.Drawing.Point(0, 24);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.dataGridView);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.groupBoxAll);
            this.splitContainer.Size = new System.Drawing.Size(784, 514);
            this.splitContainer.SplitterDistance = 462;
            this.splitContainer.TabIndex = 2;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.initialDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn});
            this.dataGridView.ContextMenuStrip = this.contextMenuDataGrid;
            this.dataGridView.DataSource = this.driverBindingSource;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.MaximumSize = new System.Drawing.Size(462, 514);
            this.dataGridView.MinimumSize = new System.Drawing.Size(462, 514);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(462, 514);
            this.dataGridView.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // initialDataGridViewTextBoxColumn
            // 
            this.initialDataGridViewTextBoxColumn.DataPropertyName = "Initial";
            this.initialDataGridViewTextBoxColumn.HeaderText = "Initial";
            this.initialDataGridViewTextBoxColumn.Name = "initialDataGridViewTextBoxColumn";
            this.initialDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contextMenuDataGrid
            // 
            this.contextMenuDataGrid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItemDataGrid,
            this.deleteToolStripMenuItemDataGrid});
            this.contextMenuDataGrid.Name = "contextMenuDataGrid";
            this.contextMenuDataGrid.Size = new System.Drawing.Size(155, 70);
            // 
            // editToolStripMenuItemDataGrid
            // 
            this.editToolStripMenuItemDataGrid.Name = "editToolStripMenuItemDataGrid";
            this.editToolStripMenuItemDataGrid.Size = new System.Drawing.Size(154, 22);
            this.editToolStripMenuItemDataGrid.Text = "Редактировать";
            this.editToolStripMenuItemDataGrid.Click += new System.EventHandler(this.editToolStripMenuItemDataGrid_Click);
            // 
            // deleteToolStripMenuItemDataGrid
            // 
            this.deleteToolStripMenuItemDataGrid.Name = "deleteToolStripMenuItemDataGrid";
            this.deleteToolStripMenuItemDataGrid.Size = new System.Drawing.Size(154, 22);
            this.deleteToolStripMenuItemDataGrid.Text = "Удалить";
            this.deleteToolStripMenuItemDataGrid.Click += new System.EventHandler(this.deleteToolStripMenuItemDataGrid_Click);
            // 
            // driverBindingSource
            // 
            this.driverBindingSource.DataMember = "Driver";
            this.driverBindingSource.DataSource = this.driverDataSet;
            // 
            // driverDataSet
            // 
            this.driverDataSet.DataSetName = "driverDataSet";
            this.driverDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBoxAll
            // 
            this.groupBoxAll.Controls.Add(this.groupBox);
            this.groupBoxAll.Controls.Add(this.groupBoxReport);
            this.groupBoxAll.Controls.Add(this.groupBoxDriver);
            this.groupBoxAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxAll.Location = new System.Drawing.Point(0, 0);
            this.groupBoxAll.Name = "groupBoxAll";
            this.groupBoxAll.Size = new System.Drawing.Size(318, 514);
            this.groupBoxAll.TabIndex = 0;
            this.groupBoxAll.TabStop = false;
            this.groupBoxAll.Text = "Панель управления";
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.richTextBox1);
            this.groupBox.Location = new System.Drawing.Point(12, 275);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(294, 233);
            this.groupBox.TabIndex = 2;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Заметки сумашедшего";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(6, 19);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(282, 208);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // groupBoxReport
            // 
            this.groupBoxReport.Controls.Add(this.button2);
            this.groupBoxReport.Controls.Add(this.button1);
            this.groupBoxReport.Location = new System.Drawing.Point(6, 184);
            this.groupBoxReport.Name = "groupBoxReport";
            this.groupBoxReport.Size = new System.Drawing.Size(306, 85);
            this.groupBoxReport.TabIndex = 1;
            this.groupBoxReport.TabStop = false;
            this.groupBoxReport.Text = "Отчет";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(6, 50);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(294, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Печатать отчет";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(6, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(294, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Сформировать отчет на экран";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBoxDriver
            // 
            this.groupBoxDriver.Controls.Add(this.btnSave);
            this.groupBoxDriver.Controls.Add(this.btnEdit);
            this.groupBoxDriver.Controls.Add(this.btdDelete);
            this.groupBoxDriver.Controls.Add(this.btnAddDriver);
            this.groupBoxDriver.Location = new System.Drawing.Point(6, 19);
            this.groupBoxDriver.Name = "groupBoxDriver";
            this.groupBoxDriver.Size = new System.Drawing.Size(309, 142);
            this.groupBoxDriver.TabIndex = 0;
            this.groupBoxDriver.TabStop = false;
            this.groupBoxDriver.Text = "Редактирование базы";
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEdit.Location = new System.Drawing.Point(6, 70);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(294, 23);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Редактировать";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btdDelete
            // 
            this.btdDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btdDelete.Location = new System.Drawing.Point(160, 31);
            this.btdDelete.Name = "btdDelete";
            this.btdDelete.Size = new System.Drawing.Size(140, 23);
            this.btdDelete.TabIndex = 1;
            this.btdDelete.Text = "Удалить";
            this.btdDelete.UseVisualStyleBackColor = true;
            // 
            // btnAddDriver
            // 
            this.btnAddDriver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddDriver.Location = new System.Drawing.Point(6, 31);
            this.btnAddDriver.Name = "btnAddDriver";
            this.btnAddDriver.Size = new System.Drawing.Size(140, 23);
            this.btnAddDriver.TabIndex = 0;
            this.btnAddDriver.Text = "Добавить";
            this.btnAddDriver.UseVisualStyleBackColor = true;
            // 
            // driverTableAdapter
            // 
            this.driverTableAdapter.ClearBeforeFill = true;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.Location = new System.Drawing.Point(6, 99);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(294, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Сохранить изменения";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Медицинские справки водителей";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Move += new System.EventHandler(this.MainForm_Move);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.contextMenuStripIcon.ResumeLayout(false);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.contextMenuDataGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.driverBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.driverDataSet)).EndInit();
            this.groupBoxAll.ResumeLayout(false);
            this.groupBox.ResumeLayout(false);
            this.groupBoxReport.ResumeLayout(false);
            this.groupBoxDriver.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripMenuItem fileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autorMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel clockStatusLabel;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripIcon;
        private System.Windows.Forms.ToolStripMenuItem returnToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.DataGridView dataGridView;
        private driverDataSet driverDataSet;
        private System.Windows.Forms.BindingSource driverBindingSource;
        private driverDataSetTableAdapters.DriverTableAdapter driverTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn initialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBoxAll;
        private System.Windows.Forms.GroupBox groupBoxDriver;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btdDelete;
        private System.Windows.Forms.Button btnAddDriver;
        private System.Windows.Forms.GroupBox groupBoxReport;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuDataGrid;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItemDataGrid;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItemDataGrid;
        private System.Windows.Forms.Button btnSave;
    }
}

