namespace ds.test.impl
{
    /// <summary>
    /// Интерфейс IPlugin
    /// </summary>
    interface IPluginFactory
    {
        /// <summary>
        /// Количество плагинов
        /// </summary>
        int PluginsCount { get; }

        /// <summary>
        /// Список наименований плагинов
        /// </summary>
        string[] GetPluginsNames { get; }

        /// <summary>
        /// Возвращает объект плагина по имени
        /// </summary>
        /// <param name="pluginName">Название плагина</param>
        /// <returns>Объект плагина приведённый к типу IPlugin</returns>
        IPlugin GetPlugin(string pluginName);
    }
}
