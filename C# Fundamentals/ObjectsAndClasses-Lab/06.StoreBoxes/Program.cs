string command;
List<Box> boxes = new List<Box>();

while ((command = Console.ReadLine()) != "end")
{
    string[] arguments = command.Split();
    Box item = new Box();

    item.SerialNumber = arguments[0];
    item.Item = arguments[1];
    item.ItemQuantity = decimal.Parse(arguments[2]);
    item.BoxPrice = decimal.Parse(arguments[3]);
    item.TotalPrice = item.ItemQuantity * item.BoxPrice;

    boxes.Add(item);
}

List<Box> sortedBox = boxes.OrderByDescending(boxes => boxes.TotalPrice).ToList();

foreach (Box box in sortedBox)
{
    Console.WriteLine($"{box.SerialNumber}");
    Console.WriteLine($"-- {box.Item} - ${box.BoxPrice:F2}: {box.ItemQuantity}");
    Console.WriteLine($"-- ${box.TotalPrice:F2}");
}


class Item
{
    public Item(string name, decimal price)
    {
        this.Name = name;
        this.Price = price;
    }

    public string Name { get; set; }

    public decimal Price { get; set; }
}

class Box
{
    public string SerialNumber { get; set; }

    public string Item { get; set; }

    public decimal ItemQuantity { get; set; }

    public decimal BoxPrice { get; set; }

    public decimal TotalPrice { get; set; }
}


