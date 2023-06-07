using System.Globalization;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Nimi()
        {
            Console.Write("Palun sisesta oma nimi: ");
            string nimi = Console.ReadLine();
            Console.WriteLine("Sinu nimi on " + nimi);
        }

        static void Vanus()
        {
            Console.Write("Kui vana sa oled? ");
            int vanus = int.Parse(Console.ReadLine());
            if (vanus < 18)
            {
                Console.WriteLine("Sa oled alaealine.");
            }
            else
            {
                Console.WriteLine("Sa oled täisealine.");
            }
        }

        static void Rühm()
        {
            Console.Write("Mis on sinu õpperühma kood? ");
            string rühm = Console.ReadLine();
            if (rühm == "TITpe22")
            {
                Console.WriteLine("Sa oled õiges rühmas.");
            }
            else
            {
                Console.WriteLine("Sa ei ole õiges rühmas.");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Vali 1, 2 või 3:");
            int valik = int.Parse(Console.ReadLine());

            switch (valik)
            {
                case 1:
                    Nimi();
                    break;
                case 2:
                    Vanus();
                    break;
                case 3:
                    Rühm();
                    break;
                default:
                    Console.WriteLine("Vigane valik!");
                    break;
            }
        }
    }
}