# 🎮 Big Boi Runnin' - Exam Game

[![Unity](https://img.shields.io/badge/Unity-2019.4+-000000.svg?logo=unity&style=flat)](https://unity.com/)
[![C#](https://img.shields.io/badge/C%23-7.0+-239120.svg?logo=c-sharp&style=flat)](https://docs.microsoft.com/en-us/dotnet/csharp/)
[![Platform](https://img.shields.io/badge/Platform-Windows-blue.svg)](https://github.com/GiorCocc/gioco-esame-eseguibile-windows)
[![License](https://img.shields.io/badge/License-Open_Source-green.svg)](#-license)

> 🏃‍♂️ An exciting 2D Super Mario-style platformer created for a high school graduation exam

---

## 📋 Table of Contents

- [🎯 Description](#-description)
- [🚀 Key Features](#-key-features)
- [🎮 How to Play](#-how-to-play)
- [⚙️ Installation](#️-installation)
- [🛠️ Technologies Used](#️-technologies-used)
- [📁 Project Structure](#-project-structure)
- [🤝 Contributing](#-contributing)
- [📄 License](#-license)
- [🙏 Acknowledgements](#-acknowledgements)

---

## 🎯 Description

**Big Boi Runnin'** is a 2D platform game developed as a graduation project for the computer science course at the Scientific High School with Applied Sciences option in Cremona, Italy.

The game is inspired by the classic **Super Mario** style and is based on the open source [Red Runner](https://bayat.itch.io/red-runner) project by developer Bayat. Players control a character who must overcome increasingly difficult challenges through three unique levels.

### 🏆 Game Objective
- 🪙 **Collect coins** of three different values to accumulate points
- ❤️ **Manage 5 lives** wisely
- 🏁 **Complete 3 levels** of increasing difficulty
- 🎯 **Achieve the highest score** possible

---

## 🚀 Key Features

### 🎮 Gameplay
- **🏃‍♂️ Fluid movement**: Responsive running and jumping
- **💰 Scoring system**: Multi-value coin collection
- **❤️ Lives system**: 5 lives to complete the adventure
- **👾 Smart enemies**: AI for enemies with automatic movement
- **⏸️ Pause menu**: Full game control

### 🎨 Interface
- **💬 Dialogue system**: Narrative interactions
- **🖥️ Main menu**: Intuitive user interface
- **📊 Dynamic HUD**: Real-time score and lives display
- **🔄 Scene transitions**: Smooth passage between levels

### 🗺️ Levels
1.  **🌱 Level 1 - Giorgio**: Introduction to basic mechanics
2.  **⚡ Level 2 - Alessandro**: Intermediate difficulty with new challenges
3.  **🔥 Level 3 - Martina**: Final high-difficulty challenge

---

## 🎮 How to Play

### 🎯 Controls
- **⬅️➡️ Arrow Keys**: Left/Right movement
- **⬆️ Spacebar**: Jump
- **⏸️ ESC**: Pause menu

### 🏆 Strategies
- 💡 **Carefully explore** each area to find all the coins
- ⚠️ **Watch out for enemies** - study their movement patterns
- 🎯 **Use jumps strategically** - many sections require precision
- 💪 **Don't give up** - some sections seem impossible but they are doable!

---

## ⚙️ Installation

### 📋 System Requirements
- **💻 OS**: Windows 7/8/10/11 (for the executable)
- **🎮 Unity**: 2019.4+ (for development)
- **⚡ RAM**: 4GB minimum
- **💾 Storage**: 500MB available

### 🚀 Method 1: Download the Executable (Windows)
```bash
# Go to the executables repository
https://github.com/GiorCocc/gioco-esame-eseguibile-windows

# Download and run the .exe file
```

### 🛠️ Method 2: Compile from Source
```bash
# Clone this repository
git clone https://github.com/GiorCocc/gioco-esame.git

# Open the project in Unity 2019.4+
# File → Open Project → Select the project folder

# Build the project
# File → Build Settings → Build
```

---

## 🛠️ Technologies Used

| Technology | Version | Usage |
|------------|----------|----------|
| ![Unity](https://img.shields.io/badge/Unity-000000?style=flat&logo=unity) | 2019.4+ | 🎮 Main game engine |
| ![C#](https://img.shields.io/badge/C%23-239120?style=flat&logo=c-sharp) | 7.0+ | 💻 Programming language |
| ![Visual Studio](https://img.shields.io/badge/Visual_Studio-5C2D91?style=flat&logo=visual-studio) | - | 🔧 IDE for development |

### 📚 Learning Resources
- 🎓 [Unity Course on Udemy](https://www.udemy.com/course/unitycourse/)
- 🎨 [Red Runner Asset Store](https://bayat.itch.io/red-runner)

---

## 📁 Project Structure

```
gioco-esame/
├── 📁 Assets/
│   ├── 🎬 Animations/          # Character and object animations
│   ├── 🎨 Materials/           # Graphic materials
│   ├── 🎮 Prefab/             # Reusable prefabs
│   ├── 🗺️ Scenes/             # Game scenes
│   │   ├── Livelli/           # The 3 game levels
│   │   └── Ui/                # User interfaces
│   ├── 💻 Scripts/            # C# gameplay scripts
│   │   ├── Player.cs          # Player control
│   │   ├── CoinPickup.cs      # Coin collection system
│   │   ├── EnemyMovement.cs   # Enemy AI
│   │   ├── GameSession.cs     # Game session management
│   │   └── ...                # Other scripts
│   └── 🎨 Sprites&Tiles/      # 2D graphics and tilemaps
├── 📋 ProjectSettings/         # Unity configurations
└── 📦 Packages/               # Unity packages
```

---

## 🤝 Contributing

This project is **open source** and welcomes contributions from the community!

### 💡 How to Contribute
1.  🍴 **Fork** the repository
2.  🌟 **Create** a branch for your feature (`git checkout -b feature/AmazingFeature`)
3.  💾 **Commit** your changes (`git commit -m 'Add some AmazingFeature'`)
4.  📤 **Push** to the branch (`git push origin feature/AmazingFeature`)
5.  🔄 **Open** a Pull Request

### 🐛 Reporting Bugs
- Use [GitHub Issues](https://github.com/GiorCocc/gioco-esame/issues) to report bugs
- Provide details about your operating system and Unity version
- Include screenshots if possible

### 💡 Feature Requests
- Propose new features via Issues
- Discuss the implementation before starting work

---

## 📄 License

This project is released under an **open source license**. All graphics and code are free to be used to improve and expand the game.

### 📜 Permitted Use
- ✅ Personal and educational use
- ✅ Modifications and improvements
- ✅ Redistribution with attribution
- ✅ Commercial use (with attribution)

---

## 🙏 Acknowledgements

- 🎨 **Bayat Games** - For the open source [Red Runner](https://bayat.itch.io/red-runner) asset
- 🎓 **Udemy Unity Course** - For the [Unity lessons](https://www.udemy.com/course/unitycourse/)
- 🏫 **Liceo Scientifico Cremona** - For the educational support
- 👥 **Development Team**:
  - **Giorgio** - Level 1 Design
  - **Alessandro** - Level 2 Design
  - **Martina** - Level 3 Design

### 🔗 Useful Links
- 🎮 **[Download Windows Executable](https://github.com/GiorCocc/gioco-esame-eseguibile-windows)**
- 🌐 **[Original Red Runner](https://bayat.itch.io/red-runner)**
- 📚 **[Unity Learn](https://learn.unity.com/)**

---

## ⚠️ Important Notes

**⚠️ Project Status**: The game is no longer actively developed (at least for now), and there will be no further corrections or updates from the original creator after its publication.

**💻 Compatibility**: The executable is compatible only with Windows. For Mac and Linux, you must compile the source files from this repository.

---

<div align="center">

**🎮 Have Fun! 🎮**

Made with ❤️ for education and fun

</div>
