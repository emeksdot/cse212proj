using System.Runtime.CompilerServices;

public class FeatureCollection
{
    // TODO Problem 5 - ADD YOUR CODE HERE
    // Create additional classes as necessary
    public List<Feature> Features = new();

}

public class Feature
{
    public Properties Properties { get; set; }
    public Geometry Geometry { get; set; }
    public string ID
    { get; set; }
}

public class Properties
{
    public string place;
    public string Place
    {
        get
        {
            return place;
        }
        set
        {
            place = value;
        }
    }
    public double? Mag { get; set; }
}

public class Geometry
{
    public string Type { get; set; }
    public List<double> Coordinates { get; set; }
}


class Metadata
{
    // Property for metadata data
    public Dictionary<string, object> Meta { get; set; } = new Dictionary<string, object>();

}
