using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Discord_Bot_1_02.Modules
{
    public class alfa : ModuleBase<SocketCommandContext>
    {
        [Command("alfa")]
        public async Task PingAsync()
        {
            await ReplyAsync("<@160410433952546816> on 5/5 alfa");
        }
        
    }
}
