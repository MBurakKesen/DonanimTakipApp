using Entity.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Console.Core
{
    public static class Check
    {
        public static object CheckNull(this object value)
        {
            return value ?? " ";
        }


        public static object ConvertToNull(this object obj)
        {
            Type objType = obj.GetType();
            PropertyInfo[] properties = objType.GetProperties();

            var mainClassProperties = properties.Where(p => p.PropertyType.Assembly == objType.Assembly);

            foreach (var mainClassProperty in mainClassProperties)
            {
                object propValue = mainClassProperty.GetValue(obj, null);
                var classAllProperties = propValue.GetType().GetProperties();

                if (propValue.GetType().GetProperties().All(propertyInfo => propertyInfo.GetValue(propValue) == null))
                {
                    mainClassProperty.SetValue(obj, " ");
                }
            }
            return obj;

        }



    }
    
}
