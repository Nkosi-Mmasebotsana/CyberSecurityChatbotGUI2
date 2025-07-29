using System;
using System.Collections.Generic; //needed for List<TaskItem>
using System.Drawing;
using System.Globalization; //needed for parsing numbers in reminder text
using System.IO;
using System.Media;
using System.Reflection;
using System.Text.RegularExpressions; //for reminder parsing
using System.Threading.Tasks;
using System.Windows.Forms;
using CyberSecurityChatbot;
using Microsoft.VisualBasic; // Needed for InputBox
using System.Linq; // Added for randomization


namespace CyberSecurityChatbotGUI
{
    public partial class Form1 : Form
    {
        ChatBot chatbot = new ChatBot();

        //  Add a list to store TaskItems
        private List<TaskItem> tasks = new List<TaskItem>();


        // State for reminder flow
        private bool awaitingReminder = false;
        private TaskItem lastAddedTask = null;


        // Activity log to store recent chatbot actions
        private List<string> activityLog = new List<string>();
        private const int MaxLogEntries = 10;
        private string userName = "friend";


        private int currentQuestionIndex = 0;
        private int score = 0;
        private List<QuizQuestion> quizQuestions;


        private CheckBox chkDarkMode;
        private bool isDarkModeEnabled = false;

        private int asciiLogoLength = 0;


        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
            InitializeDarkModeToggle();
            this.FormClosing += Form1_FormClosing;

        }
        private void InitializeDarkModeToggle()
        {
            chkDarkMode = new CheckBox();
            chkDarkMode.Name = "chkDarkMode";
            chkDarkMode.Text = "Dark Mode";
            chkDarkMode.AutoSize = true;
            chkDarkMode.Location = new Point(500, 10); // Top right corner of form

            chkDarkMode.CheckedChanged += (s, e) =>
            {
                bool isDark = chkDarkMode.Checked;
                ToggleDarkMode(isDark);
                
            };

            // Adds the checkbox directly to the Form (not to a tab)
            this.Controls.Add(chkDarkMode);
            chkDarkMode.BringToFront(); // Ensure it's visible
        }

        //dark mode toggle implementation
        private void ToggleDarkMode(bool enableDarkMode)
        {
            isDarkModeEnabled = enableDarkMode;

            Color backColor = enableDarkMode ? Color.FromArgb(30, 30, 30) : SystemColors.Control;
            Color foreColor = enableDarkMode ? Color.White : Color.Black;

            this.BackColor = backColor;

            ApplyThemeToControls(this.Controls, backColor, foreColor);

            // Just update the color of the existing ASCII logo
            UpdateAsciiLogoColor();

        }

        private void ApplyThemeToControls(Control.ControlCollection controls, Color backColor, Color foreColor)
        {
            foreach (Control ctrl in controls)
            {
                if (ctrl is TabControl || ctrl is TabPage || ctrl is Panel || ctrl is GroupBox)
                {
                    ctrl.BackColor = backColor;
                    ctrl.ForeColor = foreColor;
                    ApplyThemeToControls(ctrl.Controls, backColor, foreColor);
                }
                else
                {
                    ctrl.BackColor = backColor;
                    ctrl.ForeColor = foreColor;
                }
            }
        }

        private string asciiLogoText = @"
  _____      _                _____             _            
  / ____|    | |              / ____|           | |           
 | |    _   _| |__  _ __ ___ | (___  _   _ _ __ | |_ ___ _ __ 
 | |   | | | | '_ \| '__/ _ \ \___ \| | | | '_ \| __/ _ \ '__|
 | |___| |_| | |_) | | | (_) |____) | |_| | | | | ||  __/ |   
  \_____\__,_|_.__/|_| \___/|_____/ \__, |_| |_|\__\___|_|   
                                      __/ |                    
                                     |___/                     
  _____           _                  _____              _      
 / ____|         | |                / ____|            | |     
| (___   ___  ___| |_ _   _ _ __   | |     ___  _ __ __| |___  
 \___ \ / _ \/ __| __| | | | '_ \  | |    / _ \| '__/ _` / __| 
 ____) |  __/ (__| |_| |_| | |_) | | |___| (_) | | | (_| \__ \ 
|_____/ \___|\___|\__|\__,_| .__/   \_____|\___/|_|  \__,_|___/ 
                           | |                                 
                           |_|           

       Cybersecurity Awareness Chatbot
";

        private void ShowAsciiLogo()
        {
            // Append the logo at the end of the conversation only if it's not already there
            if (!rtbConversation.Text.StartsWith(asciiLogoText.Trim()))

            {
                rtbConversation.SelectionStart = 0;
                rtbConversation.SelectionLength = 0;
                rtbConversation.SelectionColor = isDarkModeEnabled ? Color.Cyan : Color.DarkBlue;
                rtbConversation.SelectedText = asciiLogoText + Environment.NewLine + Environment.NewLine;

                // Store the length of the added logo text + newlines for later color updates
                asciiLogoLength = asciiLogoText.Length + (Environment.NewLine.Length * 2);

                rtbConversation.SelectionColor = rtbConversation.ForeColor;
            }
        }
        private void UpdateAsciiLogoColor()
        {
            if (rtbConversation.TextLength >= asciiLogoLength && asciiLogoLength > 0)
            {
                rtbConversation.SelectionStart = 0;
                rtbConversation.SelectionLength = asciiLogoLength;
                rtbConversation.SelectionColor = isDarkModeEnabled ? Color.Cyan : Color.DarkBlue;
                rtbConversation.SelectionLength = 0; // clear selection
            }
        }


        private async void Form1_Load(object sender, EventArgs e)
        {

            await PlayGreetingAudioAsync();

            // Ask for user's name
            userName = PromptForName();
            chatbot.SetUserName(userName);


            // Show greeting message in chat
            string welcomeMessage = chatbot.GetWelcomeMessage() + $"\n\nType 'exit' or 'quit' anytime to close the application, {userName}.";
            AppendBotMessage(welcomeMessage);


            ShowAsciiLogo();


            RefreshTaskList(); // Display any tasks (initially empty)

            quizQuestions = QuizData.GetQuestions().OrderBy(q => rng.Next()).ToList();
            LoadCurrentQuestion();
        }


        private string PromptForName()
        {
            string input = Interaction.InputBox("Please enter your name:", "User Name", "friend");
            return string.IsNullOrWhiteSpace(input) ? "friend" : input;
        }

        private void btnSend1_Click(object sender, EventArgs e)
        {
            string userInput = txtUserInput1.Text.Trim();

            if (string.IsNullOrWhiteSpace(userInput))
                return;

            AppendUserMessage(userInput);

            string lowerInput = userInput.ToLower();
            if (lowerInput == "exit" || lowerInput == "quit")
            {
                DialogResult result = MessageBox.Show("Are you sure you want to exit the application?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    MessageBox.Show($"Goodbye, {userName}. Stay safe online!", "Exit", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Exit();
                    return;
                }
                else
                {
                    AppendBotMessage("Exit canceled. You can continue using the app.");
                    return;
                }
            }


            // Try to handle task commands via simple NLP parsing
            string botResponse = HandleTaskCommands(userInput);


            // If no task command detected, fallback to normal chatbot response
            if (botResponse == null)
            {
                botResponse = chatbot.GetResponse(userInput);
            }

            AppendBotMessage(botResponse);


            txtUserInput1.Clear();
            txtUserInput1.Focus();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private string HandleTaskCommands(string input)
        {
            // Lowercase for easier matching
            string lowerInput = input.ToLower();


            // NLP: Prioritize task/reminder/quiz detection before topic detection

            if ((lowerInput.Contains("add task") || lowerInput.Contains("create task") || lowerInput.Contains("new task")) &&
                !lowerInput.StartsWith("add "))
            {
                string simulatedInput = "add " + lowerInput.Substring(lowerInput.IndexOf("task") + 4).Trim();
                return HandleTaskCommands(simulatedInput);
            }

            if (Regex.IsMatch(lowerInput, @"\b(remind me to|set reminder|reminder for)\b") &&
                !lowerInput.StartsWith("remind me"))
            {
                string simulatedReminder = "remind me " + lowerInput;
                return HandleTaskCommands(simulatedReminder);
            }

            if (Regex.IsMatch(lowerInput, @"\b(quiz|start.*quiz|take.*quiz|do.*quiz)\b"))
            {
                tabControl1.SelectedTab = tabPageQuiz;
                AddToActivityLog("Quiz started via NLP command.");
                return "Let's begin the cybersecurity quiz! Answer the questions to test your knowledge.";
            }


            // Block chatbot tip detection if this is a task or reminder command
            bool isTaskCommand = lowerInput.StartsWith("add ") || lowerInput.Contains("add task") || lowerInput.Contains("remind me");
            if (!isTaskCommand && Regex.IsMatch(lowerInput, @"\b(phishing|malware|2fa|two-factor|privacy|cybersecurity)\b"))
            {
                return chatbot.GetResponse(input);
            }


            // If awaiting reminder input
            if (awaitingReminder && lastAddedTask != null)
            {
                // Look for "yes" and "remind me in X days" or "remind me on YYYY-MM-DD"
                if (lowerInput.Contains("yes") || lowerInput.Contains("remind me"))
                {
                    // Try to extract days number using regex
                    var match = Regex.Match(lowerInput, @"remind me in (\d+) days");
                    if (match.Success)
                    {
                        int days = int.Parse(match.Groups[1].Value);
                        lastAddedTask.ReminderDate = DateTime.Now.AddDays(days).Date;
                        awaitingReminder = false;
                        RefreshTaskList();
                        AddToActivityLog($"Reminder set for task '{lastAddedTask.Title}' on {lastAddedTask.ReminderDate?.ToShortDateString()}");

                        return $"Got it! I'll remind you in {days} days. You can also manage your reminders anytime in the Tasks tab.";
                    }

                    // Try to extract date 
                    match = Regex.Match(lowerInput, @"remind me on (\d{4}-\d{2}-\d{2})");
                    if (match.Success)
                    {
                        if (DateTime.TryParseExact(match.Groups[1].Value, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime date))
                        {
                            lastAddedTask.ReminderDate = date.Date;
                            awaitingReminder = false;
                            RefreshTaskList();
                            AddToActivityLog($"Reminder set for task '{lastAddedTask.Title}' on {lastAddedTask.ReminderDate?.ToShortDateString()}");

                            return $"Got it! I'll remind you on {date.ToShortDateString()}. You can also manage your reminders anytime in the Tasks tab.";
                        }
                    }

                    // User said yes but no valid time found - ask for clarification
                    return "Please specify the reminder timeframe, e.g., 'remind me in 3 days' or 'remind me on 2025-07-30'.";
                }
                else
                {
                    // User said no or something else - cancel awaiting reminder
                    awaitingReminder = false;
                    lastAddedTask = null;
                    return "No problem! You can always add reminders later in the Tasks tab.";
                }
            }


            // Add Task command: detect phrases like "add task", "add a task", "new task"
            if (lowerInput.Contains("add task") || lowerInput.StartsWith("add "))
            {

                // Extract possible title after "add task" or "add"
                string title = null;

                if (lowerInput.Contains("add task"))
                {
                    int idx = lowerInput.IndexOf("add task") + "add task".Length;
                    title = input.Length > idx ? input.Substring(idx).Trim(new char[] { '-', ' ', ':' }) : null;
                }
                else if (lowerInput.StartsWith("add "))
                {
                    title = input.Substring(4).Trim(new char[] { '-', ' ', ':' });
                }

                if (string.IsNullOrWhiteSpace(title))
                    return "Please specify the task title after 'add task'.";


                // Create a task with no description or reminder by default
                TaskItem newTask = new TaskItem(title, $"Task: {title}");
                tasks.Add(newTask);
                lastAddedTask = newTask;
                awaitingReminder = true;
                RefreshTaskList();
                AddToActivityLog($"Task added via NLP: '{title}'");
                
                return $"Task added with the title \"{title}\". You can add a description and reminder using the Task Assistant tab.";
            }


            // Delete Task command: "delete task" or "remove task" + title or just prompt user to select in UI
            if (lowerInput.Contains("delete task") || lowerInput.Contains("remove task"))
            {
                
                return "Please select the task you want to delete from the Task Assistant tab and click 'Delete Selected Task'.";
            }


            if (lowerInput.Contains("mark task complete") || lowerInput.Contains("complete task"))
            {
                return "Please select the task you want to mark as completed from the Task Assistant tab and click 'Mark as Completed'.";
            }


            // Reminder command (basic detection)
            if (lowerInput.Contains("remind me"))
            {
                return "To set reminders, please use the Task Assistant tab to add or edit tasks with reminder dates.";
            }

            if (lowerInput.Contains("activity log") || lowerInput.Contains("what have you done"))
            {
                if (activityLog.Count == 0)
                    return "The activity log is currently empty.";

                string logOutput = "Here’s a summary of recent actions:\n\n";
                foreach (string entry in activityLog)
                {
                    logOutput += "- " + entry + "\n";
                }
                return logOutput.TrimEnd();
            }

            // No task command detected
            return null;
        }

        private void AddToActivityLog(string entry)
        {
            string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
            string fullEntry = $"{timestamp}: {entry}";
            activityLog.Add(fullEntry);
            if (activityLog.Count > MaxLogEntries)
            {
                activityLog.RemoveAt(0);
            }
        }


        private async Task PlayGreetingAudioAsync()
        {
            try
            {
                var assembly = typeof(ChatBot).Assembly;
               
                using (Stream stream = assembly.GetManifestResourceStream("CyberSecurityChatbotLogic.greeting.wav"))
                {
                    if (stream != null)
                    {
                        using (SoundPlayer player = new SoundPlayer(stream))
                        {
                            player.PlaySync();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Could not find greeting.wav embedded resource.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Audio playback error: " + ex.Message);
            }
        }

        // Helper methods to show user and bot messages
        private void AppendUserMessage(string message)
        {
            rtbConversation.AppendText("You: " + message + Environment.NewLine);
        }

        private void AppendBotMessage(string message)
        {
            Color color = Color.Black;
            string lower = message.ToLower();

            if (lower.Contains("goodbye") || lower.Contains("welcome"))
                color = Color.Purple;
            else if (lower.Contains("error") || lower.Contains("didn't quite understand"))
                color = Color.Red;
            else if (lower.Contains("tip") || lower.Contains("protect") || lower.Contains("stay safe"))
                color = Color.Green;
            else if (isDarkModeEnabled)
                color = Color.LightSkyBlue; //  use bright blue only in dark mode

            rtbConversation.SelectionStart = rtbConversation.TextLength;
            rtbConversation.SelectionColor = color;
            rtbConversation.AppendText("Bot: " + message + Environment.NewLine);
            rtbConversation.SelectionColor = rtbConversation.ForeColor;
        }

        
        private void btnAddTask_Click(object sender, EventArgs e)
        {
            string title = txtTaskTitle.Text.Trim();
            string description = txtTaskDescription.Text.Trim();
            DateTime? reminderDate = null;


            if (string.IsNullOrEmpty(title))
            {
                MessageBox.Show("Please enter a task title.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (dtpReminder.Checked) // If user picked a reminder date
            {
                reminderDate = dtpReminder.Value.Date;
            }


            TaskItem newTask = new TaskItem(title, description, reminderDate);
            tasks.Add(newTask);


            RefreshTaskList();


            // Clear input fields after adding
            txtTaskTitle.Clear();
            txtTaskDescription.Clear();
            dtpReminder.Value = DateTime.Now;
            dtpReminder.Checked = false;


            // Show message box AND append chatbot message to conversation
            MessageBox.Show($"Task '{title}' added successfully!", "Task Added", MessageBoxButtons.OK, MessageBoxIcon.Information);

            AppendBotMessage($"Task added: '{title}'. Would you like a reminder?\n" +
                            $"\nRemember, you can type 'exit' anytime to close the application, {userName}.");


            // Update lastAddedTask & awaitingReminder for flow consistency if adding via UI:
            lastAddedTask = newTask;
            awaitingReminder = true;
            AddToActivityLog($"Task added via UI: '{title}'");

        }

        
        private void btnDeleteTask_Click(object sender, EventArgs e)
        {

            if (lstTasks.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a task to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            TaskItem selectedTask = (TaskItem)lstTasks.SelectedItem;
            tasks.Remove(selectedTask);

            RefreshTaskList();

            AppendBotMessage($"Task '{selectedTask.Title}' deleted.");
            AddToActivityLog($"Task deleted: '{selectedTask.Title}'");

        }

        private void btnMarkComplete_Click(object sender, EventArgs e)
        {

            if (lstTasks.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a task to mark as completed.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            TaskItem selectedTask = (TaskItem)lstTasks.SelectedItem;
            selectedTask.IsCompleted = true;

            RefreshTaskList();

            AppendBotMessage($"Task '{selectedTask.Title}' marked as completed.");
            AddToActivityLog($"Task marked as completed: '{selectedTask.Title}'");

        }

        //  Helper to refresh the ListBox display
        private void RefreshTaskList()
        {
            lstTasks.DataSource = null;
            lstTasks.DataSource = tasks;
        }
        private void rtbConversation_TextChanged(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        

        // Quiz state
        
        private bool answerSubmitted = false;
        private Random rng = new Random();

        private void LoadCurrentQuestion()
        {
            if (currentQuestionIndex >= quizQuestions.Count)
            {
                lblQuestion.Text = $"Quiz Completed! You scored {score} out of {quizQuestions.Count}.";

                // Provide score-based feedback
                if (score >= 16)
                    lblFeedback.Text = "Excellent! You're a security pro! Click 'Restart Quiz' to try again.";
                else if (score >= 9)
                    lblFeedback.Text = "Good job! Keep learning! Click 'Restart Quiz' to try again.";
                else
                    lblFeedback.Text = "Keep practicing – cybersecurity is important! Click 'Restart Quiz' to try again.";

                
                lblFeedback.Text += $"\n\nYou can type 'exit' anytime to close the application, {userName}.";

                lblFeedback.ForeColor = isDarkModeEnabled ? Color.LightSkyBlue : Color.Black;
                DisableQuizButtons();
                AddToActivityLog($"Quiz completed. Score: {score}/{quizQuestions.Count}");
                return;
            }

            QuizQuestion question = quizQuestions[currentQuestionIndex];
            lblQuestion.Text = question.Question;
            rbtnOptionA.Text = question.Options[0];
            rbtnOptionB.Text = question.Options[1];
            rbtnOptionC.Text = question.Options[2];
            rbtnOptionD.Text = question.Options[3];

            // Clear previous selections and feedback
            rbtnOptionA.Checked = false;
            rbtnOptionB.Checked = false;
            rbtnOptionC.Checked = false;
            rbtnOptionD.Checked = false;
            lblFeedback.Text = "";
            lblFeedback.ForeColor = Color.Black;
            answerSubmitted = false;
            btnNextQuestion.Enabled = false;
            btnSubmitAnswer.Enabled = true;
        }

        private void btnSubmitAnswer_Click(object sender, EventArgs e)
        {
            if (answerSubmitted)
                return;

            int selectedIndex = -1;
            if (rbtnOptionA.Checked) selectedIndex = 0;
            else if (rbtnOptionB.Checked) selectedIndex = 1;
            else if (rbtnOptionC.Checked) selectedIndex = 2;
            else if (rbtnOptionD.Checked) selectedIndex = 3;

            if (selectedIndex == -1)
            {
                MessageBox.Show("Please select an answer before submitting.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            QuizQuestion current = quizQuestions[currentQuestionIndex];
            if (selectedIndex == current.CorrectOptionIndex)
            {
                lblFeedback.ForeColor = Color.Green;
                lblFeedback.Text = $"Correct! ✅\n{current.Explanation}";
                score++;
            }
            else
            {
                lblFeedback.ForeColor = Color.Red;
                lblFeedback.Text = $"Incorrect ❌\n{current.Explanation}";
            }

            answerSubmitted = true;
            btnNextQuestion.Enabled = true;
            btnSubmitAnswer.Enabled = false;
        }

        
        private void btnNextQuestion_Click(object sender, EventArgs e)
        {
            currentQuestionIndex++;
            LoadCurrentQuestion();
        }

        
        private void btnRestartQuiz_Click(object sender, EventArgs e)
        {
            score = 0;
            currentQuestionIndex = 0;
            quizQuestions = QuizData.GetQuestions().OrderBy(q => rng.Next()).ToList();
            EnableQuizButtons();
            LoadCurrentQuestion();
            AddToActivityLog("Quiz restarted.");
        }

        // Enable buttons for quiz interaction
        private void EnableQuizButtons()
        {
            btnSubmitAnswer.Enabled = true;
            btnNextQuestion.Enabled = false;
            btnRestartQuiz.Enabled = true;
        }

        // Disable buttons at the end of the quiz
        private void DisableQuizButtons()
        {
            btnSubmitAnswer.Enabled = false;
            btnNextQuestion.Enabled = false;
            btnRestartQuiz.Enabled = true;
        }

    }
}
