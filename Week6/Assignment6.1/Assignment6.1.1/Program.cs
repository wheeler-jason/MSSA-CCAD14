namespace Assignment6._1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HouseList houseList = new HouseList();
            houseList.AddHouse(1, "Single Family", "123 Main St");
            houseList.AddHouse(2, "Apartment", "456 Elm St");
            houseList.AddHouse(3, "Condo", "789 Oak St");

            houseList.SearchHouse(1);
            houseList.SearchHouse(2);
            houseList.SearchHouse(3);
            houseList.SearchHouse(4);
            
        }
    }
}
