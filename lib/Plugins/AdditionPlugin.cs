namespace ds.test.impl
{
    /// <summary>
    /// Класс плагина, рализующий операцию вычитания двух чисел
    /// Часть реализации интерфейса IPlugin наследуется от обстрактного класса AbstractPlugin
    /// </summary>
    class AdditionPlugin : AbstractPlugin, IPlugin
    {
        /// <summary>
        /// Реализация метода Run интерфейса IPlugin
        /// Выполняет операцию сложения двух чисел
        /// </summary>
        /// <param name="input1">Первое слагаемое</param>
        /// <param name="input2">Второе слагаемое</param>
        /// <returns>Сумма</returns>
        public override int Run(int input1, int input2)
        {
            return input1 + input2;
        }
    }
}
