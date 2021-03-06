﻿using System;
using System.Collections.Generic;
using System.Text;
using Discord.Commands;
using Discord;
using System.Threading.Tasks;

namespace Discord_Bot_1_02.Modules
{
    /// <summary>
    /// All commands after b! prefix
    /// </summary>
    public class Commands : ModuleBase<SocketCommandContext>
    {
        string[] apuArray = new string[]
           {
                "https://imgur.com/gszBhIw",
                "https://imgur.com/Z6HCYAG",
                "https://imgur.com/NMxhmbF",
                "https://imgur.com/DvhouKi",
                "https://imgur.com/sdCy25L",
                "https://imgur.com/yApakTZ",
                "https://imgur.com/uEpP87o",
                "https://imgur.com/IUXt3tn",
                "https://imgur.com/rCNdkBn",
                "https://imgur.com/iQG06Ju",
                "https://imgur.com/145UZdu",
                "https://imgur.com/SJuC40h",
                "https://imgur.com/XRuFb0q",
                "https://imgur.com/a0oiokW",
                "https://imgur.com/eK9gN4Z",
                "https://imgur.com/l4TIMlT",
                "https://imgur.com/NmpuVN2",
                "https://imgur.com/7Djf7K4",
                "https://imgur.com/V8y9YSa",
                "https://imgur.com/pVaevCb",
                "https://imgur.com/ezjMOVk",
                "https://imgur.com/9OYzbOP",
                "https://imgur.com/vrfgxQS",
                "https://imgur.com/WBEjhLv",
                "https://imgur.com/ZTc0pv9",
                "https://imgur.com/ukVO1CZ",
                "https://imgur.com/Y68dGuQ",
                "https://imgur.com/CIlrtyR",
                "https://imgur.com/U9uC9if",
                "https://imgur.com/wcDcqwI",
                "https://imgur.com/yzeRRfE",
                "https://imgur.com/8yDOTxD",
                "https://imgur.com/jcmAnVz",
                "https://imgur.com/mAQezjN",
                "https://imgur.com/UYMxG3P",
                "https://imgur.com/iyZqmIZ",
                "https://imgur.com/xzHwfca",
                "https://imgur.com/jN8CIpQ",
                "https://imgur.com/o7PlBFN",
                "https://imgur.com/7DcFpwv",
                "https://imgur.com/cEJdvm9",
                "https://imgur.com/T4l6QGL",
                "https://imgur.com/Dt1n0NU",
                "https://imgur.com/lRbvzcL",
                "https://imgur.com/sJWT92f",
                "https://imgur.com/1RqbDGb",
                "https://imgur.com/TcPCm1N",
                "https://imgur.com/M2fyVfX",
                "https://imgur.com/AP9DTRk",
                "https://imgur.com/Ivpd0gk",
                "https://imgur.com/Ivpd0gk",
                "https://imgur.com/fVfWuPr",
                "https://imgur.com/Px9nQlp",
                "https://imgur.com/4fk8kuz",
                "https://imgur.com/urCjwKy",
                "https://imgur.com/moxvCQs",
                "https://imgur.com/0Anfr0w",
                "https://imgur.com/hCXaMAI",
                "https://imgur.com/JUBn8er",
                "https://imgur.com/8WxAd1e",
                "https://imgur.com/8Y7WVhx",
                "https://imgur.com/EYKIKEi",
                "https://imgur.com/qpGXkgC",
                "https://imgur.com/mfMmOM5",
                "https://imgur.com/gvpInYT",
                "https://imgur.com/BZmABYN",
                "https://imgur.com/K9bjhOR",
                "https://imgur.com/8iTaoux",
                "https://imgur.com/tYbTEaq",
                "https://imgur.com/BmWauqs",
                "https://imgur.com/K3tPklI",
                "https://imgur.com/mVry2dt",
                "https://imgur.com/RQ9NJj5",
                "https://imgur.com/cPjs1Dc",
                "https://imgur.com/C8RxDjl",
                "https://imgur.com/KH2PjBF",
                "https://imgur.com/O3MSKIa",
                "https://imgur.com/zDocsyh",
                "https://imgur.com/Y1kLzEV",
                "https://imgur.com/pH5Tppq",
                "https://imgur.com/vDw4mOJ",
                "https://imgur.com/XRxzGNi",
                "https://imgur.com/qs1WTRh",
                "https://imgur.com/waW8BC8",
                "https://imgur.com/0k2a434",
                "https://imgur.com/mftHkoS",
                "https://imgur.com/1b4tXKc",
                "https://imgur.com/tJQdPzM",
                "https://imgur.com/B6AeD0z",
                "https://imgur.com/2tgarhk",
                "https://imgur.com/baThtzk",
                "https://imgur.com/GdY8hUF",
                "https://imgur.com/NVYFlQH",
                "https://imgur.com/6ePQYeP",
                "https://imgur.com/0E4oaR1",
                "https://imgur.com/ljSinMv",
                "https://imgur.com/Mj33pre",
                "https://imgur.com/Osb3juC",
                "https://imgur.com/0Gb1nG0",
                "https://imgur.com/2SYMiU1",
                "https://imgur.com/3pP9bDt",
                "https://imgur.com/H2sK6Hv",
                "https://imgur.com/CnhLBID",
                "https://imgur.com/nlAyc0W",
                "https://imgur.com/BzQCqcd",
                "https://imgur.com/rIE8ufO",
                "https://imgur.com/9S0mbBt",
                "https://imgur.com/Xu8cSTC",
                "https://imgur.com/65jbo0d",
                "https://imgur.com/00adRLK",
                "https://imgur.com/ivmJKsm",
                "https://imgur.com/hySWY7S",
                "https://imgur.com/o8edzLu",
                "https://imgur.com/Y1MqhBd",
                "https://imgur.com/iKSbcKX",
                "https://imgur.com/gBBWXLc",
                "https://imgur.com/Rjzyosz",
                "https://imgur.com/e077ndO",
                "https://imgur.com/LeKRIcJ",
                "https://imgur.com/RtskD4W",
                "https://imgur.com/OOOHjOc",
                "https://imgur.com/sgYRd4e",
                "https://imgur.com/f58zHuV",
                "https://imgur.com/9Dej8nL",
                "https://imgur.com/UeIYP40",
                "https://imgur.com/Ckpv12N",
                "https://imgur.com/tjPuVjW",
                "https://imgur.com/XlFrsyC",
                "https://imgur.com/NtpaNKD",
                "https://imgur.com/VvltBJw",
                "https://imgur.com/7t8K9Jw",
                "https://imgur.com/8jrobpZ",
                "https://imgur.com/5sWHasN",
                "https://imgur.com/Eyb9eF2",
                "https://imgur.com/tcz7eIc",
                "https://imgur.com/F72rLOu",
                "https://imgur.com/hIxsrfC",
                "https://imgur.com/CGeVP1Y",
                "https://imgur.com/fDNiHH3",
                "https://imgur.com/lPqVJAF",
                "https://imgur.com/s8DpItP",
                "https://imgur.com/gNQ4Yr8",
                "https://imgur.com/THBWuyi",
                "https://imgur.com/FboWxJ5",
                "https://imgur.com/EddOwTg",
                "https://imgur.com/vkPtdOT",
                "https://imgur.com/pj1rjf9",
                "https://imgur.com/YwCqABg",
                "https://imgur.com/MWDwPlJ",
                "https://imgur.com/xoxseZe",
                "https://imgur.com/C4Aw4DK",
                "https://imgur.com/is0avvM",
                "https://imgur.com/wYj4HqE",
                "https://imgur.com/4U7QrQW",
                "https://imgur.com/lWDmL9g",
                "https://imgur.com/3CZducN",
                "https://imgur.com/iEAjDlR",
                "https://imgur.com/KP7UZXA",
                "https://imgur.com/betp4rV",
                "https://imgur.com/nvA6z3D",
                "https://imgur.com/WGdkJ7l",
                "https://imgur.com/htP6UvW",
                "https://imgur.com/6XbS1zY",
                "https://imgur.com/CQbF6t7",
                "https://imgur.com/MQfKwbW",
                "https://imgur.com/J3viLxP",
                "https://imgur.com/TnMi93u",
                "https://imgur.com/TclF0eu",
                "https://imgur.com/RIJEIL1",
                "https://imgur.com/G7B0ui5",
                "https://imgur.com/ZZ1F3jV",
                "https://imgur.com/kugLzsM",
                "https://imgur.com/F73ivQ5",
                "https://imgur.com/jdSxLqE",
                "https://imgur.com/1heAMWc",
                "https://imgur.com/E4RY4Gd",
                "https://imgur.com/OUvxdFA",
                "https://imgur.com/tE1huy1",
                "https://imgur.com/kIqmBh5",
                "https://imgur.com/fYuwZ7O",
                "https://imgur.com/vK77nI5",
                "https://imgur.com/XGoMWv3",
                "https://imgur.com/96tHxwf",
                "https://imgur.com/EhMqOSu",
                "https://imgur.com/GJYpwl0",
                "https://imgur.com/Uu8yNjS",
                "https://imgur.com/rftJxYb",
                "https://imgur.com/lFGpzCL",
                "https://imgur.com/C82cbIA",
                "https://imgur.com/FADfqn1",
                "https://imgur.com/5vgh2iN",
                "https://imgur.com/72pojH6",
                "https://imgur.com/0nhgY3i",
                "https://imgur.com/DpfDTn4",
                "https://imgur.com/y4CiihX",
                "https://imgur.com/63OgIEB",
                "https://imgur.com/k1QxBib",
                "https://imgur.com/Rlc4xyC",
                "https://imgur.com/AIENeDX",
                "https://imgur.com/3uNLo9t",
                "https://imgur.com/uALmaoC",
                "https://imgur.com/E6FQ98s",
                "https://imgur.com/TRF7OMv",
                "https://imgur.com/GvAlaXa",
                "https://imgur.com/lQCThap",
                "https://imgur.com/4Ilqx8n",
                "https://imgur.com/GQJUfNY",
                "https://imgur.com/Um0MY3l",
                "https://imgur.com/oCvdi3Z",
                "https://imgur.com/VhwQXAC",
                "https://imgur.com/qDa2Enl",
                "https://imgur.com/8FHS88Z",
                "https://imgur.com/gDTp0o0",
                "https://imgur.com/gYQC7zR",
                "https://imgur.com/ri7q6RA",
                "https://imgur.com/WxFY7mE",
                "https://imgur.com/l512QSD"

           };

        string[] taneliMemes = new string[]
            {
                "https://i.imgur.com/Q83E7Nk.png",
                "https://i.imgur.com/KwDgXmO.png",
                "https://i.imgur.com/W0XDtAO.jpg",
                "https://i.imgur.com/OJEp47M.png",
                "https://i.imgur.com/fGXav8g.png",
                "https://i.imgur.com/nvVAyX0.jpg",
                "https://i.imgur.com/KgEJ6QI.png",
                "https://i.imgur.com/JyCTIdQ.jpg",
                "https://i.imgur.com/IdLOROw.png",
                "https://i.imgur.com/DA2j1CL.png",
                "https://i.imgur.com/vie87aN.jpg",
                "https://i.imgur.com/D7uNuSV.png",
                "https://i.imgur.com/IC3FLRy.png",
                "https://i.imgur.com/BJaBFYW.jpg",
                "https://i.imgur.com/WoLwr7P.jpg"
            };
        Random rng = new Random();

        [Command("ping")]
        public async Task PingAsync()
        {
            await BasicEmbedBuilder("Hello", Color.DarkBlue);
            
        }

        [Command("arvostelu")]
        public async Task arvosteluAsync()
        {
            EmbedBuilder builder = new EmbedBuilder();
            EmbedFooterBuilder footerBuilder = new EmbedFooterBuilder();
            builder.WithTitle(builder.Author.Name).WithColor(Color.DarkBlue);

            await ReplyAsync("", false, builder.Build());
        }

        [Command("roulette")]
        public async Task RouletteAsync()
        {
            await ReplyAsync(rng.Next(1, 7) == 6 ? "Boom" : "Click");
        }

        [Command("tandere")]
        public async Task TandereAsync()
        {
            EmbedBuilder builder = new EmbedBuilder();
            builder.WithTitle(":page_facing_up: | **Score**: 999  |  Rating: **Explicit**\nhttps://www.reddit.com/r/Taneli_irl/").WithImageUrl(taneliMemes[rng.Next(taneliMemes.Length - 1)])
                .WithColor(Color.DarkBlue);
            
            await ReplyAsync("", false, builder.Build());
        }

        [Command("alfa")]
        public async Task Alfa()
        {
            await ReplyAsync("<@160410433952546816> on 5/5 alfa");
        }

        [Command("apu")]
        public async Task ApuAsync()
        {
            await ReplyAsync(":frog: | **Score: " + rng.Next(9999) + " | Rating: **Explicit | :frog:");
            await ReplyAsync(apuArray[rng.Next(apuArray.Length - 1)]);
        }


        public async Task BasicEmbedBuilder(string message, Color color)
        {
            EmbedBuilder builder = new EmbedBuilder();
            builder.WithTitle(message).WithColor(color);
            await ReplyAsync("", false, builder.Build());
        }
    }
}
