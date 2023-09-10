
using static System.Console;
using Packt.Shared;
using System.Runtime.Serialization;

namespace Welcpme
{
    public class Goat
    {
    static void Main(String[] args)
    {
    var bob = new Person();
    // WriteLine(bob.ToString());
     
    //var bob = new Person();
    bob.Name = "Bob Smith";
    bob.DateOfBirth = new DateTime(1965, 12, 22);
    /* Console.WriteLine(
    format: "{0} was born on {1:dddd, d MMMM yyyy}",
    arg0: bob.Name,
    arg1: bob.DateOfBirth); */

    var alice = new Person
    {
        Name = "Alice Jones",
        DateOfBirth = new DateTime(1998, 3, 7)
    };
    /*WriteLine(
        format: "{0} was born on {1:dd MMM yy}",
        arg0: alice.Name,
        arg1: alice.DateOfBirth); */


        bob.FavoriteAncientWonder = 
        WondersOfTheAncientWorld.StatueOfZeusAtOlympia;
       /*  WriteLine(format: 
        "{0}'s favorite wonder is {1}. It's integer is {2}.",
        arg0: bob.Name,
        arg1: bob.FavoriteAncientWonder,
        arg2: (int)bob.FavoriteAncientWonder); */

        bob.BucketList = 
        WondersOfTheAncientWorld.HangingGardensOfBabylon
        | WondersOfTheAncientWorld.MausoleumAtHalicarnassus;
        // bob.BucketList = (WondersOfTheAncientWorld)18; 
        // WriteLine($"{bob.Name}'s bucket list is {bob.BucketList}");
        bob.Children.Add(new Person {Name = "Alfred"});
        bob.Children.Add(new Person {Name = "Zoe"});
        /* WriteLine(
            $"{bob.Name} has {bob.Children.Count} Children");
        for (int child = 0 ; child < bob.Children.Count ; child++)
        {
            WriteLine($" {bob.Children[child].Name}");  */
        BankAccount.InterestRate =0.01M; // stores a shared value
        var jonesAccount = new BankAccount() ;
        jonesAccount.AccountName =" Mrs. Jones";
        jonesAccount.Balance = 2400;
       /*  WriteLine( format : "{0} earned {1:C} interest . ", 
        arg0 : jonesAccount.AccountName,
        arg1 : jonesAccount.Balance * BankAccount.InterestRate); */

        var gerrierAccount = new BankAccount() ;
        gerrierAccount.AccountName =" Ms. Gerrier";
        gerrierAccount.Balance = 98;
        /* WriteLine( format : "{0} earned {1:C} interest . ", 
        arg0 : gerrierAccount.AccountName,
        arg1 : gerrierAccount.Balance * BankAccount.InterestRate); */

        // for the constant fields
        //WriteLine($"{bob.Name} is a {Person.Species}");
        // for read only Fields
        //WriteLine($"{bob.Name} was born on  {bob.HomePlanet} ");
        
        /* var blankPerson = new Person();

        WriteLine(format : "{0} of {1} was Created at {2:hh:mm:ss}   on a {2:dddd} ",
        arg0 : blankPerson.Name,
        arg1 : blankPerson.HomePlanet,
        arg2 : blankPerson.Instantiated); */
        Console.WriteLine("Yours Name :");
        string Oname= ReadLine();
        Console.WriteLine("Your Planet :");
        string Oplanet = ReadLine();
        var gunny = new Person(Oname, Oplanet );
        /* WriteLine(format :
        "{0} of {1} was created at {2:hh.mm.ss} on a {2:dddd}",
        arg0 : gunny.Name,
        arg1 : gunny.HomePlanet,
        arg2 : gunny.Instantiated);  */
        
        }
    }
    
        

    
}

