using System;
using System.Collections.Generic;
namespace Packt.Shared
{
    public class Person
    //the code above means the class Person inherits properties from the base class object
    {
        // all user defined class are derived from the base class Objest 
        // fields
    public string Name;
    public DateTime DateOfBirth;

    public WondersOfTheAncientWorld FavoriteAncientWonder;

    public WondersOfTheAncientWorld BucketList;
    //test 
    public List<Person> Children = new List<Person>();
    public const string Species = "Homo Sapien" ;

    public readonly string HomePlanet = "Earth";
    public readonly DateTime Instantiated;
    // Conctructors

    public Person()
    {
        //setting default value for fields
        Name="unknown";
        Instantiated= DateTime.Now;
    }

    public Person(string initialName , string homePlanet)
    {
        Name =initialName;
        HomePlanet = homePlanet;
        Instantiated = DateTime.Now ;
        

    }
    // method 1 it is a member of class Person and does not return a value
    public void WriteToConsole()
    {
    Console.WriteLine($"{Name} was born on a {DateOfBirth:dddd}.");
    }

    // Method 2 returns a value( string)
    public string GetOrigin()
    {
    return $"{Name} was born on {HomePlanet}.";
    }
     // creating a method that retrns multiple values 
      public (string ,int ) GetFruit()
      {
        return ("Apple" , 5);
      }

      // naming fields inside a tuple 
      public (string Name ,int Number  ) GetNamed()
      {
        return (Name :"Apple", Number:5);
      }


    }
  


}