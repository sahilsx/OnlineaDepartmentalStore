namespace online_departmental_store
{
    public class item
    {
        string itemname;
        int id;
        int price;

        public item(int id, string itemname, int price)
        {
            this.Itemname = itemname;
            this.Id = id;
            this.Price = price;
        }

        public string Itemname { get => itemname; set => itemname = value; }
        public int Id { get => id; set => id = value; }
        public int Price { get => price; set => price = value; }
    }
}