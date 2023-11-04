namespace FacadePattern;

public class AudioManager
{
    private readonly Amplifier _amplifier = new Amplifier();
    private readonly CDPlayer _cdPlayer = new CDPlayer();
    private readonly Speakers _speakers = new Speakers();

    public void PlayFilm()
    {
        Console.WriteLine(_cdPlayer.OpenCDCase());
        Console.WriteLine(_cdPlayer.CloseCDCase());
        Console.WriteLine(_speakers.VolumeUp());
        Console.WriteLine(_amplifier.AplifierUp());
    }
    
    
    
    
}