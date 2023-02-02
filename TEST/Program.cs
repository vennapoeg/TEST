using System.Drawing;

namespace TEST;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Kujundite joonistamine ja ümbermöödu arvutamine");
        Console.WriteLine("Sisesta kujund");
        Console.WriteLine("1. Ruut");
        Console.WriteLine("2. Teemant");
        Console.WriteLine("3. Ristkülik");
        Console.WriteLine("4. Kolmnurk");

        string tehe = Console.ReadLine();

        switch (tehe)
        {
            case "1":
                Square();
                break;
            case "2":
                Diamond();
                break;
            case "3":
                Rectangle();
                break;
            case "4":
                Triangle();
                break;
            default:
                Console.WriteLine("Valikut ei tehtud");
                break;
        }
    }

    private static void Square()
    {
        Console.WriteLine("Ruut");
        Console.WriteLine("Kui suur on ruudu külg?");
        int number = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Ruudu pindala on: {0} cm2", number * number);
        Console.WriteLine("Ruudu ümbermõõt on: {0} cm", 4 * number);
        
      

        for (int row = 1; row <= number; row++)
        {
            for (int column = 1; column <= number; column++)
            {
                string mark;
                if (row == column || row + column <= number + 1)
                {
                    mark = " *";
                }
                else
                {
                    mark = " *";
                }
                Console.Write(mark);
            }
            Console.WriteLine();
        }



        }
        private static void Diamond()
        {
            Console.WriteLine("Teemant");
            Console.WriteLine("Mis on ühe külje pikkus?");
            int number = int.Parse(Console.ReadLine());
            
            Console.WriteLine(number);
            Console.WriteLine("Teemandi pindala on: ");
            Console.WriteLine("Teemandi ümbermõõt on:");

        }
        private static void Rectangle()
        {
        Console.WriteLine("Mis on esimese külje pikkus?");
        int külg1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Mis on teise külje pikkus?");
        int külg2 = int.Parse(Console.ReadLine());
        Console.WriteLine("ristkülik");
        Console.WriteLine(külg1);
        Console.WriteLine(külg2);
        Console.WriteLine("Ristküliku pindala S=a*b = {0}", külg1 * külg2);
        Console.WriteLine("Ristküliku ümbermõõt C=2*(a+b)=" + 2 * (külg1 + külg2));
        }
        private static void Triangle()
        {
            Console.WriteLine("Kolmnurk");
            Console.WriteLine("Kui pikk on kolmnurga kaatet?");
            int number = int.Parse(Console.ReadLine());
            
            
            
            Console.WriteLine("Kolmnurga pindala on:{0}", number*number/2);
            Console.WriteLine("Kolmnurga ümbermõõt on: {0}", 3*number);

            for (int i = 1; i <= number; i++)
            {
                Console.Write("\n");
                for (int j = 1; j <= i; j++)
            {
                Console.Write(" *");
            }
            }
    }


    }
