namespace Consumer;

[Provider.Attribute1("1")]
public class Class2
{
    
}

public class Class1 : Provider.Class1
{
    public Class1() : base("1")
    {
        
    }
}

