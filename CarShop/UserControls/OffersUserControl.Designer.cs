namespace CarShop.UserControls
{
    partial class OffersUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewOffers = new System.Windows.Forms.DataGridView();
            this.labelDetails = new System.Windows.Forms.Label();
            this.labelBrandHead = new System.Windows.Forms.Label();
            this.labelBrand = new System.Windows.Forms.Label();
            this.labelTypeHead = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.labelYearHead = new System.Windows.Forms.Label();
            this.labelYear = new System.Windows.Forms.Label();
            this.labelPriceHeader = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelFirstNameHead = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelLastNameHead = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelEquipmnetHead = new System.Windows.Forms.Label();
            this.labelEquipment = new System.Windows.Forms.Label();
            this.buttonCredit = new System.Windows.Forms.Button();
            this.buttonOwnOffers = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOffers)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewOffers
            // 
            this.dataGridViewOffers.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridViewOffers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOffers.GridColor = System.Drawing.SystemColors.HotTrack;
            this.dataGridViewOffers.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.dataGridViewOffers.Location = new System.Drawing.Point(31, 78);
            this.dataGridViewOffers.Name = "dataGridViewOffers";
            this.dataGridViewOffers.RowHeadersWidth = 51;
            this.dataGridViewOffers.RowTemplate.Height = 24;
            this.dataGridViewOffers.Size = new System.Drawing.Size(893, 159);
            this.dataGridViewOffers.TabIndex = 0;
            this.dataGridViewOffers.SelectionChanged += new System.EventHandler(this.dataGridViewOffers_SelectionChanged);
            // 
            // labelDetails
            // 
            this.labelDetails.AutoSize = true;
            this.labelDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDetails.Location = new System.Drawing.Point(304, 259);
            this.labelDetails.Name = "labelDetails";
            this.labelDetails.Size = new System.Drawing.Size(344, 32);
            this.labelDetails.TabIndex = 3;
            this.labelDetails.Text = "Szczegółowe informacje";
            // 
            // labelBrandHead
            // 
            this.labelBrandHead.AutoSize = true;
            this.labelBrandHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelBrandHead.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelBrandHead.Location = new System.Drawing.Point(28, 310);
            this.labelBrandHead.Name = "labelBrandHead";
            this.labelBrandHead.Size = new System.Drawing.Size(61, 24);
            this.labelBrandHead.TabIndex = 5;
            this.labelBrandHead.Text = "Marka";
            // 
            // labelBrand
            // 
            this.labelBrand.AutoSize = true;
            this.labelBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelBrand.ForeColor = System.Drawing.Color.Black;
            this.labelBrand.Location = new System.Drawing.Point(27, 334);
            this.labelBrand.Name = "labelBrand";
            this.labelBrand.Size = new System.Drawing.Size(95, 29);
            this.labelBrand.TabIndex = 6;
            this.labelBrand.Text = "(Marka)";
            // 
            // labelTypeHead
            // 
            this.labelTypeHead.AutoSize = true;
            this.labelTypeHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTypeHead.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelTypeHead.Location = new System.Drawing.Point(27, 382);
            this.labelTypeHead.Name = "labelTypeHead";
            this.labelTypeHead.Size = new System.Drawing.Size(42, 24);
            this.labelTypeHead.TabIndex = 7;
            this.labelTypeHead.Text = "Typ";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelType.ForeColor = System.Drawing.Color.Black;
            this.labelType.Location = new System.Drawing.Point(26, 406);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(70, 29);
            this.labelType.TabIndex = 8;
            this.labelType.Text = "(Typ)";
            // 
            // labelYearHead
            // 
            this.labelYearHead.AutoSize = true;
            this.labelYearHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelYearHead.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelYearHead.Location = new System.Drawing.Point(176, 310);
            this.labelYearHead.Name = "labelYearHead";
            this.labelYearHead.Size = new System.Drawing.Size(77, 24);
            this.labelYearHead.TabIndex = 9;
            this.labelYearHead.Text = "Rocznik";
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelYear.ForeColor = System.Drawing.Color.Black;
            this.labelYear.Location = new System.Drawing.Point(176, 334);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(114, 29);
            this.labelYear.TabIndex = 10;
            this.labelYear.Text = "(Rocznik)";
            // 
            // labelPriceHeader
            // 
            this.labelPriceHeader.AutoSize = true;
            this.labelPriceHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPriceHeader.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelPriceHeader.Location = new System.Drawing.Point(176, 382);
            this.labelPriceHeader.Name = "labelPriceHeader";
            this.labelPriceHeader.Size = new System.Drawing.Size(55, 24);
            this.labelPriceHeader.TabIndex = 11;
            this.labelPriceHeader.Text = "Cena";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPrice.ForeColor = System.Drawing.Color.Black;
            this.labelPrice.Location = new System.Drawing.Point(176, 406);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(86, 29);
            this.labelPrice.TabIndex = 12;
            this.labelPrice.Text = "(Cena)";
            // 
            // labelFirstNameHead
            // 
            this.labelFirstNameHead.AutoSize = true;
            this.labelFirstNameHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelFirstNameHead.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelFirstNameHead.Location = new System.Drawing.Point(339, 310);
            this.labelFirstNameHead.Name = "labelFirstNameHead";
            this.labelFirstNameHead.Size = new System.Drawing.Size(144, 24);
            this.labelFirstNameHead.TabIndex = 13;
            this.labelFirstNameHead.Text = "Imie właściciela";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelFirstName.ForeColor = System.Drawing.Color.Black;
            this.labelFirstName.Location = new System.Drawing.Point(338, 334);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(75, 29);
            this.labelFirstName.TabIndex = 14;
            this.labelFirstName.Text = "(Imię)";
            // 
            // labelLastNameHead
            // 
            this.labelLastNameHead.AutoSize = true;
            this.labelLastNameHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLastNameHead.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelLastNameHead.Location = new System.Drawing.Point(339, 382);
            this.labelLastNameHead.Name = "labelLastNameHead";
            this.labelLastNameHead.Size = new System.Drawing.Size(189, 24);
            this.labelLastNameHead.TabIndex = 15;
            this.labelLastNameHead.Text = "Nazwisko właściciela";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLastName.ForeColor = System.Drawing.Color.Black;
            this.labelLastName.Location = new System.Drawing.Point(338, 406);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(133, 29);
            this.labelLastName.TabIndex = 16;
            this.labelLastName.Text = "(Nazwisko)";
            // 
            // labelEquipmnetHead
            // 
            this.labelEquipmnetHead.AutoSize = true;
            this.labelEquipmnetHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelEquipmnetHead.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelEquipmnetHead.Location = new System.Drawing.Point(550, 310);
            this.labelEquipmnetHead.Name = "labelEquipmnetHead";
            this.labelEquipmnetHead.Size = new System.Drawing.Size(124, 24);
            this.labelEquipmnetHead.TabIndex = 17;
            this.labelEquipmnetHead.Text = "Wyposażenie";
            // 
            // labelEquipment
            // 
            this.labelEquipment.AutoSize = true;
            this.labelEquipment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelEquipment.ForeColor = System.Drawing.Color.Black;
            this.labelEquipment.Location = new System.Drawing.Point(549, 334);
            this.labelEquipment.Name = "labelEquipment";
            this.labelEquipment.Size = new System.Drawing.Size(132, 24);
            this.labelEquipment.TabIndex = 18;
            this.labelEquipment.Text = "(wyposażenie)";
            // 
            // buttonCredit
            // 
            this.buttonCredit.BackColor = System.Drawing.Color.Red;
            this.buttonCredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonCredit.ForeColor = System.Drawing.Color.White;
            this.buttonCredit.Location = new System.Drawing.Point(758, 334);
            this.buttonCredit.Name = "buttonCredit";
            this.buttonCredit.Size = new System.Drawing.Size(166, 72);
            this.buttonCredit.TabIndex = 19;
            this.buttonCredit.Text = "Weź kredyt!";
            this.buttonCredit.UseVisualStyleBackColor = false;
            this.buttonCredit.Click += new System.EventHandler(this.buttonCredit_Click);
            // 
            // buttonOwnOffers
            // 
            this.buttonOwnOffers.BackColor = System.Drawing.Color.Blue;
            this.buttonOwnOffers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonOwnOffers.ForeColor = System.Drawing.Color.White;
            this.buttonOwnOffers.Location = new System.Drawing.Point(393, 0);
            this.buttonOwnOffers.Name = "buttonOwnOffers";
            this.buttonOwnOffers.Size = new System.Drawing.Size(166, 52);
            this.buttonOwnOffers.TabIndex = 21;
            this.buttonOwnOffers.Text = "Moje aukcje";
            this.buttonOwnOffers.UseVisualStyleBackColor = false;
            this.buttonOwnOffers.Click += new System.EventHandler(this.buttonOwnOffers_Click);
            // 
            // OffersUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.buttonOwnOffers);
            this.Controls.Add(this.buttonCredit);
            this.Controls.Add(this.labelEquipment);
            this.Controls.Add(this.labelEquipmnetHead);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelLastNameHead);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.labelFirstNameHead);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelPriceHeader);
            this.Controls.Add(this.labelYear);
            this.Controls.Add(this.labelYearHead);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.labelTypeHead);
            this.Controls.Add(this.labelBrand);
            this.Controls.Add(this.labelBrandHead);
            this.Controls.Add(this.labelDetails);
            this.Controls.Add(this.dataGridViewOffers);
            this.Name = "OffersUserControl";
            this.Size = new System.Drawing.Size(986, 579);
            this.Load += new System.EventHandler(this.OffersUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOffers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewOffers;
        private System.Windows.Forms.Label labelDetails;
        private System.Windows.Forms.Label labelBrandHead;
        private System.Windows.Forms.Label labelBrand;
        private System.Windows.Forms.Label labelTypeHead;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelYearHead;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.Label labelPriceHeader;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelFirstNameHead;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelLastNameHead;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelEquipmnetHead;
        private System.Windows.Forms.Label labelEquipment;
        private System.Windows.Forms.Button buttonCredit;
        private System.Windows.Forms.Button buttonOwnOffers;
    }
}
