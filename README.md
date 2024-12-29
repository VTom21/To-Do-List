<h1 align="center">ToDo App - A Gamified Task Management System</h1>


<div align="center">

![Build Status](https://img.shields.io/badge/Build-Passing-lightblue) ![Version](https://img.shields.io/badge/Version-1.0-ghostwhite) ![License](https://img.shields.io/badge/License-MIT-lightblue) ![Last Commit](https://img.shields.io/badge/Last_Commit-1_day_ago-ghostwhite) ![npm](https://img.shields.io/badge/npm-v1.1-lightblue)

![Gmail](https://img.shields.io/badge/Gmail-D14836?style=for-the-badge&logo=gmail&logoColor=white)
![Visual Studio](https://img.shields.io/badge/Visual%20Studio-5C2D91.svg?style=for-the-badge&logo=visual-studio&logoColor=white)
![C#](https://img.shields.io/badge/c%23-%23239120.svg?style=for-the-badge&logo=csharp&logoColor=white)
![Stack Overflow](https://img.shields.io/badge/-Stackoverflow-FE7A16?style=for-the-badge&logo=stack-overflow&logoColor=white)
![Discord](https://img.shields.io/badge/Discord-%235865F2.svg?style=for-the-badge&logo=discord&logoColor=white)


</div>

Welcome to the **ToDo App**, a next-generation **task management system** that combines productivity with a **gaming experience**. 🎮✨ Track your **XP**, level up, earn rewards, and keep an eye on your stats—all while managing your tasks efficiently!

> **Level up your productivity!**

---

<p align="left">
  <img src="https://github.com/VTom21/To-Do-List/blob/master/ToDo/Icons/add_list-48_45484.ico" alt="ToDo App Banner" height="75">
</p>

---

## 🌟 **Table of Contents**

| Section               | Link                                  |
|-----------------------|---------------------------------------|
| [Overview](#overview)  | Overview                             |
| [Features](#features)  | Features                             |
| [Technologies](#technologies) | Technologies                        |
| [File Paths](#file-paths) | File Paths                           |
| [Installation](#installation) | Installation                        |
| [Usage](#usage)        | Usage                                 |
| [Contributing](#contributing) | Contributing                        |
| [License](#license)    | License                               |
| [Acknowledgments](#acknowledgments) | Acknowledgments                    |
| [Contact](#contact)    | Contact                               |
| [Screenshots](#screenshots) | Screenshots                         |

---

## 🌐 **Overview**

**ToDo App** is more than just a productivity tool—it's a **gamified experience** that helps you stay on top of your tasks while earning **XP** and **leveling up**. With each completed task, you gain **XP** and **progress through levels**, unlocking rewards like **higher ranks** and other in-game perks. 📈

### 🎮 **What Makes It Unique?**
- **Gamified Task Management**: Manage tasks as a game, where every task completed is an opportunity to gain XP.
- **XP and Levels**: Track your progress and unlock rewards as you level up and gain XP.
- **Statistics**: Monitor your performance—track total time spent, XP earned, and the highest level you've reached.

---

## ⚡ **Features**

### 🏠 **Home App** - Your Central Hub

The **Home App** serves as your personal dashboard for task management:

- **Start**: Opens the **ToDo App** to begin managing tasks.
- **Level System**: Track your XP, level, and rank.
- **Statistics**: View your performance stats like total time spent, XP earned, and highest level.
- **Quit**: Exit the app when you're done.

### 🎮 **Level System** - Track Your Progress

The **Level System** is where you gain **XP** and **level up** as you complete tasks. The more tasks you finish, the higher your **level** and **rank** increase!

- **Levels**: From **Level 1** to **Level 100+**.
- **Ranks**: Increase your rank as you progress (e.g., **Rookie**, **Sergeant**, **Guardian**, **Ace**).

### 📊 **Statistics App** - Your Personal Performance Dashboard

The **Statistics App** provides insights into your productivity:

- **Total Time**: Tracks the total time spent on tasks (in days, hours, minutes, and seconds).
- **Total XP**: View the total XP earned across all tasks.
- **Highest Level**: Displays your highest level achieved.

---

### 🏆 **Achievements & Rewards**

With each completed task and level progression, unlock **rewards**:

- **XP Boosts**: Earn boosts that increase your XP for subsequent tasks.
- **Special Rewards**: Gain other in-game perks and unlockables at certain level milestones.
- **Badges**: Earn badges for achievements, such as completing a set number of tasks.

---

## 💻 **Technologies Used**

The app uses modern tools and technologies:

| Technology          | Description                                   |
|---------------------|-----------------------------------------------|
| **C#**              | The core programming language powering the app.|
| **Windows Forms**   | For building a sleek and user-friendly graphical interface. |
| **File I/O**        | Read and write progress data (total XP, level, and time). |
| **Graphics & Avatars** | Custom character avatars to enhance the gamified experience. |

---

## 📁 **File Paths (Local Storage)**

This app requires specific file paths for reading and storing data:

### Text Files

| File Name          | Path                                                      |
|--------------------|-----------------------------------------------------------|
| **Total Time**     | `C:\Users\Tomi\OneDrive\ToDoApp\TextFiles\total_time.txt` |
| **Total XP**       | `C:\Users\Tomi\OneDrive\ToDoApp\TextFiles\total_xp.txt`   |
| **Highest Level**  | `C:\Users\Tomi\OneDrive\ToDoApp\TextFiles\level.txt`      |

> **Tip**: Ensure these paths match the locations on your system for proper functionality.

---

### **Code Snippets**:

**Priority XP assignment logic**:

```csharp
switch(task.Priority)
{
    case"Low":
        taskXP=5;
        break;
    case"Medium":
        taskXP=10;
        break;
    case"High":
        taskXP=15;
        break;
    default:
        taskXP=5;
        break;
}
```

**Class for Handling Tasks & Priorities**:

```csharp
class Tasks
        {

            public string Task { get; set; }
            public string Priority { get; set; }

            public Tasks(string _Task, string _Priority)
            {
                Task = _Task;
                Priority = _Priority;
            }

            public override string ToString()
            {
                return $"{Task} - {Priority}";
            }

            public override bool Equals(object obj)
            {
                if (obj is Tasks otherTask)
                {
                    return this.Task == otherTask.Task && this.Priority == otherTask.Priority;
                }
                return false;
            }

            public override int GetHashCode()
            {
                return (Task, Priority).GetHashCode();
            }


        }
```

## 🎨 **Themes in ToDo App**

The **ToDo App** offers a variety of themes to suit different user preferences. These themes not only change the color palette of the app but also add personality and flair to the interface. Whether you prefer something **minimalistic**, **vibrant**, or **futuristic**, there’s a theme for everyone.

### 🌐 **Available Themes**

#### 1. **Cyan (Default)**
- **Description**: The **Cyan** theme is the default theme and offers a bright and modern aesthetic. With its cool blue-green tones, it's easy on the eyes and provides a clean, refreshing feel for the app's interface.
- **Main Colors**:
  - **Background**: Cyan
  - **Text**: White
  - **Buttons**: Lighter Cyan with darker accents

#### 2. **Dark**
- **Description**: The **Dark** theme is perfect for those who prefer a more subdued and elegant interface. This theme uses deep shades of black and gray, with high-contrast white text, offering a sleek and professional look. Ideal for low-light environments or users who prefer darker screens.
- **Main Colors**:
  - **Background**: Dark Gray/Black
  - **Text**: White
  - **Buttons**: Dark Gray with contrasting borders

#### 3. **Purple**
- **Description**: The **Purple** theme brings a touch of royalty and elegance to the app. With its rich shades of purple and violet, it adds a sophisticated vibe while maintaining a modern look.
- **Main Colors**:
  - **Background**: Purple/Violet
  - **Text**: White
  - **Buttons**: Lighter purple with dark accents

#### 4. **Holographic**
- **Description**: The **Holographic** theme is inspired by futuristic, tech-inspired aesthetics. It uses neon colors and vibrant gradients, giving the app a futuristic and dynamic feel. This theme is perfect for users who want an interactive and visually stimulating experience.
- **Main Colors**:
  - **Background**: Gradient with neon hues
  - **Text**: Bright colors with glowing effects
  - **Buttons**: Neon borders and glowing hover effects

#### 5. **Tropical**
- **Description**: The **Tropical** theme brings a burst of sunshine and energy to the app. With warm, bright colors like oranges, yellows, and greens, it creates a vibrant and cheerful atmosphere that energizes the user. Perfect for those who enjoy a lively, summer-inspired environment.
- **Main Colors**:
  - **Background**: Tropical greens, oranges, and yellows
  - **Text**: White or Black depending on the contrast
  - **Buttons**: Bright, sunny accents

#### 6. **Red**
- **Description**: The **Red** theme is bold and intense, perfect for users who want to feel motivated and energized. It uses shades of red and pinks, making the interface powerful and full of energy.
- **Main Colors**:
  - **Background**: Deep red shades
  - **Text**: White or black depending on contrast
  - **Buttons**: Darker red with white highlights


## 🏁 **Installation**

### Prerequisites

To run the **ToDo App**, ensure you have the following installed:

| Prerequisite           | Description                                   |
|------------------------|-----------------------------------------------|
| **Visual Studio**      | IDE to build and run the app.                 |
| **.NET Framework 4.7.2** or later | Required to run the app.                   |

### Steps to Install

1. **Clone the repository**:

   ```bash
   git clone https://github.com/your-username/todo-app.git
