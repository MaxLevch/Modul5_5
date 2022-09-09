namespace modul5_6
{
    class program
    {
        static void Main(string[] args)
        {
            (string name, string lastname, int age, bool HasPet, int AmountPet, string[] NamePet, int AmountColors, string[] fawcolors) Anketa = EnterUser();
            Console.WriteLine("Данные корректны");
            ShowAnketa(Anketa);

            

        }

        static (string name, string lastname, int age, bool HasPet, int AmountPet, string[] NamePet, int AmountColors, string[] fawcolors) EnterUser ()
        {
            (string name, string lastname, int age, bool HasPet, int AmountPet, string[] NamePet, int AmountColors, string[] fawcolors) User;
            Console.WriteLine("Введите имя");
            User.name = Console.ReadLine();
            Console.WriteLine("Введите фамилию");
            User.lastname = Console.ReadLine();
            Console.WriteLine("Введите возраст");
            User.age = int.Parse(Console.ReadLine());
            CheckNum(ref User.age);
            Console.WriteLine("Имеются ли питомцы?(ответ на Русском языке с маленькой буквы)");
            var haspet = Console.ReadLine();
            if (haspet == "да")
            {
                User.HasPet = true;
                Console.WriteLine("Сколько у Вас питомцев?");
                User.AmountPet = int.Parse(Console.ReadLine());
                CheckNum(ref User.AmountPet);
                User.NamePet = NamePet(User.AmountPet);
            }
            else
            {
                User.HasPet = false;
                User.AmountPet = 0;
                User.NamePet = new string[] {"Питомцы отсутствуют"};
            }
            Console.WriteLine("Сколько любмых цветов?");
            User.AmountColors = int.Parse(Console.ReadLine());
            CheckNum(ref User.AmountColors);
            User.fawcolors = FawColors(User.AmountColors);
            return User;
        }

        static string[] NamePet(int AmountPet)
        {
            string[] pets = new string[AmountPet];
            for (int i = 0; i < AmountPet; i++)
            {
                Console.WriteLine("Введите имя {0}", i + 1);
                pets[i] = Console.ReadLine();
            }
            return pets;
        }

        static string[] FawColors(int kol)
        {
             string[] fawColors = new string[kol];
             for (int i = 0; i < kol; i++)
             {
                 Console.WriteLine("Введите {0} цвет", i + 1);
                 fawColors[i] = Console.ReadLine();
             }
             return fawColors;

        }

        static void CheckNum(ref int Num)
        {
            if (Num < 1)
            {
                Console.WriteLine("Вы ввели некорректный число, введите корректное");
                Num = int.Parse(Console.ReadLine());
                CheckNum(ref Num);
            }
        }

        static void ShowAnketa((string name, string lastname, int age, bool HasPet, int AmountPet, string[] NamePet, int AmountColors, string[] fawcolors) Anketa)
        {
            Console.WriteLine("Имя пользователя {0}", Anketa.name);
            Console.WriteLine("Фамилия {0}",Anketa.lastname);
            Console.WriteLine("Возраст {0}", Anketa.age);
            if (Anketa.AmountPet > 0)
            {
                Console.WriteLine("у пользователя {0} питомцев ",Anketa.AmountPet);
                for (int i = 0; i < Anketa.AmountPet; i++)
                {
                    Console.WriteLine("Имя {0} питомца - {1}", i + 1, Anketa.NamePet[i]);
                }
            }
            else { Console.WriteLine(Anketa.NamePet); }
            Console.WriteLine("Любимые цвета :");
            for (int k = 0; k < Anketa.fawcolors.Length; k++)
            {
                Console.WriteLine(Anketa.fawcolors[k]);
            }
        }
    }
}