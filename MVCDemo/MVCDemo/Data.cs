using MVCDemo.Models;
using System.Collections.Generic;

namespace MVCDemo
{
    public class Data
    {
        public static List<PersonViewModel> GetPersons()
        {
            return new List<PersonViewModel>
            {
                new PersonViewModel
                {
                    Id=101,
                    Name="JOhn",
                    Occupation="Fireman"
                },
                new PersonViewModel
                {
                    Id=102,
                    Name="Mary",
                    Occupation="Astronaut"
                },
                new PersonViewModel
                {
                    Id=103,
                    Name="Anurag",
                    Occupation="Developer"
                }
            };
        }
    }
}
