using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Object_oriented_programs
{
    class StockusingQueue
    {
        private string datetime;
        private string jsonFile;

        public void stockqueue()
        {
            string pathoftrancation = "C:/Users/BridgeLabz/source/repos/Object oriented programs/trancation.json";

            trancation a = new trancation();
            Trancatuionmodel m = new Trancatuionmodel();

            QueueImplementedUsingLinkedList<trancation> queue = new QueueImplementedUsingLinkedList<trancation>();
            Console.WriteLine("Enter a password ");
            queue.enqueue("datetime");
            if (Utility.userstring().Equals("admin"))
            {
                try
                {

                    var jObject = JObject.Parse(pathoftrancation);
                    JArray trancation = (JArray)jObject["Trancation"];
                    Console.Write("Enter Company ID to Update Company : ");
                    var companyId = Convert.ToInt32(Console.ReadLine());

                    if (companyId > 0)
                    {
                        Console.WriteLine("Trancstion time");
                        var Trancstion_time = Console.ReadLine();

                        foreach (var company in trancation.Where(obj => obj["datetime"].Value<int>() == companyId))
                        {
                            company["datetime"] = !string.IsNullOrEmpty(datetime) ? datetime : "";
                        }

                        jObject["datetime"] = trancation;
                        string output = Newtonsoft.Json.JsonConvert.SerializeObject(jObject, Newtonsoft.Json.Formatting.Indented);
                        File.WriteAllText(pathoftrancation, output);

                        Console.WriteLine(a.getdatetime());
                        queue.dequeue();
                    }
                }
                catch
                {

                }
                
                //  Utility.Details(pathoftrancation, m);
            }
        }
    }
}
