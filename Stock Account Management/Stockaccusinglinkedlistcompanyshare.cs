using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Object_oriented_programs
{
    class Stockaccusinglinkedlistcompanyshare
    {
        private string company_name;
        private string company_symbol;
        private string company_shares;
        private string company_share_price;
        private string company_total_value;

        public void Stockacc()
        {

            company_share r = new company_share();
           Companysharemodel cmp = new Companysharemodel();
            string pathofcompany = "C:/Users/BridgeLabz/source/repos/Object oriented programs/Companyshare.json";
         
            LinkedList<company_share> cmplist = new LinkedList<company_share>();


            ///cmplist.AddLast(cmp.getCompany_shares());
            bool isExit = false;
            Console.WriteLine(" access company data");
            if (Utility.userstring().Equals("Admin"))
            {
                while (!isExit)
                {
                    Console.WriteLine("Enter company symbol: ");
                    string companySymbol = Console.ReadLine();
                    int indexOfCompany = 0;
                   
                    for (int i = 0; i < cmplist.Count(); i++)
                    {
                        if (companySymbol == r.getcompanysymbol())
                        {
                           
                            indexOfCompany = i;
                            break;
                        }
                    }

                  //  Utility.Details(pathofcompany, cmp);
                        Console.WriteLine("The company you selected is: " + indexOfCompany, r.getcompanyname());
                    Console.ReadLine();
                        Console.WriteLine("Company shares: " + indexOfCompany, r.getcompanyshares());
                        Console.WriteLine("Company share price: " + indexOfCompany,r.getcompanyshareprice());
                        Console.WriteLine("Company Total value: " + indexOfCompany, r.getcompanytotalvalue());
                        Console.WriteLine("Welcome please select task: ");
                        Console.WriteLine("1. for adding shares\n2. for removing shares\n3. for exit");
                        int sharesAmount;
                        int ch = Convert.ToInt32(Console.ReadLine());
                        switch (ch)
                        {
                            case 1:
                            // for adding shares
                            var newadding = "{'company_symbol'" + company_symbol + ",'company_name':" + company_name + ",'company_shares'" + company_shares + ",'company_share_price':" + company_share_price + ",'company_total_value':" + company_total_value + "}";
                            var json = File.ReadAllText(pathofcompany);
                            var jsonObj = JObject.Parse(json);
                            var companyshare = jsonObj.GetValue("company_shares") as JArray;
                            var adding = JObject.Parse(newadding);
                            companyshare.Add(adding);
                            jsonObj["company_shares"] = companyshare;
                            string newJsonResult = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObj,
                               Newtonsoft.Json.Formatting.Indented);
                            File.WriteAllText(pathofcompany, newJsonResult);
                            Console.WriteLine("Enter number of shares");
                                sharesAmount = Convert.ToInt32(Console.ReadLine()) ;
                                r.setcompanyshares(r.getcompanyshares() + sharesAmount);
                                r.setcompanytotalvalue(r.getcompanyshares() * r.getcompanyshareprice());
                                
                                Console.WriteLine("Data saved!!!");
                                Console.WriteLine("Company: " + r.getcompanyname());
                                Console.WriteLine("Company shares: " + r.getcompanyshares());
                                Console.WriteLine(
                                        "Company share price: " + r.getcompanyshareprice());
                                Console.WriteLine(
                                        "Company Total value: " + r.getcompanytotalvalue());
                            Utility.Writterfile(pathofcompany, cmp);
                                Utility.Details(pathofcompany, cmp);
                                break;
                            case 2:
                            // for removing shares
                            var json1 = File.ReadAllText(pathofcompany);
                            var jObject = JObject.Parse(json1);
                            JArray companyshare1 = (JArray)jObject["company_shares"];
                            Console.Write("Enter Company ID to Delete Company : ");
                            var companyId = Console.ReadLine();
                            if (companyId !=null)
                            {
                                var companyName = string.Empty;
                                var companyToDeleted = companyshare1.FirstOrDefault(obj => obj["company_symbol"].Value<string>() == companyId);

                                companyshare1.Remove(companyToDeleted);

                                Console.WriteLine("Enter number of shares to remove");
                                sharesAmount = Convert.ToInt32(Console.ReadLine());
                                // check whether company have greater shares than sharesto remove
                                if (r.getcompanyshares() > sharesAmount)
                                {

                                    r.setcompanyshares(r.getcompanyshares() - sharesAmount);
                                    r.setcompanytotalvalue(r.getcompanyshares() - r.getcompanyshares());

                                    Console.WriteLine("Data saved!!!");
                                    Console.WriteLine("Company: " + r.getcompanyname());
                                    Console.WriteLine("Company shares: " + r.getcompanyshares());
                                    Console.WriteLine(
                                            "Company share price: " + r.getcompanyshareprice());
                                    Console.WriteLine(
                                            "Company Total value: " + r.getcompanytotalvalue());
                                    Utility.Details(pathofcompany, cmp);
                                }
                                else
                                    Console.WriteLine("Company don't have that much shares to remove");

                            }   break;
                            case 3:
                                isExit = true;
                                Console.WriteLine("Thank you for your time");
                                break;
                            default:
                                Console.WriteLine("Invalid Option");
                                break;

                        }
                    
                }

            }
            else
                Console.WriteLine("Invalid password");


        }

        
    }
}
