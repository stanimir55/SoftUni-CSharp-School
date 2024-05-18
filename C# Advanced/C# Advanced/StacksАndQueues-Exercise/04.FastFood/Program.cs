int foodQuantity = int.Parse(Console.ReadLine());
int[] orderQuantities = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

Queue<int> orders = new Queue<int>(orderQuantities);

Console.WriteLine(orders.Max());

while (orders.Count > 0 && foodQuantity > 0)
{
    if (foodQuantity - orders.Peek() >= 0)
    {
        foodQuantity -= orders.Dequeue();
    }
    else
    {
        break;
    }
}

Console.WriteLine(orders.Count == 0 ? "Orders complete" : $"Orders left: {string.Join(" ", orders)}");
