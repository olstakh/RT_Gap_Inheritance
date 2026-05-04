namespace Provider;

[AttributeUsage(AttributeTargets.Class)]
public sealed class Attribute1 : Attribute
{
    public Attribute1(params string[] x)
    {
    }
    public Attribute1(ProviderDependency.Class1 attribute)
    {
    }
}