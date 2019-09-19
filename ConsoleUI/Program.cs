using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EGTEntities;
using System.Data.Entity;

namespace ConsoleUI
{
    class Program
    {
        static string mytgId;
        static string ShowText()
        {
            string res = "";

            return res;
        }
        static void ProccedAction()
        {
            Console.WriteLine(ShowText());
            int act = Convert.ToInt32(Console.ReadLine());
            switch (act)
            {
                case 1: WriteAction(act); break;
                default: WriteAction(0); break;
            }
        }
        static void WriteAction(int action)
        {
            using (DataContext db = new DataContext())
            {
                db.RuntimeUserActions.Add(new RuntimeUserAction());
                db.SaveChanges();
            }
        }
        static void Main(string[] args)
        {
            mytgId = "12345";
            while (true)
            {
                ProccedAction();    
            }

        }
    }
}
