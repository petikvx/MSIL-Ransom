using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Management;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Wanacrytor.Core.Engine.Watcher;

public class ProcessWatcher : NativeWindow, IDisposable
{
	public sealed class ProcessStatusChangedEventArgs : EventArgs
	{
		private readonly ProcessEvents ProcessEventsB;

		private readonly Process ProcessInfoB;

		public ProcessEvents ProcessEvent
		{
			[DebuggerStepThrough]
			get
			{
				return ProcessEventsB;
			}
		}

		public Process ProcessInfo
		{
			[DebuggerStepThrough]
			get
			{
				return ProcessInfoB;
			}
		}

		[DebuggerNonUserCode]
		private ProcessStatusChangedEventArgs()
		{
		}

		[DebuggerStepThrough]
		public ProcessStatusChangedEventArgs(ProcessEvents deviceEvent, Process ProcessInfo)
		{
			ProcessEventsB = deviceEvent;
			ProcessInfoB = ProcessInfo;
		}
	}

	public enum ProcessEvents
	{
		Arrival,
		Stopped
	}

	private bool isRunningB;

	private readonly EventHandlerList events;

	private List<Process> ProcessHistory;

	private List<Process> ProcessTempHistory;

	private bool isDisposed;

	public bool IsRunning
	{
		[DebuggerStepThrough]
		get
		{
			return isRunningB;
		}
	}

	private virtual ManagementEventWatcher ProcessStartWatcher
	{
		[CompilerGenerated]
		get
		{
			return _ProcessStartWatcher;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			EventArrivedEventHandler val = new EventArrivedEventHandler(ProcessStartWatcher_EventArrived);
			ManagementEventWatcher processStartWatcher = _ProcessStartWatcher;
			if (processStartWatcher != null)
			{
				processStartWatcher.remove_EventArrived(val);
			}
			_ProcessStartWatcher = value;
			processStartWatcher = _ProcessStartWatcher;
			if (processStartWatcher != null)
			{
				processStartWatcher.add_EventArrived(val);
			}
		}
	}

	private virtual ManagementEventWatcher ProcessStopWatcher
	{
		[CompilerGenerated]
		get
		{
			return _ProcessStopWatcher;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			EventArrivedEventHandler val = new EventArrivedEventHandler(ProcessStopWatcher_Stopped);
			ManagementEventWatcher processStopWatcher = _ProcessStopWatcher;
			if (processStopWatcher != null)
			{
				processStopWatcher.remove_EventArrived(val);
			}
			_ProcessStopWatcher = value;
			processStopWatcher = _ProcessStopWatcher;
			if (processStopWatcher != null)
			{
				processStopWatcher.add_EventArrived(val);
			}
		}
	}

	public event EventHandler<ProcessStatusChangedEventArgs> ProcessStatusChanged
	{
		[DebuggerNonUserCode]
		[DebuggerStepThrough]
		add
		{
			events.AddHandler("ProcessStatusChangedEvent", value);
		}
		[DebuggerNonUserCode]
		[DebuggerStepThrough]
		remove
		{
			events.RemoveHandler("ProcessStatusChangedEvent", value);
		}
	}

	[DebuggerStepThrough]
	public ProcessWatcher()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		ProcessStartWatcher = new ManagementEventWatcher((EventQuery)new WqlEventQuery("SELECT * FROM Win32_ProcessStartTrace"));
		ProcessStopWatcher = new ManagementEventWatcher((EventQuery)new WqlEventQuery("SELECT * FROM Win32_ProcessStopTrace"));
		ProcessHistory = new List<Process>();
		ProcessTempHistory = new List<Process>();
		events = new EventHandlerList();
	}

	[SpecialName]
	[DebuggerStepThrough]
	[DebuggerNonUserCode]
	private void raise_ProcessStatusChanged(object sender, ProcessStatusChangedEventArgs e)
	{
		((EventHandler<ProcessStatusChangedEventArgs>)events["ProcessStatusChangedEvent"])?.Invoke(RuntimeHelpers.GetObjectValue(sender), e);
	}

	public void ProcessStartWatcher_EventArrived(object sender, EventArrivedEventArgs e)
	{
		Process processById = Process.GetProcessById(Conversions.ToInteger(e.get_NewEvent().get_Properties().get_Item("ProcessID")
			.get_Value()));
		ProcessHistory.Add(processById);
		ProcessTempHistory.Add(processById);
		OnProcessStatusChanged(new ProcessStatusChangedEventArgs(ProcessEvents.Arrival, processById));
	}

	private void ProcessStopWatcher_Stopped(object sender, EventArrivedEventArgs e)
	{
		string text = Conversions.ToString(e.get_NewEvent().get_Properties().get_Item("ProcessID")
			.get_Value());
		Process process = ProcessTempHistory.Where((Process x) => (double)x.Id == Conversions.ToDouble(text)).FirstOrDefault();
		OnProcessStatusChanged(new ProcessStatusChangedEventArgs(ProcessEvents.Stopped, process));
		ProcessTempHistory.Remove(process);
	}

	[DebuggerStepThrough]
	protected virtual void OnProcessStatusChanged(ProcessStatusChangedEventArgs e)
	{
		raise_ProcessStatusChanged(this, e);
	}

	[DebuggerStepThrough]
	public virtual void Start()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		if (!(((NativeWindow)this).get_Handle() == IntPtr.Zero))
		{
			throw new Exception("Monitor is already running.");
		}
		((NativeWindow)this).CreateHandle(new CreateParams());
		ProcessStartWatcher.Start();
		ProcessStopWatcher.Start();
		isRunningB = true;
	}

	[DebuggerStepThrough]
	public virtual void Stop()
	{
		if (!(((NativeWindow)this).get_Handle() != IntPtr.Zero))
		{
			throw new Exception("Monitor is already stopped.");
		}
		ProcessStartWatcher.Stop();
		ProcessStopWatcher.Stop();
		((NativeWindow)this).DestroyHandle();
		isRunningB = false;
	}

	[DebuggerStepThrough]
	public List<Process> GetProcessHistory()
	{
		return ProcessHistory;
	}

	[DebuggerStepThrough]
	public void Dispose()
	{
		Dispose(isDisposing: true);
		GC.SuppressFinalize(this);
	}

	[DebuggerStepThrough]
	protected virtual void Dispose(bool isDisposing)
	{
		if (!isDisposed && isDisposing)
		{
			events.Dispose();
			Stop();
		}
		isDisposed = true;
	}
}
