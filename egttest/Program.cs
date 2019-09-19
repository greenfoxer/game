using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EGTEntities;
using System.Data.Entity;

namespace egttest
{
    class Program
    {
        static void Main(string[] args)
        {
            int myId = 0;
            using (EGTEntities.DataContext db = new DataContext())
            {
                //decimal? pppp = db.Players.Max(t => t.Id);
                //int a = pppp == null? 0 : (int)pppp+1;
                db.Groups.Add(Group.Newbie);
                db.Classes.Add(Class.Newbie);
                int a = 0; 
                Player p = new Player(a);
                db.Players.Add(p);
                p.ChangeName("Smartee");
                db.SaveChanges();
            }
        }
    }
}
