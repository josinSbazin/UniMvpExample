using Mvp;
using UniRx;

namespace Fight.Scripts.Model
{
    public sealed class SinusoidModel : IModel
    {
        public readonly float StartSpeed;
        public readonly float ToSpeedSmooth;
        public float Position; // set from update

        public readonly FloatReactiveProperty CurrentSpeed; // can subscribe

        public SinusoidModel(float startSpeed, float toSpeedSmooth)
        {
            StartSpeed = startSpeed;
            ToSpeedSmooth = toSpeedSmooth;
            Position = 0f;

            CurrentSpeed = new FloatReactiveProperty(startSpeed);
        }
    }
}