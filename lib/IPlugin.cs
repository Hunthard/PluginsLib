﻿namespace ds.test.impl
{
    /// <summary>
    /// Базовый интерфейс для плагинов
    /// </summary>
    public interface IPlugin
    {
        /// <summary>
        /// Название плагина
        /// </summary>
        string PluginName { get; }

        /// <summary>
        /// Версия плагина
        /// </summary>
        string Version { get; }

        /// <summary>
        /// Изображение плагина
        /// </summary>
        System.Drawing.Image Image { get; }

        /// <summary>
        /// Описание плагина
        /// </summary>
        string Description { get; }

        /// <summary>
        /// Метод для реализации различных математических операций
        /// Для каждого наследуемого класса переопределяется своя реализация
        /// </summary>
        /// <param name="input1">Аргумент 1</param>
        /// <param name="input2">Аргумент 2</param>
        /// <returns>Результат вычисления</returns>
        int Run(int input1, int input2);
    }
}
