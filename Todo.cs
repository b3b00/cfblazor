
namespace LiveBlazorWasm.Data
{
    public class TodoItem
    {
        public string Id { get; set; }
        
        public string Description { get; set; }
        
        public bool Done { get; set; }

        public override string ToString()
        {
            return $"{Id ?? "null"} - {Description} : {(Done ? "done" : "not done")}";
        }
    }
}