using System;

namespace ParseText
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "John.Davidson/Berlin Michael.Barton/Lisbon Ivan.Perkinson/Moscow";
            string[] names = text.Split('.', '/', ' ');
        }
    }
}
