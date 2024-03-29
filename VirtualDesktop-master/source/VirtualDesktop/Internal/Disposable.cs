using System;

namespace WindowsDesktop.Internal
{
	public class Disposable
	{
		public static IDisposable Create(Action dispose)
		{
			return new AnonymousDisposable(dispose);
		}

		private class AnonymousDisposable(Action dispose) : IDisposable
		{
			private bool _isDisposed;

			public void Dispose()
			{
				if (this._isDisposed) return;

				this._isDisposed = true;
				dispose();
			}
		}
	}
}
