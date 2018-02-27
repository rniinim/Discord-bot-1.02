using System;
using System.Collections.Generic;
using System.Text;
using Discord.Commands;
using System.Threading.Tasks;

namespace Discord_Bot_1_02.Modules
{
    public class tandere : ModuleBase<SocketCommandContext>
    {
        string[] taneliMemes = new string[]
            {
                "https://imgur.com/Q83E7Nk",
                "https://imgur.com/KwDgXmO",
                "https://imgur.com/W0XDtAO",
                "https://imgur.com/OJEp47M",
                "https://imgur.com/fGXav8g",
                "https://imgur.com/nvVAyX0",
                "https://imgur.com/KgEJ6QI",
                "https://imgur.com/JyCTIdQ",
                "https://imgur.com/IdLOROw",
                "https://imgur.com/DA2j1CL",
                "https://imgur.com/vie87aN",
                "https://imgur.com/D7uNuSV",
                "https://imgur.com/IC3FLRy",
                "https://imgur.com/BJaBFYW",
                "https://imgur.com/WoLwr7P"
            };
        Random rng = new Random();
        

        [Command("tandere")]
        public async Task TandereAsync()
        {
            await ReplyAsync(":page_facing_up: | **Score**: 999  |  Rating: **Explicit**\nhttps://www.reddit.com/r/Taneli_irl/");
            await ReplyAsync(taneliMemes[rng.Next(taneliMemes.Length)-1]);
        }
    }
}
