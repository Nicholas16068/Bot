using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord;
using Discord.Commands;
using Discord.WebSocket;

namespace Bot.Modules
{
    public class Commands : ModuleBase<SocketCommandContext>
    {
      

        [Command("drg")]
        public async Task RandomDecks()
        {
           

            Random rnd = new Random();
            int deck1 = rnd.Next(0, 76);
            int deck2 = rnd.Next(0, 76);
            var id = Context.Message.Author.Id;
            var embed = new EmbedBuilder()
            
             .WithColor(Color.DarkBlue)
             .WithDescription($"<@{id}>" + Environment.NewLine +"Random Decks. May the RNG Gods favor us!" + Environment.NewLine + "Deck 1: " + deck1 + Environment.NewLine + "Deck 2: " + deck2 + Environment.NewLine + "Have fun!");
           
            await ReplyAsync(embed: embed.Build());
        }

        

       
    }

}
