namespace MapApplication2.Models
{
    public enum GeometryType
    {
        Point = 0,
        Polygon = 1
    }

    public class GeoEntity
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty; // Initialize with default value
        public GeometryType Type { get; set; }
        public string Wkt { get; set; } = string.Empty; // Initialize with default value
    }
}
