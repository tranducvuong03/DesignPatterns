using DesignPatterns.FacadePattern.Subsystems;

namespace DesignPatterns.FacadePattern
{
    public class HomeTheaterFacade
    {
        private readonly TV _tv = new();
        private readonly SoundSystem _sound = new();
        private readonly Lights _lights = new();
        private readonly StreamingPlayer _player = new();

        public void WatchMovie(string movie)
        {
            Console.WriteLine("Chuẩn bị xem phim...");
            _lights.Dim();
            _tv.TurnOn();
            _sound.SetVolume(15);
            _player.Play(movie);
        }

        public void EndMovie()
        {
            Console.WriteLine("Kết thúc phim...");
            _player.Stop();
            _tv.TurnOff();
            _sound.TurnOff();
            _lights.TurnOn();
        }
    }
}
