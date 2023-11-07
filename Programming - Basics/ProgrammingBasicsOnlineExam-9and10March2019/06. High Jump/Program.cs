int desiredHeight = int.Parse(Console.ReadLine());

int startHeight =  desiredHeight - 30;
int unsuccesCounter = 0;
int jumpsCounter = 0;

while (startHeight <= desiredHeight)
{
    int jumpHeight = int.Parse(Console.ReadLine());
    jumpsCounter++;

    if (jumpHeight > startHeight)
    {
        if (startHeight >= desiredHeight)
        {
            Console.WriteLine($"Tihomir succeeded, he jumped over {startHeight}cm after {jumpsCounter} jumps.");
            break;
        }

        startHeight += 5;
        unsuccesCounter = 0;
    }
    else
    {
        unsuccesCounter++;

        if (unsuccesCounter == 3)
        {
            Console.WriteLine($"Tihomir failed at {startHeight}cm after {jumpsCounter} jumps.");
            break;
        }
    }
}
