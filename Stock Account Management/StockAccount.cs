using System;
using System.Collections.Generic;
using System.Text;

namespace Object_oriented_programs
{
    class StockAccount
    {
     public void stockacc()
        {
      /*int choice;
            int indexOfCustomer = 0;
            int indexOfCompany = 0;

            int customerId;
            int companySymbol;
            int numOfCompanyShareToBuy;
            Companysharemodel m1 = new Companysharemodel();
            Customermodel m2 = new Customermodel();
            Trancatuionmodel m3 = new Trancatuionmodel();
            /////path
           // compModel = (CompanysharesModel)JsonUtil.readMapper(pathOfCompanyShares, compModel);

            // code for fetching the customer info
            //custModel = (CustomerinfoModel)JsonUtil.readMapper(pathOfCustomerInfo, custModel);

            //File file = new File(pathOfTransaction);
            //if (file.length() != 0)
            //{
              //  transModel = (TransactionModel)JsonUtil.readMapper(pathOfTransaction, transModel);
           // }

            List<Customerinfo> custList = new ArrayList<>();
            List<Companyshares> compList = new ArrayList<>();
            List<Transactions> transList = new ArrayList<>();

            custList.addAll(custModel.getCustomerinfo());
            compList.addAll(compModel.getCompanyshares());

            if (!transModel.getTransactions().isEmpty())
            {
                transList.addAll(transModel.getTransactions());
            }

            System.out.println("Welcome!!");
            System.out.println("Please enter customer id");
            customerId = OOPsUtility.integerScanner();
            boolean isCustomerFound = false;
            for (int i = 0; i < custList.size(); i++)
            {
                if (customerId == custList.get(i).getCustomer_symbol())
                {
                    isCustomerFound = true;
                    indexOfCustomer = i;
                    break;
                }
            }
            if (isCustomerFound)
            {
                while (!isExit)
                {
                    Console.WriteLine("Hello: " + custList.get(indexOfCustomer).getCustomer_name());
                    Console.WriteLine("Please select options\n" + "1. buy shares\n" + "2. sell shares\n"
                            + "3. print report\n" + "4. exit");
                    choice = OOPsUtility.integerScanner();
                    switch (choice)
                    {
                        case 1:
                            // buy

                            Console.WriteLine("****************buy***************");

                            Console.WriteLine("Please enter company symbol: ");
                            companySymbol = OOPsUtility.integerScanner();

                            Console.WriteLine("Validating...");
                            boolean isCompanyFound = false;
                            for (int i = 0; i < compList.size(); i++)
                            {
                                if (companySymbol == compList.get(i).getCompany_symbol())
                                {
                                    isCompanyFound = true;
                                    indexOfCompany = i;
                                    break;
                                }
                            }
                            Console.WriteLine("The company you selected is: " + compList.get(indexOfCompany).getCompany_name());
                            Console.WriteLine("Company shares: " + compList.get(indexOfCompany).getCompany_shares());
                            Console.WriteLine("Company share price: " + compList.get(indexOfCompany).getCompany_share_price());
                            int customerBalance = custList.get(indexOfCustomer).getCustomer_balance();
                            Console.WriteLine("You have Balance: " + customerBalance);
                            if (isCompanyFound)
                            {
                                Console.WriteLine();
                                Console.WriteLine("Please enter how much shares to buy: ");
                                numOfCompanyShareToBuy = OOPsUtility.integerScanner();

                                // checking whether amount to buy whether user has that much amount or not
                                if (numOfCompanyShareToBuy < compList.get(indexOfCompany).getCompany_shares())
                                {
                                    // checking user has that much amount or not
                                    if (customerBalance > (numOfCompanyShareToBuy
                                            * compList.get(indexOfCompany).getCompany_share_price()))
                                    {
                                        int newCustomerBalance = customerBalance - numOfCompanyShareToBuy
                                                * compList.get(indexOfCompany).getCompany_share_price();

                                        // deducting customer balance
                                        custList.get(indexOfCustomer).setCustomer_balance(newCustomerBalance);
                                        // adding customer shares
                                        custList.get(indexOfCustomer).setCustomer_shares(
                                                custList.get(indexOfCustomer).getCustomer_shares() + numOfCompanyShareToBuy);
                                        // deducting the company share
                                        compList.get(indexOfCompany).setCompany_shares(
                                                compList.get(indexOfCompany).getCompany_shares() - numOfCompanyShareToBuy);
                                        // calculating new total value of company
                                        compList.get(indexOfCompany)
                                                .setCompany_total_value(compList.get(indexOfCompany).getCompany_share_price()
                                                        * compList.get(indexOfCompany).getCompany_shares());

                                        // code reflecting transaction
                                    //    Transactions trans = new Transactions();
                                      //  LocalDateTime now = LocalDateTime.now();

                                        //String transId = dateTimeFormatter2.format(now)
                                          //      + custList.get(indexOfCustomer).getCustomer_symbol()
                                            //    + compList.get(indexOfCompany).getCompany_symbol();
                                        ///trans.setTransaction_id(transId);
                                        //trans.setBuyer(custList.get(indexOfCustomer).getCustomer_name());
                                        //trans.setSeller(compList.get(indexOfCompany).getCompany_name());
                                        //trans.setTransaction_amount(
                                          //      numOfCompanyShareToBuy * compList.get(indexOfCompany).getCompany_share_price());
                                        //trans.setDatetime(dateTimeFormatter.format(now));

                                        transList.add(trans);

                                        int saveOrNot;
                                        Console.WriteLine("Press\n" + "1. for save \n2. for not save");
                                        saveOrNot = OOPsUtility.integerScanner();
                                        if (saveOrNot == 1)
                                        {
                                            JsonUtil.writeMapper(pathOfCompanyShares2, compModel.getCompanyshares());
                                            JsonUtil.writeMapper(pathOfCustomerInfo2, custModel.getCustomerinfo());
                                            transModel.setTransactions(transList);
                                            transModel.setTransaction("Transactions");
                                            JsonUtil.writeMapper(pathOfTransaction, transModel);
                                            System.out.println("Transaction has saved");
                                        }
                                        else if (saveOrNot == 2)
                                        {
                                            Console.WriteLine("Transaction not saved");
                                        }
                                        else
                                            Console.WriteLine("Transaction get void");

                                    }
                                    else
                                        Console.WriteLine("You dont have enough balance");
                                }
                                else
                                {
                                    Console.WriteLine("Company don't have that much shares");
                                }

                            }
                            else
                            {
                                Console.WriteLine("Company not identified please try again...");
                            }
                            Console.WriteLine("****************buy***************");
                            break;
                        case 2:
                            Console.WriteLine("****************sell***************");

                            Console.WriteLine("Enter number of share you want to sell");

                            int share = OOPsUtility.integerScanner();

                            Console.WriteLine("Please enter company symbol to who you want to sell: ");
                            companySymbol = OOPsUtility.integerScanner();

                            Console.WriteLine("Validating...");
                            boolean isCompanyFound2 = false;
                            for (int i = 0; i < compList.size(); i++)
                            {
                                if (companySymbol == compList.get(i).getCompany_symbol())
                                {
                                    isCompanyFound2 = true;
                                    indexOfCompany = i;
                                    break;
                                }
                            }

                            // if company is valid
                            if (isCompanyFound2)
                            {
                                Console.WriteLine(
                                        "The company you selected is: " + compList.get(indexOfCompany).getCompany_name());
                                Console.WriteLine("Company shares: " + compList.get(indexOfCompany).getCompany_shares());
                                Console.WriteLine(
                                        "Company share price: " + compList.get(indexOfCompany).getCompany_share_price());
                                int amountToGet = share * compList.get(indexOfCompany).getCompany_share_price();
                                Console.WriteLine("Amount you will get: " + amountToGet);
                                // company share increase
                                if (share <= custList.get(indexOfCustomer).getCustomer_shares())
                                {
                                    compList.get(indexOfCompany)
                                            .setCompany_shares(compList.get(indexOfCompany).getCompany_shares() + share);
                                    // company value increase
                                    compList.get(indexOfCompany)
                                            .setCompany_total_value(compList.get(indexOfCompany).getCompany_share_price()
                                                    * compList.get(indexOfCompany).getCompany_shares());

                                    // customer share decrease
                                    custList.get(indexOfCustomer)
                                            .setCustomer_shares(custList.get(indexOfCustomer).getCustomer_shares() + share);

                                    // customer balance increase

                                    custList.get(indexOfCustomer).setCustomer_balance(
                                            custList.get(indexOfCustomer).getCustomer_balance() + amountToGet);

                                    // code reflecting transaction
                                    Transactions trans = new Transactions();
                                    LocalDateTime now = LocalDateTime.now();

                                    String transId = dateTimeFormatter2.format(now)
                                            + custList.get(indexOfCustomer).getCustomer_symbol()
                                            + compList.get(indexOfCompany).getCompany_symbol();
                                    trans.setTransaction_id(transId);
                                    trans.setBuyer(compList.get(indexOfCompany).getCompany_name());
                                    trans.setSeller(custList.get(indexOfCustomer).getCustomer_name());
                                    trans.setTransaction_amount(share * compList.get(indexOfCompany).getCompany_share_price());
                                    trans.setDatetime(dateTimeFormatter.format(now));

                                    transList.add(trans);

                                    int saveOrNot;
                                    System.out.println("Press\n" + "1. for save \n2. for not save");
                                    saveOrNot = OOPsUtility.integerScanner();
                                    if (saveOrNot == 1)
                                    {
                                        JsonUtil.writeMapper(pathOfCompanyShares2, compModel.getCompanyshares());
                                        JsonUtil.writeMapper(pathOfCustomerInfo2, custModel.getCustomerinfo());
                                        transModel.setTransactions(transList);
                                        transModel.setTransaction("Transactions");
                                        JsonUtil.writeMapper(pathOfTransaction, transModel);
                                        Console.WriteLine("Transaction has saved");
                                    }
                                    else if (saveOrNot == 2)
                                    {
                                        Console.WriteLine("Transaction not saved");
                                    }
                                    else
                                        Console.WriteLine("Transaction get void");

                                }
                                else
                                {
                                    Console.WriteLine("You dont have that much shares to sell");
                                }

                            }
                            else
                                Console.WriteLine("Company not found please try again");

                            Console.WriteLine("****************sell***************");
                            break;
                        //				case 3:
                        //					// save
                        //					System.out.println("****************save***************");
                        //
                        //					System.out.println("****************save***************");
                        //					break;
                        case 3:
                            // print report
                            Console.WriteLine("****************report***************");
                            Console.WriteLine();
                            Console.WriteLine();
                            boolean hasValue = false;
                            for (int i = 0; i < transList.size(); i++)
                            {
                                if (Character.getNumericValue(transList.get(i).getTransaction_id().charAt(6)) == customerId)
                                {
                                    hasValue = true;
                                    break;
                                }
                            }
                            if (hasValue)
                            {
                                for (int i = 0; i < transList.size(); i++)
                                {
                                    if (i == 0)
                                    {
                                        Console.WriteLine("Transaction_ID\t");
                                        Console.WriteLine("Buyer\t\t");
                                        Console.WriteLine("Seller\t\t\t");
                                        Console.WriteLine("Trans_Amt\t");
                                        Console.WriteLine("DateTime\t");
                                    }
                                    if (Character
                                            .getNumericValue(transList.get(i).getTransaction_id().charAt(6)) == customerId)
                                    {
                                        Console.WriteLine(transList.get(i).getTransaction_id() + "\t");
                                        Console.WriteLine(transList.get(i).getBuyer() + "\t\t");
                                        Console.WriteLine(transList.get(i).getSeller() + "\t\t");
                                        Console.WriteLine(transList.get(i).getTransaction_amount() + "\t");
                                        Console.WriteLine(transList.get(i).getDatetime() + "\t");

                                    }

                                }
                            }
                            else
                                Console.WriteLine("You dont have any transactions!!!");

                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine("****************report***************");
                            break;
                        case 4:
                            isExit = true;
                            Console.WriteLine("Thank you for using service");
                            break;
                        default:
                            Console.WriteLine("Please select valid option");
                    }// end of switch loop

                } // end of while loop

            }
            else
            {
                Console.WriteLine("Invalid customer id");
            }*/


        }
    }
}
