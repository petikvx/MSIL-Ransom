using System.Diagnostics;

namespace System.Threading.Tasks.Dataflow.Internal;

internal sealed class Disposables
{
	[DebuggerDisplay("Disposed = true")]
	private sealed class NopDisposable : IDisposable
	{
		void IDisposable.Dispose()
		{
		}
	}

	[DebuggerDisplay("Disposed = {Disposed}")]
	private sealed class Disposable<T1, T2> : IDisposable
	{
		private readonly T1 _arg1;

		private readonly T2 _arg2;

		private Action<T1, T2> _action;

		private bool Disposed => _action == null;

		internal Disposable(Action<T1, T2> action, T1 arg1, T2 arg2)
		{
			_action = action;
			_arg1 = arg1;
			_arg2 = arg2;
		}

		void IDisposable.Dispose()
		{
			Action<T1, T2> action = _action;
			if (action != null && Interlocked.CompareExchange(ref _action, null, action) == action)
			{
				action(_arg1, _arg2);
			}
		}
	}

	[DebuggerDisplay("Disposed = {Disposed}")]
	private sealed class Disposable<T1, T2, T3> : IDisposable
	{
		private readonly T1 _arg1;

		private readonly T2 _arg2;

		private readonly T3 _arg3;

		private Action<T1, T2, T3> _action;

		private bool Disposed => _action == null;

		internal Disposable(Action<T1, T2, T3> action, T1 arg1, T2 arg2, T3 arg3)
		{
			_action = action;
			_arg1 = arg1;
			_arg2 = arg2;
			_arg3 = arg3;
		}

		void IDisposable.Dispose()
		{
			Action<T1, T2, T3> action = _action;
			if (action != null && Interlocked.CompareExchange(ref _action, null, action) == action)
			{
				action(_arg1, _arg2, _arg3);
			}
		}
	}

	internal static readonly IDisposable Nop = new NopDisposable();

	internal static IDisposable Create<T1, T2>(Action<T1, T2> action, T1 arg1, T2 arg2)
	{
		return new Disposable<T1, T2>(action, arg1, arg2);
	}

	internal static IDisposable Create<T1, T2, T3>(Action<T1, T2, T3> action, T1 arg1, T2 arg2, T3 arg3)
	{
		return new Disposable<T1, T2, T3>(action, arg1, arg2, arg3);
	}
}
