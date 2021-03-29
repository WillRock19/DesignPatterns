using Microsoft.Extensions.Configuration;
using System;
using System.Configuration;
using System.Timers;

namespace Observer.Services
{
    public class TimerService
    {
        private readonly Timer _timer;
        private Action _actionToExecuteAfterInterval;

        public TimerService(IConfigurationRoot configurations)
        {
            var intervalInSeconds = configurations
                .GetSection("timerSettings")
                .GetSection("intervalInSeconds").Value;

            if (string.IsNullOrEmpty(intervalInSeconds))
                throw new ConfigurationErrorsException("The timer's interval could not be loaded!");

            _timer = new Timer
            {
                Interval = int.Parse(intervalInSeconds) * 1000
            };
        }

        public TimerService ExecuteActionAfterInterval(Action action) 
        {
            _actionToExecuteAfterInterval = action;
            _timer.Elapsed += OnTimedEvent;

            return this;
        }

        public void Start() 
        {
            _timer.Start();
        }
        
        private void OnTimedEvent(object sender, ElapsedEventArgs e)
        {
            _actionToExecuteAfterInterval.Invoke();
        }
    }
}
