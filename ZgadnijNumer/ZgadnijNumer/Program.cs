//Program napisany przez Michała Banasiaka


class Program
{
    static void Main()
    {
        while (true) 
        {
            Console.WriteLine("Program autorstwa: Michała Banasiaka 2024");
            Console.WriteLine();
            Console.WriteLine("Witamy w grze na zgadywanie liczby! Podaj swoją liczbę:");
            Console.WriteLine("(Wylosowana liczba jest od 1 do 100).");
            
            int number;
            string input = Console.ReadLine();
            int randomnumber = new Random().Next(1, 101);

            if (int.TryParse(input, out number))
            {
                if (number == randomnumber)
                {
                    Console.WriteLine("Wygrałes!");
                    break;
                }
                else
                {
                    Console.WriteLine("Przegrałes!");
                    if (number > randomnumber)
                    {
                        Console.WriteLine("Wylosowana liczba jest mniejsza od twojej o: " + (number - randomnumber));
                    }
                    else if (number < randomnumber)
                    {
                        Console.WriteLine("Wylosowana liczba jest większa od twojej o: " + (randomnumber - number));
                    }
                    break;

                }
            }
            else 
            {
                Console.WriteLine("Niepoprawny input. Musisz podać liczbę.");
            }
        }
        
    }
}