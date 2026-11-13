using System;

class Program
{
    static void Main()
    {
        Console.Clear();
        Console.WriteLine("╔═════════════════════════════════════════════════════════╗");
        Console.WriteLine("║                    TIC TAC TOE PROJECT                  ║");
        Console.WriteLine("╚═════════════════════════════════════════════════════════╝");

        Console.Write("\nPlayer 1 Name: ");
        string n1 = Console.ReadLine().Trim();
        if (n1 == "") { n1 = "Player 1"; }
        if (n1.Length > 10) { n1 = n1.Substring(0, 10); }

        Console.Write("Player 2 Name: ");
        string n2 = Console.ReadLine().Trim();
        if (n2 == "") { n2 = "Player 2"; }
        if (n2.Length > 10) { n2 = n2.Substring(0, 10); }
        
        char s1 = '1', s2 = '2', s3 = '3';
        char s4 = '4', s5 = '5', s6 = '6';
        char s7 = '7', s8 = '8', s9 = '9';

        int game = 1;
        int scoreA = 0;
        int scoreB = 0;
        
        while (game == 1)
        {
            int moves = 0;
            bool gameOver = false;

            s1 = '1'; s2 = '2'; s3 = '3';
            s4 = '4'; s5 = '5'; s6 = '6';
            s7 = '7'; s8 = '8'; s9 = '9';

            while (moves < 9 && !gameOver)
            {
                // ================= PLAYER 1 TURN =================
                bool p1Turn = true;
                while (p1Turn)
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

                    Console.Write($"{n1}'s turn (Press 1-9): ");
                    char m = Console.ReadKey(true).KeyChar;

                    if (m == '1' && s1 != 'X' && s1 != 'O') { s1 = 'X'; p1Turn = false; }
                    else if (m == '2' && s2 != 'X' && s2 != 'O') { s2 = 'X'; p1Turn = false; }
                    else if (m == '3' && s3 != 'X' && s3 != 'O') { s3 = 'X'; p1Turn = false; }
                    else if (m == '4' && s4 != 'X' && s4 != 'O') { s4 = 'X'; p1Turn = false; }
                    else if (m == '5' && s5 != 'X' && s5 != 'O') { s5 = 'X'; p1Turn = false; }
                    else if (m == '6' && s6 != 'X' && s6 != 'O') { s6 = 'X'; p1Turn = false; }
                    else if (m == '7' && s7 != 'X' && s7 != 'O') { s7 = 'X'; p1Turn = false; }
                    else if (m == '8' && s8 != 'X' && s8 != 'O') { s8 = 'X'; p1Turn = false; }
                    else if (m == '9' && s9 != 'X' && s9 != 'O') { s9 = 'X'; p1Turn = false; }
                    else 
                    { 
                        Console.WriteLine("\nInvalid move or slot already taken. Press any key to try again."); 
                        Console.ReadKey(true);
                    }
                }
                moves++;

                // Check Player 1 Win
                if ((s1 == 'X' && s2 == 'X' && s3 == 'X') || (s4 == 'X' && s5 == 'X' && s6 == 'X') || (s7 == 'X' && s8 == 'X' && s9 == 'X') ||
                    (s1 == 'X' && s4 == 'X' && s7 == 'X') || (s2 == 'X' && s5 == 'X' && s8 == 'X') || (s3 == 'X' && s6 == 'X' && s9 == 'X') ||
                    (s1 == 'X' && s5 == 'X' && s9 == 'X') || (s3 == 'X' && s5 == 'X' && s7 == 'X'))
                {
                    scoreA++;
                    gameOver = true;
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
                    Console.WriteLine($"🎉 {n1} WINS THIS ROUND! 🎉");
                }

                // Check Draw
                if (moves == 9 && !gameOver)
                {
                    gameOver = true;
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
                    Console.WriteLine("🤝 It's a draw round! 🤝");
                }

                if (!gameOver)
                {
                    // ================= PLAYER 2 TURN =================
                    bool p2Turn = true;
                    while (p2Turn)
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

                        Console.Write($"{n2}'s turn (Press 1-9): ");
                        char mv = Console.ReadKey(true).KeyChar;

                        if (mv == '1' && s1 != 'X' && s1 != 'O') { s1 = 'O'; p2Turn = false; }
                        else if (mv == '2' && s2 != 'X' && s2 != 'O') { s2 = 'O'; p2Turn = false; }
                        else if (mv == '3' && s3 != 'X' && s3 != 'O') { s3 = 'O'; p2Turn = false; }
                        else if (mv == '4' && s4 != 'X' && s4 != 'O') { s4 = 'O'; p2Turn = false; }
                        else if (mv == '5' && s5 != 'X' && s5 != 'O') { s5 = 'O'; p2Turn = false; }
                        else if (mv == '6' && s6 != 'X' && s6 != 'O') { s6 = 'O'; p2Turn = false; }
                        else if (mv == '7' && s7 != 'X' && s7 != 'O') { s7 = 'O'; p2Turn = false; }
                        else if (mv == '8' && s8 != 'X' && s8 != 'O') { s8 = 'O'; p2Turn = false; }
                        else if (mv == '9' && s9 != 'X' && s9 != 'O') { s9 = 'O'; p2Turn = false; }
                        else 
                        { 
                            Console.WriteLine("\nInvalid move or slot already taken. Press any key to try again."); 
                            Console.ReadKey(true);
                        }
                    }
                    moves++;

                    // Check Player 2 Win
                    if ((s1 == 'O' && s2 == 'O' && s3 == 'O') || (s4 == 'O' && s5 == 'O' && s6 == 'O') || (s7 == 'O' && s8 == 'O' && s9 == 'O') ||
                        (s1 == 'O' && s4 == 'O' && s7 == 'O') || (s2 == 'O' && s5 == 'O' && s8 == 'O') || (s3 == 'O' && s6 == 'O' && s9 == 'O') ||
                        (s1 == 'O' && s5 == 'O' && s9 == 'O') || (s3 == 'O' && s5 == 'O' && s7 == 'O'))
                    {
                        scoreB++;
                        gameOver = true;
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
                        Console.WriteLine($"🎉 {n2} WINS THIS ROUND! 🎉");
                    }
                }
            }

            // ================= END OR RESTART MENU =================
            bool choiceMade = false;
            while (!choiceMade)
            {
                Console.Write("\nPress [1] End Game | [2] Restart Game: ");
                char choice = Console.ReadKey(true).KeyChar;

                if (choice == '1')
                {
                    game = 0;
                    choiceMade = true;
                    Console.Clear();
                    string left = $"{n1} ({scoreA})";
                    string right = $"({scoreB}) {n2}";
                    Console.WriteLine("╔═════════════════════════════════════════════════════════╗");
                    Console.WriteLine("║                       FINAL SCORES                      ║");
                    Console.WriteLine("╠═════════════════════════════════════════════════════════╣");
                    Console.WriteLine($"║   {left,23}  |  {right,-23}   ║");
                    Console.WriteLine("╚═════════════════════════════════════════════════════════╝");
                    Console.WriteLine(" Thank you for playing our application!");
                }
                else if (choice == '2')
                {
                    choiceMade = true;
                    Console.WriteLine("\nGame Restarted...");
                }
                else
                {
                    Console.WriteLine("\nInvalid choice. Please press either 1 or 2.");
                }
            }
        }
    }
}
