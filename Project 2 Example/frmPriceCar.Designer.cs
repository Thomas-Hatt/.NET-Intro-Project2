namespace Project_2_Example
{
    partial class frmPriceCar
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
            this.lstAvailableOptions = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstSelectedOptions = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblSalesTax = new System.Windows.Forms.Label();
            this.lblDestination = new System.Windows.Forms.Label();
            this.lblOptions = new System.Windows.Forms.Label();
            this.lblBasePrice = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tmrCar = new System.Windows.Forms.Timer(this.components);
            this.picCar = new System.Windows.Forms.PictureBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lstAvailableOptions
            // 
            this.lstAvailableOptions.FormattingEnabled = true;
            this.lstAvailableOptions.ItemHeight = 19;
            this.lstAvailableOptions.Items.AddRange(new object[] {
            "Power Windows",
            "Power Doorlocks",
            "Power Mirrors",
            "Automatic Transmission",
            "Cloth Seats",
            "Air Conditioning",
            "Keyless Entry",
            "Floormats",
            "Premium Paint"});
            this.lstAvailableOptions.Location = new System.Drawing.Point(34, 138);
            this.lstAvailableOptions.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstAvailableOptions.Name = "lstAvailableOptions";
            this.lstAvailableOptions.Size = new System.Drawing.Size(190, 194);
            this.lstAvailableOptions.TabIndex = 0;
            this.lstAvailableOptions.DoubleClick += new System.EventHandler(this.lstAvailableOptions_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Available Options";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(295, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Selected Options";
            // 
            // lstSelectedOptions
            // 
            this.lstSelectedOptions.FormattingEnabled = true;
            this.lstSelectedOptions.ItemHeight = 19;
            this.lstSelectedOptions.Location = new System.Drawing.Point(295, 138);
            this.lstSelectedOptions.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstSelectedOptions.Name = "lstSelectedOptions";
            this.lstSelectedOptions.Size = new System.Drawing.Size(190, 194);
            this.lstSelectedOptions.TabIndex = 2;
            this.lstSelectedOptions.DoubleClick += new System.EventHandler(this.lstSelectedOptions_DoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTotal);
            this.groupBox1.Controls.Add(this.lblSalesTax);
            this.groupBox1.Controls.Add(this.lblDestination);
            this.groupBox1.Controls.Add(this.lblOptions);
            this.groupBox1.Controls.Add(this.lblBasePrice);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(530, 120);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 212);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pricing Information";
            // 
            // lblTotal
            // 
            this.lblTotal.Location = new System.Drawing.Point(123, 156);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(166, 19);
            this.lblTotal.TabIndex = 14;
            this.lblTotal.Text = "$0.00";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblSalesTax
            // 
            this.lblSalesTax.Location = new System.Drawing.Point(123, 125);
            this.lblSalesTax.Name = "lblSalesTax";
            this.lblSalesTax.Size = new System.Drawing.Size(166, 19);
            this.lblSalesTax.TabIndex = 13;
            this.lblSalesTax.Text = "$0.00";
            this.lblSalesTax.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblDestination
            // 
            this.lblDestination.Location = new System.Drawing.Point(123, 94);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(166, 19);
            this.lblDestination.TabIndex = 12;
            this.lblDestination.Text = "$0.00";
            this.lblDestination.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblOptions
            // 
            this.lblOptions.Location = new System.Drawing.Point(123, 64);
            this.lblOptions.Name = "lblOptions";
            this.lblOptions.Size = new System.Drawing.Size(166, 19);
            this.lblOptions.TabIndex = 11;
            this.lblOptions.Text = "$0.00";
            this.lblOptions.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblBasePrice
            // 
            this.lblBasePrice.Location = new System.Drawing.Point(123, 36);
            this.lblBasePrice.Name = "lblBasePrice";
            this.lblBasePrice.Size = new System.Drawing.Size(166, 19);
            this.lblBasePrice.TabIndex = 10;
            this.lblBasePrice.Text = "$0.00";
            this.lblBasePrice.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 19);
            this.label7.TabIndex = 9;
            this.label7.Text = "Total:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 19);
            this.label6.TabIndex = 8;
            this.label6.Text = "Sales Tax:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "Destination Fee:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Options:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Base Price:";
            // 
            // tmrCar
            // 
            this.tmrCar.Enabled = true;
            this.tmrCar.Tag = "F";
            this.tmrCar.Tick += new System.EventHandler(this.tmrCar_Tick);
            // 
            // picCar
            // 
            this.picCar.Image = global::Project_2_Example.Properties.Resources.car1;
            this.picCar.Location = new System.Drawing.Point(659, 13);
            this.picCar.Name = "picCar";
            this.picCar.Size = new System.Drawing.Size(166, 74);
            this.picCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCar.TabIndex = 6;
            this.picCar.TabStop = false;
            // 
            // picLogo
            // 
            this.picLogo.Image = global::Project_2_Example.Properties.Resources.logo;
            this.picLogo.Location = new System.Drawing.Point(34, 12);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(213, 75);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 5;
            this.picLogo.TabStop = false;
            // 
            // frmPriceCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(854, 366);
            this.Controls.Add(this.picCar);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstSelectedOptions);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstAvailableOptions);
            this.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmPriceCar";
            this.Text = "EconoCar";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstAvailableOptions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstSelectedOptions;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblSalesTax;
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.Label lblOptions;
        private System.Windows.Forms.Label lblBasePrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.PictureBox picCar;
        private System.Windows.Forms.Timer tmrCar;
    }
}

