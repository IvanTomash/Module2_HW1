using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2_1
{
    internal class Starter
    {
        /// <summary>
        /// Entry point for program.
        /// </summary>
        public void Run()
        {
            var actor = new Actions();
            var res = new Result();
            var rand = new Random();
            for (int i = 0; i < 100; i++) 
            {
                switch(rand.Next(1, 4))
                {
                    case 1:                        
                        res = actor.FirstMethod();
                        break;
                    case 2:
                        res = actor.SecondMethod(); 
                        break;
                    case 3: 
                        res = actor.ThirdMethod();
                        break;
                }
                if (res.Status == false)
                {
                    Logger.Instance.LogInfo(LogTypes.Error, "Action failed by a reason:\t" + res.Message);
                }
                Thread.Sleep(100);                
            }
            File.WriteAllText("log.txt",Logger.Instance.AllLogs);
        }
    }
}
