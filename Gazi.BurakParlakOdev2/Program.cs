namespace Gazi.BurakParlakOdev2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("başlangıç");
            int bas = int.Parse(Console.ReadLine());
            Console.WriteLine("bitiş");
            int bit = int.Parse(Console.ReadLine());
            Console.WriteLine("kaç tane rastgele sayı istersiniz");
            int say = int.Parse(Console.ReadLine());


            int[] numbers = new int[say];
            Random rnd = new Random();
            int kutu;
            for (int i = 0; i < say; i++)
            {
                kutu = rnd.Next(bas, bit);
                if (i == 0)
                {
                    numbers[i] = kutu;
                }
                for (int j = 0; j < i; j++)
                {
                    if (numbers[j] == kutu)
                    {
                        i--;
                        break;
                    }
                    else
                    {
                        numbers[i] = kutu;
                    }
                }


            }
            Array.Sort(numbers);
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

        }
    }
}