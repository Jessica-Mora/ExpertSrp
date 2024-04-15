/*using System;

namespace Ucu.Poo.Expert
{
 // la clase book tiene asignada dos responsabilidades, por lo cual no cumple
 //con los principios de srp
 //se le asigna la responsabilidad de conocer al libro y conocer donde esta ubicado  
    
    public class Book
    {

        public string Title { get ; }
        public string Author { get ; }
        public string Code { get ;  }
        public string LibrarySector { get ; set; } //esto deeberia pertenecer a otra clase
        public string LibraryShelve { get ; set; } //esto deberia pertencer a otra clase

        public Book(String title, String author, String code)
        {
            this.Title = title;
            this.Author = author;
            this.Code = code;
        }
// se le asigna la responsabilidad de conocer en donde esta ubicado el libro
//lo cual deberia estar en otra clase
        public void ShelveBook(String sector, String shelve) 
        {
            this.LibrarySector = sector;
            this.LibraryShelve = shelve;
        }

    }
}   */