using System.Text;


namespace C__ders3
{
    internal class task3
    {
        static void Main(string[] args)
        {


            string[,] questions =

        {

            { "Azərbaycanın paytaxtı?", "Bakı", "Gəncə", "Şəki", "Bakı" },
            { "Türkiyənin paytaxtı?", "Ankara", "İstanbul", "İzmir", "Ankara" },
            { "Ən böyük okean?", "Atlantik", "Sakit", "Hind", "Sakit" },
            { "Bir ildə neçə ay var?", "10", "12", "11", "12" },
            { "Neçə planet var?", "7", "8", "9", "8" },
            { "Ən böyük qitə?", "Afrika", "Avropa", "Asiya", "Asiya" },
            { "Su neçə dərəcədə qaynayır?", "90", "100", "120", "100" },
            { "İnsanın neçə ürəyi var?", "1", "2", "3", "1" },
            { "Everest haradadır?", "Alplar", "Himalay", "Qafqaz", "Himalay" },
            { "Delfin hansı heyvandır?", "Balıq", "Sürünən", "Məməli", "Məməli" }

        };

        string[] letters = { "A", "B", "C" };
        Random random = new Random();
        int score = 0;
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("\n" + questions[i, 0]);
                string[] answers =
                {
                questions[i, 1],
                questions[i, 2],
                questions[i, 3]
            };

            for (int j = 0; j < 3; j++)
            {
                int k = random.Next(0, 3);
                string temp = answers[j];
                answers[j] = answers[k];
                answers[k] = temp;
            }

            for (int j = 0; j < 3; j++)
            {
                Console.WriteLine(letters[j] + ") " + answers[j]);
            }

            Console.Write("Cavab: ");
            string answer = Console.ReadLine().ToUpper();
            if (answer == "A" && answers[0] == questions[i, 4] ||
                answer == "B" && answers[1] == questions[i, 4] ||
                answer == "C" && answers[2] == questions[i, 4])

            {

                Console.WriteLine("Düzgün cavab!");
                score++;

            }
            else
            {
                Console.WriteLine("Yanlış cavab!");
                break;
            }

        }
        Console.WriteLine("Xalınız: " + score);

    



        }
    }
}
