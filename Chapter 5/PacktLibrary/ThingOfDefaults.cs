using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace Packt.Shared
 {
    public class ThingOfDefaults
    {
        public int Population;
        public DateTime When;
        public  string Name;
        public  List<Person> People;

        public ThingOfDefaults()
        {
            Population = default;
            When = default;
            Name = default;
            People = default;

            
        }
    }

 }