namespace pz_18
{
    internal class Program
    {
        enum Marks
        {
            terribly = 1,
            unsatisfactory = 2,
            satisfactory = 3,
            well = 4,
            excellent = 5
        }

        static void Evaluation(Marks mb)
        {
            switch (mb)
            {
                case Marks.terribly:
                    Console.WriteLine("очень плохо"); break;
                case Marks.unsatisfactory:
                    Console.WriteLine("неудовлетворительно"); break;
                case Marks.satisfactory:
                    Console.WriteLine("удовлетворительно"); break;
                case Marks.well:
                    Console.WriteLine("хорошо"); break;
                case Marks.excellent:
                    Console.WriteLine("отлично"); break;

            }
        }

        enum Seasons
        {
            summer,
            winter,
            spring,
            autumn
        }

        static void Year(Seasons seasons)
        {
            switch (seasons)
            {
                case Seasons.summer:
                    Console.WriteLine(">> Праздники в данный промежуток:\r\n>> День российской почты — 11 июля\r\n>> День металлурга — 17 июля (в 2022 году)\r\n>> День Крещения Руси (Памятная дата России) — 28 июля\r\n>> День железнодорожника — 7 августа (в 2022 году)\r\n>> День строителя — 14 августа (в 2022 году)\r\n>> Международный день молодежи — 12 августа"); break;
                case Seasons.winter:
                    Console.WriteLine(">> Праздники в данный промежуток:\r\n>> Новый год — 1 января\r\n>> Рождество Христово — 7 января\r\n>> День защитника отечества — 23 февраля\r\n>> День Героев Отечества — 9 декабрСтарый Новый год — 14 января"); break;
                case Seasons.spring:
                    Console.WriteLine(">> раздники в данный промежуток:\r\n>> Международный женский день — 8 марта\r\n>> День труда — 1 мая\r\n>> День Победы — 9 мая\r\n>> Масленица — 28.02.-06.03. (в 2022 году)\r\n>> День смеха (День дурака) — 1 апреля"); break;
                case Seasons.autumn:
                    Console.WriteLine(">> Праздники в данный промежуток:\r\n>> День знаний —  1 сентября\r\n>> День нефтяника — 4 сентября (в 2022 году)\r\n>> День танкиста в России — 11 сентября (в 2022 году)\r\n>> День машиностроителя — 25 сентября (в 2022 году)\r\n>> Всемирный день учителя — 5 октября\r\n>> День автомобилиста — 30 октября (в 2022 году)"); break;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine(">> введите отметку \n ");
            Console.Write("<< "); int mv = Convert.ToInt32(Console.ReadLine());

            if (mv == 1)
            {
                Console.Write("\n>> характестика отметки 1: "); Evaluation(Marks.terribly);
            }
            if (mv == 2)
            {
                Console.Write("\n>> характестика отметки 2: "); Evaluation(Marks.unsatisfactory);
            }
            if (mv == 3)
            {
                Console.Write("\n>> характестика отметки 3: "); Evaluation(Marks.satisfactory);
            }
            if (mv == 4)
            {
                Console.Write("\n>> характестика отметки 4: "); Evaluation(Marks.well);
            }
            if (mv == 5)
            {
                Console.Write("\n>> характестика отметки 5: "); Evaluation(Marks.excellent);
            }
            Console.WriteLine();

            Console.WriteLine(">> введите время года: ");
            Console.Write("<< "); string mg = Console.ReadLine();

            if (mg == "summer")
            {
                Console.Write("\n"); Year(Seasons.summer);
            }
            if (mg == "winter")
            {
                Console.Write("\n"); Year(Seasons.winter);
            }
            if (mg == "spring")
            {
                Console.Write("\n"); Year(Seasons.spring);
            }
            if (mg == "autumn")
            {
                Console.Write("\n"); Year(Seasons.autumn);
            }
        }

    }
}