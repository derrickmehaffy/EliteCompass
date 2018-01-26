namespace Elite_Compass
{
    partial class Heading
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
            this.setButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.latLng = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.longitudeLabel = new System.Windows.Forms.Label();
            this.Longitude = new System.Windows.Forms.TextBox();
            this.latitudeLabel = new System.Windows.Forms.Label();
            this.Latitude = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // setButton
            // 
            this.setButton.Location = new System.Drawing.Point(239, 122);
            this.setButton.Name = "setButton";
            this.setButton.Size = new System.Drawing.Size(75, 23);
            this.setButton.TabIndex = 4;
            this.setButton.Text = "&Set";
            this.setButton.UseVisualStyleBackColor = true;
            this.setButton.Click += new System.EventHandler(this.setButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(320, 122);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Lat/Lng:";
            // 
            // latLng
            // 
            this.latLng.Location = new System.Drawing.Point(79, 12);
            this.latLng.Name = "latLng";
            this.latLng.Size = new System.Drawing.Size(316, 20);
            this.latLng.TabIndex = 0;
            this.latLng.TextChanged += new System.EventHandler(this.latLng_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.longitudeLabel);
            this.groupBox1.Controls.Add(this.Longitude);
            this.groupBox1.Controls.Add(this.latitudeLabel);
            this.groupBox1.Controls.Add(this.Latitude);
            this.groupBox1.Location = new System.Drawing.Point(15, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(380, 73);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bearing";
            // 
            // longitudeLabel
            // 
            this.longitudeLabel.AutoSize = true;
            this.longitudeLabel.Location = new System.Drawing.Point(196, 33);
            this.longitudeLabel.Name = "longitudeLabel";
            this.longitudeLabel.Size = new System.Drawing.Size(57, 13);
            this.longitudeLabel.TabIndex = 7;
            this.longitudeLabel.Text = "Longitude:";
            // 
            // Longitude
            // 
            this.Longitude.Location = new System.Drawing.Point(263, 30);
            this.Longitude.Name = "Longitude";
            this.Longitude.Size = new System.Drawing.Size(100, 20);
            this.Longitude.TabIndex = 2;
            // 
            // latitudeLabel
            // 
            this.latitudeLabel.AutoSize = true;
            this.latitudeLabel.Location = new System.Drawing.Point(14, 33);
            this.latitudeLabel.Name = "latitudeLabel";
            this.latitudeLabel.Size = new System.Drawing.Size(48, 13);
            this.latitudeLabel.TabIndex = 5;
            this.latitudeLabel.Text = "Latitude:";
            // 
            // Latitude
            // 
            this.Latitude.Location = new System.Drawing.Point(81, 30);
            this.Latitude.Name = "Latitude";
            this.Latitude.Size = new System.Drawing.Size(100, 20);
            this.Latitude.TabIndex = 1;
            // 
            // Heading
            // 
            this.AcceptButton = this.setButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(407, 159);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.latLng);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.setButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Heading";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Heading";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Heading_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button setButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox latLng;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label longitudeLabel;
        private System.Windows.Forms.TextBox Longitude;
        private System.Windows.Forms.Label latitudeLabel;
        private System.Windows.Forms.TextBox Latitude;
    }
}