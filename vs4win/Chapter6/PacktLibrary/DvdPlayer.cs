namespace Packt.Shared;
public class DvdPlayer : IPlayable
{
    public void Pause()
    {
        WriteLine("DVD player is pausing.");
    }
    public void Play()
    {
        WriteLine("DVD player is playing.");
    }
    public void Stop()
    {
        WriteLine("Overriding Stop implementation");
    }
}
