using System;
using System.Collections.Generic;
using System.Text;
//the namespace must be PAT.Lib, the class and method names can be arbitrary
namespace PAT.Lib
{
    /// <summary>
    /// The math library that can be used in your model.
    /// all methods should be declared as public static.
    /// 
    /// The parameters must be of type "int", or "int array"
    /// The number of parameters can be 0 or many
    /// 
    /// The return type can be bool, int or int[] only.
    /// 
    /// The method name will be used directly in your model.
    /// e.g. call(max, 10, 2), call(dominate, 3, 2), call(amax, [1,3,5]),
    /// 
    /// Note: method names are case sensetive
    /// </summary>
    public class WinCheck
    {
	       public static bool didFirstWinSecond(int p1, int p2, int[] money, int[] properties, int propertyFields, int owner, int cost)
        {
		        int p1PropertyValue = 0;
		        int p2PropertyValue = 0;
		        for (int i = 0; i < properties.Length; i += propertyFields) {
		        	if (properties[i + owner] == p1) {
		        		p1PropertyValue = p1PropertyValue + properties[i + cost];
		        	}
		        	if (properties[i + owner] == p2) {
		        		p2PropertyValue = p2PropertyValue + properties[i + cost];
		        	}
		        }
		        return (money[p1] + p1PropertyValue) > (money[p2] + p2PropertyValue);
        }
    }
}
