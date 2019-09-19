using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EGTEntities
{
    public class RuntimeUserAction
    {
        int id;
        Player player;
        RuntimeAction action;
        DateTime dateStart;
        DateTime dateFinish;
        bool isFinished;

        public int Id { get => id; set => id = value; }
        public DateTime DateStart { get => dateStart; set => dateStart = value; }
        public DateTime DateFinish { get => dateFinish; set => dateFinish = value; }
        internal Player CurrentPlayer { get => player; set => player = value; }
        internal RuntimeAction CurrentAction { get => action; set => action = value; }
        public bool IsFinished { get => isFinished; set => isFinished = value; }
    }
}