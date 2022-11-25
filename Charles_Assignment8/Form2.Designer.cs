namespace Charles_Assignment8
{
    partial class Form2
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
            this.titleLbl = new System.Windows.Forms.Label();
            this.registeredLstBx = new System.Windows.Forms.ListBox();
            this.childLbl = new System.Windows.Forms.Label();
            this.sportLbl = new System.Windows.Forms.Label();
            this.sportLstBx = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.titleLbl.Location = new System.Drawing.Point(301, 30);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(199, 30);
            this.titleLbl.TabIndex = 0;
            this.titleLbl.Text = "Registered Children";
            // 
            // registeredLstBx
            // 
            this.registeredLstBx.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.registeredLstBx.FormattingEnabled = true;
            this.registeredLstBx.ItemHeight = 25;
            this.registeredLstBx.Location = new System.Drawing.Point(144, 117);
            this.registeredLstBx.Name = "registeredLstBx";
            this.registeredLstBx.Size = new System.Drawing.Size(168, 254);
            this.registeredLstBx.TabIndex = 1;
            // 
            // childLbl
            // 
            this.childLbl.AutoSize = true;
            this.childLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.childLbl.Location = new System.Drawing.Point(175, 93);
            this.childLbl.Name = "childLbl";
            this.childLbl.Size = new System.Drawing.Size(94, 21);
            this.childLbl.TabIndex = 2;
            this.childLbl.Text = "Child Name";
            // 
            // sportLbl
            // 
            this.sportLbl.AutoSize = true;
            this.sportLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sportLbl.Location = new System.Drawing.Point(500, 93);
            this.sportLbl.Name = "sportLbl";
            this.sportLbl.Size = new System.Drawing.Size(133, 21);
            this.sportLbl.TabIndex = 3;
            this.sportLbl.Text = "Registered sport";
            // 
            // sportLstBx
            // 
            this.sportLstBx.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sportLstBx.FormattingEnabled = true;
            this.sportLstBx.ItemHeight = 25;
            this.sportLstBx.Location = new System.Drawing.Point(484, 117);
            this.sportLstBx.Name = "sportLstBx";
            this.sportLstBx.Size = new System.Drawing.Size(168, 254);
            this.sportLstBx.TabIndex = 4;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sportLstBx);
            this.Controls.Add(this.sportLbl);
            this.Controls.Add(this.childLbl);
            this.Controls.Add(this.registeredLstBx);
            this.Controls.Add(this.titleLbl);
            this.Name = "Form2";
            this.Text = "CW: Sports Registration";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label titleLbl;
        private ListBox registeredLstBx;
        private Label childLbl;
        private Label sportLbl;
        private ListBox sportLstBx;
    }
}