﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoBridge
{
    internal class RemoteControl
    {
        protected IDevice device;

        public RemoteControl(IDevice device)
        {
            this.device = device;
        }

        public void TogglePower()
        {
            if (device.IsEnabled())
                device.Disable();
            else
                device.Enable();
        }

        public void VolumeDown() => device.SetVolume(device.GetVolume() - 10);

        public void VolumeUp() => device.SetVolume(device.GetVolume() + 10);

        public void ChannelDown() => device.SetChannel(device.GetChannel() - 1);

        public void ChannelUp() => device.SetChannel(device.GetChannel() + 1);
    }
}
