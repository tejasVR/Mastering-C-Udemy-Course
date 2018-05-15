using System;

namespace ClassesExercises
{
    public class StopWatch
    {
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        private bool _watchStarted;


        public void Start()
        {
            if (!_watchStarted)
            {
                StartTime = DateTime.Now;
                _watchStarted = true;
            }
            else
                throw new InvalidOperationException("The stopwatch has alredy started!");
        }

        public void Stop()
        {
            EndTime = DateTime.Now;
            _watchStarted = false;
        }

        public TimeSpan Result()
        {
            return EndTime - StartTime;
        }
    }
}
