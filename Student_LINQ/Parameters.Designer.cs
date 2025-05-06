namespace Student_LINQ
{
    partial class ParametersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParametersForm));
            radioButtonFirstName = new RadioButton();
            groupBox1 = new GroupBox();
            radioButtonAverageScore = new RadioButton();
            radioButtonId = new RadioButton();
            btnSort = new Button();
            btnShowAll = new Button();
            textBox1 = new TextBox();
            btnGroup = new Button();
            labelEnter = new Label();
            pictureBox1 = new PictureBox();
            btnFillter = new Button();
            btnAgreg = new Button();
            compareButton = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // radioButtonFirstName
            // 
            radioButtonFirstName.AutoSize = true;
            radioButtonFirstName.Cursor = Cursors.Hand;
            radioButtonFirstName.Location = new Point(6, 47);
            radioButtonFirstName.Name = "radioButtonFirstName";
            radioButtonFirstName.Size = new Size(119, 25);
            radioButtonFirstName.TabIndex = 1;
            radioButtonFirstName.TabStop = true;
            radioButtonFirstName.Text = "By last name";
            radioButtonFirstName.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Snow;
            groupBox1.Controls.Add(radioButtonAverageScore);
            groupBox1.Controls.Add(radioButtonId);
            groupBox1.Controls.Add(radioButtonFirstName);
            groupBox1.FlatStyle = FlatStyle.Popup;
            groupBox1.Location = new Point(3, 58);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(161, 97);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "How?";
            // 
            // radioButtonAverageScore
            // 
            radioButtonAverageScore.AutoSize = true;
            radioButtonAverageScore.Cursor = Cursors.Hand;
            radioButtonAverageScore.Location = new Point(6, 72);
            radioButtonAverageScore.Name = "radioButtonAverageScore";
            radioButtonAverageScore.Size = new Size(147, 25);
            radioButtonAverageScore.TabIndex = 3;
            radioButtonAverageScore.TabStop = true;
            radioButtonAverageScore.Text = "By average score";
            radioButtonAverageScore.UseVisualStyleBackColor = true;
            // 
            // radioButtonId
            // 
            radioButtonId.AutoSize = true;
            radioButtonId.Cursor = Cursors.Hand;
            radioButtonId.Location = new Point(6, 22);
            radioButtonId.Name = "radioButtonId";
            radioButtonId.Size = new Size(67, 25);
            radioButtonId.TabIndex = 2;
            radioButtonId.TabStop = true;
            radioButtonId.Text = "By ID";
            radioButtonId.UseVisualStyleBackColor = true;
            // 
            // btnSort
            // 
            btnSort.Cursor = Cursors.Hand;
            btnSort.Location = new Point(170, 33);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(95, 27);
            btnSort.TabIndex = 5;
            btnSort.Text = "Sort";
            btnSort.UseVisualStyleBackColor = true;
            btnSort.Click += btnSort_Click;
            // 
            // btnShowAll
            // 
            btnShowAll.Cursor = Cursors.Hand;
            btnShowAll.Location = new Point(170, 161);
            btnShowAll.Name = "btnShowAll";
            btnShowAll.Size = new Size(95, 27);
            btnShowAll.TabIndex = 2;
            btnShowAll.Text = "View All";
            btnShowAll.UseVisualStyleBackColor = true;
            btnShowAll.Click += btnShowAll_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(3, 33);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(161, 28);
            textBox1.TabIndex = 3;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // btnGroup
            // 
            btnGroup.Cursor = Cursors.Hand;
            btnGroup.Location = new Point(170, 98);
            btnGroup.Name = "btnGroup";
            btnGroup.Size = new Size(95, 27);
            btnGroup.TabIndex = 4;
            btnGroup.Text = "Group";
            btnGroup.UseVisualStyleBackColor = true;
            btnGroup.Click += btnGroup_Click;
            // 
            // labelEnter
            // 
            labelEnter.AutoSize = true;
            labelEnter.Location = new Point(3, 9);
            labelEnter.Name = "labelEnter";
            labelEnter.Size = new Size(131, 21);
            labelEnter.TabIndex = 9;
            labelEnter.Text = "Choose an option";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.circle_customer_help_info_information_service_support_icon_123208;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(242, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 32);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btnFillter
            // 
            btnFillter.Cursor = Cursors.Hand;
            btnFillter.Location = new Point(170, 66);
            btnFillter.Name = "btnFillter";
            btnFillter.Size = new Size(95, 27);
            btnFillter.TabIndex = 11;
            btnFillter.Text = "Fillter";
            btnFillter.UseVisualStyleBackColor = true;
            btnFillter.Click += btnFillter_Click;
            // 
            // btnAgreg
            // 
            btnAgreg.Cursor = Cursors.Hand;
            btnAgreg.Location = new Point(170, 131);
            btnAgreg.Name = "btnAgreg";
            btnAgreg.Size = new Size(95, 27);
            btnAgreg.TabIndex = 12;
            btnAgreg.Text = "Aggregate";
            btnAgreg.UseVisualStyleBackColor = true;
            btnAgreg.Click += btnAgreg_Click;
            // 
            // compareButton
            // 
            compareButton.Cursor = Cursors.Hand;
            compareButton.Location = new Point(38, 157);
            compareButton.Name = "compareButton";
            compareButton.Size = new Size(95, 27);
            compareButton.TabIndex = 13;
            compareButton.Text = "Compare";
            compareButton.UseVisualStyleBackColor = true;
            compareButton.Click += compareButton_Click;
            // 
            // ParametersForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            ClientSize = new Size(277, 189);
            Controls.Add(compareButton);
            Controls.Add(btnAgreg);
            Controls.Add(btnFillter);
            Controls.Add(pictureBox1);
            Controls.Add(labelEnter);
            Controls.Add(btnGroup);
            Controls.Add(btnSort);
            Controls.Add(textBox1);
            Controls.Add(btnShowAll);
            Controls.Add(groupBox1);
            Font = new Font("Corbel", 10F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ParametersForm";
            Text = "Parameters";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private RadioButton radioButtonFirstName;
        private GroupBox groupBox1;
        private Button btnShowAll;
        private TextBox textBox1;
        private Button btnGroup;
        private Button btnSort;
        private RadioButton radioButtonAverageScore;
        private RadioButton radioButtonId;
        private Label labelEnter;
        private PictureBox pictureBox1;
        private Button btnFillter;
        private Button btnAgreg;
        private Button compareButton;
    }
}
