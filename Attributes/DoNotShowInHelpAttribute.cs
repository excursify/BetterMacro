using System;

namespace BetterMacro
{
    [AttributeUsage(AttributeTargets.Method)]
    public class DoNotShowInHelpAttribute : Attribute
    {
    }
}