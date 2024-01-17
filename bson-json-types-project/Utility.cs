using bson_json_types_project.Models;

namespace bson_json_types_project
{
    public class Utility
    {
        public List<Person> FillEmployees()
        {
            List<Person> employees = new List<Person>();

            employees.Add(new Person
            {
                PersonId = 1,
                Title = "Tom Kren",
                Salary = 1900,
                Jobs = (new List<Job>
                 {
                     new Job
                     {
                         JobId = 1,
                         Description =  "Google's Master Scientist",
                         AddingTime = DateTime.Now
                     },
                     new Job
                     {
                           JobId= 2,
                           Description  = "Amazon System Manager",
                           AddingTime = DateTime.Now
                     }
                 }).ToArray()
            });

            employees.Add(new Person
            {
                PersonId = 2,
                Title = "Jon Carter",
                Salary = 1780,
                Jobs = (new List<Job>()
                {
                    new Job
                    {
                        JobId=1,
                        Description="Microsoft Principle Developer",
                        AddingTime= DateTime.Now
                    }
                 }).ToArray()
            });

            return employees;
        }

        public void WriteLine(List<Person> personList)
        {
            foreach (Person person in personList) {

                Console.WriteLine(person.ToString());

                foreach (var job in person.Jobs)
                {
                    Console.WriteLine(job.ToString()); 
                }
            }
        }
    }
}
