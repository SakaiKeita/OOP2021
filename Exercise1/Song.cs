using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1 {




    
    class Song {
       public String Title { get; set; }
       public String ArtistName { get; set; }
       public int Length { get; set; }
       
        
        //コンストラクタ
        public Song(string title,String artistName,int length) {
            this.Title = title;
            this.ArtistName = artistName;
            this.Length = length;
        }
    
    
    
    
    
    
    }
}
