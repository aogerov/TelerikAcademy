//Create a [Version] attribute that can be applied to structures, classes, interfaces,
//enumerations and methods and holds a version in the format major.minor (e.g. 2.11).
//Apply the version attribute to a sample class and display its version at runtime.

using System;

[AttributeUsage(AttributeTargets.Struct | AttributeTargets.Class | 
    AttributeTargets.Interface | AttributeTargets.Enum | AttributeTargets.Method)]

public class Version : System.Attribute
{
    public int Major { get; private set; }
    public int Minor { get; private set; }

    public Version(double version)
    {
        string[] split = version.ToString().Split(new char[] {',', '.'});
        
        this.Major = int.Parse(split[0]);
        this.Minor = int.Parse(split[1]);

        //this.Major = (int)version;
        //this.Minor = int.Parse(version.ToString().Substring(version.ToString().IndexOf(',') + 1,
        //    version.ToString().Length - version.ToString().IndexOf(',') - 1));
    }
}