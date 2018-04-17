using System;

namespace Fight.Scripts.Config
{
    [Serializable]
    public class Sinusoid
    {
        /// <summary>
        ///  Мульипликатор увеличения движения скорости синусоиды при нажатии.
        ///  Здесь потому-что вызывается в Update
        /// </summary>
        public float SpeedMultiplicator = 2f;

        /// <summary>
        /// Стандартная скорость синусоиды
        /// </summary>
        public float CustomSpeed = 200f;

        /// <summary>
        /// Скорость торможения и разгона синусоиды при нажатии
        /// </summary>
        public float ToSpeedSmooth = 10f;
    }
}