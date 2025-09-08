# 🎮 Big Boi Runnin' - Gioco Esame

[![Unity](https://img.shields.io/badge/Unity-2019.4+-000000.svg?logo=unity&style=flat)](https://unity.com/)
[![C#](https://img.shields.io/badge/C%23-7.0+-239120.svg?logo=c-sharp&style=flat)](https://docs.microsoft.com/en-us/dotnet/csharp/)
[![Platform](https://img.shields.io/badge/Platform-Windows-blue.svg)](https://github.com/GiorCocc/gioco-esame-eseguibile-windows)
[![License](https://img.shields.io/badge/License-Open_Source-green.svg)](#-license)

> 🏃‍♂️ Un emozionante gioco platform 2D in stile Super Mario creato per l'esame di maturità

**🇮🇹 [Italiano](#-descrizione-italiana) | 🇬🇧 [English](#-english-description)**

---

## 📋 Table of Contents

- [🎯 Descrizione Italiana](#-descrizione-italiana)
- [🚀 Caratteristiche Principali](#-caratteristiche-principali)
- [🎮 Come Giocare](#-come-giocare)
- [⚙️ Installazione](#️-installazione)
- [🛠️ Tecnologie Utilizzate](#️-tecnologie-utilizzate)
- [📁 Struttura del Progetto](#-struttura-del-progetto)
- [🎯 English Description](#-english-description)
- [🤝 Contributing](#-contributing)
- [📄 License](#-license)
- [🙏 Ringraziamenti](#-ringraziamenti)

---

## 🎯 Descrizione Italiana

**Big Boi Runnin'** è un gioco platform 2D sviluppato come progetto per l'esame di maturità del corso di informatica presso il Liceo Scientifico opzione Scienze Applicate di Cremona. 

Il gioco si ispira al classico stile **Super Mario** ed è basato sul progetto open source [Red Runner](https://bayat.itch.io/red-runner) dello sviluppatore Bayat. Il giocatore controlla un personaggio che deve superare sfide sempre più difficili attraverso tre livelli unici.

### 🏆 Obiettivo del Gioco
- 🪙 **Raccogli monete** di tre valori differenti per accumulare punti
- ❤️ **Gestisci 5 vite** con saggezza
- 🏁 **Supera 3 livelli** di difficoltà crescente
- 🎯 **Raggiungi il punteggio più alto** possibile

---

## 🚀 Caratteristiche Principali

### 🎮 Gameplay
- **🏃‍♂️ Movimento fluido**: Corsa e salti responsivi
- **💰 Sistema di punteggio**: Monete con valori multipli
- **❤️ Sistema vite**: 5 vite per completare l'avventura
- **👾 Nemici intelligenti**: AI per nemici con movimento automatico
- **⏸️ Menu pausa**: Controllo completo del gioco

### 🎨 Interfaccia
- **💬 Sistema dialoghi**: Interazioni narrative
- **🖥️ Menu principale**: Interfaccia utente intuitiva
- **📊 HUD dinamico**: Visualizzazione punteggio e vite in tempo reale
- **🔄 Transizioni scene**: Passaggio fluido tra livelli

### 🗺️ Livelli
1. **🌱 Level 1 - Giorgio**: Introduzione alle meccaniche base
2. **⚡ Level 2 - Alessandro**: Difficoltà intermedia con nuove sfide
3. **🔥 Livello 3 - Martina**: Sfida finale ad alta difficoltà

---

## 🎮 Come Giocare

### 🎯 Controlli
- **⬅️➡️ Frecce**: Movimento sinistro/destro
- **⬆️ Spazio**: Salto
- **⏸️ ESC**: Menu pausa

### 🏆 Strategie
- 💡 **Esplora attentamente** ogni area per trovare tutte le monete
- ⚠️ **Attenzione ai nemici** - studiare i loro pattern di movimento
- 🎯 **Usa i salti strategicamente** - molte sezioni richiedono precisione
- 💪 **Non arrenderti** - alcune sezioni sembrano impossibili ma sono fattibili!

---

## ⚙️ Installazione

### 📋 Requisiti di Sistema
- **💻 OS**: Windows 7/8/10/11 (per l'eseguibile)
- **🎮 Unity**: 2019.4+ (per sviluppo)
- **⚡ RAM**: 4GB minimo
- **💾 Spazio**: 500MB disponibili

### 🚀 Metodo 1: Scarica l'Eseguibile (Windows)
```bash
# Vai al repository degli eseguibili
https://github.com/GiorCocc/gioco-esame-eseguibile-windows

# Scarica e avvia il file .exe
```

### 🛠️ Metodo 2: Compila dai Sorgenti
```bash
# Clona questo repository
git clone https://github.com/GiorCocc/gioco-esame.git

# Apri il progetto in Unity 2019.4+
# File → Open Project → Seleziona la cartella del progetto

# Build del progetto
# File → Build Settings → Build
```

---

## 🛠️ Tecnologie Utilizzate

| Tecnologia | Versione | Utilizzo |
|------------|----------|----------|
| ![Unity](https://img.shields.io/badge/Unity-000000?style=flat&logo=unity) | 2019.4+ | 🎮 Motore di gioco principale |
| ![C#](https://img.shields.io/badge/C%23-239120?style=flat&logo=c-sharp) | 7.0+ | 💻 Linguaggio di programmazione |
| ![Visual Studio](https://img.shields.io/badge/Visual_Studio-5C2D91?style=flat&logo=visual-studio) | - | 🔧 IDE per sviluppo |

### 📚 Risorse di Apprendimento
- 🎓 [Corso Unity su Udemy](https://www.udemy.com/course/unitycourse/)
- 🎨 [Red Runner Asset Store](https://bayat.itch.io/red-runner)

---

## 📁 Struttura del Progetto

```
gioco-esame/
├── 📁 Assets/
│   ├── 🎬 Animations/          # Animazioni personaggi e oggetti
│   ├── 🎨 Materials/           # Materiali grafici
│   ├── 🎮 Prefab/             # Prefab riutilizzabili
│   ├── 🗺️ Scenes/             # Scene del gioco
│   │   ├── Livelli/           # I 3 livelli di gioco
│   │   └── Ui/                # Interfacce utente
│   ├── 💻 Scripts/            # Script C# del gameplay
│   │   ├── Player.cs          # Controllo del giocatore
│   │   ├── CoinPickup.cs      # Sistema raccolta monete
│   │   ├── EnemyMovement.cs   # AI dei nemici
│   │   ├── GameSession.cs     # Gestione sessione di gioco
│   │   └── ...                # Altri script
│   └── 🎨 Sprites&Tiles/      # Grafica 2D e tilemap
├── 📋 ProjectSettings/         # Configurazioni Unity
└── 📦 Packages/               # Pacchetti Unity
```

---

## 🎯 English Description

**Big Boi Runnin'** is a 2D platform game developed as a graduation project for the computer science course at the Scientific High School with Applied Sciences option in Cremona, Italy.

The game is inspired by the classic **Super Mario** style and is based on the open source [Red Runner](https://bayat.itch.io/red-runner) project by developer Bayat. Players control a character who must overcome increasingly difficult challenges through three unique levels.

### 🏆 Game Objective
- 🪙 **Collect coins** of three different values to accumulate points
- ❤️ **Manage 5 lives** wisely
- 🏁 **Complete 3 levels** of increasing difficulty
- 🎯 **Achieve the highest score** possible

### 🚀 Key Features
- **🏃‍♂️ Fluid movement**: Responsive running and jumping
- **💰 Scoring system**: Multi-value coin collection
- **❤️ Lives system**: 5 lives to complete the adventure
- **👾 Smart enemies**: AI-driven automatic movement
- **💬 Dialogue system**: Narrative interactions
- **⏸️ Pause menu**: Complete game control

---

## 🤝 Contributing

Questo progetto è **open source** e accoglie contributi dalla comunità! 

### 💡 Come Contribuire
1. 🍴 **Fork** il repository
2. 🌟 **Crea** un branch per la tua feature (`git checkout -b feature/AmazingFeature`)
3. 💾 **Commit** le tue modifiche (`git commit -m 'Add some AmazingFeature'`)
4. 📤 **Push** al branch (`git push origin feature/AmazingFeature`)
5. 🔄 **Apri** una Pull Request

### 🐛 Segnalazione Bug
- Usa le [GitHub Issues](https://github.com/GiorCocc/gioco-esame/issues) per segnalare bug
- Fornisci dettagli sul sistema operativo e versione Unity
- Includi screenshot se possibile

### 💡 Richieste Feature
- Proponi nuove funzionalità tramite Issues
- Discuti l'implementazione prima di iniziare il lavoro

---

## 📄 License

Questo progetto è rilasciato sotto **licenza open source**. Tutte le grafiche e i codici sono liberi di essere utilizzati per migliorare ed espandere il gioco.

### 📜 Uso Consentito
- ✅ Uso personale e educativo
- ✅ Modifiche e miglioramenti
- ✅ Redistribuzione con attribuzione
- ✅ Uso commerciale (con attribuzione)

---

## 🙏 Ringraziamenti

- 🎨 **Bayat Games** - Per l'asset [Red Runner](https://bayat.itch.io/red-runner) open source
- 🎓 **Udemy Unity Course** - Per le [lezioni di Unity](https://www.udemy.com/course/unitycourse/)
- 🏫 **Liceo Scientifico Cremona** - Per il supporto educativo
- 👥 **Team di sviluppo**:
  - **Giorgio** - Level 1 Design
  - **Alessandro** - Level 2 Design  
  - **Martina** - Level 3 Design

### 🔗 Link Utili
- 🎮 **[Download Eseguibile Windows](https://github.com/GiorCocc/gioco-esame-eseguibile-windows)**
- 🌐 **[Red Runner Original](https://bayat.itch.io/red-runner)**
- 📚 **[Unity Learn](https://learn.unity.com/)**

---

## ⚠️ Note Importanti

**⚠️ Stato del Progetto**: Il gioco non è più supportato nello sviluppo (o almeno per il momento) e non ci saranno eventuali correzioni e/o aggiornamenti da parte del creatore originale dopo la sua pubblicazione.

**💻 Compatibilità**: L'eseguibile è compatibile solo con Windows. Per Mac e Linux è necessario compilare i file sorgenti presenti in questo repository.

---

<div align="center">

**🎮 Buon Divertimento! | Have Fun! 🎮**

Made with ❤️ for education and fun

</div>
