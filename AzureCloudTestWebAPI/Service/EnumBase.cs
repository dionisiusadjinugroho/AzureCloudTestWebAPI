using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace AzureCloudTestWebAPI.Service
{
    public class EnumBase
    {
        public enum SideCategory
        {
            [Description("Equilateral Triangle")]
            Equilateral=0,
            [Description("Isosceles Triangle")]
            Isosceles = 1,
            [Description("Scalene Triangle")]
            Scalene = 2,
            [Description("Invalid Data (Found zero/Sum of two sides should be larger than the third)")]
            Invalid = 3,
        }
        public enum CornerCategory
        {
            [Description("Obtuse")]
            Obtuse = 0,
            [Description("Acute")]
            Acute = 1,
            [Description("Right")]
            Right = 2,
        }
    }
    public static class EnumHelper
    {
        public static string GetEnumDescription(this Enum enumValue)
        {
            var field = enumValue.GetType().GetField(enumValue.ToString());
            if (Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute)) is DescriptionAttribute attribute)
            {
                return attribute.Description;
            }
            throw new ArgumentException("Item not found.", nameof(enumValue));
        }

    }
}
