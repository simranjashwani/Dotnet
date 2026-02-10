namespace GarbageCollectionDemo
{
    // CLASS
    public class TempClass
    {
        public int Id { get; init; }
        public string Name { get; init; }

        public TempClass(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }

    // RECORD
    public record Temp
    {
        public int Id { get; init; }
        public string Name { get; init; } = string.Empty;
    }

    // STRUCT
    public struct TempStruct
    {
        public int Id { get; init; }
        public string Name { get; init; }
    }
}
