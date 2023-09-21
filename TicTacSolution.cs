using System;
namespace TicTacChallenge
{
    public class TicTacSolution
    {
         static string[,] arry2D = 
        {
                {"1","2","3" },
                {"4","5","6" },
                {"7","8","9" }
          };
        public static void ShowTac(
        {
            Console.Clear();
            for (int a = 0; a < 3; a++)
            {
                for (int b = 0; b < 3; b++)
                {
                    Console.Write("{0} |", arry2D[a, b]);
                }
                Console.WriteLine();
                Console.WriteLine("---------");
            }
        }

        public static void TicTac()
        { 
            var playerId = true;
            int cnt =0;
            var status = true;
            while (status == true)
            {
                ShowTac();
                Check();
                switch (playerId)
                {
                             

                    case true:
                        Console.WriteLine("Player 1: Choose Field: ");
                        var p1= Console.ReadLine();
                        if (String.IsNullOrWhiteSpace(p1))
                        {
                            break; 
                        }
                        var s =Convert.ToInt32(p1);
                        switch (s)
                        {
                            case 1:
                                if (arry2D[0, 0] != "o")
                                    arry2D[0, 0] = "x";

                                break;
                            case 2:
                                if (arry2D[0, 1] != "o")
                                    arry2D[0, 1] = "x";

                                break;
                            case 3:
                                if (arry2D[0, 2] != "o")
                                    arry2D[0, 2] = "x";

                                break;
                            case 4:
                                if (arry2D[1, 0] != "o")
                                    arry2D[1, 0] = "x";
                                break;
                            case 5:
                                if (arry2D[1, 1] != "o")
                                    arry2D[1, 1] = "x";
                                break;
                            case 6:
                                if (arry2D[1, 2] != "o")
                                    arry2D[1, 2] = "x";
                                break;
                            case 7:
                                if (arry2D[2, 0] != "o")
                                    arry2D[2, 0] = "x";
                                break;
                            case 8:
                                if (arry2D[2, 1] != "o")
                                    arry2D[2, 1] = "x";

                                break;
                            case 9:
                                if (arry2D[2, 2] != "o")
                                    arry2D[2, 2] = "x";

                                break;
                        }
                         

                        break;
                         

                    case false:
                        Console.WriteLine("Player 2: Choose Field: ");
                        var p2 = Console.ReadLine();
                        if (String.IsNullOrWhiteSpace(p2))
                        {
                            break;
                        }
                        var q = Convert.ToInt32(p2);
                        switch (q)
                        {
                            case 1:
                                if (arry2D[0, 0] !="x")
                                arry2D[0, 0] = "o";
                                break;  
                            case 2:
                                if (arry2D[0, 1] != "x")
                                    arry2D[0, 1] = "o";
                                break;
                            case 3:
                                if (arry2D[0, 2] != "x")
                                    arry2D[0, 2] = "o";
                                break;
                            case 4:
                                if (arry2D[1, 0] != "x")
                                    arry2D[1, 0] = "o";
                                break;
                            case 5:
                                if (arry2D[1, 1] != "x")
                                    arry2D[1, 1] = "o";
                                break;
                            case 6:
                                if (arry2D[1, 2] != "x")
                                    arry2D[1, 2] = "o";
                                break;
                            case 7:
                                if (arry2D[2, 0] != "x")
                                    arry2D[2, 0] = "o";
                                break;
                            case 8:
                                if (arry2D[2, 1] != "x")
                                   arry2D[2, 1] = "o";
                                break;
                            case 9:
                                if (arry2D[2, 2] != "x")
                                    arry2D[2, 2] = "o";
                                break;
                        }
                        break;
                }
 
                playerId = !playerId;
                cnt++;
                 
                if (cnt == 9)
                {

                    status = false;
                }

            }

        }
        public static void Check( )
        {
            if ((arry2D[0, 0] == "x" && arry2D[1, 0] == "x" && arry2D[2, 0] == "x") || (arry2D[0, 1] == "x" && arry2D[1, 1] == "x" && arry2D[2, 1] == "x") || (arry2D[0, 2] == "x" && arry2D[1, 2] == "x" && arry2D[2, 2] == "x"))
            {
                Console.Clear();
                Console.WriteLine("player 1 won");
                Console.WriteLine("press any key to close");
                Console.ReadKey();
                System.Environment.Exit(0);
            }
            else if ((arry2D[0, 0] == "o" && arry2D[1, 0] == "o" && arry2D[2, 0] == "o") || (arry2D[0, 1] == "o" && arry2D[1, 1] == "o" && arry2D[2, 1] == "o") || (arry2D[0, 2] == "o" && arry2D[1, 2] == "o" && arry2D[2, 2] == "o"))
            {
                Console.Clear();
                Console.WriteLine("player 2 won");
                Console.WriteLine("press any key to close");
                Console.ReadKey();
                System.Environment.Exit(0);
            }
            else if ((arry2D[0, 0] == "x" && arry2D[0, 1] == "x" && arry2D[0, 2] == "x") || (arry2D[1, 0] == "x" && arry2D[1, 1] == "x" && arry2D[1, 2] == "x") || (arry2D[2, 0] == "x" && arry2D[2, 1] == "x" && arry2D[2, 2] == "x"))
            {
                Console.Clear();
                Console.WriteLine("player 1 won");
                Console.WriteLine("press any key to close");
                Console.ReadKey();
                System.Environment.Exit(0);
            }
            else if ((arry2D[0, 0] == "o" && arry2D[0, 1] == "o" && arry2D[0, 2] == "o") || (arry2D[1, 0] == "o" && arry2D[1, 1] == "o" && arry2D[1, 2] == "o") || (arry2D[2, 0] == "o" && arry2D[2, 1] == "o" && arry2D[2, 2] == "o"))
            {
                Console.Clear();
                Console.WriteLine("player 2 won");
                Console.WriteLine("press any key to close");
                Console.ReadKey();
                System.Environment.Exit(0);
            }
            else if ((arry2D[0, 0] == "x" && arry2D[1, 1] == "x" && arry2D[2, 2] == "x") || (arry2D[0, 2] == "x" && arry2D[1, 1] == "x" && arry2D[2, 0] == "x"))
            {
                Console.Clear();
                Console.WriteLine("player 1 won");
                Console.WriteLine("press any key to close");
                Console.ReadKey();
                System.Environment.Exit(0);
            }


            else if ((arry2D[0, 0] == "o" && arry2D[1, 1] == "o" && arry2D[2, 2] == "o") || (arry2D[0, 2] == "o" && arry2D[1, 1] == "o" && arry2D[2, 0] == "o"))
            {
                Console.Clear();
                Console.WriteLine("player 2 won");
                Console.WriteLine("press any key to close");
                Console.ReadKey();
                System.Environment.Exit(0);

            }
            else
            {
                Console.WriteLine("looking for winner");
                
            }
        }
    }
}
