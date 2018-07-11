using System;
using System.Collections.Generic;

namespace DAL.Interfaces
{
    /// <summary>
    /// Base interface for all repositorys.
    /// </summary>
    /// <typeparam name="T">Type of element.</typeparam>
    public interface IRepository<T> : IDisposable
    {
        /// <summary>
        /// Get all elements.
        /// </summary>
        /// <returns>Enumerable of elements.</returns>
        IEnumerable<T> GetAll();

        /// <summary>
        /// Get element by id.
        /// </summary>
        /// <param name="id">Id or the element.</param>
        /// <returns>Element with the id.</returns>
        T GetById(string id);

        /// <summary>
        /// Insert new element.
        /// </summary>
        /// <param name="element">New element.</param>
        void Insert(T element);

        /// <summary>
        /// Insert all elements.
        /// </summary>
        /// <param name="elements">Enumerable of elements.</param>
        void InsertAll(IEnumerable<T> elements);

        /// <summary>
        /// Delete element by id.
        /// </summary>
        /// <param name="id">Id of the element.</param>
        void Delete(string id);

        /// <summary>
        /// Update element.
        /// </summary>
        /// <param name="element">Element.</param>
        void Update(T element);

        /// <summary>
        /// Save changes.
        /// </summary>
        void Save();
    }
}
