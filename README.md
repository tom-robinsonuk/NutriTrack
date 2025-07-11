# NutriTrack

**NutriTrack** is a modern web-based nutrition and hunger tracker built with **C# and ASP.NET**, using **Razor Pages** and **SQLite**.

It was created to demonstrate full-stack .NET skills relevant to real-world QA/Dev work.

---

## 🚀 Features

- Daily food tracking: kcal, protein, carbs, fats, liquids, exercise, location
- Hunger journaling per day
- Hunger score (1–10) pre/post meal (optional)
- Weekly average calculations
- SQLite database integration
- Clean, modern Razor Pages architecture
- No external dependencies

---

## 🔧 Tech Stack

- ASP.NET Core 8.0 (C#)
- Razor Pages
- Entity Framework Core
- SQLite
- Bootstrap (bundled with template)

---

## 🛠️ Getting Started

### Prerequisites
- [.NET SDK](https://dotnet.microsoft.com/en-us/download)
- Visual Studio / VS Code

### Clone and Run
```bash
git clone https://github.com/yourusername/NutriTrack.git
cd NutriTrack
dotnet restore
dotnet ef database update
dotnet run
