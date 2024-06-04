using System.Collections;

namespace online_departmental_store
{
    class ourstock
    {
        ArrayList godown = new ArrayList();
        int id = 0;
       public ourstock()
        {

            id++;

             godown.Add(new item(id,  "lays", 30));
            id++;
            godown.Add(new item(id, "candy",    20));
            id++;
            godown.Add(new item(id, "gems",     40));
            id++;
           godown.Add(new item(id,"choco",100));
            id++;
            godown.Add(new item(id, "jelly", 10));
            id++;
            godown.Add(new item(id,"pizza",350 ));
            id++;
            godown.Add(new item(id, "pasta",    150));
            id++;
            godown.Add(new item(id, "biryani",  120));
        }


      public void addstock(item it)
        {



            godown.Add(it);







        }

        public ArrayList getstock()
        {
            return godown;








        }




    }
}