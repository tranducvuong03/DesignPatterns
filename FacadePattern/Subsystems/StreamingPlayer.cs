namespace DesignPatterns.FacadePattern.Subsystems
{
    public class StreamingPlayer
    {
        public void Play(string movie) => Console.WriteLine($"Đang phát: {movie}");
        public void Stop() => Console.WriteLine("Dừng phát");
    }
}
