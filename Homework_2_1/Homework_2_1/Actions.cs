using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2_1
{
    /// <summary>
    /// Call the logger to log a message containing the text.
    /// </summary>
    internal class Actions
    {

        public Result FirstMethod()
        {
            Logger.Instance.LogInfo(LogTypes.Info, "Start method");
            return new Result(true);
        }

        public Result SecondMethod()
        {
            Logger.Instance.LogInfo(LogTypes.Warning, "Skipped logic in method");
            return new Result(true);
        }

        public Result ThirdMethod()
        {           
            return new Result(false, "I broke a logic");
        }
    }
}
