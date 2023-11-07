//int ___Do___ = int.Parse(Console.ReadLine());
//for (int takoa = 2; takoa <= ___Do___; takoa++)
//{
//    bool takovalie = true;
//    for (int cepitel = 2; cepitel < takoa; cepitel++)
//    {
//        if (takoa % cepitel == 0)
//        {
//            takovalie = false;
//            break;
//        }
//    }
//    Console.WriteLine("{0} -> {1}", takoa, takovalie);
//}
//**********(Changed code)**********

int number = int.Parse(Console.ReadLine());
for (int i = 2; i <= number; i++)
{
    bool trueOrFalse = true;

    for (int k = 2; k < i; k++)
    {
        if (i % k == 0)
        {
            trueOrFalse = false;
            break;
        }
    }
    Console.WriteLine($"{i} -> {trueOrFalse.ToString().ToLower()}");
}

