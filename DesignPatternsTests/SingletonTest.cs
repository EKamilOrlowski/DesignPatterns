using DesignPatternsApp.Creational_Patterns.Singleton;

namespace DesignPatternsTests
{
    public class SingletonTest
    {
        [Fact]
        public void BaseTest()
        {
            Singleton singletonFirst = GetSingletonInstance();
            Singleton singletonSecond = GetSingletonInstance();

            Assert.Equal(singletonFirst, singletonSecond);
        }

        [Fact]
        public void MultiThreadTest()
        {
            Singleton? singletonFirst = null;
            Singleton? singletonSecond = null;

            Thread processFirst = new Thread(() =>
            {
                singletonFirst = GetSingletonInstance();
            });
            Thread processSecond = new Thread(() =>
            {
                singletonSecond = GetSingletonInstance();
            });

            processFirst.Start();
            processSecond.Start();

            processFirst.Join();
            processSecond.Join();

            Assert.Equal(singletonFirst, singletonSecond);
        }

        private Singleton GetSingletonInstance()
        {
            return Singleton.Instance;
        }
    }
}