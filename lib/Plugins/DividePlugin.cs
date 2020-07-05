using System;

namespace ds.test.impl
{
    /// <summary>
    /// Класс плагина, рализующий операцию вычитания двух чисел
    /// Часть реализации интерфейса IPlugin наследуется от обстрактного класса AbstractPlugin
    /// </summary>
    class DividePlugin : AbstractPlugin, IPlugin
    {
        /// <summary>
        /// Реализация метода Run интерфейса IPlugin
        /// Выполняет операцию деления двух чисел
        /// </summary>
        /// <param name="input1">Делимое</param>
        /// <param name="input2">Делитель</param>
        /// <returns>Результат деления</returns>
        public override int Run(int input1, int input2)
        {
            // Проверка деления на 0
            if (input2 != 0)
            {
                return input1 / input2;
            }
            throw new DivideByZeroException("Divide by zero is not supported");
        }
    }
}
