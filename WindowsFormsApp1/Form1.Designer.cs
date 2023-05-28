namespace WindowsFormsApp1
{
    partial class Form1
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
            this.openLine = new System.Windows.Forms.Label();
            this.Line2 = new System.Windows.Forms.Label();
            this.madeBy = new System.Windows.Forms.Label();
            this.FourWheelsButton = new System.Windows.Forms.Button();
            this.TwoWheelsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openLine
            // 
            this.openLine.AutoSize = true;
            this.openLine.BackColor = System.Drawing.Color.Transparent;
            this.openLine.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.openLine.ForeColor = System.Drawing.Color.RosyBrown;
            this.openLine.Location = new System.Drawing.Point(83, 9);
            this.openLine.Name = "openLine";
            this.openLine.Size = new System.Drawing.Size(590, 37);
            this.openLine.TabIndex = 0;
            this.openLine.Text = "Welcome to vehicle reccomandations";
            // 
            // Line2
            // 
            this.Line2.AutoSize = true;
            this.Line2.BackColor = System.Drawing.Color.Transparent;
            this.Line2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Line2.ForeColor = System.Drawing.Color.MistyRose;
            this.Line2.Location = new System.Drawing.Point(164, 46);
            this.Line2.Name = "Line2";
            this.Line2.Size = new System.Drawing.Size(387, 22);
            this.Line2.TabIndex = 1;
            this.Line2.Text = "What kind of vehicle are you looking for?";
            // 
            // madeBy
            // 
            this.madeBy.AutoSize = true;
            this.madeBy.BackColor = System.Drawing.Color.Transparent;
            this.madeBy.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.madeBy.ForeColor = System.Drawing.Color.RosyBrown;
            this.madeBy.Location = new System.Drawing.Point(303, 621);
            this.madeBy.Name = "madeBy";
            this.madeBy.Size = new System.Drawing.Size(80, 14);
            this.madeBy.TabIndex = 2;
            this.madeBy.Text = "made by ANA";
            // 
            // FourWheelsButton
            // 
            this.FourWheelsButton.BackColor = System.Drawing.Color.DarkGray;
            this.FourWheelsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FourWheelsButton.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.FourWheelsButton.Location = new System.Drawing.Point(81, 147);
            this.FourWheelsButton.Name = "FourWheelsButton";
            this.FourWheelsButton.Size = new System.Drawing.Size(189, 54);
            this.FourWheelsButton.TabIndex = 3;
            this.FourWheelsButton.Text = "Four Wheels";
            this.FourWheelsButton.UseVisualStyleBackColor = false;
            this.FourWheelsButton.Click += new System.EventHandler(this.FourWheelsButton_Click);
            // 
            // TwoWheelsButton
            // 
            this.TwoWheelsButton.BackColor = System.Drawing.Color.DarkGray;
            this.TwoWheelsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TwoWheelsButton.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.TwoWheelsButton.ForeColor = System.Drawing.Color.Black;
            this.TwoWheelsButton.Location = new System.Drawing.Point(475, 149);
            this.TwoWheelsButton.Name = "TwoWheelsButton";
            this.TwoWheelsButton.Size = new System.Drawing.Size(189, 54);
            this.TwoWheelsButton.TabIndex = 4;
            this.TwoWheelsButton.Text = "Two Wheels";
            this.TwoWheelsButton.UseVisualStyleBackColor = false;
            this.TwoWheelsButton.Click += new System.EventHandler(this.TwoWheelsButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.josh_berquist__4sWbzH5fp8_unsplash;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(735, 644);
            this.Controls.Add(this.TwoWheelsButton);
            this.Controls.Add(this.FourWheelsButton);
            this.Controls.Add(this.madeBy);
            this.Controls.Add(this.Line2);
            this.Controls.Add(this.openLine);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label openLine;
        private System.Windows.Forms.Label Line2;
        private System.Windows.Forms.Label madeBy;
        private System.Windows.Forms.Button FourWheelsButton;
        private System.Windows.Forms.Button TwoWheelsButton;
    }
}

