using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ds.test.impl
{
    class PluginFactory : IPluginFactory
    {
        public int PluginsCount { get; }

        public string[] GetPluginsNames { get; }

        public IPlugin GetPlugin(string pluginName)
        {
            switch (pluginName)
            {
                case "AdditionPlugin":
                    return new AdditionPlugin();
                case "SubstractPlugin":
                    return new SubstractPlugin();
                case "MultiplyPlugin":
                    return new MultiplyPlugin();
                case "DividePlugin":
                    return new DividePlugin();
                default:
                    throw new ArgumentException($"Undefined plugin: {pluginName}");
            }
        }
    }
}
