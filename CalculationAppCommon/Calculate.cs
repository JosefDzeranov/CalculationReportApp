using System;
using System.Collections.Generic;

namespace CalculationAppCommon
{
    public static class Calculate
    {
        public static Dictionary<string, int> ExecutorsAndTheirTasksAmount(string[] users)
        {
            var resultDct = new Dictionary<string, int>();
            for (int i = 0; i < users.Length; i++)
            {
                var stringNames = users[i].Split(new string[] { "\t" }, StringSplitOptions.RemoveEmptyEntries);
                var name = stringNames[0].Split();
                var fullname = "";
                if (stringNames[0] == "Климов Сергей Александрович")
                {
                    fullname = (stringNames[1].Split(new string[] { "(Отв.)", ";", }, StringSplitOptions.RemoveEmptyEntries)[0].Trim());
                }
                else
                    fullname = ($"{name[0]} {name[1][0]}.{name[2][0]}.".Trim());

                if (resultDct.ContainsKey(fullname))
                    resultDct[fullname] += 1;
                else
                {
                    resultDct[fullname] = 1;
                }
            }

            return resultDct;
        }
       
        public static List<Executor> CreateResultExecutorsList(Dictionary<string, int> appealsDct, Dictionary<string, int> rkkDct)
        {
            var resultExecutorsLst = new List<Executor>();

            foreach (var appeal in appealsDct)
            {
                if (rkkDct.ContainsKey(appeal.Key))
                    resultExecutorsLst.Add(new Executor(appeal.Key, rkkDct[appeal.Key], appeal.Value, appeal.Value + rkkDct[appeal.Key]));
                else if (!rkkDct.ContainsKey(appeal.Key))
                    resultExecutorsLst.Add(new Executor(appeal.Key, 0, appeal.Value, appeal.Value));
            }

            foreach (var rkk in rkkDct)
            {
                if (!appealsDct.ContainsKey(rkk.Key))
                    resultExecutorsLst.Add(new Executor(rkk.Key, rkk.Value, 0, rkk.Value));
            }

            return resultExecutorsLst;
        }
    }
}
