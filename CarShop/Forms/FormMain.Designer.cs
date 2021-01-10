namespace CarShop
{
    partial class FormOtomoto
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
            this.ownOffersUserControl = new CarShop.UserControls.OwnOffersUserControl();
            this.offersUserControl = new CarShop.UserControls.OffersUserControl();
            this.loginUserControl = new CarShop.UserControls.LoginUserControl();
            this.SuspendLayout();
            // 
            // ownOffersUserControl
            // 
            this.ownOffersUserControl.BackColor = System.Drawing.Color.Transparent;
            this.ownOffersUserControl.IsHiden = false;
            this.ownOffersUserControl.Location = new System.Drawing.Point(103, 140);
            this.ownOffersUserControl.Name = "ownOffersUserControl";
            this.ownOffersUserControl.Size = new System.Drawing.Size(1018, 543);
            this.ownOffersUserControl.TabIndex = 2;
            this.ownOffersUserControl.Visible = false;
            this.ownOffersUserControl.VisibleChanged += new System.EventHandler(this.ownOffersUserControl_VisibleChanged);
            // 
            // offersUserControl
            // 
            this.offersUserControl.BackColor = System.Drawing.Color.Transparent;
            this.offersUserControl.Location = new System.Drawing.Point(138, 131);
            this.offersUserControl.Name = "offersUserControl";
            this.offersUserControl.Size = new System.Drawing.Size(961, 532);
            this.offersUserControl.TabIndex = 1;
            this.offersUserControl.Visible = false;
            this.offersUserControl.VisibleChanged += new System.EventHandler(this.offersUserControl_VisibleChanged);
            // 
            // loginUserControl
            // 
            this.loginUserControl.BackColor = System.Drawing.Color.Transparent;
            this.loginUserControl.Location = new System.Drawing.Point(368, 131);
            this.loginUserControl.Name = "loginUserControl";
            this.loginUserControl.Size = new System.Drawing.Size(406, 450);
            this.loginUserControl.TabIndex = 0;
            this.loginUserControl.VisibleChanged += new System.EventHandler(this.loginUserControl_VisibleChanged);
            // 
            // FormOtomoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CarShop.Properties.Resources.BackgroundCarShop1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1108, 695);
            this.Controls.Add(this.ownOffersUserControl);
            this.Controls.Add(this.offersUserControl);
            this.Controls.Add(this.loginUserControl);
            this.Name = "FormOtomoto";
            this.Text = "OTOMOTO";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.LoginUserControl loginUserControl1;
        private UserControls.LoginUserControl loginUserControl;
        private UserControls.OffersUserControl offersUserControl;
        private UserControls.OwnOffersUserControl ownOffersUserControl;
    }
}

