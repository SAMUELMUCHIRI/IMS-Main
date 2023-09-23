/*
psudo codde to follow
if ipAddress consists of 4 numbers
and
if each ipAddress number has no leading zeroes
and
if each ipAddress number is in range 0 - 255

then ipAddress is valid

else ipAddress is invalid
*/
string ipv4Input = "107.31.1.5";
bool validLength = false;
bool validZeroes = false;
bool validRange = false;

void ValidateLength() 
{
    string[] address = ipv4Input.Split(".");
    validLength = address.Length == 4;
}
void ValidateZeroes() {}
void ValidateRange() {}

if (ValidateLength() && ValidateZeroes() && ValidateRange()) 
{
    Console.WriteLine($"ip is a valid IPv4 address");
} 
else 
{
    Console.WriteLine($"ip is an invalid IPv4 address");
}
