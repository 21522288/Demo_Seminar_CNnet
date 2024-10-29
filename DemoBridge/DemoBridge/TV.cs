using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoBridge
{
    internal class Tv : IDevice
    {
        private bool _enabled;
        private int _volume;
        private int _channel;

        public Tv(bool enabled = false, int volume = 50, int channel = 1)
        {
            _enabled = enabled;
            _volume = volume;
            _channel = channel;
        }

        public bool IsEnabled() => _enabled;

        public void Enable() => _enabled = true;

        public void Disable() => _enabled = false;

        public int GetVolume() => _volume;

        public void SetVolume(int percent) => _volume = percent;

        public int GetChannel() => _channel;

        public void SetChannel(int channel) => _channel = channel;
    }
}
