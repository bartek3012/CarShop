namespace CarShop.Forms
{
    partial class FormCredit
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
            this.dataGridViewCredits = new System.Windows.Forms.DataGridView();
            this.comboBoxBank = new System.Windows.Forms.ComboBox();
            this.labelBank = new System.Windows.Forms.Label();
            this.comboBoxYears = new System.Windows.Forms.ComboBox();
            this.labelYears = new System.Windows.Forms.Label();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelYourCredits = new System.Windows.Forms.Label();
            this.buttonTakeCredit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCredits)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCredits
            // 
            this.dataGridViewCredits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCredits.Location = new System.Drawing.Point(92, 197);
            this.dataGridViewCredits.Name = "dataGridViewCredits";
            this.dataGridViewCredits.RowHeadersWidth = 51;
            this.dataGridViewCredits.Size = new System.Drawing.Size(605, 122);
            this.dataGridViewCredits.TabIndex = 0;
            // 
            // comboBoxBank
            // 
            this.comboBoxBank.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxBank.FormattingEnabled = true;
            this.comboBoxBank.Items.AddRange(new object[] {
            "ING",
            "Santander",
            "PKO",
            "Milenium",
            "MBank"});
            this.comboBoxBank.Location = new System.Drawing.Point(339, 53);
            this.comboBoxBank.Name = "comboBoxBank";
            this.comboBoxBank.Size = new System.Drawing.Size(121, 28);
            this.comboBoxBank.TabIndex = 1;
            // 
            // labelBank
            // 
            this.labelBank.AutoSize = true;
            this.labelBank.BackColor = System.Drawing.Color.Transparent;
            this.labelBank.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelBank.Location = new System.Drawing.Point(374, 30);
            this.labelBank.Name = "labelBank";
            this.labelBank.Size = new System.Drawing.Size(51, 20);
            this.labelBank.TabIndex = 2;
            this.labelBank.Text = "Bank";
            // 
            // comboBoxYears
            // 
            this.comboBoxYears.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxYears.FormattingEnabled = true;
            this.comboBoxYears.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "20"});
            this.comboBoxYears.Location = new System.Drawing.Point(212, 53);
            this.comboBoxYears.Name = "comboBoxYears";
            this.comboBoxYears.Size = new System.Drawing.Size(121, 28);
            this.comboBoxYears.TabIndex = 3;
            // 
            // labelYears
            // 
            this.labelYears.AutoSize = true;
            this.labelYears.BackColor = System.Drawing.Color.Transparent;
            this.labelYears.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelYears.Location = new System.Drawing.Point(221, 30);
            this.labelYears.Name = "labelYears";
            this.labelYears.Size = new System.Drawing.Size(102, 20);
            this.labelYears.TabIndex = 4;
            this.labelYears.Text = "Lata spłaty";
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxAmount.Location = new System.Drawing.Point(466, 53);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.ReadOnly = true;
            this.textBoxAmount.Size = new System.Drawing.Size(121, 27);
            this.textBoxAmount.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(501, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Kowta";
            // 
            // labelYourCredits
            // 
            this.labelYourCredits.AutoSize = true;
            this.labelYourCredits.BackColor = System.Drawing.Color.Transparent;
            this.labelYourCredits.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelYourCredits.Location = new System.Drawing.Point(302, 165);
            this.labelYourCredits.Name = "labelYourCredits";
            this.labelYourCredits.Size = new System.Drawing.Size(176, 29);
            this.labelYourCredits.TabIndex = 7;
            this.labelYourCredits.Text = "Twoje kredyty";
            // 
            // buttonTakeCredit
            // 
            this.buttonTakeCredit.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.buttonTakeCredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonTakeCredit.Location = new System.Drawing.Point(307, 99);
            this.buttonTakeCredit.Name = "buttonTakeCredit";
            this.buttonTakeCredit.Size = new System.Drawing.Size(171, 42);
            this.buttonTakeCredit.TabIndex = 8;
            this.buttonTakeCredit.Text = "Weź kredyt!";
            this.buttonTakeCredit.UseVisualStyleBackColor = false;
            this.buttonTakeCredit.Click += new System.EventHandler(this.buttonTakeCredit_Click);
            // 
            // FormCredit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CarShop.Properties.Resources.CreditBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(754, 353);
            this.Controls.Add(this.buttonTakeCredit);
            this.Controls.Add(this.labelYourCredits);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxAmount);
            this.Controls.Add(this.labelYears);
            this.Controls.Add(this.comboBoxYears);
            this.Controls.Add(this.labelBank);
            this.Controls.Add(this.comboBoxBank);
            this.Controls.Add(this.dataGridViewCredits);
            this.Name = "FormCredit";
            this.Text = "FormCredit";
            this.Load += new System.EventHandler(this.FormCredit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCredits)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCredits;
        private System.Windows.Forms.ComboBox comboBoxBank;
        private System.Windows.Forms.Label labelBank;
        private System.Windows.Forms.ComboBox comboBoxYears;
        private System.Windows.Forms.Label labelYears;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelYourCredits;
        private System.Windows.Forms.Button buttonTakeCredit;
    }
}