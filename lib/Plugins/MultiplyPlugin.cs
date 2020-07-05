namespace ds.test.impl
{
    /// <summary>
    /// Класс плагина, рализующий операцию вычитания двух чисел
    /// Часть реализации интерфейса IPlugin наследуется от обстрактного класса AbstractPlugin
    /// </summary>
    class MultiplyPlugin : AbstractPlugin, IPlugin
    {
        /// <summary>
        /// Реализация метода Run интерфейса IPlugin
        /// Выполняет операцию умножения двух чисел
        /// </summary>
        /// <param name="input1">Первый множитель</param>
        /// <param name="input2">Второй множитель</param>
        /// <returns>Результат умножения</returns>
        public override int Run(int input1, int input2)
        {
            return input1 * input2;
        }
    }
}
