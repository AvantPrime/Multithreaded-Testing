using System.Threading;
using Events;
using NUnit.Framework;

namespace Multithreaded.Tests
{
	public class CustomEventShould
	{
		[Test]
		public void RunTheOnPublishEventAfterPublishing()
		{
			// Arrange
			bool isPublished = false;
			AutoResetEvent syncEvent = new AutoResetEvent(false);
				CustomEvent @event = new CustomEvent(() =>
			{
				isPublished = true;
				syncEvent.Set();
			});

			// Act
			ThreadPool.QueueUserWorkItem(state => @event.Publish());
			syncEvent.WaitOne();

			// Assert
			Assert.IsTrue(isPublished);
		}
	}
}