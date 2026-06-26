# Cybersecurity Awareness Chatbot

CyberAwareBot is a cross-platform desktop chatbot built with Avalonia and .NET 8. It helps users learn cybersecurity best practices through a conversational experience with reminders, quizzes, sentiment-aware replies, and memory-based follow-ups.

## What this project does

The app provides an interactive assistant for:

- answering cybersecurity questions such as phishing, passwords, malware, updates, VPNs, and backups
- remembering the user's name and recent conversation context
- creating and tracking simple security-related tasks
- running a built-in cybersecurity quiz
- logging recent bot activity for review

## Key features

- natural conversational chat flow with varied responses
- voice greeting on startup using text-to-speech
- keyword-based guidance for common cybersecurity topics
- sentiment-aware tone adjustments based on user input
- conversation memory for context-aware follow-ups
- task reminders with local storage and optional MySQL support
- quiz mode with instant feedback
- a modern Avalonia desktop interface with tabs for chat, tasks, quiz, and activity history

## Example interactions

- User: "How do I create a strong password?"
- Bot: "Strong passwords are your first line of defense. Use a mix of letters, numbers, and symbols, and change them regularly."

- User: "My name is Alex"
- Bot: "Nice to meet you, Alex! I’ll remember your name so our conversation feels more personal."

- User: "Start quiz"
- Bot: "Great choice. Let’s begin the cybersecurity quiz."

## Installation and setup

### Prerequisites
- .NET 8 SDK
- macOS or Windows
- Avalonia desktop runtime support

### Build and run

From the project directory:

```bash
dotnet build
dotnet run
```

You can also build from the repository root if needed:

```bash
dotnet build CyberAwareBot/CyberAwareBot.csproj
dotnet run --project CyberAwareBot/CyberAwareBot.csproj
```

## How to use it

- Ask questions about password safety, phishing, malware, updates, VPNs, or backups.
- Use phrases such as "my name is" or "call me" to personalize the conversation.
- Try commands like "what did we talk about", "add task", "remind me", "start quiz", or "show activity log".

## Project structure

```text
CyberAwareBot/
├── ActivityLog.cs
├── App.axaml
├── App.xaml.cs
├── AudioPlayer.cs
├── Chatbot.cs
├── CyberAwareBot.csproj
├── CyberSecurityTask.cs
├── CyberSecurityTaskStore.cs
├── KeywordResponder.cs
├── MainWindow.axaml
├── MainWindow.xaml.cs
├── MemoryStore.cs
├── Program.cs
├── QuizEngine.cs
├── QuizQuestion.cs
├── SentimentDetector.cs
├── UIHelper.cs
└── README.md
```

## Notes

- The app targets .NET 8 and uses Avalonia for the desktop experience.
- Task storage is local by default and can optionally use MySQL when the `CYBERAWAREBOT_MYSQL_CONNECTION` environment variable is set.
- This project is intended as an educational cybersecurity awareness tool.

## GitHub and ARC submission

GitHub repository: https://github.com/LithaMbawu/AwarenessChatBot.git

If you are submitting to ARC, include the GitHub link and your video demo link in the submission form.

## Demo video

Please update the YouTube demo link below with your latest video before sharing the project publicly.

YouTube video: https://youtu.be/PCWVSgsUzIA?si=J9yzzO7IJ4WFapTH

## License

Educational project — feel free to use and modify it for learning and demonstration purposes.