using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bson_json_types_project.Models
{
    public class Person
    {
        public int PersonId { get; set; }
        public string Title { get; set; }
        public decimal Salary { get; set; }
        public Job[] Jobs { get; set; }

        public override string ToString()
        {
            return string.Format("{0}-{1}-{2}", PersonId, Title, Salary.ToString("C2"));
        }
    }
}
