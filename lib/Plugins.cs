using System;

namespace ds.test.impl
{
    /// <summary>
    /// Статический класс Plugin
    /// Реализует методы и поля, определённые в интерфейсе IPluginFactory
    /// </summary>
    public static class Plugins
    {
        /// <summary>
        /// Количество плагинов
        /// </summary>
        public static int PluginsCount { get; }

        /// <summary>
        /// Список наименований плагинов
        /// </summary>
        public static string[] GetPluginNames { get; }

        /// <summary>
        /// Возвращает объект плагина по имени
        /// </summary>
        /// <param name="pluginName">Название плагина</param>
        /// <returns>Объект плагина приведённый к типу IPlugin</returns>
        public static IPlugin GetPlugin(string pluginName)
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
