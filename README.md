# CyberSecurityChatbotGUI

A C# Windows Forms application designed to promote cybersecurity awareness through an interactive chatbot, task assistant, and a mini quiz. 
It includes dark mode support, activity logging, audio greeting, NLP-powered command recognition, and colorful UI feedback.

## 📦 Features

- 🤖 **Cybersecurity Chatbot**  
  Responds to security-related keywords (e.g., phishing, malware, privacy) and offers practical tips.

- ✅ **Task Assistant**  
  Add, delete, and complete tasks with optional reminder dates (natural language reminders also supported).

- 🧠 **NLP Command Handling**  
  Understands flexible commands like "remind me to update my password" or "start quiz".

- 📝 **Activity Log**  
  Tracks recent actions including tasks, reminders, and quiz attempts.

- 🎮 **Cybersecurity Quiz**  
  18-question multiple-choice quiz with instant feedback, score tracking, and educational explanations.

- 🌙 **Dark Mode Toggle**  
  Seamlessly switch between light and dark themes with a top-right toggle.

- 🔊 **Audio Greeting**  
  Plays a welcome sound on startup before showing the ASCII logo and greeting.


## 🛠️ Setup Instructions

### 🔧 Requirements
- **Windows OS**
- **Visual Studio 2022**
- **.NET Framework (preferably 4.7.2 or later) I used 4.8**

### 📁 Clone the Project

```bash
git clone https://github.com/Nkosi-Mmasebotsana/CyberSecurityChatbotGUI2.git


🚀 Running the Application

(1) Open in Visual Studio 2022:

- Open the .sln file (e.g., CyberSecurityChatbotGUI.sln).
- Wait for project dependencies to load.

(2) Run the application:

- Press F5 or click Start Debugging.

(3) Interact with the app:

- A greeting audio will play.
- Enter your name when prompted.
- Begin chatting with the bot, add tasks, or type commands like:
    - "add task Update antivirus"
    - "remind me in 3 days"
    - "start the quiz"


💬 Sample Commands

| Command                      | Description                                    |
| ---------------------------- | ---------------------------------------------- |
| add task Submit assignment   | Adds a task titled *Submit assignment*.        |
| remind me in 5 days          | Sets a reminder 5 days from today.             |
| remind me on 2025-08-01      | Sets a reminder on a specific date.            |
| start quiz                   | Switches to the quiz tab.                      |
| exit` or quit                | Triggers the exit confirmation dialog.         |
| what have you done?          | Displays the last 5 or 10 actions taken.       |
| phishing or malware          | Triggers a cybersecurity tip from the chatbot. |


📂Project Structure

CyberSecurityChatbotGUI/
├── CyberSecurityChatbotGUI.sln       # Visual Studio solution file
├── Form1.cs                          # Main application logic (chatbot, quiz, tasks)                     
├── ChatBot.cs                        # Chat logic and keyword detection
├── QuizData.cs                       # Static class containing quiz questions
├── Memory.cs                         # Stores user preferences (e.g., name)
├── SentimentAnalyzer.cs              # Analyzes positive/negative sentiment (if used)
├── UIHelpers.cs                      # Helper formatting for messages (console version only)
├── TaskItem.cs                       # Represents a single task with optional reminder
├── Resources/
│   └── greeting.wav                  # Embedded welcome audio file


🎨 UI Overview

Chatbot Tab:
- Colored feedback (tips in green, errors in red, greetings in purple).

Task Assistant Tab:
- Add, complete, and delete tasks.
- Set reminders via picker or natural language.

 Quiz Tab: 
- Answer questions, get explanations, track your score.
- Restart as needed.


🧪 Development Notes
- Designed and built using Windows Forms in Visual Studio 2022.
- Code organized into logical components (chat, tasks, quiz).
- Embedded Resources used for audio playback — greeting.wav is bundled within the project.
- Dark mode and ASCII art dynamically styled via isDarkModeEnabled.


🔗 Version Control & GitHub Usage
This project was version-controlled and deployed using the following process:

(1) Created a new repository on GitHub.com.
(2) Opened the project in Visual Studio 2022.
(3) Used Git Changes to commit changes.
(4) Connected to the existing GitHub repo and pushed directly using Visual Studio.


🧑‍💻 Author
Created by Mmasebotsana Nkosi | © 2025
