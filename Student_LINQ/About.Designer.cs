namespace PasswordManager_WinForms
{
    partial class About
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
            components = new System.ComponentModel.Container();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label1 = new Label();
            btnMeow = new Button();
            btnBack = new Button();
            btnInst = new Button();
            btnGitHub = new Button();
            toolTip1 = new ToolTip(components);
            label3 = new Label();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Corbel", 10F);
            label1.Location = new Point(223, 48);
            label1.Name = "label1";
            label1.Size = new Size(410, 63);
            label1.TabIndex = 1;
            label1.Text = "2nd year student of the \r\nNational Aerospace University \"Kharkiv Aviation Institute\"\r\nI like dogs, cats and capybaras 💜\r\n";
            // 
            // btnMeow
            // 
            btnMeow.BackColor = Color.WhiteSmoke;
            btnMeow.BackgroundImage = Student_LINQ.Properties.Resources.cat;
            btnMeow.BackgroundImageLayout = ImageLayout.Zoom;
            btnMeow.Cursor = Cursors.Hand;
            btnMeow.FlatAppearance.BorderColor = Color.DarkMagenta;
            btnMeow.FlatAppearance.BorderSize = 2;
            btnMeow.FlatAppearance.MouseOverBackColor = Color.Thistle;
            btnMeow.FlatStyle = FlatStyle.Flat;
            btnMeow.Font = new Font("Calisto MT", 10F);
            btnMeow.ForeColor = Color.WhiteSmoke;
            btnMeow.Location = new Point(478, 153);
            btnMeow.Margin = new Padding(0);
            btnMeow.Name = "btnMeow";
            btnMeow.Size = new Size(78, 66);
            btnMeow.TabIndex = 8;
            btnMeow.UseVisualStyleBackColor = false;
            btnMeow.Click += btnMeow_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.GhostWhite;
            btnBack.BackgroundImage = Student_LINQ.Properties.Resources.back;
            btnBack.BackgroundImageLayout = ImageLayout.Zoom;
            btnBack.Cursor = Cursors.Hand;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatAppearance.MouseOverBackColor = Color.Gainsboro;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Location = new Point(515, 3);
            btnBack.Margin = new Padding(0);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(45, 42);
            btnBack.TabIndex = 10;
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnInst
            // 
            btnInst.BackColor = Color.GhostWhite;
            btnInst.BackgroundImage = Student_LINQ.Properties.Resources.instagram;
            btnInst.BackgroundImageLayout = ImageLayout.Zoom;
            btnInst.Cursor = Cursors.Hand;
            btnInst.FlatAppearance.BorderColor = Color.Gainsboro;
            btnInst.FlatAppearance.BorderSize = 0;
            btnInst.FlatAppearance.MouseOverBackColor = Color.Gainsboro;
            btnInst.FlatStyle = FlatStyle.Flat;
            btnInst.Font = new Font("Calisto MT", 10F);
            btnInst.ForeColor = Color.Gainsboro;
            btnInst.Location = new Point(291, 153);
            btnInst.Margin = new Padding(0);
            btnInst.Name = "btnInst";
            btnInst.Size = new Size(117, 66);
            btnInst.TabIndex = 12;
            btnInst.UseVisualStyleBackColor = false;
            btnInst.Click += btnInst_Click;
            // 
            // btnGitHub
            // 
            btnGitHub.BackColor = Color.GhostWhite;
            btnGitHub.BackgroundImage = Student_LINQ.Properties.Resources.github;
            btnGitHub.BackgroundImageLayout = ImageLayout.Zoom;
            btnGitHub.Cursor = Cursors.Hand;
            btnGitHub.FlatAppearance.BorderColor = Color.Gainsboro;
            btnGitHub.FlatAppearance.BorderSize = 0;
            btnGitHub.FlatAppearance.MouseOverBackColor = Color.Gainsboro;
            btnGitHub.FlatStyle = FlatStyle.Flat;
            btnGitHub.Font = new Font("Calisto MT", 10F);
            btnGitHub.ForeColor = Color.WhiteSmoke;
            btnGitHub.Location = new Point(223, 150);
            btnGitHub.Margin = new Padding(0);
            btnGitHub.Name = "btnGitHub";
            btnGitHub.Size = new Size(68, 66);
            btnGitHub.TabIndex = 13;
            btnGitHub.UseVisualStyleBackColor = false;
            btnGitHub.Click += btnGitHub_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(223, 16);
            label3.Name = "label3";
            label3.Size = new Size(220, 24);
            label3.TabIndex = 14;
            label3.Text = "Author: Akhtyrska Sofiia";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Student_LINQ.Properties.Resources.photo_288x288;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(12, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(205, 207);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.GhostWhite;
            label4.ForeColor = Color.GhostWhite;
            label4.Location = new Point(386, 196);
            label4.Name = "label4";
            label4.Size = new Size(89, 20);
            label4.TabIndex = 16;
            label4.Text = "I love Andrii";
            // 
            // About
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.GhostWhite;
            ClientSize = new Size(569, 231);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(btnMeow);
            Controls.Add(btnGitHub);
            Controls.Add(label1);
            Controls.Add(btnInst);
            Controls.Add(btnBack);
            FormBorderStyle = FormBorderStyle.None;
            Name = "About";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "About";
            Load += About_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label1;
        private Button btnMeow;
        private Button btnBack;
        private Button btnInst;
        private Button btnGitHub;
        private ToolTip toolTip1;
        private Label label3;
        private PictureBox pictureBox1;
        private Label label4;
    }
}