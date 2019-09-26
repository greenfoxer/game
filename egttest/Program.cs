using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using egt.Classes;
using egt.Logic.Services;
using egt.Logic.Interfaces;
using egt.Logic.DataTransferObjects;
using egt.Logic.BusinessLogic.Commands;
namespace egt.test
{
    class Program
    {
        static void Main(string[] args)
        {
            int myId = 0;
            //egt.Classes.UnitOfWork.UnitOfWork unit = new Classes.UnitOfWork.UnitOfWork();
            //unit.GetRepository<egt.Classes.Entities.Player>().Add(new Classes.Entities.Player() {Name="lesha" });
            PlayerInfo a = new PlayerInfo() { Name = "Alesha" };
            IPlayerService data = new PlayerService();
            //data.Add(a);
            CommandInvoker inv = new Logic.BusinessLogic.Commands.CommandInvoker();
            inv.ProcessInput("/curehealth");
            List<PlayerInfo> t = data.GetAll().Value.ToList();
            egt.Logic.BusinessLogic.PlayerLogics ata = new Logic.BusinessLogic.PlayerLogics();
            ata.CureHealth(11);
            //using (EGTEntities.DataContext db = new DataContext())
            //{
            //    //decimal? pppp = db.Players.Max(t => t.Id);
            //    //int a = pppp == null ? 0 : (int)pppp + 1;
            //    Equipment e = new Equipment();
            //    e.Buffs.Add(new Buff());
            //    db.Groups.Add(Group.Newbie);
            //    db.Classes.Add(Class.Newbie);
            //    int a = 0;
            //    Player p = new Player(a);
            //    db.Players.Add(p);
            //    p.ChangeName("Smartee");
            //    db.SaveChanges();
            //}
        }
    }
}
