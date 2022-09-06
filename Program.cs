using System;
using System.ServiceModel;

namespace Test
{
    interface ISomeInterface
    {
        public void DoSomething();
    }

    public sealed class TestClass : IDisposable
    {
        private readonly ChannelFactory<ISomeInterface> channelFactory;

        public void Dispose()
        {
            channelFactory.Dispose();
        }
    }
}