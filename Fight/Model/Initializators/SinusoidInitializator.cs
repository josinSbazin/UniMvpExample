using Fight.Scripts.Manager;
using Mvp;
using UnityEngine;

namespace Fight.Scripts.Model.Initializators
{
    public class SinusoidInitializator : IInitializator
    {
        public IModel InitAndGet()
        {
            return new SinusoidModel(
                ConfigManager.Instance.Parameters.Sinusoid.CustomSpeed,
                ConfigManager.Instance.Parameters.Sinusoid.ToSpeedSmooth);
        }

        public void Dispose()
        {
            //NA
        }
    }
}