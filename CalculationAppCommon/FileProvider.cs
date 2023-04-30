using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CalculationAppCommon
{
    public static class FileProvider
    {
        public static void Write(string path, List<Executor> executors,bool flag,string time,string signSort)
        {
            var writer = new StreamWriter(path, false, Encoding.UTF8);
            var count = 1;
            writer.WriteLine("Справка о неисполненных документах и обращениях граждан\n");
            writer.WriteLine($"Не исполнено в срок {executors.Sum(x => x.TotalCount)} документов, из них:\n");
            writer.WriteLine($"- количество неисполненных входящих документов: {executors.Sum(x => x.RKK_Count)};\n");
            writer.WriteLine($"- количество неисполненных письменных обращений граждан: {executors.Sum(x => x.AppealsCount)}.\n");
            var sortType = "";
            switch (signSort)
            {
                case "name":
                    sortType= "по фамилии ответственного исполнителя";
                    break;
                case "rkkCount":
                    sortType= "по количеству РКК";
                    break;
                case "appealsCount":
                    sortType= "по количеству обращений";
                    break;
                case "totalCount":
                    sortType= "по общему количеству документов";
                    break;
            }
            writer.WriteLine($"Сортировка: {sortType}\n");
            writer.WriteLine("{0,-5} {1,-20} {2,-20} {3,-20} {4,-20}", "№ п.п.","Ответственный исполнитель ", "Количество неисполненных входящих документов ", "Количество неисполненных письменных обращений граждан ", "Общее количество документов и обращений");
            foreach (var executor in executors)
            {
                writer.WriteLine("{0,-5} {1,-25} {2,-50} {3,-50} {4,-50}",$"{count}",$"{executor.Name}", $"{executor.RKK_Count}",$"{executor.AppealsCount}",$"{executor.TotalCount}");
                count += 1;
            }
            writer.WriteLine('\n');
            var date = DateTime.Now.ToString();
            writer.WriteLine($"Дата составления справки: {DateTime.Parse(date).ToShortDateString()}\n");
            if(flag==true)
                writer.WriteLine($"Время выполнения алгоритма {time} мс");
            writer.Close();
        }

        
    }
}
