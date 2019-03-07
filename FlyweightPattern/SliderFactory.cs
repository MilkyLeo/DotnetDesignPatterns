using System.Collections.Generic;

namespace FlyweightPattern
{
    class SliderFactory
    {
        private readonly Dictionary<char, Slider> _sliders = new Dictionary<char, Slider>();

        /// <summary>
        /// The Flyweight factory
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public Slider GetSlider(char key)
        {
            Slider slider = null;
            if (_sliders.ContainsKey(key))
            {
                slider = _sliders[key];
            }
            else
            {
                switch (key)
                {
                    case 'B': slider = new BaconMaster(); break;
                    case 'V': slider = new VeggieSlider(); break;
                    case 'Q': slider = new BbqKing(); break;
                }
                _sliders.Add(key, slider);
            }
            return slider;
        }
    }
}