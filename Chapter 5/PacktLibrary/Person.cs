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
    

    }
  


}