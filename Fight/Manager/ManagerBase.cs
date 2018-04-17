using System;
using UnityEngine;

namespace Fight.Scripts.Manager
{
    [DisallowMultipleComponent]
    
    public abstract class ManagerBase<T> : MonoBehaviour where T : MonoBehaviour
    {
        private static T _instance;

        public static T Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = FindObjectOfType<T>();
                }
                return _instance;
            }
            private set { _instance = value; }
        }

        protected virtual void Awake()
        {
            Instance = this as T;
        }
        
        void OnApplicationQuit() {
            Instance = null;
        }

        /// <summary>
        /// Init in Awake
        /// </summary>
        public virtual void Init()
        {
            
        }
    }
}