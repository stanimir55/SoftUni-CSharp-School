string titleOfAnArticle = Console.ReadLine();
string contentArticle = Console.ReadLine();
string command;

Console.WriteLine("<h1>");
Console.WriteLine($"   {titleOfAnArticle}");
Console.WriteLine("</h1>");
Console.WriteLine("<article>");
Console.WriteLine($"   {contentArticle}");
Console.WriteLine("</article>");

while ((command = Console.ReadLine()) != "end of comments")
{
    Console.WriteLine("<div>");
    Console.WriteLine($"   {command}");
    Console.WriteLine("</div>");
}

