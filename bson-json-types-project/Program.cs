using bson_json_types_project.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Bson;

namespace bson_json_types_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var utility = new Utility();
            var employees = utility.FillEmployees();

            var root = Environment.CurrentDirectory;
            var filePath = Path.Combine(root, "employees.bson");
            var serializer = new JsonSerializer(); 

            using (MemoryStream memoryStream = new MemoryStream())
            {
                using (BsonDataWriter bsonDataWriter = new BsonDataWriter(memoryStream))
                {
                    serializer.Serialize(bsonDataWriter,employees);
                }

                File.WriteAllText(filePath, Convert.ToBase64String(memoryStream.ToArray()));
            }

            var fileContent =  File.ReadAllText(filePath);
            var binaryContent = Convert.FromBase64String(fileContent);

            using (MemoryStream memoryStream = new MemoryStream(binaryContent))
            {
                using (BsonDataReader bsonDataReader = new BsonDataReader(memoryStream))
                {
                    bsonDataReader.ReadRootValueAsArray = true; 
                    var result = serializer.Deserialize<List<Person>>(bsonDataReader);
                    utility.WriteLine(result); 
                }
            }


        }
    }
}
