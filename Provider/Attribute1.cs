namespace Provider;

[AttributeUsage(AttributeTargets.Class)]
public sealed class Attribute1 : Attribute
{
    public Attribute1(params string[] x) : this(new ProviderDependency.Class1())
    {
    }
    public Attribute1(ProviderDependency.Class1 attribute)
    {
    }
}