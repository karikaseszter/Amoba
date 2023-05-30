using System;

namespace AmobaV2
{
    class Program
    {
        static void show()
        {
            Console.WriteLine("=============");
            Console.WriteLine("| {0} | {1} | {2} |",map[0,0],map[0,1],map[0,2]);
            Console.WriteLine("=============");
            Console.WriteLine("| {0} | {1} | {2} |",map[1,0],map[1,1],map[1,2]);
            Console.WriteLine("=============");
            Console.WriteLine("| {0} | {1} | {2} |",map[2,0],map[2,1],map[2,2]);
            Console.WriteLine("=============");
        }


        static int winScan()
        {
            if (map[0, 0] == "x" && map[0, 1] == "x" && map[0, 2] == "x")
                return 1;
            else if (map[1, 0] == "x" && map[1, 1] == "x" && map[1, 2] == "x")
                return 1;
            else if (map[2, 0] == "x" && map[2, 1] == "x" && map[2, 2] == "x")
                return 1;
            else if (map[0, 0] == "x" && map[1, 0] == "x" && map[2, 0] == "x")
                return 1;
            else if (map[0, 1] == "x" && map[1, 1] == "x" && map[2, 1] == "x")
                return 1;
            else if (map[0, 2] == "x" && map[1, 2] == "x" && map[2, 2] == "x")
                return 1;
            else if (map[0, 0] == "x" && map[1, 1] == "x" && map[2, 2] == "x")
                return 1;
            else if (map[0, 2] == "x" && map[1, 1] == "x" && map[2, 0] == "x")
                return 1;
            // kör
            else if (map[0, 0] == "o" && map[0, 1] == "o" && map[0, 2] == "o")
                return 2;
            else if (map[1, 0] == "o" && map[1, 1] == "o" && map[1, 2] == "o")
                return 2;
            else if (map[2, 0] == "o" && map[2, 1] == "o" && map[2, 2] == "o")
                return 2;
            else if (map[0, 0] == "o" && map[1, 0] == "o" && map[2, 0] == "o")
                return 2;
            else if (map[0, 1] == "o" && map[1, 1] == "o" && map[2, 1] == "o")
                return 2;
            else if (map[0, 2] == "o" && map[1, 2] == "o" && map[2, 2] == "o")
                return 2;
            else if (map[0, 0] == "o" && map[1, 1] == "o" && map[2, 2] == "o")
                return 2;
            else if (map[0, 2] == "o" && map[1, 1] == "o" && map[2, 0] == "o")
                return 2;
            else
                return 0;
        }
        static string[,] map = new string[3, 3];



        static void Main(string[] args)
        {
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    map[i, j] = "-";


            string p1="", p2="";
            int hiba = 0, p = 1, nyert = 0, round = 0;

            Console.WriteLine("Üdvözlünk a játékban!");
            Console.WriteLine("Amőba. Tic-Tac-Toe. Paraszt nyelven köriksz.");
            Console.WriteLine("A játék lényege, hogy az általad irányított karakterből (X / O) vízszintesen, függőlegesen, vagy átlósan 3 legyen.");
            Console.WriteLine("A játékhoz szükséged lesz egy társra is, ugyanis ez egy kétszemélyes játék!");
			Console.WriteLine("A játékteret a numpad segítségével irányíthatod (1-9), ahol az egyes a bal alsó, a kilences a jobb felső sarkot szimbolizálja. (ha nincs numpad, a számbillentyűk is megfelelőek.)");
            Console.WriteLine("Sok sikert, jó szórakozást kívánunk!");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Első játékos neve(x): ");
            p1 = Console.ReadLine();
            Console.WriteLine("Második játékos neve(o): ");
            p2 = Console.ReadLine();

            while(nyert == 0 && round < 9)
            {
                round++;
                Console.WriteLine("{0}. kör.",round);
                do
                {
                    hiba = 0;
                    if (p == 1)
                    {
                        Console.WriteLine("{0}, hova szeretnéd rakni az X-et?",p1);
                        string hely = Console.ReadLine();
                        switch (hely)
                        {
                            case "1":
                                {
                                    if (map[2, 0] == "-")
                                    {
                                        map[2, 0] = "x";
                                    }
                                    else
                                    {
                                        hiba = 1;
                                        Console.WriteLine("Oda már nem tudsz rakni.");
                                    }
                                    break;
                                }
                            case "2":
                                {
                                    if (map[2, 1] == "-")
                                    {
                                        map[2, 1] = "x";
                                    }
                                    else
                                    {
                                        hiba = 1;
                                        Console.WriteLine("Oda már nem tudsz rakni.");
                                    }
                                    break;
                                }
                            case "3":
                                {
                                    if (map[2, 2] == "-")
                                    {
                                        map[2, 2] = "x";
                                    }
                                    else
                                    {
                                        hiba = 1;
                                        Console.WriteLine("Oda már nem tudsz rakni.");
                                    }
                                    break;
                                }
                            case "4":
                                {
                                    if (map[1, 0] == "-")
                                    {
                                        map[1, 0] = "x";
                                    }
                                    else
                                    {
                                        hiba = 1;
                                        Console.WriteLine("Oda már nem tudsz rakni.");
                                    }
                                    break;
                                }
                            case "5":
                                {
                                    if (map[1, 1] == "-")
                                    {
                                        map[1, 1] = "x";
                                    }
                                    else
                                    {
                                        hiba = 1;
                                        Console.WriteLine("Oda már nem tudsz rakni.");
                                    }
                                    break;
                                }
                            case "6":
                                {
                                    if (map[1, 2] == "-")
                                    {
                                        map[1, 2] = "x";
                                    }
                                    else
                                    {
                                        hiba = 1;
                                        Console.WriteLine("Oda már nem tudsz rakni.");
                                    }
                                    break;
                                }
                            case "7":
                                {
                                    if (map[0, 0] == "-")
                                    {
                                        map[0, 0] = "x";
                                    }
                                    else
                                    {
                                        hiba = 1;
                                        Console.WriteLine("Oda már nem tudsz rakni.");
                                    }
                                    break;
                                }
                            case "8":
                                {
                                    if (map[0, 1] == "-")
                                    {
                                        map[0, 1] = "x";
                                    }
                                    else
                                    {
                                        hiba = 1;
                                        Console.WriteLine("Oda már nem tudsz rakni.");
                                    }
                                    break;
                                }
                            case "9":
                                {
                                    if (map[0, 2] == "-")
                                    {
                                        map[0, 2] = "x";
                                    }
                                    else
                                    {
                                        hiba = 1;
                                        Console.WriteLine("Oda már nem tudsz rakni.");
                                    }
                                    break;
                                }

                        }

                    }
                    else
                    {
                            Console.WriteLine("{0}, hova szeretnéd rakni a kört?", p2);
                            string hely = Console.ReadLine();
                            switch (hely)
                            {
                                case "1":
                                    {
                                        if (map[2, 0] == "-")
                                        {
                                            map[2, 0] = "o";
                                        }
                                        else
                                        {
                                            hiba = 1;
                                            Console.WriteLine("Oda már nem tudsz rakni.");
                                        }
                                        break;
                                    }
                                case "2":
                                    {
                                        if (map[2, 1] == "-")
                                        {
                                            map[2, 1] = "o";
                                        }
                                        else
                                        {
                                            hiba = 1;
                                            Console.WriteLine("Oda már nem tudsz rakni.");
                                        }
                                        break;
                                    }
                                case "3":
                                    {
                                        if (map[2, 2] == "-")
                                        {
                                            map[2, 2] = "o";
                                        }
                                        else
                                        {
                                            hiba = 1;
                                            Console.WriteLine("Oda már nem tudsz rakni.");
                                        }
                                        break;
                                    }
                                case "4":
                                    {
                                        if (map[1, 0] == "-")
                                        {
                                            map[1, 0] = "o";
                                        }
                                        else
                                        {
                                            hiba = 1;
                                            Console.WriteLine("Oda már nem tudsz rakni.");
                                        }
                                        break;
                                    }
                                case "5":
                                    {
                                        if (map[1, 1] == "-")
                                        {
                                            map[1, 1] = "o";
                                        }
                                        else
                                        {
                                            hiba = 1;
                                            Console.WriteLine("Oda már nem tudsz rakni.");
                                        }
                                        break;
                                    }
                                case "6":
                                    {
                                        if (map[1, 2] == "-")
                                        {
                                            map[1, 2] = "o";
                                        }
                                        else
                                        {
                                            hiba = 1;
                                            Console.WriteLine("Oda már nem tudsz rakni.");
                                        }
                                        break;
                                    }
                                case "7":
                                    {
                                        if (map[0, 0] == "-")
                                        {
                                            map[0, 0] = "o";
                                        }
                                        else
                                        {
                                            hiba = 1;
                                            Console.WriteLine("Oda már nem tudsz rakni.");
                                        }
                                        break;
                                    }
                                case "8":
                                    {
                                        if (map[0, 1] == "-")
                                        {
                                            map[0, 1] = "o";
                                        }
                                        else
                                        {
                                            hiba = 1;
                                            Console.WriteLine("Oda már nem tudsz rakni.");
                                        }
                                        break;
                                    }
                                case "9":
                                    {
                                        if (map[0, 2] == "-")
                                        {
                                            map[0, 2] = "o";
                                        }
                                        else
                                        {
                                            hiba = 1;
                                            Console.WriteLine("Oda már nem tudsz rakni.");
                                        }
                                        break;
                                    }

                            }
                        }


                }
                while (hiba != 0);
                if (p == 1) p = 2;
                else p = 1;
                show();
                nyert = winScan();
            }
            if(winScan() == 1)
                Console.WriteLine(p1+" nyert, gratulálunk!");
            else if(winScan() == 2)
                Console.WriteLine(p2+" nyert, gratulálunk!");
            else
                Console.WriteLine("Senki sem nyert.");

            Console.WriteLine("\n \n Szép mérkőzés volt, a vesztes(ek) se csüggedjenek!");
            
            Console.ReadKey();
        }
    }
}
