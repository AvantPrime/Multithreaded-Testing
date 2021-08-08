using System;

namespace Events
{
	public class CustomEvent
	{
		private readonly Action _onPublish;

		public CustomEvent(Action onPublish)
		{
			_onPublish = onPublish;
		}

		public void Publish()
		{
			_onPublish?.Invoke();
		}
	}
}