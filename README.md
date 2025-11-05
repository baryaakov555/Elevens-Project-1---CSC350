Elevens (Project 1) – Final Submission

Bar Yaakov
CSC 350 – Fall 2025

Overview:

This project is a console-based implementation of the classic card game Elevens.
The program simulates a 9-card board dealt from a standard 52-card deck.
The player selects cards to remove. They can either remove:

Two cards whose values add up to 11.

Or

Three cards that are: Jack, Queen, and a King all togehter.

Each valid move replaces the selected cards with new ones from the deck.
The game continues until there are no more legal plays left, at which point it ends automatically.

---------------------------------------------------------------------------------------------------------------------------

How to Compile and Run:

Open the project in Visual Studio 2022 or any compatible C# IDE.

Build the project (Ctrl + Shift + B).

Run it (Ctrl + F5 or the green “Run” button).

---------------------------------------------------------------------------------------------------------------------------

How to Play:

The program will deal 9 cards and display them on the console.

Enter the indexes (1–9) of your chosen cards seperated by a comma:

Example for an 11 pair: 2,5 (card at index two being five of hearts and card at index 5 being six of spades)

Example for J-Q-K: 1,4,8

If your move is valid, the selected cards will be replaced with new ones.

Continue until no legal moves remain.

When no moves are possible, the game ends with:

No more legal plays left. Game Over!

---------------------------------------------------------------------------------------------------------------------------

Key Features:

Automatic card replacement system.

Shuffle and deck management logic.

Input validation and user-friendly console prompts.

Automated game-over detection.

Fully object-oriented design.

---------------------------------------------------------------------------------------------------------------------------

Summary:

This project helped reinforce the following aspects:

OOP concepts such as encapsulation and class interaction.

List manipulation and dynamic collections.

Conditional logic and loops for real gameplay flow.

Testing and debugging.

Challenges:
Debugging the IsLegalMove() logic and ensuring board updates were correctly synchronized with the deck was tricky.

Solution:
I added clear helper functions (ReplaceCards(), AnotherPlayIsPossible(), DisplayBoard()) and used tested them.

---------------------------------------------------------------------------------------------------------------------------

Example gameplay flow:

<img width="463" height="1199" alt="Screenshot 2025-11-05 003124" src="https://github.com/user-attachments/assets/ecc6d1d6-d57a-4b3d-9361-effbbb95697a" />
