using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuntimeProcessor
{
    class Program
    {
        static void Main(string[] args)
        {
            //string inp = "v3 001017 18-8001 200 23840001 5000  20023840001-5000  v3 001017 18-8001 200 23845001 5000  20023845001-50000  v3 001017 18-8001 200 23850001 5000  20023850001-5000  v3 001017 18-8001 200 23795001 5000  20023795001-800000  v3 001017 18-8001 200 23800001 5000  20023800001-5000  v3 001017 18-8001 200 23805001 5000  20023805001-10000  v3 001017 18-8001 200 23735001 5000  20023735001-40000  v3 001017 18-8001 200 23740001 5000  20023740001-5000  v3 001017 18-8001 200 23745001 5000  20023745001-50000  v3 001017 18-8001 200 23750001 5000  20023750001-5000  v3 001017 18-8001 200 23755001 5000  20023755001-60000  v3 001017 18-8001 200 23760001 5000  20023760001-5000  v3 001017 18-8001 200 23825001 5000  20023825001-30000  v3 001017 18-8001 200 23830001 5000  20023830001-5000  v3 001017 18-8001 200 23835001 5000  20023835001-40000  v3 001017 18-8001 200 23810001 5000  20023810001-5000  v3 001017 18-8001 200 23815001 5000  20023815001-20000  v3 001017 18-8001 200 23820001 5000  20023820001-5000  v3 001017 18-8001 200 23780001 5000  20023780001-5000  v3 001017 18-8001 200 23785001 5000  20023785001-90000  v3 001017 18-8001 200 23790001 5000  20023790001-5000  v3 001017 18-8001 200 23855001 5000  20023855001-60000  v3 001017 18-8001 200 23860001 5000  20023860001-5000  v3 001017 18-8001 200 23865001 5000  20023865001-70000  v3 001017 18-8001 200 23975001 5000  20023975001-80000  v3 001017 18-8001 200 23980001 5000  20023980001-5000  v3 001017 18-8001 200 23985001 5000  20023985001-90000  v3 001017 18-8001 200 24065001 5000  20024065001-70000  v3 001017 18-8001 200 24070001 5000  20024070001-5000  v3 001017 18-8001 200 24075001 5000  20024075001-80000  v3 001017 18-8001 200 24050001 5000  20024050001-5000  v3 001017 18-8001 200 24055001 5000  20024055001-60000  v3 001017 18-8001 200 24060001 5000  20024060001-5000  v3 001017 18-8001 200 24125001 5000  20024125001-30000  v3 001017 18-8001 200 24130001 5000  20024130001-5000  v3 001017 18-8001 200 24135001 5000  20024135001-40000  v3 001017 18-8001 200 24095001 5000  20024095001-100000  v3 001017 18-8001 200 24100001 5000  20024100001-5000  v3 001017 18-8001 200 24105001 5000  20024105001-10000  v3 001017 18-8001 200 24080001 5000  20024080001-5000  v3 001017 18-8001 200 24085001 5000  20024085001-90000  v3 001017 18-8001 200 24090001 5000  20024090001-5000  v3 001017 18-8001 200 24020001 5000  20024020001-5000  v3 001017 18-8001 200 24025001 5000  20024025001-30000  v3 001017 18-8001 200 24030001 5000  20024030001-5000  v3 001017 18-8001 200 23990001 5000  20023990001-5000  v3 001017 18-8001 200 24010001 5000  20024010001-5000  v3 001017 18-8001 200 24015001 5000  20024015001-20000  v3 001017 18-8001 200 24035001 5000  20024035001-40000  v3 001017 18-8001 200 24040001 5000  20024040001-5000  v3 001017 18-8001 200 24045001 5000  20024045001-50000  v3 001017 18-8001 200 23960001 5000  20023960001-5000  v3 001017 18-8001 200 23965001 5000  20023965001-70000  v3 001017 18-8001 200 23970001 5000  20023970001-5000  v3 001017 18-8001 200 24110001 5000  20024110001-5000  v3 001017 18-8001 200 24115001 5000  20024115001-20000  v3 001017 18-8001 200 24120001 5000  20024120001-5000  v3 001017 18-8001 200 23270001 5000  20023270001-5000  v3 001017 18-8001 200 23275001 5000  20023275001-80000  v3 001017 18-8001 200 23280001 5000  20023280001-5000  v3 001017 18-8001 200 23255001 5000  20023255001-60000  v3 001017 18-8001 200 23260001 5000  20023260001-5000  v3 001017 18-8001 200 23265001 5000  20023265001-70000  v3 001017 18-8001 200 23195001 5000  20023195001-200000  v3 001017 18-8001 200 23200001 5000  20023200001-5000  v3 001017 18-8001 200 23205001 5000  20023205001-10000  v3 001017 18-8001 200 23330001 5000  20023330001-5000  v3 001017 18-8001 200 23335001 5000  20023335001-40000  v3 001017 18-8001 200 23340001 5000  20023340001-5000  v3 001017 18-8001 200 23630001 5000  20023630001-5000  v3 001017 18-8001 200 23635001 5000  20023635001-40000  v3 001017 18-8001 200 23640001 5000  20023640001-5000  v3 001017 18-8001 200 23585001 5000  20023585001-90000  v3 001017 18-8001 200 23590001 5000  20023590001-5000  v3 001017 18-8001 200 23595001 5000  20023595001-600000  v3 001017 18-8001 200 23600001 5000  20023600001-5000  v3 001017 18-8001 200 23605001 5000  20023605001-10000  v3 001017 18-8001 200 23610001 5000  20023610001-5000  v3 001017 18-8001 200 23285001 5000  20023285001-90000  v3 001017 18-8001 200 23290001 5000  20023290001-5000  v3 001017 18-8001 200 23295001 5000  20023295001-300000  v3 001017 18-8001 200 23615001 5000  20023615001-20000  v3 001017 18-8001 200 23620001 5000  20023620001-5000  v3 001017 18-8001 200 23625001 5000  20023625001-30000  v3 001017 18-8001 200 23675001 5000  20023675001-80000  v3 001017 18-8001 200 23680001 5000  20023680001-5000  v3 001017 18-8001 200 23685001 5000  20023685001-90000  v3 001017 18-8001 200 23690001 5000  20023690001-5000  v3 001017 18-8001 200 23695001 5000  20023695001-700000  v3 001017 18-8001 200 23700001 5000  20023700001-5000  v3 001017 18-8001 200 23660001 5000  20023660001-5000  v3 001017 18-8001 200 23665001 5000  20023665001-70000  v3 001017 18-8001 200 23670001 5000  20023670001-5000  v3 001017 18-8001 200 23945001 5000  20023945001-50000  v3 001017 18-8001 200 23950001 5000  20023950001-5000  v3 001017 18-8001 200 23955001 5000  20023955001-60000  v3 001017 18-8001 200 23915001 5000  20023915001-20000  v3 001017 18-8001 200 23920001 5000  20023920001-5000  v3 001017 18-8001 200 23925001 5000  20023925001-30000  v3 001017 18-8001 200 23185001 5000  20023185001-90000";
            //string outp = "v3 001017 18-8001 200 23270001 5000  20023270001-5000  v3 001017 18-8001 200 23275001 5000  20023275001-80000  v3 001017 18-8001 200 23280001 5000  20023280001-5000  v3 001017 18-8001 200 23825001 5000  20023825001-30000  v3 001017 18-8001 200 23830001 5000  20023830001-5000  v3 001017 18-8001 200 23835001 5000  20023835001-40000    v3 001017 18-8001 200 24125001 5000  20024125001-30000  v3 001017 18-8001 200 24130001 5000  20024130001-5000  v3 001017 18-8001 200 24135001 5000  20024135001-40000    v3 001017 18-8001 200 23795001 5000  20023795001-800000  v3 001017 18-8001 200 23800001 5000  20023800001-5000  v3 001017 18-8001 200 23805001 5000  20023805001-10000    v3 001017 18-8001 200 23600001 5000  20023600001-5000  v3 001017 18-8001 200 23605001 5000  20023605001-10000  v3 001017 18-8001 200 23610001 5000  20023610001-5000    v3 001017 18-8001 200 23990001 5000  20023990001-5000  v3 001017 18-8001 200 24010001 5000  20024010001-5000  v3 001017 18-8001 200 24015001 5000  20024015001-20000    v3 001017 18-8001 200 24050001 5000  20024050001-5000  v3 001017 18-8001 200 24055001 5000  20024055001-60000  v3 001017 18-8001 200 24060001 5000  20024060001-5000    v3 001017 18-8001 200 24080001 5000  20024080001-5000  v3 001017 18-8001 200 24085001 5000  20024085001-90000  v3 001017 18-8001 200 24090001 5000  20024090001-5000    v3 001017 18-8001 200 23675001 5000  20023675001-80000  v3 001017 18-8001 200 23680001 5000  20023680001-5000  v3 001017 18-8001 200 23685001 5000  20023685001-90000    v3 001017 18-8001 200 23630001 5000  20023630001-5000  v3 001017 18-8001 200 23635001 5000  20023635001-40000  v3 001017 18-8001 200 23640001 5000  20023640001-5000    v3 001017 18-8001 200 24110001 5000  20024110001-5000  v3 001017 18-8001 200 24115001 5000  20024115001-20000  v3 001017 18-8001 200 24120001 5000  20024120001-5000    v3 001017 18-8001 200 23975001 5000  20023975001-80000  v3 001017 18-8001 200 23980001 5000  20023980001-5000  v3 001017 18-8001 200 23985001 5000  20023985001-90000    v3 001017 18-8001 200 23960001 5000  20023960001-5000  v3 001017 18-8001 200 23965001 5000  20023965001-70000  v3 001017 18-8001 200 23970001 5000  20023970001-5000    v3 001017 18-8001 200 23585001 5000  20023585001-90000  v3 001017 18-8001 200 23590001 5000  20023590001-5000  v3 001017 18-8001 200 23595001 5000  20023595001-600000    v3 001017 18-8001 200 23735001 5000  20023735001-40000  v3 001017 18-8001 200 23740001 5000  20023740001-5000  v3 001017 18-8001 200 23745001 5000  20023745001-50000    v3 001017 18-8001 200 23750001 5000  20023750001-5000  v3 001017 18-8001 200 23755001 5000  20023755001-60000  v3 001017 18-8001 200 23760001 5000  20023760001-5000    v3 001017 18-8001 200 23615001 5000  20023615001-20000  v3 001017 18-8001 200 23620001 5000  20023620001-5000  v3 001017 18-8001 200 23625001 5000  20023625001-30000    v3 001017 18-8001 200 23330001 5000  20023330001-5000  v3 001017 18-8001 200 23335001 5000  20023335001-40000  v3 001017 18-8001 200 23340001 5000  20023340001-5000    v3 001017 18-8001 200 23285001 5000  20023285001-90000  v3 001017 18-8001 200 23290001 5000  20023290001-5000  v3 001017 18-8001 200 23295001 5000  20023295001-300000    v3 001017 18-8001 200 23855001 5000  20023855001-60000  v3 001017 18-8001 200 23860001 5000  20023860001-5000  v3 001017 18-8001 200 23865001 5000  20023865001-70000    v3 001017 18-8001 200 23660001 5000  20023660001-5000  v3 001017 18-8001 200 23665001 5000  20023665001-70000  v3 001017 18-8001 200 23670001 5000  20023670001-5000    v3 001017 18-8001 200 24020001 5000  20024020001-5000  v3 001017 18-8001 200 24025001 5000  20024025001-30000  v3 001017 18-8001 200 24030001 5000  20024030001-5000    v3 001017 18-8001 200 24095001 5000  20024095001-100000  v3 001017 18-8001 200 24100001 5000  20024100001-5000  v3 001017 18-8001 200 24105001 5000  20024105001-10000    v3 001017 18-8001 200 23810001 5000  20023810001-5000  v3 001017 18-8001 200 23815001 5000  20023815001-20000  v3 001017 18-8001 200 23820001 5000  20023820001-5000    v3 001017 18-8001 200 23780001 5000  20023780001-5000  v3 001017 18-8001 200 23785001 5000  20023785001-90000  v3 001017 18-8001 200 23790001 5000  20023790001-5000    v3 001017 18-8001 200 23945001 5000  20023945001-50000  v3 001017 18-8001 200 23950001 5000  20023950001-5000  v3 001017 18-8001 200 23955001 5000  20023955001-60000    v3 001017 18-8001 200 23255001 5000  20023255001-60000  v3 001017 18-8001 200 23260001 5000  20023260001-5000  v3 001017 18-8001 200 23265001 5000  20023265001-70000      v3 001017 18-8001 200 23195001 5000  20023195001-200000  v3 001017 18-8001 200 23200001 5000  20023200001-5000  v3 001017 18-8001 200 23205001 5000  20023205001-10000    v3 001017 18-8001 200 23915001 5000  v3 001017 18-8001 200 24035001 5000  20024035001-40000  v3 001017 18-8001 200 24040001 5000  20024040001-5000  v3 001017 18-8001 200 24045001 5000  20024045001-50000    20023915001-20000  v3 001017 18-8001 200 23920001 5000  20023920001-5000  v3 001017 18-8001 200 23925001 5000  20023925001-30000    v3 001017 18-8001 200 23690001 5000  20023690001-5000  v3 001017 18-8001 200 23695001 5000  20023695001-700000  v3 001017 18-8001 200 23700001 5000  20023700001-5000    v3 001017 18-8001 200 24065001 5000  20024065001-70000  v3 001017 18-8001 200 24070001 5000  20024070001-5000  v3 001017 18-8001 200 24075001 5000  20024075001-80000    v3 001017 18-8001 200 23840001 5000  20023840001-5000  v3 001017 18-8001 200 23845001 5000  20023845001-50000  v3 001017 18-8001 200 23850001 5000  20023850001-5000    v3 001017 18-8001 200 23185001 5000  20023185001-90000 ";
            //string[] splitter = { "v3" };
            //List<string> otgr = inp.Split(splitter,StringSplitOptions.RemoveEmptyEntries).Select(t=>t.Replace(" ","")).ToList();
            //List<string> vozvr = outp.Split(splitter, StringSplitOptions.RemoveEmptyEntries).Select(t => t.Replace(" ", "")).ToList();
            //foreach (string s in otgr)
            //    if (!vozvr.Contains(s))
            //        Console.WriteLine(s);
            //Console.ForegroundColor = ConsoleColor.Green;
            //foreach (string s in vozvr)
            //    if (!otgr.Contains(s))
            //        Console.WriteLine(s);
            //////////////////////////////initiation test//////////////////////////////
            new RuntimePseudo(1, 1, "go", "go_d*");
            new RuntimePseudo(1, 1, "walk", "walk_d*");
            new RuntimePseudo(1, 3, "itemtransfer", "itemtransfer_d*_d*_d*");
            ///////////////////////////////////////////////////////////////////////////
            string cmd = "/go_1";
            CommandParser(cmd);
        }
        static void CommandParser(string command)
        {
            string[] raw = command.Split('_');
            bool isnormal = RuntimePseudo.IsCorrect(raw[0], raw.Skip(1).Take(raw.Length - 1).ToArray());

        }
        class RuntimePseudo
        {
            int id, numOfP;

            public int NumOfP
            {
                get { return numOfP; }
                set { numOfP = value; }
            }

            public int Id
            {
                get { return id; }
                set { id = value; }
            }
            string name, pattern, description;

            public string Description
            {
                get { return description; }
                set { description = value; }
            }

            public string Pattern
            {
                get { return pattern; }
                set { pattern = value; }
            }

            public string Name
            {
                get { return name; }
                set { name = value; }
            }
            public RuntimePseudo(int id, int numofp, string name, string pattern, string description = "")
            {
                this.description = description;
                this.id = id;
                this.numOfP = numofp;
                this.name = name;
                this.pattern = pattern;
                Pseudos.Add(this);
            }
            static List<RuntimePseudo> Pseudos = new List<RuntimePseudo>();
            public static bool IsCorrect(string cmd,string[] param)
            {
                if (Pseudos.FirstOrDefault(t => t.name == cmd) != null && param.Length == Pseudos.FirstOrDefault(t => t.name == cmd).NumOfP)
                    return true;
                return false;
            }
        }
        class UserActionType
        {
            int id;
            string name;
        }
        interface IPlace
        {
            string Name { get; set; }
            int Priority { get; set; }
            string Description { get; set; }
        }
        class Location: IPlace
        {
            int id, duration, stamina, priority;

            public int Stamina
            {
                get { return stamina; }
                set { stamina = value; }
            }

            public int Duration
            {
                get { return duration; }
                set { duration = value; }
            }
            bool isMakesBusy, isRequestBusy, isConstant;

            public bool IsConstant
            {
                get { return isConstant; }
                set { isConstant = value; }
            }

            public bool IsRequestBusy
            {
                get { return isRequestBusy; }
                set { isRequestBusy = value; }
            }

            public bool IsMakesBusy
            {
                get { return isMakesBusy; }
                set { isMakesBusy = value; }
            }
            string name, description;
            public Location(int i, int duration, int stamina, string name, string descr, bool isMB, bool isRB, bool isC, int priority= 2)
            {
                this.id = i;
                this.duration = duration;
                this.stamina = stamina;
                this.name = name;
                this.description = descr;
                this.isMakesBusy = isMB;
                this.isRequestBusy = isRB;
                this.isConstant = isC;
                this.priority = priority;
            }

            public string Name
            {
                get{return this.name;}
                set{this.name = value;}
            }

            public int Priority
            {
                get { return this.priority; }
                set { this.priority = value; }
            }

            public string Description
            {
                get { return this.description; }
                set { this.description = value; }
            }
        }
        class Area: IPlace
        {
            int id, duration, priority;

            public int Id
            {
                get { return id; }
                set { id = value; }
            }

            public int Duration
            {
                get { return duration; }
                set { duration = value; }
            }
            bool isRequestBusy, isConstant;
            string name, description;
            public Area(int i, string name, string descr, bool isC, int priority = 1, int duration = 0)
            {
                this.id = i;
                this.duration = duration;
                this.name = name;
                this.description = descr;
                this.isConstant = isC;
                this.priority = priority;
            }

            public string Name
            {
                get { return this.name; }
                set { this.name = value; }
            }

            public int Priority
            {
                get { return this.priority; }
                set { this.priority = value; }
            }

            public string Description
            {
                get { return this.description; }
                set { this.description = value; }
            }
        }
        class UserAction
        {
            int id, duration,priority;

            public int Priority
            {
              get { return priority; }
              set { priority = value; }
            }

            public int Duration
            {
              get { return duration; }
              set { duration = value; }
            }

            public int Id
            {
              get { return id; }
              set { id = value; }
            }
            string name, description;

            public string Description
            {
              get { return description; }
              set { description = value; }
            }

            public string Name
            {
              get { return name; }
              set { name = value; }
}
            bool makesBusy;

            public bool MakesBusy
            {
              get { return makesBusy; }
              set { makesBusy = value; }
            }
            IPlace location;
            public UserAction(int i, int priority, string name, string description, bool makesBusy, IPlace loc)
            {
                this.id = i;
                if (loc.GetType() == typeof(Area))
                {
                    this.duration = (loc as Area).Duration;
                    this.makesBusy = false;
                }
                if (loc.GetType() == typeof(Location))
                {
                    this.duration = (loc as Location).Duration;
                    this.makesBusy = (loc as Location).IsMakesBusy;
                }
                this.priority = loc.Priority;
                this.name = loc.Name;
                this.description = loc.Description;
                this.location = loc;
            }
            void GenerateTask()
            {
                
            }
        }
        class Player
        {
            int id;
            string name;
            bool isBusy;

            public Player(int id, string name)
            {
                this.id = id;
                this.name = name;
                this.isBusy = false;
            }
            public void MakePersonBusy()
            {
                this.isBusy = true;
            }
            public void MakePersonUnbusy()
            {
                this.isBusy = false;
            }
        }
        class UserTask
        {
            int id;

            public int Id
            {
              get { return id; }
              set { id = value; }
            }
                        UserAction uAction;

            public UserAction UAction
            {
              get { return uAction; }
              set { uAction = value; }
            }
                        DateTime datetimestart, datetimefinish;

            public DateTime Datetimefinish
            {
              get { return datetimefinish; }
              set { datetimefinish = value; }
            }

            public DateTime Datetimestart
            {
              get { return datetimestart; }
              set { datetimestart = value; }
            }
                        bool isFinished;

            public bool IsFinished
            {
              get { return isFinished; }
              set { isFinished = value; }
            }
            public UserTask(UserAction loc)
            {
                this.uAction = loc;
                this.datetimestart = DateTime.Now;
                this.datetimefinish = DateTime.Now.AddMinutes((double)uAction.Duration);
                tasks.Add(this);
            }
            static List<UserTask> tasks = new List<UserTask>();
        }
    }
}
