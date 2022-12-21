namespace pz_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
                int Armor = 0;
                int HP = 20;
                int power = 5;
                int buff_count = 0;
                int player_level = 1;

                Random rnd = new Random();
                int[,] spawn_armor = { { rnd.Next(0, 25), rnd.Next(0, 25) }, { rnd.Next(0, 25), rnd.Next(0, 25) } };
                int[,] spawn_boss = { { rnd.Next(0, 25) }, { rnd.Next(0, 25) } };
                int[] player_position = { 13, 13 };
                int[,] spawn_buff = { { rnd.Next(0, 25), rnd.Next(0, 25), rnd.Next(0, 25) }, { rnd.Next(0, 25), rnd.Next(0, 25), rnd.Next(0, 25) } };
                int[,] spawn_enemy = {{rnd.Next(0, 25), rnd.Next(0, 25), rnd.Next(0, 25), rnd.Next(0, 25), rnd.Next(0, 25), rnd.Next(0, 25), rnd.Next(0, 25), rnd.Next(0, 25), rnd.Next(0, 25), rnd.Next(0, 25) },
                    {rnd.Next(0, 25), rnd.Next(0, 25), rnd.Next(0, 25), rnd.Next(0, 25), rnd.Next(0, 25), rnd.Next(0, 25), rnd.Next(0, 25), rnd.Next(0, 25), rnd.Next(0, 25), rnd.Next(0, 25) } };
                int[,] spawn_kit = {{rnd.Next(0, 25), rnd.Next(0, 25), rnd.Next(0, 25), rnd.Next(0, 25), rnd.Next(0, 25) },
                    {rnd.Next(0, 25), rnd.Next(0, 25), rnd.Next(0, 25), rnd.Next(0, 25), rnd.Next(0, 25) } };

                GenerateMap(player_position, spawn_armor, spawn_boss, spawn_buff, spawn_enemy, spawn_kit, Armor, HP, power, player_level, buff_count);
                string move = Console.ReadLine();
                while (move != "exit" && HP > 0)
                {
                    for (int i = 0; i < move.Length; i++)
                    {
                        if (buff_count != 0)
                        {
                            buff_count--;
                        }
                        else
                        {
                            power = 5 * player_level;
                        }
                        char x = move[i];
                        UpdateMap(ref player_position, x, spawn_armor, spawn_boss, spawn_buff, spawn_enemy, spawn_kit, ref Armor, ref HP, ref power, ref buff_count, ref player_level);
                    }
                    move = Console.ReadLine();
                }
                if (HP <= 0)
                {
                    Console.WriteLine("LOSE!");
                }
                else
                {
                    Console.WriteLine("WIN!");
                }
            }

            public static bool ContainsCoordinate(int[,] array, int x1, int y1)
            {
                for (int x = 0; x < array.GetLength(1); x++)
                {
                    if (array[0, x] == x1 && array[1, x] == y1)
                    {
                        return true;
                    }
                }
                return false;
            }
            public static int IndexCoordinate(int[,] array, int player_x, int player_y)
            {
                int index = 0;
                for (int x = 0; x < array.GetLength(1); x++)
                {
                    index++;
                    if (array[0, x] == player_x && array[1, x] == player_y)
                    {
                        return index;
                    }
                }
                return -1;
            }
            public static void GenerateMap(int[] player_position, int[,] spawn_boss, int[,] spawn_armor, int[,] spawn_buff, int[,] spawn_enemy, int[,] spawn_kit, int Armor, int HP, int power, int player_level, int buff_count)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("###########################\n#");
                for (int x = 1; x <= 25; x++)
                {
                    for (int y = 1; y <= 25; y++)
                    {

                        if (player_position[0] == x && player_position[1] == y)
                        {
                            Console.BackgroundColor = ConsoleColor.Magenta;
                            Console.Write(" ");
                        }
                        else if (ContainsCoordinate(spawn_buff, x, y))
                        {
                            Console.BackgroundColor = ConsoleColor.Blue;
                            Console.Write(" ");
                        }
                        else if (ContainsCoordinate(spawn_armor, x, y))
                        {
                            Console.BackgroundColor = ConsoleColor.Gray;
                            Console.Write(" ");
                        }
                        else if (ContainsCoordinate(spawn_kit, x, y))
                        {
                            Console.BackgroundColor = ConsoleColor.Green;
                            Console.Write(" ");
                        }
                        else if (ContainsCoordinate(spawn_enemy, x, y))
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.Write(" ");
                        }
                        else if (ContainsCoordinate(spawn_boss, x, y))
                        {
                            Console.BackgroundColor = ConsoleColor.Yellow;
                            Console.Write(" ");
                        }
                        else
                        {
                            Console.BackgroundColor = ConsoleColor.DarkCyan;
                            Console.Write(" ");
                        }
                    }
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                    if (x == 3)
                    {
                        Console.Write("#                 ");
                        Console.BackgroundColor = ConsoleColor.Magenta;
                        Console.Write(" ");
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write(" – Игрок\n#");
                    }
                    else if (x == 5)
                    {
                        Console.Write("#                 ");
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.Write(" ");
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write(" – Аптечка\n#");
                    }
                    else if (x == 7)
                    {
                        Console.Write("#                 ");
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Write(" ");
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write(" – Враг\n#");
                    }
                    else if (x == 9)
                    {
                        Console.Write("#                 ");
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.Write(" ");
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write(" – Усиление\n#");
                    }
                    else if (x == 11)
                    {
                        Console.Write("#                 ");
                        Console.BackgroundColor = ConsoleColor.Gray;
                        Console.Write(" ");
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write(" –  Броня\n#");
                    }
                    else if (x == 13)
                    {
                        Console.Write("#                 ");
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.Write(" ");
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write(" – ТРОЛЛЬ\n#");
                    }
                    else if (x == 15)
                    {
                        Console.Write($"#                 ОЗ = {HP}   Сила = {power}  Усилие действует = {buff_count}\n#");
                    }
                    else if (x == 17)
                    {
                        Console.Write($"#                 Уровень = {player_level}   Броня = {Armor}\n#");
                    }
                    else
                    {
                        Console.Write("#\n#");
                    }

                }
                Console.WriteLine("##########################");
            }
            public static void UpdateMap(ref int[] player_position, char move, int[,] spawn_armor, int[,] spawn_boss, int[,] spawn_buff, int[,] spawn_enemy, int[,] spawn_kit, ref int Armor, ref int HP, ref int power, ref int buff_count, ref int player_level)
            {
                Console.Clear();
                if (move == 'w')
                {
                    player_position[0]--;
                    if (player_position[0] <= 0)
                    {
                        player_position[0] = 25;
                    }
                }
                else if (move == 's')
                {
                    player_position[0]++;
                    if (player_position[0] >= 25)
                    {
                        player_position[0] = 1;
                    }
                }
                else if (move == 'a')
                {
                    player_position[1]--;
                    if (player_position[1] <= 0)
                    {
                        player_position[1] = 25;
                    }
                }
                else if (move == 'd')
                {
                    player_position[1]++;
                    if (player_position[1] >= 25)
                    {
                        player_position[1] = 1;
                    }
                }
                if (ContainsCoordinate(spawn_armor, player_position[0], player_position[1]))
                {
                    Console.Clear();
                    ArmorUP(ref Armor, ref spawn_armor, ref player_position);
                }
                if (ContainsCoordinate(spawn_boss, player_position[0], player_position[1]))
                {
                    Console.Clear();
                    Boss(ref Armor, ref player_level, ref power, ref HP, ref spawn_boss, player_position);
                }
                if (ContainsCoordinate(spawn_enemy, player_position[0], player_position[1]))
                {
                    Console.Clear();
                    Fight(ref Armor, ref HP, ref power, ref spawn_enemy, player_position, ref player_level);
                }
                if (ContainsCoordinate(spawn_kit, player_position[0], player_position[1]))
                {
                    Console.Clear();
                    Healing(ref HP, ref spawn_kit, player_position, player_level);
                }
                if (ContainsCoordinate(spawn_buff, player_position[0], player_position[1]))
                {
                    Console.Clear();
                    Buff(ref power, ref spawn_buff, player_position, ref buff_count);
                }

                GenerateMap(player_position, spawn_boss, spawn_armor, spawn_buff, spawn_enemy, spawn_kit, Armor, HP, power, player_level, buff_count);
            }
            public static void ArmorUP(ref int Armor, ref int[,] spawn_armor, ref int[] player_position)
            {
                Armor = 50;
                int index = IndexCoordinate(spawn_armor, player_position[0], player_position[1]);
                spawn_armor[0, index - 1] = -1;
            }
            public static void Fight(ref int Armor, ref int HP, ref int power, ref int[,] spawn_enemy, int[] player_position, ref int player_level)
            {
                int HP_bot = 15;
                while (HP > 0 && HP_bot > 0)
                {
                    if (Armor > 0)
                    {
                        Armor -= 10;
                        HP -= 2;
                        HP_bot -= power;
                        Console.WriteLine($"Вы почувствовали, что ваша броня немного треснула");
                        Console.WriteLine($"Вы нанесли урон врагу в размере: {power}");
                        Console.WriteLine($"Количество Вашего здоровья = {HP}");
                        Console.WriteLine($"Количество здоровья врага = {HP_bot}");
                        Console.WriteLine("----------------------------------\n");

                    }
                    else
                    {
                        HP -= 5;
                        HP_bot -= power;
                        Console.WriteLine($"Вы нанесли урон врагу в размере: {power}");
                        Console.WriteLine($"Количество Вашего здоровья = {HP}");
                        Console.WriteLine($"Количество здоровья врага = {HP_bot}");
                        Console.WriteLine("----------------------------------\n");
                    }
                    try
                    {
                        int index = IndexCoordinate(spawn_enemy, player_position[0], player_position[1]);
                        spawn_enemy[0, index - 1] = -1;
                    }
                    catch (IndexOutOfRangeException e)
                    {
                    }
                    if (Armor == 0)
                    {
                        Console.WriteLine("Упс... моя броня ;(");
                        Console.WriteLine("----------------------------------\n");
                    }

                }
                player_level += 1;
            }
            public static void Boss(ref int Armor, ref int player_level, ref int power, ref int HP, ref int[,] spawn_boss, int[] player_position)
            {
                Console.WriteLine($"Вы почувствовали, что ваша броня сломалась");
                int HP_Boss = 50;
                while (HP > 0 && HP_Boss > 0)
                {
                    if (Armor > 0)
                    {
                        Armor -= 99;
                        HP -= 4;
                        HP_Boss -= power;
                        Console.WriteLine($"Вы нанесли урон троллю в размере: {power}");
                        Console.WriteLine($"Количество Вашего здоровья = {HP}");
                        Console.WriteLine($"Количество здоровья тролля = {HP_Boss}");
                        Console.WriteLine("----------------------------------\n");
                    }
                    else
                    {
                        HP -= 8;
                        HP_Boss -= power;
                        Console.WriteLine($"Вы нанесли урон врагу в размере: {power}");
                        Console.WriteLine($"Количество Вашего  здоровья = {HP}");
                        Console.WriteLine($"Количество здоровья врага = {HP_Boss}");
                        Console.WriteLine("----------------------------------\n");
                    }
                    try
                    {
                        int index = IndexCoordinate(spawn_boss, player_position[0], player_position[1]);
                        spawn_boss[0, index - 1] = -1;
                    }
                    catch (IndexOutOfRangeException e)
                    {

                    }
                }
                player_level += 4;
            }

            public static void Healing(ref int HP, ref int[,] spawn_kit, int[] player_position, int player_level)
            {
                HP = 30 + (5 * player_level);
                try
                {
                    int index = IndexCoordinate(spawn_kit, player_position[0], player_position[1]);
                    spawn_kit[0, index - 1] = -1;
                }
                catch (IndexOutOfRangeException e)
                {

                }
            }
            public static void Buff(ref int power, ref int[,] spawn_buff, int[] player_position, ref int buff_count)
            {
                power += 10;
                buff_count += 15;
                try
                {
                    int index = IndexCoordinate(spawn_buff, player_position[0], player_position[1]);
                    spawn_buff[0, index - 1] = -1;

                }
                catch
                {

                }
            }
            public static void SaveState()
            {

            }
        }
    }