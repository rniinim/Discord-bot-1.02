using System;
using System.Collections.Generic;
using System.Text;
using Discord.Commands;
using System.Threading.Tasks;

namespace Discord_Bot_1_02.Modules
{
    public class Public : ModuleBase<SocketCommandContext>
    {
        Random rng = new Random();
        [Command("ping")]
        public async Task PingAsync()
        {
            await ReplyAsync("Hello");
        }
        
        

        [Command("roulette")]
        public async Task RouletteAsync()
        {
            
            await ReplyAsync(rng.Next(1,7) == 6 ? "Boom" : "Click");
        }
    }
}
