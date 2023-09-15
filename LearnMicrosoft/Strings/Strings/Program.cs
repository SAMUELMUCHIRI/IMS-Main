/* string first="Hello";
string second="World";
decimal money=10000M;
string result =string.Format("{0} {1} i have !",first ,second);
Console.WriteLine($"{result} {money:C2}");

//padding
string input ="Pad this";
Console.WriteLine(input.PadLeft(12 , '-'));
Console.WriteLine("C110".PadLeft(6, '0'));,
*/

string message = "Find what is (inside the parentheses)";

int openingPosition = message.IndexOf('(');
int closingPosition = message.IndexOf(')');

// Console.WriteLine(openingPosition);
// Console.WriteLine(closingPosition);

int length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length));