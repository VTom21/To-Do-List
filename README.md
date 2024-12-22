# To-Do List App

A simple and interactive To-Do List application built with C# and Windows Forms. This app allows users to add, remove, and manage tasks with priorities. It also tracks time spent on tasks and provides XP-based leveling mechanics to gamify task management. The app includes a customizable character avatar and progress bar for a more engaging experience.

## Features

- **Add Tasks**: Add new tasks with a title and priority (Low, Medium, High).
- **Remove Tasks**: Remove a task from the list.
- **Clear All Tasks**: Clear all tasks in the list.
- **Mark Tasks as Completed**: Tasks can be marked as completed, granting XP based on priority.
- **XP and Leveling**: The user gains XP for completed tasks, which leads to leveling up.
- **Ranking System**: User's rank changes based on their level, with associated character images.
- **Progress Bar**: A visual bar shows the user's progress towards their next level.
- **Timer**: A timer tracks the time spent using the app.
- **Customizable Theme**: The app allows users to customize backgrounds and character images.
- **Persistent Storage**: Saves total XP, level, and time in text files.

## Technologies Used

- **C#**: Main programming language.
- **Windows Forms**: UI framework used for the app.
- **StreamWriter/StreamReader**: For saving and loading total time, XP, and highest level from text files.

## File Paths (Local Storage)

- **Home Path**: The path to an executable that can be opened from within the app (`Home.exe`).
- **Character Images**: Image paths for the character avatars (Viking, Mage, Rogue, etc.).
- **Bars**: Image paths for different progress bars based on the user's XP.
- **Text Files**:
  - `total time.txt`: Stores the total time spent in the app.
  - `total xp.txt`: Stores the total XP accumulated.
  - `level.txt`: Stores the current highest level achieved.

### Local File Example Paths:
- `Home.exe` (Executable): `"C:\Users\Tomi\OneDrive\Asztali gép\To Do App\ToDo\ToDo\Home\bin\Debug\Home.exe"`
- Character Images: `"C:\Users\Tomi\OneDrive\Asztali gép\To Do App\ToDo\ToDo\Sprites\Viking.png"`

## Installation

### Prerequisites

Make sure you have the following installed:
- **Visual Studio** or any other C# compatible IDE.
- **.NET Framework 4.7.2** or later.

### Setup

1. Clone or download the repository to your local machine.
   
   ```bash
   git clone https://github.com/your-username/to-do-list-app.git
