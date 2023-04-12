using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Patterns.Common.Domain.Extensions
{
    public static class TypeExtensions
    {
        public static string GetFullName(this Type t) =>
            !t.IsGenericType || t.IsGenericTypeDefinition
            ? !t.IsGenericTypeDefinition ? t.Name : t.Name.Remove(t.Name.IndexOf(' '))
            : $"{GetFullName(t.GetGenericTypeDefinition())}<{string.Join(',', t.GetGenericArguments().Select(GetFullName))}>";
    }
}
