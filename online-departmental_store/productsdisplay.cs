using System;
using System.Collections;

namespace online_departmental_store
{
     class productsdisplay
    {
        ArrayList van = new ArrayList();
        public ArrayList displayingpd(ourstock stk)
            
        {

          van =  stk.getstock();

          foreach(item it in van)
            {

                
                Console.WriteLine(it.Id + "\t" + it.Itemname+ "\t" + "\t" + it.Price);





            }



            return van;


        }
    }
}