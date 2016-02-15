namespace TSST.Client
{
    partial class MainForm
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
            this.createProjectButton = new System.Windows.Forms.Button();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.Description = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.selectedFriendsListBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.adFriendButton = new System.Windows.Forms.Button();
            this.friendsListBox = new System.Windows.Forms.ListBox();
            this.showFreindsButton = new System.Windows.Forms.Button();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.udateTaskButton = new System.Windows.Forms.Button();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.updateTaskComboBox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.taskTitleTextBox = new System.Windows.Forms.TextBox();
            this.createTaskButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.taskDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.projectsAvailableComboBox = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.addFileButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.fileDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.attachFileButton = new System.Windows.Forms.Button();
            this.selectedFileTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.fileTaskComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.fileProjectComboBox = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.deleteProjectButton = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.deletingProjectComboBox = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // createProjectButton
            // 
            this.createProjectButton.Location = new System.Drawing.Point(157, 224);
            this.createProjectButton.Name = "createProjectButton";
            this.createProjectButton.Size = new System.Drawing.Size(84, 23);
            this.createProjectButton.TabIndex = 8;
            this.createProjectButton.Text = "Create Project";
            this.createProjectButton.UseVisualStyleBackColor = true;
            this.createProjectButton.Click += new System.EventHandler(this.createProjectButton_Click);
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(87, 68);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(308, 20);
            this.descriptionTextBox.TabIndex = 12;
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Location = new System.Drawing.Point(15, 71);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(60, 13);
            this.Description.TabIndex = 13;
            this.Description.Text = "Description";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.selectedFriendsListBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.createProjectButton);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.adFriendButton);
            this.groupBox1.Controls.Add(this.friendsListBox);
            this.groupBox1.Controls.Add(this.showFreindsButton);
            this.groupBox1.Controls.Add(this.titleTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.descriptionTextBox);
            this.groupBox1.Controls.Add(this.Description);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(401, 268);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Project Properties";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(279, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Selected Friends";
            // 
            // selectedFriendsListBox
            // 
            this.selectedFriendsListBox.Enabled = false;
            this.selectedFriendsListBox.FormattingEnabled = true;
            this.selectedFriendsListBox.Location = new System.Drawing.Point(257, 113);
            this.selectedFriendsListBox.Name = "selectedFriendsListBox";
            this.selectedFriendsListBox.Size = new System.Drawing.Size(140, 56);
            this.selectedFriendsListBox.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Deadline!";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(89, 175);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 18;
            // 
            // adFriendButton
            // 
            this.adFriendButton.Location = new System.Drawing.Point(8, 149);
            this.adFriendButton.Name = "adFriendButton";
            this.adFriendButton.Size = new System.Drawing.Size(76, 20);
            this.adFriendButton.TabIndex = 17;
            this.adFriendButton.Text = "Add Friend";
            this.adFriendButton.UseVisualStyleBackColor = true;
            this.adFriendButton.Click += new System.EventHandler(this.adFriendButton_Click);
            // 
            // friendsListBox
            // 
            this.friendsListBox.FormattingEnabled = true;
            this.friendsListBox.Location = new System.Drawing.Point(96, 113);
            this.friendsListBox.Name = "friendsListBox";
            this.friendsListBox.Size = new System.Drawing.Size(155, 56);
            this.friendsListBox.TabIndex = 16;
            // 
            // showFreindsButton
            // 
            this.showFreindsButton.Location = new System.Drawing.Point(6, 113);
            this.showFreindsButton.Name = "showFreindsButton";
            this.showFreindsButton.Size = new System.Drawing.Size(84, 21);
            this.showFreindsButton.TabIndex = 15;
            this.showFreindsButton.Text = "Show Friends";
            this.showFreindsButton.UseVisualStyleBackColor = true;
            this.showFreindsButton.Click += new System.EventHandler(this.showFreindsButton_Click);
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(89, 30);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(306, 20);
            this.titleTextBox.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Title";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.udateTaskButton);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.updateTaskComboBox);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.taskTitleTextBox);
            this.groupBox2.Controls.Add(this.createTaskButton);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.taskDescriptionTextBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.projectsAvailableComboBox);
            this.groupBox2.Location = new System.Drawing.Point(420, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(406, 267);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Task Properties";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(223, 238);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 36;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // udateTaskButton
            // 
            this.udateTaskButton.Location = new System.Drawing.Point(109, 238);
            this.udateTaskButton.Name = "udateTaskButton";
            this.udateTaskButton.Size = new System.Drawing.Size(75, 23);
            this.udateTaskButton.TabIndex = 35;
            this.udateTaskButton.Text = "Update";
            this.udateTaskButton.UseVisualStyleBackColor = true;
            this.udateTaskButton.Click += new System.EventHandler(this.udateTaskButton_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(223, 212);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(75, 17);
            this.radioButton2.TabIndex = 34;
            this.radioButton2.Text = "Completed";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(109, 212);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(78, 17);
            this.radioButton1.TabIndex = 33;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "In Progress";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 180);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 13);
            this.label11.TabIndex = 32;
            this.label11.Text = "Task";
            // 
            // updateTaskComboBox
            // 
            this.updateTaskComboBox.FormattingEnabled = true;
            this.updateTaskComboBox.Location = new System.Drawing.Point(72, 176);
            this.updateTaskComboBox.Name = "updateTaskComboBox";
            this.updateTaskComboBox.Size = new System.Drawing.Size(328, 21);
            this.updateTaskComboBox.TabIndex = 31;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(127, 155);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(171, 13);
            this.label10.TabIndex = 30;
            this.label10.Text = "Update Task Status / Delete Task";
            // 
            // taskTitleTextBox
            // 
            this.taskTitleTextBox.Location = new System.Drawing.Point(72, 70);
            this.taskTitleTextBox.Name = "taskTitleTextBox";
            this.taskTitleTextBox.Size = new System.Drawing.Size(328, 20);
            this.taskTitleTextBox.TabIndex = 29;
            // 
            // createTaskButton
            // 
            this.createTaskButton.Location = new System.Drawing.Point(170, 122);
            this.createTaskButton.Name = "createTaskButton";
            this.createTaskButton.Size = new System.Drawing.Size(75, 23);
            this.createTaskButton.TabIndex = 26;
            this.createTaskButton.Text = "Create Task";
            this.createTaskButton.UseVisualStyleBackColor = true;
            this.createTaskButton.Click += new System.EventHandler(this.createTaskButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Title";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(391, 23);
            this.button1.TabIndex = 27;
            this.button1.Text = "Show Projects";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Description";
            // 
            // taskDescriptionTextBox
            // 
            this.taskDescriptionTextBox.Location = new System.Drawing.Point(72, 96);
            this.taskDescriptionTextBox.Name = "taskDescriptionTextBox";
            this.taskDescriptionTextBox.Size = new System.Drawing.Size(328, 20);
            this.taskDescriptionTextBox.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Project";
            // 
            // projectsAvailableComboBox
            // 
            this.projectsAvailableComboBox.FormattingEnabled = true;
            this.projectsAvailableComboBox.Location = new System.Drawing.Point(72, 43);
            this.projectsAvailableComboBox.Name = "projectsAvailableComboBox";
            this.projectsAvailableComboBox.Size = new System.Drawing.Size(328, 21);
            this.projectsAvailableComboBox.TabIndex = 13;
            this.projectsAvailableComboBox.SelectedIndexChanged += new System.EventHandler(this.projectsAvailableComboBox_SelectedIndexChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // addFileButton
            // 
            this.addFileButton.Location = new System.Drawing.Point(8, 127);
            this.addFileButton.Name = "addFileButton";
            this.addFileButton.Size = new System.Drawing.Size(57, 20);
            this.addFileButton.TabIndex = 21;
            this.addFileButton.Text = "Add file";
            this.addFileButton.UseVisualStyleBackColor = true;
            this.addFileButton.Click += new System.EventHandler(this.addFileButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox3.Controls.Add(this.fileDescriptionTextBox);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.attachFileButton);
            this.groupBox3.Controls.Add(this.selectedFileTextBox);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.fileTaskComboBox);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.fileProjectComboBox);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.addFileButton);
            this.groupBox3.Location = new System.Drawing.Point(12, 286);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(401, 217);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Files ";
            // 
            // fileDescriptionTextBox
            // 
            this.fileDescriptionTextBox.Location = new System.Drawing.Point(71, 159);
            this.fileDescriptionTextBox.Name = "fileDescriptionTextBox";
            this.fileDescriptionTextBox.Size = new System.Drawing.Size(324, 20);
            this.fileDescriptionTextBox.TabIndex = 36;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 162);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 35;
            this.label9.Text = "Description";
            // 
            // attachFileButton
            // 
            this.attachFileButton.Location = new System.Drawing.Point(166, 185);
            this.attachFileButton.Name = "attachFileButton";
            this.attachFileButton.Size = new System.Drawing.Size(75, 23);
            this.attachFileButton.TabIndex = 34;
            this.attachFileButton.Text = "Attach File";
            this.attachFileButton.UseVisualStyleBackColor = true;
            this.attachFileButton.Click += new System.EventHandler(this.attachFileButton_Click);
            // 
            // selectedFileTextBox
            // 
            this.selectedFileTextBox.Location = new System.Drawing.Point(71, 127);
            this.selectedFileTextBox.Name = "selectedFileTextBox";
            this.selectedFileTextBox.Size = new System.Drawing.Size(324, 20);
            this.selectedFileTextBox.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Task";
            // 
            // fileTaskComboBox
            // 
            this.fileTaskComboBox.FormattingEnabled = true;
            this.fileTaskComboBox.Location = new System.Drawing.Point(71, 100);
            this.fileTaskComboBox.Name = "fileTaskComboBox";
            this.fileTaskComboBox.Size = new System.Drawing.Size(324, 21);
            this.fileTaskComboBox.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Project";
            // 
            // fileProjectComboBox
            // 
            this.fileProjectComboBox.FormattingEnabled = true;
            this.fileProjectComboBox.Location = new System.Drawing.Point(71, 72);
            this.fileProjectComboBox.Name = "fileProjectComboBox";
            this.fileProjectComboBox.Size = new System.Drawing.Size(324, 21);
            this.fileProjectComboBox.TabIndex = 29;
            this.fileProjectComboBox.SelectedIndexChanged += new System.EventHandler(this.fileProjectComboBox_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(4, 28);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(393, 26);
            this.button2.TabIndex = 28;
            this.button2.Text = "Show Projects";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox4.Controls.Add(this.deleteProjectButton);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.deletingProjectComboBox);
            this.groupBox4.Controls.Add(this.button4);
            this.groupBox4.Location = new System.Drawing.Point(420, 286);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(406, 217);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Deleting Project";
            // 
            // deleteProjectButton
            // 
            this.deleteProjectButton.Location = new System.Drawing.Point(119, 123);
            this.deleteProjectButton.Name = "deleteProjectButton";
            this.deleteProjectButton.Size = new System.Drawing.Size(168, 56);
            this.deleteProjectButton.TabIndex = 31;
            this.deleteProjectButton.Text = "Delete";
            this.deleteProjectButton.UseVisualStyleBackColor = true;
            this.deleteProjectButton.Click += new System.EventHandler(this.deleteProjectButton_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 76);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 13);
            this.label12.TabIndex = 30;
            this.label12.Text = "Project";
            // 
            // deletingProjectComboBox
            // 
            this.deletingProjectComboBox.FormattingEnabled = true;
            this.deletingProjectComboBox.Location = new System.Drawing.Point(72, 72);
            this.deletingProjectComboBox.Name = "deletingProjectComboBox";
            this.deletingProjectComboBox.Size = new System.Drawing.Size(328, 21);
            this.deletingProjectComboBox.TabIndex = 29;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(9, 28);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(391, 23);
            this.button4.TabIndex = 28;
            this.button4.Text = "Show Projects";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 509);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button createProjectButton;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button adFriendButton;
        private System.Windows.Forms.ListBox friendsListBox;
        private System.Windows.Forms.Button showFreindsButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox selectedFriendsListBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button addFileButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox taskDescriptionTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox projectsAvailableComboBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button createTaskButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox taskTitleTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox fileTaskComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox fileProjectComboBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox selectedFileTextBox;
        private System.Windows.Forms.Button attachFileButton;
        private System.Windows.Forms.TextBox fileDescriptionTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox updateTaskComboBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button udateTaskButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button deleteProjectButton;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox deletingProjectComboBox;
        private System.Windows.Forms.Button button4;
    }
}

