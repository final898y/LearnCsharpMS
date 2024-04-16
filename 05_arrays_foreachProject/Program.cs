// See https://aka.ms/new-console-template for more information
string [] booking = {"B123","C234","A345","C15","B177","G3003","C235","B179"};
foreach (string itemB in booking)
{
    if(itemB.StartsWith("B"))
    {
        Console.WriteLine($"{itemB}The name starts with 'B'!");
    }
}
