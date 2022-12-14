using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.CSharp;

namespace CustomWindowsForm;

public class Compiler
{
	public Compiler(string sourceCode, string savePath, string iconLocation)
	{
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected O, but got Unknown
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected O, but got Unknown
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Expected O, but got Unknown
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		string[] array = new string[5] { "System.dll", "System.Linq.dll", "System.Windows.Forms.dll", "System.Text.RegularExpressions.dll", "System.Runtime.InteropServices.dll" };
		Dictionary<string, string> dictionary = new Dictionary<string, string> { { "CompilerVersion", "v4.0" } };
		string text = "/target:winexe /platform:anycpu /optimize+ ";
		if (iconLocation != "")
		{
			text = text + "/win32icon:" + iconLocation;
		}
		CSharpCodeProvider val = new CSharpCodeProvider((IDictionary<string, string>)dictionary);
		try
		{
			CompilerParameters val2 = new CompilerParameters(array);
			val2.set_GenerateExecutable(true);
			val2.set_GenerateInMemory(false);
			val2.set_OutputAssembly(savePath);
			val2.set_CompilerOptions(text);
			val2.set_TreatWarningsAsErrors(false);
			val2.set_IncludeDebugInformation(false);
			CompilerParameters val3 = val2;
			CompilerResults val4 = ((CodeDomProvider)val).CompileAssemblyFromSource(val3, new string[1] { sourceCode });
			if (((CollectionBase)(object)val4.get_Errors()).Count > 0)
			{
				foreach (CompilerError item in (CollectionBase)(object)val4.get_Errors())
				{
					CompilerError val5 = item;
					MessageBox.Show($"{val5.get_ErrorText()}\nLine: {val5.get_Line()} - Column: {val5.get_Column()}\nFile: {val5.get_FileName()}");
				}
				return;
			}
			MessageBox.Show("Done!");
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
	}
}
