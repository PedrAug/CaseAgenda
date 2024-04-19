using CaseAgenda.Enum;
using CaseAgenda.Store;

namespace CaseTests
{
    public class StoreTest
    {
        [Fact]
        public void AlarmStore_GetState_ReturnsMorningAlarmInitially()
        {
            // Arrange
            var alarmStore = new AlarmStore();

            // Act
            var state = alarmStore.GetState();

            // Assert
            Assert.Equal(AlarmType.Morning, state.Alarm);
        }

        [Fact]
        public void AlarmStore_StateChangeListeners_NotifiedOnStateChange()
        {
            // Arrange
            var alarmStore = new AlarmStore();
            bool listenerCalled = false;
            void Listener() => listenerCalled = true;

            // Act
            alarmStore.AddStateChangeListeners(Listener);
            alarmStore.MorningAlarm();

            // Assert
            Assert.True(listenerCalled);
        }

    }
}
