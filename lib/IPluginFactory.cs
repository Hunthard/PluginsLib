using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ds.test.impl
{
    interface IPluginFactory
    {
        int PluginsCount { get; }
        string[] GetPluginsNames { get; }
        IPlugin GetPlugin(string pluginName);
    }
}
