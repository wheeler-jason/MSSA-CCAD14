using System.Text.Json;
using System.Xml.Serialization;

namespace Assignment10._1
{
    [Serializable]
    public class Phone
    {
        // Backing fields
        private string _brand;
        private string _model;

        // Properties
        public string Brand
        {
            get { return _brand; }
            set { _brand = value; }
        }

        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        public decimal Price { get; set; }
        public DateTime ReleaseDate { get; set; }
        public bool Is5GEnabled { get; set; }

        // Constructors
        public Phone()
        {
        }

        public Phone(string brand, string model, decimal price, DateTime releaseDate, bool is5GEnabled)
        {
            _brand = brand;
            _model = model;
            Price = price;
            ReleaseDate = releaseDate;
            Is5GEnabled = is5GEnabled;
        }

        // Method to display phone details
        public void DisplayPhoneInfo()
        {
            Console.WriteLine($"Brand: {Brand}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Price: {Price:C}");
            Console.WriteLine($"Release Date: {ReleaseDate.ToShortDateString()}");
            Console.WriteLine($"5G Enabled: {Is5GEnabled}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create a new phone object
            Phone phone = new Phone("Samsung", "Galaxy S21", 799.99m, new DateTime(2021, 1, 29), true);

            Console.WriteLine("Before JSON Serialization: ");
            phone.DisplayPhoneInfo();
            Console.WriteLine();

            // JSON serialization
            string jsonString = JsonSerializer.Serialize(phone);
            File.WriteAllText("phone.json", jsonString);

            // JSON deserialization
            jsonString = File.ReadAllText("phone.json");
            Phone? deserializedPhone = JsonSerializer.Deserialize<Phone>(jsonString);
            
            Console.WriteLine("After JSON Deserialization: ");
            deserializedPhone?.DisplayPhoneInfo();
            Console.WriteLine();

            
            Console.WriteLine("Before XML Serialization: ");
            phone.DisplayPhoneInfo();
            Console.WriteLine();

            // XML serialization
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Phone));
            using (StreamWriter writer = new StreamWriter("phone.xml"))
            {
                xmlSerializer.Serialize(writer, phone);
            }

            // XML deserialization
            Console.WriteLine("After XML Deserialization: ");
            using (StreamReader reader = new StreamReader("phone.xml"))
            {
                Phone? deserializedPhoneXML = (Phone?)xmlSerializer.Deserialize(reader);
                deserializedPhoneXML?.DisplayPhoneInfo();
            }
            Console.WriteLine();
        }
    }
}
