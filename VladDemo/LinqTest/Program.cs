using System;
using System.Text;
using System.Linq;

namespace LinqTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Character[] characters = { 
                new Character { name = "Hakurei_Reimu", firstArtwork = "Th01", hasBeenPlayableCharacter = true }, 
                new Character { name = "Kirisame_Marisa", firstArtwork = "Th01", hasBeenPlayableCharacter = true },
                new Character { name = "Alice_Margatroid", firstArtwork = "Th05", hasBeenPlayableCharacter = false },
                new Character { name = "Izoyoi_Sakuya", firstArtwork = "Th06", hasBeenPlayableCharacter = true }, 
                new Character { name = "Remilia_Scarlet", firstArtwork = "Th06", hasBeenPlayableCharacter = true },
                new Character { name = "Frandre_Scarlet", firstArtwork = "Th06", hasBeenPlayableCharacter = false },
                new Character { name = "Konpaku_Youmu", firstArtwork = "Th07", hasBeenPlayableCharacter = true },
                new Character { name = "Saigyouji_Yuyuko", firstArtwork = "Th07", hasBeenPlayableCharacter = true },                
                new Character { name = "Yakumo_Yukari", firstArtwork = "Th07", hasBeenPlayableCharacter = true },
                new Character { name = "Mystia_Loreira", firstArtwork = "Th08", hasBeenPlayableCharacter = false },
                new Character { name = "Kamishirasawa_Keine", firstArtwork = "Th08", hasBeenPlayableCharacter = false },
                new Character { name = "Reisen_Udongein_Inaba", firstArtwork = "Th08", hasBeenPlayableCharacter = true }
            };

            var playableCharacters =
                from pc in characters
                orderby pc.firstArtwork ascending, pc.name ascending
                group pc by pc.hasBeenPlayableCharacter into pcs
                from i in pcs
                where pcs.Key
                orderby i.name ascending
                where i.firstArtwork[3] <= 5 
                select i.name;

            foreach (var item in playableCharacters)
            {
                Console.Write("Add new playable character");
                string[] str = item.Split("_");
                foreach (var item1 in str)
                {
                    Console.Write(" " + item1);
                }
                Console.WriteLine("\n");
            }

        }

        struct Character
        {
            public string name;
            public string firstArtwork;
            public bool hasBeenPlayableCharacter;
        }
    }

  
}
