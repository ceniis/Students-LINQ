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
            btnSearch = new Button();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            labelEnter = new Label();
            pictureBox1 = new PictureBox();
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
            radioButtonFirstName.Size = new Size(101, 21);
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
            groupBox1.Controls.Add(btnSort);
            groupBox1.FlatStyle = FlatStyle.Popup;
            groupBox1.Location = new Point(12, 58);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(139, 140);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sorting parameters:";
            // 
            // radioButtonAverageScore
            // 
            radioButtonAverageScore.AutoSize = true;
            radioButtonAverageScore.Cursor = Cursors.Hand;
            radioButtonAverageScore.Location = new Point(6, 72);
            radioButtonAverageScore.Name = "radioButtonAverageScore";
            radioButtonAverageScore.Size = new Size(124, 21);
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
            radioButtonId.Size = new Size(56, 21);
            radioButtonId.TabIndex = 2;
            radioButtonId.TabStop = true;
            radioButtonId.Text = "By ID";
            radioButtonId.UseVisualStyleBackColor = true;
            // 
            // btnSort
            // 
            btnSort.Cursor = Cursors.Hand;
            btnSort.Location = new Point(58, 111);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(75, 23);
            btnSort.TabIndex = 5;
            btnSort.Text = "Sort";
            btnSort.UseVisualStyleBackColor = true;
            // 
            // btnShowAll
            // 
            btnShowAll.Cursor = Cursors.Hand;
            btnShowAll.Location = new Point(157, 174);
            btnShowAll.Name = "btnShowAll";
            btnShowAll.Size = new Size(75, 23);
            btnShowAll.TabIndex = 2;
            btnShowAll.Text = "View All";
            btnShowAll.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 29);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(220, 24);
            textBox1.TabIndex = 3;
            // 
            // btnSearch
            // 
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.Location = new Point(157, 145);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.Location = new Point(157, 58);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.Location = new Point(157, 87);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 23);
            btnEdit.TabIndex = 7;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.Location = new Point(157, 116);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // labelEnter
            // 
            labelEnter.AutoSize = true;
            labelEnter.Location = new Point(12, 9);
            labelEnter.Name = "labelEnter";
            labelEnter.Size = new Size(198, 17);
            labelEnter.TabIndex = 9;
            labelEnter.Text = "Enret student's Last Name or ID:";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.circle_customer_help_info_information_service_support_icon_123208;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(238, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 32);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // ParametersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            ClientSize = new Size(277, 209);
            Controls.Add(pictureBox1);
            Controls.Add(labelEnter);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(btnSearch);
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
        private Button btnSearch;
        private Button btnSort;
        private RadioButton radioButtonAverageScore;
        private RadioButton radioButtonId;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Label labelEnter;
        private PictureBox pictureBox1;
    }
}
