using System;
using System.Collections;

namespace online_departmental_store
{
     class shopping
    {
       
        public shopping(ArrayList vanproducts, ArrayList trolly )
        {
            string dm;
            do
            {
                Console.WriteLine("press id to buy items");
                int id = Convert.ToInt32(Console.ReadLine());


                switch (id)
                {

                    case 1:                            
                                                             
                        trolly.Add(vanproducts[0]);
                        break;
                    case 2:

                        trolly.Add(vanproducts[1]);
                        break;

                    case 3:

                        trolly.Add(vanproducts[2]);
                        break;
                    case 4:

                        trolly.Add(vanproducts[3]);
                        break;

                    case 5:

                        trolly.Add(vanproducts[4]);
                        break;
                    case 6:

                        trolly.Add(vanproducts[5]);
                        break;


                    case 7:

                        trolly.Add(vanproducts[6]);
                        break;
                    case 8:

                        trolly.Add(vanproducts[7]);
                        break;
                    case 9:

                        trolly.Add(vanproducts[8]);
                        break;
                    case 10:

                        trolly.Add(vanproducts[9]);
                        break;

                    case 11:

                        trolly.Add(vanproducts[10]);
                        break;
                    case 12:

                        trolly.Add(vanproducts[11]);
                        break;

                    case 13:

                        trolly.Add(vanproducts[12]);
                        break;
                    case 14:

                        trolly.Add(vanproducts[13]);
                        break;


                    case 15:

                        trolly.Add(vanproducts[14]);
                        break;
                    case 16:

                        trolly.Add(vanproducts[15]);
                        break;


                }

                Console.WriteLine("DO YOU WANT TO CONTINUE YOUR SHOPPING");
                dm = Console.ReadLine();
            }
            while (dm == "yes");
        }
    }
}