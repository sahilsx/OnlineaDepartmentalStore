using System;
using System.Collections;

namespace online_departmental_store
{
    class billing
    {
        public billing(ArrayList vanproducts)
        {
            int sum = 0;
            foreach (item it in vanproducts)
            {

                sum = sum + it.Price;





            }


            Console.WriteLine("___________________________");
            Console.WriteLine("GRAND TOTAL=\t" + sum);

            Console.WriteLine("FANDOM DISCOUNT OFFERS");
            Console.WriteLine("_____________________________");
            Console.WriteLine("PRESS 1 IF ITS YOUR FIRST TIME" + "\n" + "PRESS 2 IF YOU ARE A REGULAR BUYER" + "\n" + "PRESS 3 IF YOU ARE A PRIME MEMBER");
            int chs = Convert.ToInt32(Console.ReadLine());

            switch (chs)
            {



                case 1:


                    Console.WriteLine("CONGRATULATIONS YOU HAVE GOT 10% OFF");

                    int div = sum * 10 / 100;

                    sum = sum - div;
                    Console.WriteLine("___________________________");
                    Console.WriteLine("DISCOUNTED TOTAL=\t" + sum);

                    break;


                case 2:


                    Console.WriteLine("CONGRATULATIONS YOU HAVE GOT 20% OFF");

                    int chn = sum * 20 / 100;

                    sum = sum -chn;
                    Console.WriteLine("___________________________");
                    Console.WriteLine("DISCOUNTED TOTAL=\t" + sum);

                    break;

                case 3:


                    Console.WriteLine("CONGRATULATIONS YOU HAVE GOT 30% OFF");

                    int chns = sum * 30 / 100;

                    sum = sum - chns;
                    Console.WriteLine("___________________________");
                    Console.WriteLine("DISCOUNTED TOTAL=\t" + sum);

                    break;











            }


























        }
    }

}