using System;
using System.ServiceModel;

namespace Test
{
    public interface ISomeInterface
    {
        public void DoSomething();
    }

    public sealed class TestClass : IDisposable
    {
        private readonly ChannelFactory<ISomeInterface> _channelFactory;

        public TestClass(ChannelFactory<ISomeInterface> factory)
        {
            _channelFactory = factory;
        }

        public void Dispose()
        {
            _channelFactory.Dispose();
        }
    }
}