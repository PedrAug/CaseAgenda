using CaseAgenda.Enum;

namespace CaseAgenda.Store
{
    public class AlarmState
    {
        public AlarmType Alarm { get; }

        public AlarmState(AlarmType alarm)
        {
            Alarm = alarm;
        }
    }
    public class AlarmStore
    {
        private AlarmState _state;

        public AlarmState GetState() {
            return _state;
        }

        public AlarmStore()
        {
            _state = new AlarmState(AlarmType.Morning);
        }

        public void MorningAlarm()
        {
            this._state = new AlarmState(AlarmType.Morning);
            BroadcastStateChange();
        }

        public void LateNightAlarm()
        {
            this._state = new AlarmState(AlarmType.LateNight);
            BroadcastStateChange();
        }


        private Action _listeners;

        public void AddStateChangeListeners(Action listener) 
        { 
            _listeners += listener;
        }

        public void RemoveStateChangeListeners(Action listener) 
        {
            _listeners -= listener;
        }

        private void BroadcastStateChange() 
        {
            _listeners.Invoke();
        }
    }
}
