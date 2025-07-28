namespace CyberSecurityChatbotGUI
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageChatbot = new System.Windows.Forms.TabPage();
            this.btnSend1 = new System.Windows.Forms.Button();
            this.txtUserInput1 = new System.Windows.Forms.TextBox();
            this.rtbConversation = new System.Windows.Forms.RichTextBox();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.tabPageTaskAssistant = new System.Windows.Forms.TabPage();
            this.lstTasks = new System.Windows.Forms.ListBox();
            this.lblTasks = new System.Windows.Forms.Label();
            this.btnMarkComplete = new System.Windows.Forms.Button();
            this.btnDeleteTask = new System.Windows.Forms.Button();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.dtpReminder = new System.Windows.Forms.DateTimePicker();
            this.lblReminder = new System.Windows.Forms.Label();
            this.txtTaskDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtTaskTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tabPageQuiz = new System.Windows.Forms.TabPage();
            this.btnRestartQuiz = new System.Windows.Forms.Button();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblFeedback = new System.Windows.Forms.Label();
            this.btnNextQuestion = new System.Windows.Forms.Button();
            this.btnSubmitAnswer = new System.Windows.Forms.Button();
            this.rbtnOptionD = new System.Windows.Forms.RadioButton();
            this.rbtnOptionC = new System.Windows.Forms.RadioButton();
            this.rbtnOptionB = new System.Windows.Forms.RadioButton();
            this.rbtnOptionA = new System.Windows.Forms.RadioButton();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPageChatbot.SuspendLayout();
            this.tabPageTaskAssistant.SuspendLayout();
            this.tabPageQuiz.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageChatbot);
            this.tabControl1.Controls.Add(this.tabPageTaskAssistant);
            this.tabControl1.Controls.Add(this.tabPageQuiz);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(809, 604);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPageChatbot
            // 
            this.tabPageChatbot.Controls.Add(this.btnSend1);
            this.tabPageChatbot.Controls.Add(this.txtUserInput1);
            this.tabPageChatbot.Controls.Add(this.rtbConversation);
            this.tabPageChatbot.Controls.Add(this.lblWelcome);
            this.tabPageChatbot.Font = new System.Drawing.Font("Constantia", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageChatbot.Location = new System.Drawing.Point(4, 38);
            this.tabPageChatbot.Name = "tabPageChatbot";
            this.tabPageChatbot.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageChatbot.Size = new System.Drawing.Size(801, 562);
            this.tabPageChatbot.TabIndex = 0;
            this.tabPageChatbot.Text = "Chatbot";
            this.tabPageChatbot.UseVisualStyleBackColor = true;
            // 
            // btnSend1
            // 
            this.btnSend1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend1.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend1.Location = new System.Drawing.Point(715, 533);
            this.btnSend1.Name = "btnSend1";
            this.btnSend1.Size = new System.Drawing.Size(75, 23);
            this.btnSend1.TabIndex = 4;
            this.btnSend1.Text = "SEND";
            this.btnSend1.UseVisualStyleBackColor = true;
            this.btnSend1.Click += new System.EventHandler(this.btnSend1_Click);
            // 
            // txtUserInput1
            // 
            this.txtUserInput1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUserInput1.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserInput1.Location = new System.Drawing.Point(6, 500);
            this.txtUserInput1.Name = "txtUserInput1";
            this.txtUserInput1.Size = new System.Drawing.Size(784, 28);
            this.txtUserInput1.TabIndex = 3;
            // 
            // rtbConversation
            // 
            this.rtbConversation.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbConversation.Location = new System.Drawing.Point(6, 44);
            this.rtbConversation.Name = "rtbConversation";
            this.rtbConversation.ReadOnly = true;
            this.rtbConversation.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbConversation.Size = new System.Drawing.Size(784, 466);
            this.rtbConversation.TabIndex = 2;
            this.rtbConversation.Text = "";
            this.rtbConversation.TextChanged += new System.EventHandler(this.rtbConversation_TextChanged);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Constantia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(6, 13);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(437, 28);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Welcome to the CyberSecurity Chatbot!";
            // 
            // tabPageTaskAssistant
            // 
            this.tabPageTaskAssistant.Controls.Add(this.lstTasks);
            this.tabPageTaskAssistant.Controls.Add(this.lblTasks);
            this.tabPageTaskAssistant.Controls.Add(this.btnMarkComplete);
            this.tabPageTaskAssistant.Controls.Add(this.btnDeleteTask);
            this.tabPageTaskAssistant.Controls.Add(this.btnAddTask);
            this.tabPageTaskAssistant.Controls.Add(this.dtpReminder);
            this.tabPageTaskAssistant.Controls.Add(this.lblReminder);
            this.tabPageTaskAssistant.Controls.Add(this.txtTaskDescription);
            this.tabPageTaskAssistant.Controls.Add(this.lblDescription);
            this.tabPageTaskAssistant.Controls.Add(this.txtTaskTitle);
            this.tabPageTaskAssistant.Controls.Add(this.lblTitle);
            this.tabPageTaskAssistant.Font = new System.Drawing.Font("Constantia", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageTaskAssistant.Location = new System.Drawing.Point(4, 38);
            this.tabPageTaskAssistant.Name = "tabPageTaskAssistant";
            this.tabPageTaskAssistant.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTaskAssistant.Size = new System.Drawing.Size(801, 562);
            this.tabPageTaskAssistant.TabIndex = 1;
            this.tabPageTaskAssistant.Text = "Task Assistant";
            this.tabPageTaskAssistant.UseVisualStyleBackColor = true;
            // 
            // lstTasks
            // 
            this.lstTasks.ColumnWidth = 300;
            this.lstTasks.Font = new System.Drawing.Font("Constantia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstTasks.FormattingEnabled = true;
            this.lstTasks.ItemHeight = 22;
            this.lstTasks.Location = new System.Drawing.Point(16, 352);
            this.lstTasks.Name = "lstTasks";
            this.lstTasks.Size = new System.Drawing.Size(595, 180);
            this.lstTasks.TabIndex = 10;
            // 
            // lblTasks
            // 
            this.lblTasks.AutoSize = true;
            this.lblTasks.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTasks.Location = new System.Drawing.Point(13, 322);
            this.lblTasks.Name = "lblTasks";
            this.lblTasks.Size = new System.Drawing.Size(68, 24);
            this.lblTasks.TabIndex = 9;
            this.lblTasks.Text = "Tasks:";
            // 
            // btnMarkComplete
            // 
            this.btnMarkComplete.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarkComplete.Location = new System.Drawing.Point(400, 233);
            this.btnMarkComplete.Name = "btnMarkComplete";
            this.btnMarkComplete.Size = new System.Drawing.Size(125, 23);
            this.btnMarkComplete.TabIndex = 8;
            this.btnMarkComplete.Text = "Completed";
            this.btnMarkComplete.UseVisualStyleBackColor = true;
            this.btnMarkComplete.Click += new System.EventHandler(this.btnMarkComplete_Click);
            // 
            // btnDeleteTask
            // 
            this.btnDeleteTask.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteTask.Location = new System.Drawing.Point(200, 233);
            this.btnDeleteTask.Name = "btnDeleteTask";
            this.btnDeleteTask.Size = new System.Drawing.Size(116, 23);
            this.btnDeleteTask.TabIndex = 7;
            this.btnDeleteTask.Text = "Delete Selected Task";
            this.btnDeleteTask.UseVisualStyleBackColor = true;
            this.btnDeleteTask.Click += new System.EventHandler(this.btnDeleteTask_Click);
            // 
            // btnAddTask
            // 
            this.btnAddTask.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTask.Location = new System.Drawing.Point(13, 234);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(109, 23);
            this.btnAddTask.TabIndex = 6;
            this.btnAddTask.Text = "Add Task";
            this.btnAddTask.UseVisualStyleBackColor = true;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // dtpReminder
            // 
            this.dtpReminder.Font = new System.Drawing.Font("Constantia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpReminder.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpReminder.Location = new System.Drawing.Point(200, 156);
            this.dtpReminder.Name = "dtpReminder";
            this.dtpReminder.Size = new System.Drawing.Size(200, 29);
            this.dtpReminder.TabIndex = 5;
            // 
            // lblReminder
            // 
            this.lblReminder.AutoSize = true;
            this.lblReminder.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReminder.Location = new System.Drawing.Point(10, 156);
            this.lblReminder.Name = "lblReminder";
            this.lblReminder.Size = new System.Drawing.Size(147, 24);
            this.lblReminder.TabIndex = 4;
            this.lblReminder.Text = "Set Reminder:";
            // 
            // txtTaskDescription
            // 
            this.txtTaskDescription.Font = new System.Drawing.Font("Constantia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaskDescription.Location = new System.Drawing.Point(200, 82);
            this.txtTaskDescription.Multiline = true;
            this.txtTaskDescription.Name = "txtTaskDescription";
            this.txtTaskDescription.Size = new System.Drawing.Size(200, 35);
            this.txtTaskDescription.TabIndex = 3;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(10, 82);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(130, 24);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Description:";
            // 
            // txtTaskTitle
            // 
            this.txtTaskTitle.Font = new System.Drawing.Font("Constantia", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaskTitle.Location = new System.Drawing.Point(200, 18);
            this.txtTaskTitle.Name = "txtTaskTitle";
            this.txtTaskTitle.Size = new System.Drawing.Size(200, 29);
            this.txtTaskTitle.TabIndex = 1;
            this.txtTaskTitle.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(7, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(109, 24);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Task Title:";
            // 
            // tabPageQuiz
            // 
            this.tabPageQuiz.Controls.Add(this.btnRestartQuiz);
            this.tabPageQuiz.Controls.Add(this.lblScore);
            this.tabPageQuiz.Controls.Add(this.lblFeedback);
            this.tabPageQuiz.Controls.Add(this.btnNextQuestion);
            this.tabPageQuiz.Controls.Add(this.btnSubmitAnswer);
            this.tabPageQuiz.Controls.Add(this.rbtnOptionD);
            this.tabPageQuiz.Controls.Add(this.rbtnOptionC);
            this.tabPageQuiz.Controls.Add(this.rbtnOptionB);
            this.tabPageQuiz.Controls.Add(this.rbtnOptionA);
            this.tabPageQuiz.Controls.Add(this.lblQuestion);
            this.tabPageQuiz.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageQuiz.Location = new System.Drawing.Point(4, 38);
            this.tabPageQuiz.Name = "tabPageQuiz";
            this.tabPageQuiz.Size = new System.Drawing.Size(801, 562);
            this.tabPageQuiz.TabIndex = 2;
            this.tabPageQuiz.Text = "Quiz";
            this.tabPageQuiz.UseVisualStyleBackColor = true;
            // 
            // btnRestartQuiz
            // 
            this.btnRestartQuiz.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestartQuiz.Location = new System.Drawing.Point(101, 414);
            this.btnRestartQuiz.Name = "btnRestartQuiz";
            this.btnRestartQuiz.Size = new System.Drawing.Size(148, 33);
            this.btnRestartQuiz.TabIndex = 9;
            this.btnRestartQuiz.Text = "Restart Quiz";
            this.btnRestartQuiz.UseVisualStyleBackColor = true;
            this.btnRestartQuiz.Click += new System.EventHandler(this.btnRestartQuiz_Click);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(16, 385);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(0, 21);
            this.lblScore.TabIndex = 8;
            // 
            // lblFeedback
            // 
            this.lblFeedback.AutoSize = true;
            this.lblFeedback.Location = new System.Drawing.Point(16, 330);
            this.lblFeedback.Name = "lblFeedback";
            this.lblFeedback.Size = new System.Drawing.Size(0, 21);
            this.lblFeedback.TabIndex = 7;
            // 
            // btnNextQuestion
            // 
            this.btnNextQuestion.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextQuestion.Location = new System.Drawing.Point(186, 279);
            this.btnNextQuestion.Name = "btnNextQuestion";
            this.btnNextQuestion.Size = new System.Drawing.Size(156, 33);
            this.btnNextQuestion.TabIndex = 6;
            this.btnNextQuestion.Text = "Next Question";
            this.btnNextQuestion.UseVisualStyleBackColor = true;
            this.btnNextQuestion.Click += new System.EventHandler(this.btnNextQuestion_Click);
            // 
            // btnSubmitAnswer
            // 
            this.btnSubmitAnswer.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitAnswer.Location = new System.Drawing.Point(16, 279);
            this.btnSubmitAnswer.Name = "btnSubmitAnswer";
            this.btnSubmitAnswer.Size = new System.Drawing.Size(150, 33);
            this.btnSubmitAnswer.TabIndex = 5;
            this.btnSubmitAnswer.Text = "Submit Answer";
            this.btnSubmitAnswer.UseVisualStyleBackColor = true;
            this.btnSubmitAnswer.Click += new System.EventHandler(this.btnSubmitAnswer_Click);
            // 
            // rbtnOptionD
            // 
            this.rbtnOptionD.AutoSize = true;
            this.rbtnOptionD.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnOptionD.Location = new System.Drawing.Point(16, 215);
            this.rbtnOptionD.Name = "rbtnOptionD";
            this.rbtnOptionD.Size = new System.Drawing.Size(96, 22);
            this.rbtnOptionD.TabIndex = 4;
            this.rbtnOptionD.TabStop = true;
            this.rbtnOptionD.Text = "Option D";
            this.rbtnOptionD.UseVisualStyleBackColor = true;
            // 
            // rbtnOptionC
            // 
            this.rbtnOptionC.AutoSize = true;
            this.rbtnOptionC.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnOptionC.Location = new System.Drawing.Point(16, 163);
            this.rbtnOptionC.Name = "rbtnOptionC";
            this.rbtnOptionC.Size = new System.Drawing.Size(94, 22);
            this.rbtnOptionC.TabIndex = 3;
            this.rbtnOptionC.TabStop = true;
            this.rbtnOptionC.Text = "Option C";
            this.rbtnOptionC.UseVisualStyleBackColor = true;
            // 
            // rbtnOptionB
            // 
            this.rbtnOptionB.AutoSize = true;
            this.rbtnOptionB.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnOptionB.Location = new System.Drawing.Point(16, 112);
            this.rbtnOptionB.Name = "rbtnOptionB";
            this.rbtnOptionB.Size = new System.Drawing.Size(94, 22);
            this.rbtnOptionB.TabIndex = 2;
            this.rbtnOptionB.TabStop = true;
            this.rbtnOptionB.Text = "Option B";
            this.rbtnOptionB.UseVisualStyleBackColor = true;
            // 
            // rbtnOptionA
            // 
            this.rbtnOptionA.AutoSize = true;
            this.rbtnOptionA.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnOptionA.Location = new System.Drawing.Point(16, 63);
            this.rbtnOptionA.Name = "rbtnOptionA";
            this.rbtnOptionA.Size = new System.Drawing.Size(94, 22);
            this.rbtnOptionA.TabIndex = 1;
            this.rbtnOptionA.TabStop = true;
            this.rbtnOptionA.Text = "Option A";
            this.rbtnOptionA.UseVisualStyleBackColor = true;
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(13, 26);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(218, 21);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "Question will appear here";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(824, 620);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPageChatbot.ResumeLayout(false);
            this.tabPageChatbot.PerformLayout();
            this.tabPageTaskAssistant.ResumeLayout(false);
            this.tabPageTaskAssistant.PerformLayout();
            this.tabPageQuiz.ResumeLayout(false);
            this.tabPageQuiz.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtConversation;
        private System.Windows.Forms.TextBox txtUserInput;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageChatbot;
        private System.Windows.Forms.TabPage tabPageTaskAssistant;
        private System.Windows.Forms.TabPage tabPageQuiz;
        private System.Windows.Forms.Button btnSend1;
        private System.Windows.Forms.TextBox txtUserInput1;
        private System.Windows.Forms.RichTextBox rtbConversation;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.TextBox txtTaskTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtTaskDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.DateTimePicker dtpReminder;
        private System.Windows.Forms.Label lblReminder;
        private System.Windows.Forms.Button btnMarkComplete;
        private System.Windows.Forms.Button btnDeleteTask;
        private System.Windows.Forms.ListBox lstTasks;
        private System.Windows.Forms.Label lblTasks;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Button btnSubmitAnswer;
        private System.Windows.Forms.RadioButton rbtnOptionD;
        private System.Windows.Forms.RadioButton rbtnOptionC;
        private System.Windows.Forms.RadioButton rbtnOptionB;
        private System.Windows.Forms.RadioButton rbtnOptionA;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblFeedback;
        private System.Windows.Forms.Button btnNextQuestion;
        private System.Windows.Forms.Button btnRestartQuiz;
    }
}

