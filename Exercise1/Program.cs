using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1 {
    class Program {
        static void Main(string[] args) {
            //2.1.3
            var songs = new Song[] {
                new Song("タイトル", "アーティスト名", 0),
                new Song("Bride Over", "Simon&Garfunke", 323),
                new Song("Close to you", "Capen", 545),
                new Song("Honesty", "BillyJoel",222),
                 new Song("I will Always", "Whitnhey Houston", 124)
            };
            PrintSongs(songs);
        }
        //  2.1.4
        private static void PrintSongs(Song[] songs) {
            foreach(var song in songs) {
                Console.WriteLine(@"{0},{1},{2:m\:ss}", song.Title, song.ArtistName, song.Length);




            }
        }
    }
}
