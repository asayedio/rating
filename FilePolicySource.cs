using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class FilePolicySource
{
    public string GetPolicyFromSource()
    {
        return File.ReadAllText(@"C:\Users\asayed\Source\Repos\Rating\policy.json");
    }
}