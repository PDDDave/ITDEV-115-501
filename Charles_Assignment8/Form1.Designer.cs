namespace Charles_Assignment8
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lessonChoiceGrpBx = new System.Windows.Forms.GroupBox();
            this.ultFrisRdBtn = new System.Windows.Forms.RadioButton();
            this.fieldHocRdBtn = new System.Windows.Forms.RadioButton();
            this.sftBallRdBtn = new System.Windows.Forms.RadioButton();
            this.bladeRdBtn = new System.Windows.Forms.RadioButton();
            this.skateRdBtn = new System.Windows.Forms.RadioButton();
            this.mainPicBx = new System.Windows.Forms.PictureBox();
            this.titleLbl = new System.Windows.Forms.Label();
            this.nameLbl = new System.Windows.Forms.Label();
            this.addressLbl = new System.Windows.Forms.Label();
            this.cityLbl = new System.Windows.Forms.Label();
            this.stateLbl = new System.Windows.Forms.Label();
            this.cityTxtBx = new System.Windows.Forms.TextBox();
            this.addressTxtBx = new System.Windows.Forms.TextBox();
            this.nameTxtBx = new System.Windows.Forms.TextBox();
            this.stateCmboBx = new System.Windows.Forms.ComboBox();
            this.captionTxtBx = new System.Windows.Forms.TextBox();
            this.registerBtn = new System.Windows.Forms.Button();
            this.lessonChoiceGrpBx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainPicBx)).BeginInit();
            this.SuspendLayout();
            // 
            // lessonChoiceGrpBx
            // 
            this.lessonChoiceGrpBx.Controls.Add(this.ultFrisRdBtn);
            this.lessonChoiceGrpBx.Controls.Add(this.fieldHocRdBtn);
            this.lessonChoiceGrpBx.Controls.Add(this.sftBallRdBtn);
            this.lessonChoiceGrpBx.Controls.Add(this.bladeRdBtn);
            this.lessonChoiceGrpBx.Controls.Add(this.skateRdBtn);
            this.lessonChoiceGrpBx.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lessonChoiceGrpBx.Location = new System.Drawing.Point(22, 200);
            this.lessonChoiceGrpBx.Name = "lessonChoiceGrpBx";
            this.lessonChoiceGrpBx.Size = new System.Drawing.Size(168, 152);
            this.lessonChoiceGrpBx.TabIndex = 99;
            this.lessonChoiceGrpBx.TabStop = false;
            this.lessonChoiceGrpBx.Text = "Sporting Events";
            // 
            // ultFrisRdBtn
            // 
            this.ultFrisRdBtn.AutoSize = true;
            this.ultFrisRdBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ultFrisRdBtn.Location = new System.Drawing.Point(6, 122);
            this.ultFrisRdBtn.Name = "ultFrisRdBtn";
            this.ultFrisRdBtn.Size = new System.Drawing.Size(147, 25);
            this.ultFrisRdBtn.TabIndex = 8;
            this.ultFrisRdBtn.Text = "Ultimate Frisbee";
            this.ultFrisRdBtn.UseVisualStyleBackColor = true;
            this.ultFrisRdBtn.CheckedChanged += new System.EventHandler(this.ultFrisRdBtn_CheckedChanged);
            // 
            // fieldHocRdBtn
            // 
            this.fieldHocRdBtn.AutoSize = true;
            this.fieldHocRdBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.fieldHocRdBtn.Location = new System.Drawing.Point(6, 22);
            this.fieldHocRdBtn.Name = "fieldHocRdBtn";
            this.fieldHocRdBtn.Size = new System.Drawing.Size(122, 25);
            this.fieldHocRdBtn.TabIndex = 4;
            this.fieldHocRdBtn.Text = "Field Hockey";
            this.fieldHocRdBtn.UseVisualStyleBackColor = true;
            this.fieldHocRdBtn.CheckedChanged += new System.EventHandler(this.fieldHocRdBtn_CheckedChanged);
            // 
            // sftBallRdBtn
            // 
            this.sftBallRdBtn.AutoSize = true;
            this.sftBallRdBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sftBallRdBtn.Location = new System.Drawing.Point(6, 97);
            this.sftBallRdBtn.Name = "sftBallRdBtn";
            this.sftBallRdBtn.Size = new System.Drawing.Size(85, 25);
            this.sftBallRdBtn.TabIndex = 7;
            this.sftBallRdBtn.Text = "Softball";
            this.sftBallRdBtn.UseVisualStyleBackColor = true;
            this.sftBallRdBtn.CheckedChanged += new System.EventHandler(this.sftBallRdBtn_CheckedChanged);
            // 
            // bladeRdBtn
            // 
            this.bladeRdBtn.AutoSize = true;
            this.bladeRdBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bladeRdBtn.Location = new System.Drawing.Point(6, 47);
            this.bladeRdBtn.Name = "bladeRdBtn";
            this.bladeRdBtn.Size = new System.Drawing.Size(126, 25);
            this.bladeRdBtn.TabIndex = 5;
            this.bladeRdBtn.Text = "Rollerblading";
            this.bladeRdBtn.UseVisualStyleBackColor = true;
            this.bladeRdBtn.CheckedChanged += new System.EventHandler(this.bladeRdBtn_CheckedChanged);
            // 
            // skateRdBtn
            // 
            this.skateRdBtn.AutoSize = true;
            this.skateRdBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.skateRdBtn.Location = new System.Drawing.Point(6, 72);
            this.skateRdBtn.Name = "skateRdBtn";
            this.skateRdBtn.Size = new System.Drawing.Size(135, 25);
            this.skateRdBtn.TabIndex = 6;
            this.skateRdBtn.Text = "Skateboarding";
            this.skateRdBtn.UseVisualStyleBackColor = true;
            this.skateRdBtn.CheckedChanged += new System.EventHandler(this.skateRdBtn_CheckedChanged);
            // 
            // mainPicBx
            // 
            this.mainPicBx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainPicBx.Image = global::Charles_Assignment8.Properties.Resources.sports;
            this.mainPicBx.Location = new System.Drawing.Point(471, 200);
            this.mainPicBx.Name = "mainPicBx";
            this.mainPicBx.Size = new System.Drawing.Size(265, 148);
            this.mainPicBx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mainPicBx.TabIndex = 1;
            this.mainPicBx.TabStop = false;
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.titleLbl.Location = new System.Drawing.Point(198, 9);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(343, 30);
            this.titleLbl.TabIndex = 2;
            this.titleLbl.Text = "County Works: Sports Registration";
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameLbl.Location = new System.Drawing.Point(167, 74);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(59, 21);
            this.nameLbl.TabIndex = 3;
            this.nameLbl.Text = "Name: ";
            // 
            // addressLbl
            // 
            this.addressLbl.AutoSize = true;
            this.addressLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addressLbl.Location = new System.Drawing.Point(167, 98);
            this.addressLbl.Name = "addressLbl";
            this.addressLbl.Size = new System.Drawing.Size(113, 21);
            this.addressLbl.TabIndex = 4;
            this.addressLbl.Text = "Street Address:";
            // 
            // cityLbl
            // 
            this.cityLbl.AutoSize = true;
            this.cityLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cityLbl.Location = new System.Drawing.Point(167, 128);
            this.cityLbl.Name = "cityLbl";
            this.cityLbl.Size = new System.Drawing.Size(40, 21);
            this.cityLbl.TabIndex = 5;
            this.cityLbl.Text = "City:";
            // 
            // stateLbl
            // 
            this.stateLbl.AutoSize = true;
            this.stateLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.stateLbl.Location = new System.Drawing.Point(509, 132);
            this.stateLbl.Name = "stateLbl";
            this.stateLbl.Size = new System.Drawing.Size(47, 21);
            this.stateLbl.TabIndex = 6;
            this.stateLbl.Text = "State:";
            // 
            // cityTxtBx
            // 
            this.cityTxtBx.Location = new System.Drawing.Point(286, 134);
            this.cityTxtBx.Name = "cityTxtBx";
            this.cityTxtBx.Size = new System.Drawing.Size(219, 23);
            this.cityTxtBx.TabIndex = 2;
            // 
            // addressTxtBx
            // 
            this.addressTxtBx.Location = new System.Drawing.Point(286, 105);
            this.addressTxtBx.Name = "addressTxtBx";
            this.addressTxtBx.Size = new System.Drawing.Size(219, 23);
            this.addressTxtBx.TabIndex = 1;
            // 
            // nameTxtBx
            // 
            this.nameTxtBx.Location = new System.Drawing.Point(286, 76);
            this.nameTxtBx.Name = "nameTxtBx";
            this.nameTxtBx.Size = new System.Drawing.Size(219, 23);
            this.nameTxtBx.TabIndex = 0;
            // 
            // stateCmboBx
            // 
            this.stateCmboBx.FormattingEnabled = true;
            this.stateCmboBx.ItemHeight = 15;
            this.stateCmboBx.Location = new System.Drawing.Point(588, 134);
            this.stateCmboBx.Name = "stateCmboBx";
            this.stateCmboBx.Size = new System.Drawing.Size(69, 23);
            this.stateCmboBx.TabIndex = 3;
            // 
            // captionTxtBx
            // 
            this.captionTxtBx.Location = new System.Drawing.Point(471, 354);
            this.captionTxtBx.Name = "captionTxtBx";
            this.captionTxtBx.ReadOnly = true;
            this.captionTxtBx.Size = new System.Drawing.Size(265, 23);
            this.captionTxtBx.TabIndex = 12;
            this.captionTxtBx.TabStop = false;
            this.captionTxtBx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // registerBtn
            // 
            this.registerBtn.Location = new System.Drawing.Point(267, 403);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(216, 35);
            this.registerBtn.TabIndex = 9;
            this.registerBtn.Text = "Register";
            this.registerBtn.UseVisualStyleBackColor = true;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.registerBtn);
            this.Controls.Add(this.captionTxtBx);
            this.Controls.Add(this.stateCmboBx);
            this.Controls.Add(this.nameTxtBx);
            this.Controls.Add(this.addressTxtBx);
            this.Controls.Add(this.cityTxtBx);
            this.Controls.Add(this.stateLbl);
            this.Controls.Add(this.cityLbl);
            this.Controls.Add(this.addressLbl);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.titleLbl);
            this.Controls.Add(this.mainPicBx);
            this.Controls.Add(this.lessonChoiceGrpBx);
            this.Name = "Form1";
            this.Text = "CW: Sports Registration";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.lessonChoiceGrpBx.ResumeLayout(false);
            this.lessonChoiceGrpBx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainPicBx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox lessonChoiceGrpBx;
        private RadioButton ultFrisRdBtn;
        private RadioButton fieldHocRdBtn;
        private RadioButton sftBallRdBtn;
        private RadioButton bladeRdBtn;
        private RadioButton skateRdBtn;
        private PictureBox mainPicBx;
        private Label titleLbl;
        private Label nameLbl;
        private Label addressLbl;
        private Label cityLbl;
        private Label stateLbl;
        private TextBox cityTxtBx;
        private TextBox addressTxtBx;
        private TextBox nameTxtBx;
        private ComboBox stateCmboBx;
        private TextBox captionTxtBx;
        private Button registerBtn;
    }
}