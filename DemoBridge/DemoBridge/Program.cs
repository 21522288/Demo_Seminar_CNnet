using DemoBridge;

public class Program
{
    public static void Main()
    {
        // Using a TV with a basic remote control
        IDevice tv = new Tv(false, 10, 4);
        RemoteControl remote = new RemoteControl(tv);

        remote.TogglePower();
        remote.VolumeUp();
        remote.ChannelUp();
        Console.WriteLine("TV Volume: " + tv.GetVolume());
        Console.WriteLine("TV Channel: " + tv.GetChannel());

        // Using a Radio with an advanced remote control
        IDevice radio = new Radio(false, 50, 5);
        AdvancedRemoteControl advancedRemote = new AdvancedRemoteControl(radio);

        advancedRemote.TogglePower();
        advancedRemote.Mute();
        Console.WriteLine("Radio Volume: " + radio.GetVolume());
    }
}
