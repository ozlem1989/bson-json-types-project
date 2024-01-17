namespace bson_json_types_project.Models
{
    public class Job
    {
        public int JobId { get; set; }
        public string Description { get; set; }
        public DateTime AddingTime { get; set; }


        // \t : escape sequence that represents a horizontal tab character.
        public override string ToString()
        {
            return string.Format("\t{0}-{1}-{2}", JobId, Description, AddingTime); 
        }
    }
}
