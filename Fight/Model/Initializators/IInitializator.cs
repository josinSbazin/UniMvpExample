using System;
using Mvp;

namespace Fight.Scripts.Model.Initializators
{
    /// <summary>
    /// Может инициализировать из любого репозитория и других источников.
    /// Необходимые сущности передаются в конструкторе.
    /// Наследуемся от диспособле, чтобы не забыть
    /// </summary>
    public interface IInitializator : IDisposable
    {
        /// <summary>
        /// Инициализирует и возвращает модель
        /// </summary>
        /// <returns>Инициалзированная модель</returns>
        IModel InitAndGet();
    }
}