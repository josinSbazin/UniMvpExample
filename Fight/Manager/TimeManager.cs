using System;
using UniRx;
using UnityEngine;

namespace Fight.Scripts.Manager
{
    public class TimeManager : ManagerBase<TimeManager>
    {
        public float Time;
        
        #region In Inspector Fields

        public bool IsPaused;

        #endregion

        public override void Init()
        {
            IsPaused = true;
            Time = 0f;
            Observable
                .EveryUpdate()
                .Subscribe(_ =>
                {
                    if (!IsPaused)
                    {
                        Time += UnityEngine.Time.deltaTime;
                    }   
                })
                .AddTo(this);
        }
    }
}