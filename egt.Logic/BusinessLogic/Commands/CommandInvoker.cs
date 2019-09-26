using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace egt.Logic.BusinessLogic.Commands
{
    public class CommandInvoker //Invoker for Command pattern
    {
        private readonly List<IGameCommand> _queue = new List<IGameCommand>();
        public bool HasQuery { get { return _queue.Any(x => x.Status == Status.Queued || x.Status == Status.ExecuteFailed || x.Status == Status.RevertFailed); } }
        public void AddCommand(IGameCommand cmd)
        {
            _queue.Add(cmd);
        }
        public void ProcessQueue()
        { 
            foreach(var cmd in _queue.Where(x=>x.Status==Status.Queued))
                cmd.Execute();
        }
        //Dictionary<string, ConstructorInfo> cmds = new Dictionary<string, ConstructorInfo>();
        Dictionary<string, Func<IGameCommand>> cmds = new Dictionary<string, Func<IGameCommand>>();
        public void ProcessInput(string str)
        {
            string[] sample_param = new string[] {"1","2"};
            cmds.Add("/curehealth", ( ) => new CureHealthCommand(1,sample_param));
            //var type = typeof(IGameCommand);
            //var types = AppDomain.CurrentDomain.GetAssemblies()
            //    .SelectMany(s => s.GetTypes())
            //    .Where(p => type.IsAssignableFrom(p)).ToList();
            //string[] sample_param = new string[] {"1","2"};
            //cmds.Add("/curehealth", typeof(CureHealthCommand).GetConstructor(new Type[]{typeof(int),typeof(string[])}));
            //IGameCommand c = (CureHealthCommand)cmds["/curehealth"].Invoke(new object[] { 1, sample_param });
        }
    }
}
