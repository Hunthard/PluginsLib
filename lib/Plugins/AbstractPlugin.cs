using System.Drawing;

namespace ds.test.impl
{
    /// <summary>
    /// Абстрактный класс, реализующий часть интерфейса IPlugin
    /// </summary>
    internal abstract class AbstractPlugin : IPlugin
    {
        /// <summary>
        /// Название плагина
        /// </summary>
        public string PluginName { get; }

        /// <summary>
        /// Версия плагина
        /// </summary>
        public string Version { get; }

        /// <summary>
        /// Изображение плагина
        /// </summary>
        public Image Image { get; }

        /// <summary>
        /// Описание плагина
        /// </summary>
        public string Description { get; }

        /// <summary>
        /// Метод для реализации различных математических операций
        /// Для каждого наследуемого класса необходимо переопределить данный метод
        /// </summary>
        /// <param name="input1">Аргумент 1</param>
        /// <param name="input2">Аргумент 2</param>
        /// <returns>Результат вычисления</returns>
        public abstract int Run(int input1, int input2);
    }
}
