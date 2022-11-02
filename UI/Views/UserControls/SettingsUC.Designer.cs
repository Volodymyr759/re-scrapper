
namespace UI.Views.UserControls
{
    partial class SettingsUC
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
            this.lblBaseUrl = new System.Windows.Forms.Label();
            this.txtBaseUrl = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.gbSelectors = new System.Windows.Forms.GroupBox();
            this.numThreads = new System.Windows.Forms.NumericUpDown();
            this.lblThreadsNumber = new System.Windows.Forms.Label();
            this.txtPropertiesForRent = new System.Windows.Forms.TextBox();
            this.lblPropertiesForRent = new System.Windows.Forms.Label();
            this.txtPropertiesSold = new System.Windows.Forms.TextBox();
            this.lblPropertiesSold = new System.Windows.Forms.Label();
            this.txtGetInTouch = new System.Windows.Forms.TextBox();
            this.lblGetInTouch = new System.Windows.Forms.Label();
            this.gbSelectors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numThreads)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBaseUrl
            // 
            this.lblBaseUrl.AutoSize = true;
            this.lblBaseUrl.Location = new System.Drawing.Point(18, 27);
            this.lblBaseUrl.Name = "lblBaseUrl";
            this.lblBaseUrl.Size = new System.Drawing.Size(63, 20);
            this.lblBaseUrl.TabIndex = 0;
            this.lblBaseUrl.Text = "Base Url";
            // 
            // txtBaseUrl
            // 
            this.txtBaseUrl.Location = new System.Drawing.Point(87, 24);
            this.txtBaseUrl.Name = "txtBaseUrl";
            this.txtBaseUrl.Size = new System.Drawing.Size(731, 27);
            this.txtBaseUrl.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(691, 545);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(127, 38);
            this.btnSave.TabIndex = 28;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // gbSelectors
            // 
            this.gbSelectors.Controls.Add(this.numThreads);
            this.gbSelectors.Controls.Add(this.lblThreadsNumber);
            this.gbSelectors.Controls.Add(this.txtPropertiesForRent);
            this.gbSelectors.Controls.Add(this.lblPropertiesForRent);
            this.gbSelectors.Controls.Add(this.txtPropertiesSold);
            this.gbSelectors.Controls.Add(this.lblPropertiesSold);
            this.gbSelectors.Controls.Add(this.txtGetInTouch);
            this.gbSelectors.Controls.Add(this.lblGetInTouch);
            this.gbSelectors.Location = new System.Drawing.Point(22, 74);
            this.gbSelectors.Name = "gbSelectors";
            this.gbSelectors.Size = new System.Drawing.Size(796, 456);
            this.gbSelectors.TabIndex = 29;
            this.gbSelectors.TabStop = false;
            this.gbSelectors.Text = "The selectors, which change most often for protecting against parsing";
            // 
            // numThreads
            // 
            this.numThreads.Location = new System.Drawing.Point(216, 145);
            this.numThreads.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numThreads.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numThreads.Name = "numThreads";
            this.numThreads.Size = new System.Drawing.Size(56, 27);
            this.numThreads.TabIndex = 3;
            this.numThreads.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numThreads.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // lblThreadsNumber
            // 
            this.lblThreadsNumber.AutoSize = true;
            this.lblThreadsNumber.Location = new System.Drawing.Point(9, 147);
            this.lblThreadsNumber.Name = "lblThreadsNumber";
            this.lblThreadsNumber.Size = new System.Drawing.Size(116, 20);
            this.lblThreadsNumber.TabIndex = 2;
            this.lblThreadsNumber.Text = "Threads number";
            // 
            // txtPropertiesForRent
            // 
            this.txtPropertiesForRent.Location = new System.Drawing.Point(216, 111);
            this.txtPropertiesForRent.Name = "txtPropertiesForRent";
            this.txtPropertiesForRent.Size = new System.Drawing.Size(563, 27);
            this.txtPropertiesForRent.TabIndex = 1;
            // 
            // lblPropertiesForRent
            // 
            this.lblPropertiesForRent.AutoSize = true;
            this.lblPropertiesForRent.Location = new System.Drawing.Point(9, 114);
            this.lblPropertiesForRent.Name = "lblPropertiesForRent";
            this.lblPropertiesForRent.Size = new System.Drawing.Size(199, 20);
            this.lblPropertiesForRent.TabIndex = 0;
            this.lblPropertiesForRent.Text = "Properties For Rent elements";
            // 
            // txtPropertiesSold
            // 
            this.txtPropertiesSold.Location = new System.Drawing.Point(216, 78);
            this.txtPropertiesSold.Name = "txtPropertiesSold";
            this.txtPropertiesSold.Size = new System.Drawing.Size(563, 27);
            this.txtPropertiesSold.TabIndex = 1;
            // 
            // lblPropertiesSold
            // 
            this.lblPropertiesSold.AutoSize = true;
            this.lblPropertiesSold.Location = new System.Drawing.Point(9, 81);
            this.lblPropertiesSold.Name = "lblPropertiesSold";
            this.lblPropertiesSold.Size = new System.Drawing.Size(174, 20);
            this.lblPropertiesSold.TabIndex = 0;
            this.lblPropertiesSold.Text = "Properties Sold elements";
            // 
            // txtGetInTouch
            // 
            this.txtGetInTouch.Location = new System.Drawing.Point(216, 45);
            this.txtGetInTouch.Name = "txtGetInTouch";
            this.txtGetInTouch.Size = new System.Drawing.Size(563, 27);
            this.txtGetInTouch.TabIndex = 1;
            // 
            // lblGetInTouch
            // 
            this.lblGetInTouch.AutoSize = true;
            this.lblGetInTouch.Location = new System.Drawing.Point(9, 48);
            this.lblGetInTouch.Name = "lblGetInTouch";
            this.lblGetInTouch.Size = new System.Drawing.Size(145, 20);
            this.lblGetInTouch.TabIndex = 0;
            this.lblGetInTouch.Text = "Buttons Get In Touch";
            // 
            // SettingsUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbSelectors);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtBaseUrl);
            this.Controls.Add(this.lblBaseUrl);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(830, 603);
            this.Name = "SettingsUC";
            this.Size = new System.Drawing.Size(830, 603);
            this.gbSelectors.ResumeLayout(false);
            this.gbSelectors.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numThreads)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBaseUrl;
        private System.Windows.Forms.TextBox txtBaseUrl;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox gbSelectors;
        private System.Windows.Forms.TextBox txtPropertiesForRent;
        private System.Windows.Forms.Label lblPropertiesForRent;
        private System.Windows.Forms.TextBox txtPropertiesSold;
        private System.Windows.Forms.Label lblPropertiesSold;
        private System.Windows.Forms.TextBox txtGetInTouch;
        private System.Windows.Forms.Label lblGetInTouch;
        private System.Windows.Forms.NumericUpDown numThreads;
        private System.Windows.Forms.Label lblThreadsNumber;
    }
}
