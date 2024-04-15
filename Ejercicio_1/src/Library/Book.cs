using System;

namespace Ucu.Poo.Expert
{
    public class Book
    {

        public string Title { get ; }
        public string Author { get ; }
        public string Code { get ;  }
        
        //public string LibrarySector { get ; set; } //otra clase
        //public string LibraryShelve { get ; set; } //otra clase

        public Book(String title, String author, String code)
        {
            this.Title = title;
            this.Author = author;
            this.Code = code;
        }

       /* public void ShelveBook(String sector, String shelve) //esta es la otra clase
        {
            this.LibrarySector = sector;
            this.LibraryShelve = shelve;
        }   */

    }
}
