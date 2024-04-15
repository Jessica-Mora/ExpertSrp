using System;

namespace Ucu.Poo.Expert{

   public class ShelveBook
    {
        public string LibrarySector { get; }
        public string LibraryShelve { get; }

        public ShelveBook(string sector, string shelve)
        {
            LibrarySector = sector;
            LibraryShelve = shelve;
        }
    }
}
   