

string password = string.Empty;
string name =string.Empty;

/* do
{
 Console.Clear();
 Console.WriteLine("Hello Welcome to OuR aPP");
 password = Console.ReadLine();
}
while ( password != "Pa$$word");
*/
Console.WriteLine("Correct"); 
 Console.Clear();
 string input = Console.ReadLine();


Console.WriteLine(ReverseSentence(input));

string ReverseSentence(string input) 
{
    string result = "";
    string[] words = input.Split(" ");
    foreach(string word in words) 
    {
        result += ReverseWord(word) + " ";
    }
    return result.Trim();
}

string ReverseWord(string word) 
{
    string result = "";
    for (int i = word.Length - 1; i >= 0; i--) 
    {
        result += word[i];
    }
    return result;
}