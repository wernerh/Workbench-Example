using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Workbench_Example.Model
{
    /// <summary>
    /// MVVM Service Locator
    /// </summary>
    public class ServiceLocator
    {

        #region Fields

        private readonly Dictionary<Type, object> _Services;
        private readonly object _ServicesLock;

        /// <summary>
        /// Service locator instance
        /// </summary>
        public static readonly ServiceLocator Instance = new ServiceLocator();

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        private ServiceLocator()
        {
            _Services = new Dictionary<Type, object>();
            _ServicesLock = new object();
        }

        #endregion

        #region Public Methods

        /// <summary> Adds service to dictionary
        /// </summary>
        /// <typeparam name="T">Type of service</typeparam>
        /// <param name="service">Service</param>
        public void AddService<T>(T service) where T : class
        {
            lock (_ServicesLock)
            {
                _Services[typeof(T)] = service;
            }
        }

        /// <summary> Gets service instance
        /// </summary>
        /// <typeparam name="T">Type of service</typeparam>
        /// <returns>Service</returns>
        public T GetService<T>() where T : class
        {
            object service;
            lock (_ServicesLock)
            {
                _Services.TryGetValue(typeof(T), out service);
            }
            return service as T;
        }

        #endregion

    }
}
