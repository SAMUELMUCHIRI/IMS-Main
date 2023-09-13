string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
string[] items=orderStream.Split(",");
Array.Sort(items);

foreach (var item in items)
{
   
    if ((item.Length)==4)
    {
        Console.WriteLine(item);
        
    }
    else
    {
        Console.WriteLine(item +"\t- Error");
    }
    
}
