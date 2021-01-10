namespace CarShop.UserControls
{
    partial class OwnOffersUserControl
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
            this.dataGridViewOwnOffers = new System.Windows.Forms.DataGridView();
            this.textBoxPirceChange = new System.Windows.Forms.TextBox();
            this.buttonPriceChange = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.labelBrand = new System.Windows.Forms.Label();
            this.comboBoxBrand = new System.Windows.Forms.ComboBox();
            this.labelType = new System.Windows.Forms.Label();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.labelEquipment = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.textBoxPriceSet = new System.Windows.Forms.TextBox();
            this.labelYear = new System.Windows.Forms.Label();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonAddOffer = new System.Windows.Forms.Button();
            this.checkBoxABS = new System.Windows.Forms.CheckBox();
            this.checkBoxRainSensor = new System.Windows.Forms.CheckBox();
            this.checkBoxParkingSensor = new System.Windows.Forms.CheckBox();
            this.checkBoxGPS = new System.Windows.Forms.CheckBox();
            this.checkBoxAirCondition = new System.Windows.Forms.CheckBox();
            this.checkBoxASR = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOwnOffers)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewOwnOffers
            // 
            this.dataGridViewOwnOffers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOwnOffers.Location = new System.Drawing.Point(145, 101);
            this.dataGridViewOwnOffers.Name = "dataGridViewOwnOffers";
            this.dataGridViewOwnOffers.RowHeadersWidth = 51;
            this.dataGridViewOwnOffers.RowTemplate.Height = 24;
            this.dataGridViewOwnOffers.Size = new System.Drawing.Size(604, 152);
            this.dataGridViewOwnOffers.TabIndex = 0;
            this.dataGridViewOwnOffers.SelectionChanged += new System.EventHandler(this.dataGridViewOwnOffers_SelectionChanged);
            // 
            // textBoxPirceChange
            // 
            this.textBoxPirceChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxPirceChange.Location = new System.Drawing.Point(279, 65);
            this.textBoxPirceChange.Name = "textBoxPirceChange";
            this.textBoxPirceChange.Size = new System.Drawing.Size(165, 30);
            this.textBoxPirceChange.TabIndex = 1;
            // 
            // buttonPriceChange
            // 
            this.buttonPriceChange.BackColor = System.Drawing.Color.Blue;
            this.buttonPriceChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPriceChange.ForeColor = System.Drawing.Color.White;
            this.buttonPriceChange.Location = new System.Drawing.Point(279, 0);
            this.buttonPriceChange.Name = "buttonPriceChange";
            this.buttonPriceChange.Size = new System.Drawing.Size(165, 59);
            this.buttonPriceChange.TabIndex = 2;
            this.buttonPriceChange.Text = "Zmień cene";
            this.buttonPriceChange.UseVisualStyleBackColor = false;
            this.buttonPriceChange.Click += new System.EventHandler(this.buttonPriceChange_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1013, 536);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Red;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDelete.ForeColor = System.Drawing.Color.White;
            this.buttonDelete.Location = new System.Drawing.Point(470, 0);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(165, 59);
            this.buttonDelete.TabIndex = 4;
            this.buttonDelete.Text = "Usuń ogłoszenie";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // labelBrand
            // 
            this.labelBrand.AutoSize = true;
            this.labelBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelBrand.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelBrand.Location = new System.Drawing.Point(141, 256);
            this.labelBrand.Name = "labelBrand";
            this.labelBrand.Size = new System.Drawing.Size(61, 24);
            this.labelBrand.TabIndex = 5;
            this.labelBrand.Text = "Marka";
            // 
            // comboBoxBrand
            // 
            this.comboBoxBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxBrand.FormattingEnabled = true;
            this.comboBoxBrand.Items.AddRange(new object[] {
            "BMW",
            "Fiat",
            "Mercedes",
            "Toyota",
            "Honda",
            "Ford",
            "Audi",
            "Skoda"});
            this.comboBoxBrand.Location = new System.Drawing.Point(145, 283);
            this.comboBoxBrand.Name = "comboBoxBrand";
            this.comboBoxBrand.Size = new System.Drawing.Size(121, 30);
            this.comboBoxBrand.TabIndex = 7;
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelType.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelType.Location = new System.Drawing.Point(141, 328);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(42, 24);
            this.labelType.TabIndex = 8;
            this.labelType.Text = "Typ";
            // 
            // comboBoxType
            // 
            this.comboBoxType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Sedan",
            "Combi",
            "Minivan",
            "SUV"});
            this.comboBoxType.Location = new System.Drawing.Point(145, 355);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(121, 30);
            this.comboBoxType.TabIndex = 9;
            // 
            // labelEquipment
            // 
            this.labelEquipment.AutoSize = true;
            this.labelEquipment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelEquipment.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelEquipment.Location = new System.Drawing.Point(527, 256);
            this.labelEquipment.Name = "labelEquipment";
            this.labelEquipment.Size = new System.Drawing.Size(124, 24);
            this.labelEquipment.TabIndex = 10;
            this.labelEquipment.Text = "Wyposażenie";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPrice.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelPrice.Location = new System.Drawing.Point(327, 256);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(55, 24);
            this.labelPrice.TabIndex = 11;
            this.labelPrice.Text = "Cena";
            // 
            // textBoxPriceSet
            // 
            this.textBoxPriceSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxPriceSet.Location = new System.Drawing.Point(331, 283);
            this.textBoxPriceSet.Name = "textBoxPriceSet";
            this.textBoxPriceSet.Size = new System.Drawing.Size(147, 28);
            this.textBoxPriceSet.TabIndex = 12;
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelYear.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelYear.Location = new System.Drawing.Point(327, 330);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(125, 24);
            this.labelYear.TabIndex = 13;
            this.labelYear.Text = "Rok produkcji";
            // 
            // textBoxYear
            // 
            this.textBoxYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxYear.Location = new System.Drawing.Point(331, 357);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(147, 28);
            this.textBoxYear.TabIndex = 14;
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.Blue;
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonBack.ForeColor = System.Drawing.Color.White;
            this.buttonBack.Location = new System.Drawing.Point(145, 421);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(165, 59);
            this.buttonBack.TabIndex = 15;
            this.buttonBack.Text = "Powrót";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonAddOffer
            // 
            this.buttonAddOffer.BackColor = System.Drawing.Color.Red;
            this.buttonAddOffer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAddOffer.ForeColor = System.Drawing.Color.White;
            this.buttonAddOffer.Location = new System.Drawing.Point(331, 421);
            this.buttonAddOffer.Name = "buttonAddOffer";
            this.buttonAddOffer.Size = new System.Drawing.Size(165, 59);
            this.buttonAddOffer.TabIndex = 16;
            this.buttonAddOffer.Text = "Dodaj ogłoszenie";
            this.buttonAddOffer.UseVisualStyleBackColor = false;
            this.buttonAddOffer.Click += new System.EventHandler(this.buttonAddOffer_Click);
            // 
            // checkBoxABS
            // 
            this.checkBoxABS.AutoSize = true;
            this.checkBoxABS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBoxABS.Location = new System.Drawing.Point(531, 291);
            this.checkBoxABS.Name = "checkBoxABS";
            this.checkBoxABS.Size = new System.Drawing.Size(69, 28);
            this.checkBoxABS.TabIndex = 17;
            this.checkBoxABS.Text = "ABS";
            this.checkBoxABS.UseVisualStyleBackColor = true;
            // 
            // checkBoxRainSensor
            // 
            this.checkBoxRainSensor.AutoSize = true;
            this.checkBoxRainSensor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBoxRainSensor.Location = new System.Drawing.Point(531, 452);
            this.checkBoxRainSensor.Name = "checkBoxRainSensor";
            this.checkBoxRainSensor.Size = new System.Drawing.Size(168, 28);
            this.checkBoxRainSensor.TabIndex = 18;
            this.checkBoxRainSensor.Text = "Czujnik deszczu";
            this.checkBoxRainSensor.UseVisualStyleBackColor = true;
            // 
            // checkBoxParkingSensor
            // 
            this.checkBoxParkingSensor.AutoSize = true;
            this.checkBoxParkingSensor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBoxParkingSensor.Location = new System.Drawing.Point(531, 421);
            this.checkBoxParkingSensor.Name = "checkBoxParkingSensor";
            this.checkBoxParkingSensor.Size = new System.Drawing.Size(194, 28);
            this.checkBoxParkingSensor.TabIndex = 19;
            this.checkBoxParkingSensor.Text = "Czujnik parkowania";
            this.checkBoxParkingSensor.UseVisualStyleBackColor = true;
            // 
            // checkBoxGPS
            // 
            this.checkBoxGPS.AutoSize = true;
            this.checkBoxGPS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBoxGPS.Location = new System.Drawing.Point(531, 389);
            this.checkBoxGPS.Name = "checkBoxGPS";
            this.checkBoxGPS.Size = new System.Drawing.Size(70, 28);
            this.checkBoxGPS.TabIndex = 20;
            this.checkBoxGPS.Text = "GPS";
            this.checkBoxGPS.UseVisualStyleBackColor = true;
            // 
            // checkBoxAirCondition
            // 
            this.checkBoxAirCondition.AutoSize = true;
            this.checkBoxAirCondition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBoxAirCondition.Location = new System.Drawing.Point(531, 355);
            this.checkBoxAirCondition.Name = "checkBoxAirCondition";
            this.checkBoxAirCondition.Size = new System.Drawing.Size(134, 28);
            this.checkBoxAirCondition.TabIndex = 21;
            this.checkBoxAirCondition.Text = "Klimatyzacja";
            this.checkBoxAirCondition.UseVisualStyleBackColor = true;
            // 
            // checkBoxASR
            // 
            this.checkBoxASR.AutoSize = true;
            this.checkBoxASR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBoxASR.Location = new System.Drawing.Point(531, 324);
            this.checkBoxASR.Name = "checkBoxASR";
            this.checkBoxASR.Size = new System.Drawing.Size(70, 28);
            this.checkBoxASR.TabIndex = 22;
            this.checkBoxASR.Text = "ASR";
            this.checkBoxASR.UseVisualStyleBackColor = true;
            // 
            // OwnOffersUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.checkBoxASR);
            this.Controls.Add(this.checkBoxAirCondition);
            this.Controls.Add(this.checkBoxGPS);
            this.Controls.Add(this.checkBoxParkingSensor);
            this.Controls.Add(this.checkBoxRainSensor);
            this.Controls.Add(this.checkBoxABS);
            this.Controls.Add(this.buttonAddOffer);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.textBoxYear);
            this.Controls.Add(this.labelYear);
            this.Controls.Add(this.textBoxPriceSet);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelEquipment);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.comboBoxBrand);
            this.Controls.Add(this.labelBrand);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonPriceChange);
            this.Controls.Add(this.textBoxPirceChange);
            this.Controls.Add(this.dataGridViewOwnOffers);
            this.Name = "OwnOffersUserControl";
            this.Size = new System.Drawing.Size(891, 483);
            this.VisibleChanged += new System.EventHandler(this.OwnOffersUserControl_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOwnOffers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewOwnOffers;
        private System.Windows.Forms.TextBox textBoxPirceChange;
        private System.Windows.Forms.Button buttonPriceChange;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label labelBrand;
        private System.Windows.Forms.ComboBox comboBoxBrand;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Label labelEquipment;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.TextBox textBoxPriceSet;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonAddOffer;
        private System.Windows.Forms.CheckBox checkBoxABS;
        private System.Windows.Forms.CheckBox checkBoxRainSensor;
        private System.Windows.Forms.CheckBox checkBoxParkingSensor;
        private System.Windows.Forms.CheckBox checkBoxGPS;
        private System.Windows.Forms.CheckBox checkBoxAirCondition;
        private System.Windows.Forms.CheckBox checkBoxASR;
    }
}
