# AwarenessChatBot

AwarenessChatBot is a cross-platform cybersecurity awareness chatbot intended to help users learn safer online habits through an engaging desktop experience.

## Overview

This project is designed as an educational cybersecurity assistant with features for:

- natural conversational guidance on passwords, phishing, malware, software updates, VPNs, backups, and secure habits
- sentiment-aware responses that adjust tone based on user mood
- conversational memory and simple personalization
- task tracking, reminders, and activity logging
- an interactive cybersecurity quiz with instant feedback
- an Avalonia desktop interface for macOS and Windows

## Features

- chatbot-style guidance for cybersecurity topics
- keyword detection for security questions and commands
- task assistant for cybersecurity actions like enabling 2FA or checking updates
- activity log for recent interactions and actions
- quiz mode for reinforcing cybersecurity knowledge
- voice greeting support through the desktop app

## Getting Started

### Prerequisites

- .NET 8.0 SDK
- Avalonia Desktop support on macOS or Windows

### Build

From the repository root, run:

```bash
dotnet build
```

### Run

If the source is present in a subproject, run the appropriate project file, for example:

```bash
dotnet run --project CyberAwareBot/CyberAwareBot.csproj
```

## Usage

- Ask the chatbot security questions like "How do I create a strong password?" or "What is phishing?"
- Use phrases like "my name is" or "call me" to enable personalized responses
- Start the quiz with commands such as "start quiz" or "quiz"
- View tasks and activity logs in the desktop UI

## Notes

This README has been added to the `AwarenessChatBot` repository to document the cybersecurity awareness chatbot project and support future development.

## License

This repository is intended for educational and demonstration purposes. Feel free to build on it to create a stronger cybersecurity learning experience.