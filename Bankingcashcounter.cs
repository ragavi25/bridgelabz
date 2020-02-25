//-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
// <copyright file=Bankingcashcounter.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name=" R Ragavi>
// ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections;

namespace Datastructure
{
    /// <summary>
    /// purpose: Create a Program which creates Banking Cash Counter where people come in to deposit Cash and withdraw Cash.
    /// Have an input panel to add people to Queue to either deposit or withdraw money and dequeue the people.
    /// Maintain the Cash Balance.
    /// </summary>
    class Bankingcashcounter
    {
        /// <summary>
        /// purpose:create aQueue Class to enqueue and dequeue people to either deposit or withdraw money and maintain the cash balance

        /// </summary>
        public void Bank()
        {
            Queue tokenno = new Queue();
            Queue accno = new Queue();
            Queue custName = new Queue();
            double money;
            int tokennum = 0;
        doTransAgain:
            Console.WriteLine("\n1.  Adding new Customer ");
            Console.WriteLine("\n2.  Attend a customer ");
            Console.WriteLine("----------------------------------------------------");
            int outer = Convert.ToInt32(Console.ReadLine());
            switch(outer)
            {
                case 1:
                    Console.Write("Enter your name");
             string name = Utility.UserName();
                    Console.Write("Enter Account number");
                    int ACno = Utility.UserAcno();
                    tokenno.Enqueue(tokennum);
                    custName.Enqueue(name);
                    accno.Enqueue(ACno);

                    Console.WriteLine("\nPlease Wait...Your Token number is: {0} \n",tokennum++);
                    goto doTransAgain;
                case 2:
                    if (tokenno.Count> 0)
                    {
                        Console.WriteLine("\n======= Select your Transaction From (1-3) ==========");
                        Console.WriteLine("1.  Deposit Money ");
                        Console.WriteLine("2.  Withdraw Money ");
                        Console.WriteLine("3.  Print Passbook ");

                        Console.WriteLine("-------------------------------------------------------\n");
                        int inner = Convert.ToInt32(Console.ReadLine());
                        switch (inner)
                        {
                            case 1:////deposit money
                                Console.WriteLine("\nYour Token No. {0} Please Attend at Counter :(A)\n", tokenno.Dequeue());
                                Console.Write("Enter the Amount to be Deposit: ");
                                money = Utility.UserMoney();
                                Console.WriteLine("\n------------- Cash Deposit Reciept -----------");
                                Console.WriteLine("\n\tCash Deposited :   {0}\n\tAccount No :  {1}\n\tCust Name :   {2}\n", money, accno.Dequeue(), custName.Dequeue());

                                Console.WriteLine("------------  ---------------------------------");
                                goto doTransAgain;

                            case 2: ////Withdrwal

                                Console.WriteLine("\nYour Token No. {0} Please Attend at Counter :(B)\n", tokenno.Dequeue());
                                Console.Write("Enter the Amount to be Withdraw: ");
                                money = Utility.UserMoney();
                                Console.WriteLine("\n------------- Cash Withdraw Reciept -----------");
                                Console.WriteLine("\n\tCash Withdraw :   {0}\n\tAccount No :   {1}\n\tCust Name :    {2}\n", money, accno.Dequeue(), custName.Dequeue());

                                Console.WriteLine("----------- ---------------------------------");
                                goto doTransAgain;

                            case 3:
                              ////Print Passbook

                                Console.WriteLine("\nYour Token No. {0} Please Attend at Counter :(C)\n", tokenno.Dequeue());
                                Console.Write("Enter Money in Your Account : ");
                                money = Utility.UserMoney();

                                Console.WriteLine("\n\t\t-----  Printing Pass Book ----- ");
                                Console.WriteLine("-------------------------------------------\n");
                                Console.WriteLine("\n\t\tAccount number :  {0}\n\t\tAccount Holder Name :{1}\n\t\tTotal Amount :  {2}\n", accno.Dequeue(), custName.Dequeue(), money);



                                Console.WriteLine("--------------------------------------------\n");
                                goto doTransAgain;

                        }

                    }

                    else
                    {
                        Console.WriteLine("There is no Customer Available Right now...\n");
                        goto doTransAgain;
                    }
                    break;
            }
        }

    }
    }

