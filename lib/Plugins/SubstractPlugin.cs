namespace ds.test.impl
{
    /// <summary>
    /// Класс плагина, рализующий операцию вычитания двух чисел
    /// Часть реализации интерфейса IPlugin наследуется от обстрактного класса AbstractPlugin
    /// </summary>
    class SubstractPlugin : AbstractPlugin, IPlugin
    {
        /// <summary>
        /// Реализация метода Run интерфейса IPlugin
        /// Выполняет операцию вычитания двух чисел
        /// </summary>
        /// <param name="input1">Уменьшаемое</param>
        /// <param name="input2">Вычитаемое</param>
        /// <returns>Разность</returns>
        public override int Run(int input1, int input2)
        {
            return input1 - input2;
        }
    }
}
