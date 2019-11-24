using System;
using System.ComponentModel;
using System.Reflection;

namespace HLStudios.GhostAPI.Utilities
{
    public static class EnumExtension
    {
        public static string GetDescriptions(this Enum e)
        {
            var descriptions = string.Empty;
            var type = e.GetType();

            var name = e.ToString();
            if (name != String.Empty)
            {
                foreach (var fieldName in name.Split(','))   
                {
                    var field = type.GetField(fieldName.Replace(" ", String.Empty));
                    if (field == null) continue;
                    DescriptionAttribute attr = 
                        Attribute.GetCustomAttribute(field, 
                            typeof(DescriptionAttribute)) as DescriptionAttribute;
                    if (attr != null)
                    {
                        descriptions = descriptions != String.Empty ? 
                            String.Join(",", descriptions, attr.Description) : 
                            attr.Description;
                    }
                }

                return descriptions;
            }
            return null;
        }
    }
}