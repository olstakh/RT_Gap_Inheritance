namespace Provider;

public class Class1
{
    public Class1(params string[] x) : this(new ProviderDependency.Class1())
    {
    }
    public Class1(ProviderDependency.Class1 attribute)
    {
    }
}
