using CaseAgenda.Factory;
using CaseAgenda.Enum;

namespace CaseTests
{
    public class FactoryTest
    {
        [Fact]
        public void AlarmFactory_CreateAlarm_ReturnsMorningInstance()
        {
            // Arrange
            var factory = new AlarmFactory();

            // Act
            var alarm = factory.CreateAlarm(AlarmType.Morning);

            // Assert
            Assert.IsType<MorningAlarm>(alarm);
        }

        [Fact]
        public void AlarmFactory_CreateAlarm_ReturnsLateNightInstance()
        {
            // Arrange
            var factory = new AlarmFactory();

            // Act
            var alarm = factory.CreateAlarm(AlarmType.LateNight);

            // Assert
            Assert.IsType<LateNightAlarm>(alarm);
        }
    }
}
