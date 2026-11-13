# Development of an Interactive C# Console-Based Tic-Tac-Toe Game Application with Score Tracking

**Course:** ITEC 102 – Fundamentals of Programming  
**Institution:** Laguna State Polytechnic University – College of Computer Studies  

## Project Description
Traditional pen-and-paper Tic-Tac-Toe games require manual grid drawing and constant human tracking, which can lead to turn oversights or score disputes. This project digitizes the classic two-player board game into a lightweight, interactive **C# Console Application** featuring real-time board rendering, single-keystroke controls, automated move validation, and persistent multi-round score tracking.

## Objectives
### General Objective
* To develop a functional, interactive C# console-based Tic-Tac-Toe game application that automates two-player gameplay, move validation, win-loss detection, and session management using basic programming constructs.

### Specific Objectives
* To develop a simple C# console application that addresses the limitations of manual board game tracking.
* To accept and process user inputs (player names and slot choices) using variables and appropriate data types (`string`, `char`, `int`).
* To implement conditional statements (`if-else`) and looping structures (`while`) to control game flow and alternate turns between players.
* To perform necessary logical evaluations, such as checking winning patterns across rows, columns, and diagonals, and tracking move counts.
* To display accurate and organized results through the console interface, including the real-time visual rendering of the 3×3 game board.
* To test the program and verify that its features—including input validation and restart/exit choices—work reliably without crashing.

## Group Members
* **Cabangal, Shelldon Reygie B.** – Group Leader
* **Piñana, Alexander Jr. G.** – Member

## Technologies & Programming Language Used
* **Language:** C#
* **Platform / Compiler:** Console Application (.NET / OnlineGDB)
* **Core Concepts:** Variables & Data Types, `Console.ReadLine()`, `Console.ReadKey()`, `Console.Clear()`, `if-else` Conditionals, `while` Loops

## System Features
* **Custom Player Registration:** Supports custom names for Player 1 (`[X]`) and Player 2 (`[O]`), automatically capped at 10 characters to maintain clean ASCII box alignment.
* **Single-Keystroke Gameplay:** Uses `Console.ReadKey` for instant grid selection (`1–9`) and post-game menu navigation without pressing Enter.
* **Input & Move Validation:** Prevents players from selecting occupied cells or entering invalid keys.
* **Live Match Metrics:** Displays an updated 3×3 grid alongside a live scoreboard tracking wins across rounds.
* **Session Control:** Interactive post-round menu allowing players to **Restart Game (`[2]`)** or **End Game (`[1]`)** to view the final score summary.

## Repository Structure
```text
ITEC102-Final-Project/
├── README.md
├── Proposal/
│   └── Finalproject-Proposal-Form.pdf
├── src/
│   └── Program.cs
├── flowcharts/
│   └── Flowchart_TicTacToe_ITEC102_Final_Project.pdf
├── pseudocode/
│   └── Pseudocode.pdf
├── screenshots/
│   ├── Screenshot1.png
│   ├── Screenshot2.png
│   ├── Screenshot3.png
│   ├── Screenshot4.png
│   └── Screenshot5.png
└── documentation/
    └── User-Manual.pdf
```

## How to Run the Code
1. Open the source file located at `src/Program.cs`.
2. Copy the code into **OnlineGDB** ([onlinegdb.com](https://onlinegdb.com)) with the language set to **C#**, or open it in **Visual Studio** / **.NET CLI**.
3. Click **Run** (or run `dotnet run` in your terminal).
4. Enter names for Player 1 and Player 2 (up to 10 characters each) and press keys `1–9` to play.
