# ChannelFactoryIssue
Showing an issue with Dispose and ChannelFactory&lt;T>

Update: the code doesn't build because ChannelFactory uses an explicit interface implementation of IDisposable, which is not obvious from the decompiled metadata in Visual Studio but can be seen if you decompile the reference assembly with ildasm or just look at the implmentation on source.dot.net.
