
namespace LiveBlazorWasm.Data
{
    public class TodoItem
    {
        public int Id { get; set; }
        
        public string Description { get; set; }
        
        public bool Done { get; set; }

        public override string ToString()
        {
            return $"{Id} - {Description} : {(Done ? "done" : "not done")}";
        }
    }
}