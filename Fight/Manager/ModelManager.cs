using System;
using System.Collections.Generic;
using Fight.Scripts.Model.Initializators;
using Mvp;
using UnityEngine;

namespace Fight.Scripts.Manager
{
    public class ModelManager : ManagerBase<ModelManager>
    {
        #region Private Fields

        private readonly Dictionary<Type, IModel> _models = new Dictionary<Type, IModel>();   

        #endregion

        #region Init Methods

        public override void Init()
        {
            ModelInitializator modelInitializator = new ModelInitializator();
            Dictionary<Type, IInitializator> initializators = modelInitializator.InitializatorsByType;

            if (initializators == null)
            {
                throw new ArgumentException("Can't find initializators!");
            }

            foreach (KeyValuePair<Type, IInitializator> pair in initializators)
            {
                IInitializator initializator = pair.Value;
                _models.Add(pair.Key, pair.Value.InitAndGet());
                initializator.Dispose();
            }

            initializators.Clear(); // можно было сделать Диспоз, но чтобы не бежать два раза по массиву - будем диспозить здесь
        }

        #endregion


        #region Public Methods

        /// <summary>                                                                        
        /// Возвращает модель                                 
        /// </summary>                                                                       
        /// <typeparam name="T">Тип модели</typeparam>                                       
        /// <returns>Модель</returns>                                                        
        /// <exception cref="ArgumentException">Если модель не инициализирована</exception>  
        public T GetModel<T>() where T : IModel                                            
        {                                                                                    
            Type type = typeof(T);                                                           
                                                                                     
            if (_models.ContainsKey(type))                                                   
            {                                                                                
                IModel model = _models[type];                                                
                return (T) model;                                                            
            }                                                                                
                                                                                     
            throw new ArgumentException("Can't find model of type " + type.Name);            
        }                                                                                    

        #endregion
    }
}