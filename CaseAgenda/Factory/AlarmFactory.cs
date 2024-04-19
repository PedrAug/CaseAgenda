using CaseAgenda.Enum;

namespace CaseAgenda.Factory
{
    public class AlarmFactory
    {
        public IAlarm CreateAlarm(AlarmType type) 
        {
            switch (type) 
            { 
                case AlarmType.Morning:
                    return new MorningAlarm();
                case AlarmType.LateNight:
                    return new LateNightAlarm();
                default:
                    throw new ArgumentException("Invalid alarm type");
            }
        }
    }
}
