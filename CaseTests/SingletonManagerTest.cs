using CaseAgenda.Singleton;

namespace CaseTests
{
    public class SingletonManagerTest
    {
        [Fact]
        public void SingletonManager_Instance_ReturnsSameInstance()
        {
            // Arrange
            var instance1 = SingletonManager.Instance;
            var instance2 = SingletonManager.Instance;

            // Act & Assert
            Assert.Same(instance1, instance2);
        }

        [Fact]
        public void SingletonManager_Counter_IncrementsCorrectly()
        {
            // Arrange
            var instance = SingletonManager.Instance;

            // Act
            instance.IncrementCounter();
            instance.IncrementCounter();
            instance.IncrementCounter();

            // Assert
            Assert.Equal(3, instance.GetCounter());
        }
    }
}
