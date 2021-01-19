using System;
 

namespace HonestRaplphsUsedCars
{
    class PersonEntry
    {
        public PersonEntry()
        {
        }

        public PersonEntry( string name, string lastname, string phoneNumber, string dobmonth, string dobday )
        {
            Name = name;
            LastName = lastname;
            PhoneNumber = phoneNumber;
            DOBMonth = dobmonth;
            DOBDay = dobday; 

        }

        //Fields
        public string Name { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string DOBMonth { get; set; }
        public string DOBDay { get; set; }
        public string boxItem { set; get; }
         
        public void DisplayValues ()
        {
            Console.WriteLine("Name {0}:", Name);
   
            Console.WriteLine("Phone Number {0}:", PhoneNumber);

        }//end of Display Values

    }
}
