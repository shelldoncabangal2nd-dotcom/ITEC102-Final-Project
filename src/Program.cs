using System;

class Program
{
    static string n1 = "", n2 = "", currentName = "";
    static char s1 = '1', s2 = '2', s3 = '3', s4 = '4', s5 = '5', s6 = '6', s7 = '7', s8 = '8', s9 = '9';
    static char currentMark = 'X';
    static int scoreA = 0, scoreB = 0, moves = 0, game = 1;
    static bool gameOver = false;

    static void Main()
    {
        Console.Clear();
        Console.WriteLine("╔═════════════════════════════════════════════════════════╗");
        Console.WriteLine("║                    TIC TAC TOE PROJECT                  ║");
        Console.WriteLine("╚═════════════════════════════════════════════════════════╝");

        Console.Write("\nPlayer 1 Name: ");
        string input1 = Console.ReadLine();
        if (input1 == null) { input1 = ""; }
        n1 = "";
        for (int i = 0; i < input1.Length; i++)
        {
            char c = input1[i];
            if ((c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z') || (c >= '0' && c <= '9') || c == ' ')
            {
                n1 = n1 + c;
            }
        }
        n1 = n1.Trim();
        if (n1 == "") { n1 = "Player 1"; }
        if (n1.Length > 10) { n1 = n1.Substring(0, 10); }

        Console.Write("Player 2 Name: ");
        string input2 = Console.ReadLine();
        if (input2 == null) { input2 = ""; }
        n2 = "";
        for (int i = 0; i < input2.Length; i++)
        {
            char c = input2[i];
            if ((c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z') || (c >= '0' && c <= '9') || c == ' ')
            {
                n2 = n2 + c;
            }
        }
        n2 = n2.Trim();
        if (n2 == "") { n2 = "Player 2"; }
        if (n2.Length > 10) { n2 = n2.Substring(0, 10); }
        
        while (game == 1)
        {
            moves = 0;
            gameOver = false;
            s1 = '1'; s2 = '2'; s3 = '3'; s4 = '4'; s5 = '5'; s6 = '6'; s7 = '7'; s8 = '8'; s9 = '9';

            while (moves < 9 && !gameOver)
            {
                currentName = n1; currentMark = 'X';
                PlayTurn();
                CheckResult();

                if (!gameOver)
                {
                    currentName = n2; currentMark = 'O';
                    PlayTurn();
                    CheckResult();
                }
            }
            EndOrRestartMenu();
        }
    }

    static void DrawBoard()
    {
        Console.Clear();
        Console.WriteLine("╔═════════════════════════════════════════════════════════╗");
        Console.WriteLine("║                 ITEC 102: TIC-TAC-TOE                   ║");
        Console.WriteLine("╚═════════════════════════════════════════════════════════╝");
        Console.WriteLine("  ┌───────────────┐     ┌─────────────────────────────────┐");
        Console.WriteLine($"  │   {s1} │ {s2} │ {s3}   │     │ {"MATCH METRICS",-31} │");
        Console.WriteLine("  │  ───┼───┼───  │     │ ─────────────────────────────── │");
        Console.WriteLine($"  │   {s4} │ {s5} │ {s6}   │     │ Player 1 [X]: {n1,-17} │");
        Console.WriteLine($"  │  ───┼───┼───  │     │ Player 2 [O]: {n2,-17} │");
        string scoreText = $"Score: P1 ({scoreA}) vs P2 ({scoreB})";
        Console.WriteLine($"  │   {s7} │ {s8} │ {s9}   │     │ {scoreText,-31} │");
        Console.WriteLine("  └───────────────┘     └─────────────────────────────────┘\n");
    }

    static void PlayTurn()
    {
        bool turn = true;
        while (turn)
        {
            DrawBoard();
            Console.Write($"{currentName}'s turn (Press 1-9): ");
            char m = Console.ReadKey(true).KeyChar;

            if (m == '1' && s1 != 'X' && s1 != 'O') { s1 = currentMark; turn = false; }
            else if (m == '2' && s2 != 'X' && s2 != 'O') { s2 = currentMark; turn = false; }
            else if (m == '3' && s3 != 'X' && s3 != 'O') { s3 = currentMark; turn = false; }
            else if (m == '4' && s4 != 'X' && s4 != 'O') { s4 = currentMark; turn = false; }
            else if (m == '5' && s5 != 'X' && s5 != 'O') { s5 = currentMark; turn = false; }
            else if (m == '6' && s6 != 'X' && s6 != 'O') { s6 = currentMark; turn = false; }
            else if (m == '7' && s7 != 'X' && s7 != 'O') { s7 = currentMark; turn = false; }
            else if (m == '8' && s8 != 'X' && s8 != 'O') { s8 = currentMark; turn = false; }
            else if (m == '9' && s9 != 'X' && s9 != 'O') { s9 = currentMark; turn = false; }
            else
            {
                Console.WriteLine("\nInvalid move or slot already taken. Press any key to try again.");
                Console.ReadKey(true);
            }
        }
        moves++;
    }

    static void CheckResult()
    {
        if ((s1 == currentMark && s2 == currentMark && s3 == currentMark) || (s4 == currentMark && s5 == currentMark && s6 == currentMark) || (s7 == currentMark && s8 == currentMark && s9 == currentMark) ||
            (s1 == currentMark && s4 == currentMark && s7 == currentMark) || (s2 == currentMark && s5 == currentMark && s8 == currentMark) || (s3 == currentMark && s6 == currentMark && s9 == currentMark) ||
            (s1 == currentMark && s5 == currentMark && s9 == currentMark) || (s3 == currentMark && s5 == currentMark && s7 == currentMark))
        {
            if (currentMark == 'X') { scoreA++; } else { scoreB++; }
            gameOver = true;
            DrawBoard();
            Console.WriteLine($"*** {currentName} WINS THIS ROUND! ***");
            Console.Write("Press any key to continue...");
            Console.ReadKey(true);
        }
        else if (moves == 9)
        {
            gameOver = true;
            DrawBoard();
            Console.WriteLine("=== It's a draw round! ===");
            Console.Write("Press any key to continue...");
            Console.ReadKey(true);
        }
    }

    static void EndOrRestartMenu()
    {
        bool choiceMade = false;
        while (!choiceMade)
        {
            DrawBoard();
            Console.Write("Press [1] End Game | [2] Restart Game: ");
            char choice = Console.ReadKey(true).KeyChar;
            if (choice == '1')
            {
                game = 0; choiceMade = true;
                Console.Clear();
                string left = $"{n1} ({scoreA})", right = $"({scoreB}) {n2}";
                Console.WriteLine("╔═════════════════════════════════════════════════════════╗");
                Console.WriteLine("║                       FINAL SCORES                      ║");
                Console.WriteLine("╠═════════════════════════════════════════════════════════╣");
                Console.WriteLine($"║   {left,23}  |  {right,-23}   ║");
                Console.WriteLine("╚═════════════════════════════════════════════════════════╝");
                Console.WriteLine(" Thank you for playing our application!");
            }
            else if (choice == '2') { choiceMade = true; }
            else { Console.WriteLine("\nInvalid choice. Press any key to try again."); Console.ReadKey(true); }
        }
    }
}
