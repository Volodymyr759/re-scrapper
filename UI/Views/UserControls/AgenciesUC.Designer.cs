
namespace UI.Views.UserControls
{
    partial class AgenciesUC
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblState = new System.Windows.Forms.Label();
            this.cmbState = new System.Windows.Forms.ComboBox();
            this.dgvAgencies = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.webSiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facebookPageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.propertiesSoldDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.propertiesForRentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastUpdatedOnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsAgencies = new System.Windows.Forms.BindingSource(this.components);
            this.cmbOptions = new System.Windows.Forms.ComboBox();
            this.lblOptions = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgencies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAgencies)).BeginInit();
            this.SuspendLayout();
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(3, 6);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(46, 20);
            this.lblState.TabIndex = 2;
            this.lblState.Text = "State:";
            // 
            // cmbState
            // 
            this.cmbState.FormattingEnabled = true;
            this.cmbState.Location = new System.Drawing.Point(55, 3);
            this.cmbState.Name = "cmbState";
            this.cmbState.Size = new System.Drawing.Size(71, 28);
            this.cmbState.TabIndex = 3;
            this.cmbState.SelectedValueChanged += new System.EventHandler(this.CmbState_SelectedValueChanged);
            // 
            // dgvAgencies
            // 
            this.dgvAgencies.AllowUserToAddRows = false;
            this.dgvAgencies.AllowUserToDeleteRows = false;
            this.dgvAgencies.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAgencies.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAgencies.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAgencies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgencies.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.fullAddressDataGridViewTextBoxColumn,
            this.stateDataGridViewTextBoxColumn,
            this.webSiteDataGridViewTextBoxColumn,
            this.facebookPageDataGridViewTextBoxColumn,
            this.propertiesSoldDataGridViewTextBoxColumn,
            this.propertiesForRentDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.lastUpdatedOnDataGridViewTextBoxColumn,
            this.notesDataGridViewTextBoxColumn});
            this.dgvAgencies.DataSource = this.bsAgencies;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAgencies.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAgencies.Location = new System.Drawing.Point(3, 36);
            this.dgvAgencies.Name = "dgvAgencies";
            this.dgvAgencies.ReadOnly = true;
            this.dgvAgencies.RowHeadersWidth = 51;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.dgvAgencies.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAgencies.RowTemplate.Height = 24;
            this.dgvAgencies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAgencies.Size = new System.Drawing.Size(824, 564);
            this.dgvAgencies.TabIndex = 4;
            this.dgvAgencies.SelectionChanged += new System.EventHandler(this.DgvAgencies_SelectionChanged);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 50;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // fullAddressDataGridViewTextBoxColumn
            // 
            this.fullAddressDataGridViewTextBoxColumn.DataPropertyName = "FullAddress";
            this.fullAddressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.fullAddressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fullAddressDataGridViewTextBoxColumn.Name = "fullAddressDataGridViewTextBoxColumn";
            this.fullAddressDataGridViewTextBoxColumn.ReadOnly = true;
            this.fullAddressDataGridViewTextBoxColumn.Width = 125;
            // 
            // stateDataGridViewTextBoxColumn
            // 
            this.stateDataGridViewTextBoxColumn.DataPropertyName = "State";
            this.stateDataGridViewTextBoxColumn.HeaderText = "State";
            this.stateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stateDataGridViewTextBoxColumn.Name = "stateDataGridViewTextBoxColumn";
            this.stateDataGridViewTextBoxColumn.ReadOnly = true;
            this.stateDataGridViewTextBoxColumn.Width = 50;
            // 
            // webSiteDataGridViewTextBoxColumn
            // 
            this.webSiteDataGridViewTextBoxColumn.DataPropertyName = "WebSite";
            this.webSiteDataGridViewTextBoxColumn.HeaderText = "Web";
            this.webSiteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.webSiteDataGridViewTextBoxColumn.Name = "webSiteDataGridViewTextBoxColumn";
            this.webSiteDataGridViewTextBoxColumn.ReadOnly = true;
            this.webSiteDataGridViewTextBoxColumn.Width = 125;
            // 
            // facebookPageDataGridViewTextBoxColumn
            // 
            this.facebookPageDataGridViewTextBoxColumn.DataPropertyName = "FacebookPage";
            this.facebookPageDataGridViewTextBoxColumn.HeaderText = "Facebook";
            this.facebookPageDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.facebookPageDataGridViewTextBoxColumn.Name = "facebookPageDataGridViewTextBoxColumn";
            this.facebookPageDataGridViewTextBoxColumn.ReadOnly = true;
            this.facebookPageDataGridViewTextBoxColumn.Width = 125;
            // 
            // propertiesSoldDataGridViewTextBoxColumn
            // 
            this.propertiesSoldDataGridViewTextBoxColumn.DataPropertyName = "PropertiesSold";
            this.propertiesSoldDataGridViewTextBoxColumn.HeaderText = "Sold";
            this.propertiesSoldDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.propertiesSoldDataGridViewTextBoxColumn.Name = "propertiesSoldDataGridViewTextBoxColumn";
            this.propertiesSoldDataGridViewTextBoxColumn.ReadOnly = true;
            this.propertiesSoldDataGridViewTextBoxColumn.Width = 50;
            // 
            // propertiesForRentDataGridViewTextBoxColumn
            // 
            this.propertiesForRentDataGridViewTextBoxColumn.DataPropertyName = "PropertiesForRent";
            this.propertiesForRentDataGridViewTextBoxColumn.HeaderText = "Rent";
            this.propertiesForRentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.propertiesForRentDataGridViewTextBoxColumn.Name = "propertiesForRentDataGridViewTextBoxColumn";
            this.propertiesForRentDataGridViewTextBoxColumn.ReadOnly = true;
            this.propertiesForRentDataGridViewTextBoxColumn.Width = 50;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
            this.phoneDataGridViewTextBoxColumn.Width = 125;
            // 
            // lastUpdatedOnDataGridViewTextBoxColumn
            // 
            this.lastUpdatedOnDataGridViewTextBoxColumn.DataPropertyName = "LastUpdatedOn";
            this.lastUpdatedOnDataGridViewTextBoxColumn.HeaderText = "Updated";
            this.lastUpdatedOnDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastUpdatedOnDataGridViewTextBoxColumn.Name = "lastUpdatedOnDataGridViewTextBoxColumn";
            this.lastUpdatedOnDataGridViewTextBoxColumn.ReadOnly = true;
            this.lastUpdatedOnDataGridViewTextBoxColumn.Width = 125;
            // 
            // notesDataGridViewTextBoxColumn
            // 
            this.notesDataGridViewTextBoxColumn.DataPropertyName = "Notes";
            this.notesDataGridViewTextBoxColumn.HeaderText = "Notes";
            this.notesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.notesDataGridViewTextBoxColumn.Name = "notesDataGridViewTextBoxColumn";
            this.notesDataGridViewTextBoxColumn.ReadOnly = true;
            this.notesDataGridViewTextBoxColumn.Width = 125;
            // 
            // bsAgencies
            // 
            this.bsAgencies.DataSource = typeof(Services.AgencyDto);
            this.bsAgencies.Sort = "";
            // 
            // cmbOptions
            // 
            this.cmbOptions.FormattingEnabled = true;
            this.cmbOptions.Items.AddRange(new object[] {
            "Parse agencies",
            "Show website",
            "Show Facebook page"});
            this.cmbOptions.Location = new System.Drawing.Point(211, 3);
            this.cmbOptions.Name = "cmbOptions";
            this.cmbOptions.Size = new System.Drawing.Size(213, 28);
            this.cmbOptions.TabIndex = 6;
            this.cmbOptions.SelectedValueChanged += new System.EventHandler(this.CmbOptions_SelectedValueChanged);
            // 
            // lblOptions
            // 
            this.lblOptions.AutoSize = true;
            this.lblOptions.Location = new System.Drawing.Point(141, 6);
            this.lblOptions.Name = "lblOptions";
            this.lblOptions.Size = new System.Drawing.Size(64, 20);
            this.lblOptions.TabIndex = 5;
            this.lblOptions.Text = "Options:";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(430, 6);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(0, 20);
            this.lblInfo.TabIndex = 7;
            // 
            // AgenciesUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.cmbOptions);
            this.Controls.Add(this.lblOptions);
            this.Controls.Add(this.dgvAgencies);
            this.Controls.Add(this.cmbState);
            this.Controls.Add(this.lblState);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(830, 603);
            this.Name = "AgenciesUC";
            this.Size = new System.Drawing.Size(830, 603);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgencies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAgencies)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.ComboBox cmbState;
        private System.Windows.Forms.DataGridView dgvAgencies;
        private System.Windows.Forms.BindingSource bsAgencies;
        private System.Windows.Forms.ComboBox cmbOptions;
        private System.Windows.Forms.Label lblOptions;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn webSiteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn facebookPageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn propertiesSoldDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn propertiesForRentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastUpdatedOnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notesDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblInfo;
    }
}
