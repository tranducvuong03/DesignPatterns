namespace DesignPatterns.FacadePattern.Subsystems
{
    public class SoundSystem
    {
        public void SetVolume(int level) => Console.WriteLine($"Âm lượng: {level}");
        public void TurnOff() => Console.WriteLine("Âm thanh tắt");
    }
}
