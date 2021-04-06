using System;

namespace Properties
{
    class Person
    {
        public string Name { get; set; }
        public string Username { get; set; }
        
        // we want the Birthdate to only be set once and cannot be changed
        // we can now only set the Birthdate with a constructor
        public Person(DateTime birtdate)
        {
            Birthdate = birtdate;
        }
        public DateTime Birthdate {get; private set;}

        public int Age
        {
            get // this prop cant be auto implemented {get; set;}, because we want logic to base off Birthdate prop
            {
                var timeSpan = DateTime.Today - Birthdate;
                var years = timeSpan.Days/365;
                return years;
            }
            // intentionally did not use set, because Age should just be calculated and not set
            // if you dont want a settable property then dont use set
        }

    }
}
