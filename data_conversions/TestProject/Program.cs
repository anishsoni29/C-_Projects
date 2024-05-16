string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";


//firstly store the orderStream in a new array name that items, split it via the comma and sort it then.
string[] items = orderStream.Split(',');

Array.Sort(items);

foreach (var item in items)
{
    if (item.Length == 4)
    {
        Console.WriteLine(item);
    }
    else
    {
        Console.WriteLine(item + "\t-Error");
    }
}