using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_departmental_store
{
    class Program
    {
        static void Main(string[] args)
        {
            manager mn = new manager();
            Console.ReadLine();
        }
        
    }
    class manager
    {
        ourstock stk = new ourstock();
        ArrayList vanproducts = new ArrayList();
        ArrayList trolly = new ArrayList();
        public manager ()
        {
            string cnt;
            do
            {

                try
                {




                    Console.WriteLine("press 1 if you customer " + "\n" + "press 2 if you are a employe");
                    int choice = Convert.ToInt32(Console.ReadLine());


                    if (choice == 1)

                    {

                        Console.WriteLine("ENTER CUSTOMER NAME");
                        string custname = Console.ReadLine();

                        Console.WriteLine("HEY" + "\t" + custname + "\t" + "WELCOME TO FANDOM DEPARTMENTAL STORE");
                        Console.WriteLine("_______________________________________________________________");
                        Console.WriteLine("STOCK AVAILABLE IN FANDOM DEPARMENTAL STORE");
                        Console.WriteLine("__________________________________________");
                        Console.WriteLine("ID" + "\t" + "PRODUCT NAME" + "\t" + "PRICE");
                        productsdisplay dis = new productsdisplay();
                        vanproducts = dis.displayingpd(stk);
                        shopping shp = new shopping(vanproducts, trolly);
                        billing mybill = new billing(trolly);
                        Console.WriteLine("THANKYOU " + custname + "  FOR SHOPPING WITH US WE GUARENTED YOU WONT REGRET " + "\n" + "HAVE A NICE DAY");




                    }



                    else
                    {
                        int idd = 0;
                        credential crd = new credential();
                        Console.WriteLine("enter employe username id to sign in");
                        string employeid = Console.ReadLine();
                        Console.WriteLine("enter password of employe user id");
                        string passcode = Console.ReadLine();
                        Boolean user = crd.checkuser(new user(employeid, passcode));
                        if (user && passcode == "himsa")
                        {

                            Console.WriteLine("WELCOME TO FANDOM DEPARTMENTAL STORE");
                            Console.WriteLine("_____________________________________");
                            ArrayList mystock = stk.getstock();

                            foreach (item it in mystock)
                            {


                                idd = it.Id;



                            }
                            Console.WriteLine("PRODUCTS AVAILABLE IN OURSTOCK");
                            Console.WriteLine("______________________________");
                            Console.WriteLine("ID" + "\t" + "PRODUCT" + "\t" + "PRICE");
                            Console.WriteLine("________________________________________");
                            foreach (item it in mystock)
                            {

                                Console.WriteLine(it.Id + "\t" + it.Itemname + "\t" + it.Price);
                            }
                            int i;

                            Console.WriteLine("How many items you want to add");
                            int qty = Convert.ToInt32(Console.ReadLine());
                            for (i = 0; i < qty; i++)
                            {
                                idd++;
                                Console.WriteLine("Enter item name to add");
                                string itn = Console.ReadLine();
                                Console.WriteLine("Enter item price to add");
                                int ipr = Convert.ToInt32(Console.ReadLine());
                                stk.addstock(new item(idd, itn, ipr));
                            }

                            Console.WriteLine("ID" + "\t" + "PRODUCT" + "\t" + "PRICE");
                            Console.WriteLine("________________________________________");
                            foreach (item it in mystock)
                            {
                                Console.WriteLine(it.Id + "\t" + it.Itemname + "\t" + it.Price);
                            }

                            Console.WriteLine("items added successfully as per your choice");

                        }

                        else
                        {




                            Console.WriteLine("invalid input" + "\n" + "please try again");


                        }







                    }






























                }
                catch(System.FormatException)
                {

                    Console.WriteLine("invalid input" + "\n" + "please try again");




                }























                Console.WriteLine("do yo want to continue");
                cnt = Console.ReadLine();

            }


            while (cnt == "yes");

        }




    }

    class credential
    {
        public Boolean checkuser (user usr)
        {
            if (   
                  usr.Username.Equals("sahil")
                   
                  
                )
                return true;
            else
            
                return false;
           
        }
    }
}
