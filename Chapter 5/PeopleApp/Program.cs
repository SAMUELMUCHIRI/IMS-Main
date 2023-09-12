
using static System.Console;
using Packt.Shared;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.IO;


namespace Welcpme
{
    public class Goat
    {
    static void Main(String[] args)
    {
    DateTime staRT= DateTime.Now;
    Trace.Listeners.Add(new TextWriterTraceListener(
    File.CreateText("log.txt")));
    Trace.AutoFlush = true;
    var bob = new Person();
    Trace.WriteLine($"Started Execution at {staRT}");
     Trace.WriteLine("Created the new variable Bob by calling the Person class ");
    
    // WriteLine(bob.ToString());
     
    //var bob = new Person();
    bob.Name = "Bob Smith";
    bob.DateOfBirth = new DateTime(1965, 12, 22);
    Trace.WriteLine("Created the new variable Bob");
    /* Console.WriteLine(
    format: "{0} was born on {1:dddd, d MMMM yyyy}",
    arg0: bob.Name,
    arg1: bob.DateOfBirth); */

    var alice = new Person
    {
        Name = "Alice Jones",
        DateOfBirth = new DateTime(1998, 3, 7)
    };
    Trace.WriteLine("Created the new variable Alice ");
    WriteLine(
        format: "{0} was born on {1:dd MMM yy}",
        arg0: alice.Name,
        arg1: alice.DateOfBirth); 
        Trace.WriteLine("Printed Alice characteristics");


        bob.FavoriteAncientWonder = 
        WondersOfTheAncientWorld.StatueOfZeusAtOlympia;
        Trace.WriteLine("Included Bob likings");
        WriteLine(format: 
        "{0}'s favorite wonder is {1}. It's integer is {2}.",
        arg0: bob.Name,
        arg1: bob.FavoriteAncientWonder,
        arg2: (int)bob.FavoriteAncientWonder); 
        Trace.WriteLine("printed Bob's Likings");

        bob.BucketList = 
        WondersOfTheAncientWorld.HangingGardensOfBabylon
        | WondersOfTheAncientWorld.MausoleumAtHalicarnassus;
        bob.BucketList = (WondersOfTheAncientWorld)18; 
        Trace.WriteLine("Created the Bob's bucket list");

        WriteLine($"{bob.Name}'s bucket list is {bob.BucketList}");
        Trace.WriteLine("Printed Bob's bucket list ");

        bob.Children.Add(new Person {Name = "Alfred"});
        bob.Children.Add(new Person {Name = "Zoe"});
        Trace.WriteLine("added children to the person Bob");

        WriteLine(
            $"{bob.Name} has {bob.Children.Count} Children");
        for (int child = 0 ; child < bob.Children.Count ; child++)
        {
            WriteLine($" {bob.Children[child].Name}");  
        Trace.WriteLine("Printed His Children");
        BankAccount.InterestRate =0.01M; // stores a shared value
        var jonesAccount = new BankAccount() ;
        jonesAccount.AccountName =" Mrs. Jones";
        jonesAccount.Balance = 2400;
        Trace.WriteLine("Assigned Bank accounts and populated interest");
        WriteLine( format : "{0} earned {1:C} interest . ", 
        arg0 : jonesAccount.AccountName,
        arg1 : jonesAccount.Balance * BankAccount.InterestRate); 

        var gerrierAccount = new BankAccount() ;
        gerrierAccount.AccountName =" Ms. Gerrier";
        gerrierAccount.Balance = 98;
        /* WriteLine( format : "{0} earned {1:C} interest . ", 
        arg0 : gerrierAccount.AccountName,
        arg1 : gerrierAccount.Balance * BankAccount.InterestRate); */

        // for the constant fields
        WriteLine($"{bob.Name} is a {Person.Species}");
        // for read only Fields
        WriteLine($"{bob.Name} was born on  {bob.HomePlanet} ");
        
        var blankPerson = new Person();
        Trace.WriteLine("Created the new variable blank person");

        WriteLine(format : "{0} of {1} was Created at {2:hh:mm:ss}   on a {2:dddd} ",
        arg0 : blankPerson.Name,
        arg1 : blankPerson.HomePlanet,
        arg2 : blankPerson.Instantiated); 
        Trace.WriteLine("Printed the new variable person");
        
     
        var gunny = new Person("Casey", "Venus" );
        Trace.WriteLine("Created the new variable person");
        WriteLine(format :
        "{0} of {1} was created at {2:hh.mm.ss} on a {2:dddd}",
        arg0 : gunny.Name,
        arg1 : gunny.HomePlanet,
        arg2 : gunny.Instantiated); 
        Trace.WriteLine("printed the new variable person"); 
        DateTime eND= DateTime.Now;
        Trace.WriteLine($"eNDED execution at {eND}");

        
        }
    }
    }
        

    
}

