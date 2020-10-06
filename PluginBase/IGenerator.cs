using System;

namespace PluginBase
{
    public interface IGenerator
    {
        object Next(Type type);
        bool IsValidType(Type type);
    }
}