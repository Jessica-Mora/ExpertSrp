using System;

namespace Ucu.Poo.Expert
{

    class Program
    {
        static void Main()
        {
            Book book1 = new Book("Design Patterns","Erich Gamma & Others","001-034");
            Book book2 = new Book("Pro C#","Troelsen","001-035");
            //book1.ShelveBook("A","7");
            //book2.ShelveBook("B","3");
            ShelveBook location1 = new ShelveBook("A", "7");
            ShelveBook location2 = new ShelveBook("B", "3");


            Console.WriteLine($"Libro 1: {book1.Title} ({book1.Code}) - Localizacion: {location1.LibrarySector}-{location1.LibraryShelve}");
            Console.WriteLine($"Libro 2: {book2.Title} ({book2.Code}) - Localizacion {location2.LibrarySector}-{location2.LibraryShelve}");


        }
    }
}