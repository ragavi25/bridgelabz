using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Object_oriented_programs
{
    class Addressbook
    {
        public string path = "C:/Users/BridgeLabz/source/repos/Object oriented programs/Adressbook.json";
      
        // var json = File.ReadAllText(path);
        public void Adrres()
        {
            Addressmodel a = JsonConvert.DeserializeObject<Addressmodel>(path);
            Console.WriteLine("enter your choose:\t1.Adding\n2.Removing\n3.Updating");
            int ch = Utility.Usernum();
            switch(ch)
            {
                case 1:
                    Console.WriteLine("Adding:");
                   
                    Address a1 = new Address { State = Utility.userstring(), City = Utility.userstring(), Street = Utility.userstring(), Zipcode = Utility.Usernum() };
                   // a.a1.Add(a1);
                    Utility.Writterfile(path, a);
            break;
                case 2:
                    var json = File.ReadAllText(path);
                    try
                    {
                        var jObject = JObject.Parse(json);
                        JArray newperson = (JArray)jObject["person"];
                        Console.Write("Enter Company ID to Delete Company : ");
                        var Id = Convert.ToInt32(Console.ReadLine());

                        if (Id > 0)
                        {
                            var FirstName = string.Empty;
                            var companyToDeleted = newperson.FirstOrDefault(obj => obj["id"].Value<int>() ==Id);

                            newperson.Remove(companyToDeleted);

                            string output = Newtonsoft.Json.JsonConvert.SerializeObject(jObject, Newtonsoft.Json.Formatting.Indented);
                            File.WriteAllText(path, output);
                        }
                        else
                        {
                            Console.Write("Invalid Company ID, Try Again!");
                            
                        }
                    }
                    catch (Exception e)
                    {

                        Console.WriteLine(e.Message);
                    }
                    break;
                case 3:
                    string json1 = File.ReadAllText(path);

                    try
                    {
                        var jObject = JObject.Parse(json1);
                        JArray person = (JArray)jObject["person"];
                        Console.Write("Enter  ID to Update Company : ");
                        var Id = Convert.ToInt32(Console.ReadLine());

                        if (Id > 0)
                        {
                            Console.Write("Enter new company name : ");
                            var FirstName = Convert.ToString(Console.ReadLine());

                            foreach (var ad in person.Where(obj => obj["id"].Value<int>() == Id))
                            {
                                ad["Firstname"] = !string.IsNullOrEmpty(FirstName) ? FirstName : "";
                            }

                            jObject["person"] = person;
                            string output = Newtonsoft.Json.JsonConvert.SerializeObject(jObject, Newtonsoft.Json.Formatting.Indented);
                            File.WriteAllText(path, output);
                        }
                        else
                        {
                            Console.Write("Invalid Company ID, Try Again!");

                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }

                        break;

            }


        }
    }
}
