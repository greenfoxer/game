using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using egtClasses.Entities;
using Telegram.Bot;
using Telegram.Bot.Types;
namespace testProject1.Command
{
    public class CurehealthCommand : Command
    {
        public override string Name
        {
            get { return "curehealth"; }
        }

        public override void Execute(Message message, TelegramBotClient client)
        {
            using (DataContext db = new DataContext())
            {
                Player player = db.Players.FirstOrDefault(t => t.TelegramID == client.BotId.ToString());
                if (player.Cookie > 0)
                {
                    player.Health = player.Health_max;
                    player.Cookie--;
                }
                db.SaveChanges();
            }
        }
    }
}
