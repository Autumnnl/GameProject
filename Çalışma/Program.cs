using System;

namespace Çalışma
{
    class Program
    {
        static void Main(string[] args)
        {
            Deneme denemes = new Deneme();

            denemes.Topla2(3,6);

            int toplamaSonucu = denemes.Topla(3,6);
            Console.WriteLine(toplamaSonucu*2);
        }
    }
}
