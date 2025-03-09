# 🎳 Unity Bowling Game

## 📌 Overview
This is a **Bowling Game** built in Unity, where players can roll a ball down a lane and knock down pins. The game features physics-based interactions, a scoring system, and realistic pin resets.

## 🎮 Features
- **Realistic Bowling Mechanics** 🏆
- **Score Tracking System** 🧮
- **Automatic Pin Reset System** 🔄
- **Gutter Detection with Force Application** ➡️
- **Player Movement & Camera Control** 🎥
- **Invisible Walls to Keep Ball in Lane** 🚧
- **UI for Score Display** 📊

## 🛠 Setup & Installation
1. Clone the repository.
2. Open **Unity Hub** and add the project.
3. Open the project and start the game.

## 🔧 Controls
- **A / D Keys** → Move the player
- **Mouse** → Aim the direction
- **Spacebar** → Launch the ball
- **R Key** → Reset the game

## 📂 Project Structure
```
/Assets
    /Scripts
        - BallController.cs
        - PinReset.cs
        - Gutter.cs
        - ScoreManager.cs
        - GameManager.cs
    /Prefabs
        - Pin.prefab
        - Ball.prefab
    /UI
        - ScoreText
        - ResetButton
```

## 📜 Key Scripts
### **1️⃣ BallController.cs**
- Manages player movement and ball launch mechanics.
- Adjust **speed** in `Inspector` to modify movement speed.

### **2️⃣ Gutter.cs**
- Detects when the ball enters the gutter.
- Resets velocity and applies directional force.
  
### **3️⃣ PinReset.cs**
- Handles resetting pins after each round.
- Uses prefabs to instantiate new pin sets.

### **4️⃣ ScoreManager.cs**
- Tracks and updates score when pins fall.
- Ensures only valid pin collisions are counted.

### **5️⃣ GameManager.cs**
- Handles game logic like resetting and UI updates.
- Controls pin and ball reset behavior.

Demo:
https://github.com/user-attachments/assets/b85c4414-614d-4f98-b092-20baced6bc80


---
🎯 **Built using Unity**

