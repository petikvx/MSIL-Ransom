using System;
using System.Collections;
using System.Data;
using System.Runtime.InteropServices;
using System.Text;

namespace ns2;

public class SQLiteBase
{
	public enum SQLiteDataTypes
	{
		INT = 1,
		FLOAT,
		TEXT,
		BLOB,
		NULL
	}

	private const int SQL_OK = 0;

	private const int SQL_ROW = 100;

	private const int SQL_DONE = 101;

	private IntPtr database;

	[DllImport("kernel32")]
	private static extern IntPtr HeapAlloc(IntPtr heap, uint flags, uint bytes);

	[DllImport("kernel32")]
	private static extern IntPtr GetProcessHeap();

	[DllImport("kernel32")]
	private static extern int lstrlen(IntPtr str);

	[DllImport("sqlite3")]
	private static extern int sqlite3_open(IntPtr fileName, ref IntPtr database);

	[DllImport("sqlite3")]
	private static extern int sqlite3_close(IntPtr database);

	[DllImport("sqlite3")]
	private static extern int sqlite3_exec(IntPtr database, IntPtr query, IntPtr callback, IntPtr arguments, ref IntPtr error);

	[DllImport("sqlite3")]
	private static extern IntPtr sqlite3_errmsg(IntPtr database);

	[DllImport("sqlite3")]
	private static extern int sqlite3_prepare_v2(IntPtr database, IntPtr query, int length, ref IntPtr statement, ref IntPtr tail);

	[DllImport("sqlite3")]
	private static extern int sqlite3_step(IntPtr statement);

	[DllImport("sqlite3")]
	private static extern int sqlite3_column_count(IntPtr statement);

	[DllImport("sqlite3")]
	private static extern IntPtr sqlite3_column_name(IntPtr statement, int columnNumber);

	[DllImport("sqlite3")]
	private static extern int sqlite3_column_type(IntPtr statement, int columnNumber);

	[DllImport("sqlite3")]
	private static extern int sqlite3_column_int(IntPtr statement, int columnNumber);

	[DllImport("sqlite3")]
	private static extern double sqlite3_column_double(IntPtr statement, int columnNumber);

	[DllImport("sqlite3")]
	private static extern IntPtr sqlite3_column_text(IntPtr statement, int columnNumber);

	[DllImport("sqlite3")]
	private static extern IntPtr sqlite3_column_blob(IntPtr statement, int columnNumber);

	[DllImport("sqlite3")]
	private static extern IntPtr sqlite3_column_table_name(IntPtr statement, int columnNumber);

	[DllImport("sqlite3")]
	private static extern int sqlite3_finalize(IntPtr handle);

	public SQLiteBase()
	{
		database = IntPtr.Zero;
	}

	public SQLiteBase(string baseName)
	{
		OpenDatabase(baseName);
	}

	public void OpenDatabase(string baseName)
	{
		if (sqlite3_open(StringToPointer(baseName), ref database) != 0)
		{
			database = IntPtr.Zero;
			throw new Exception(GClass0.smethod_0("Y???????????????????????\u0b7e??????\u0e60???\u1062???????????????????????????\u1a67???") + baseName + GClass0.smethod_0(" "));
		}
	}

	public void CloseDatabase()
	{
		if (database != IntPtr.Zero)
		{
			sqlite3_close(database);
		}
	}

	public ArrayList GetTables()
	{
		string query = GClass0.smethod_0("??????????\u05f8????\u08c8\u09c5\u0ac2???\u0ce3\u0df6\u0eec\u0fef??????????????????\u16fe\u17c5??????\u1ae4??????\u1de6???\u1fc5\u20d9????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????\ua94c?????????????????????");
		DataTable dataTable = ExecuteQuery(query);
		ArrayList arrayList = new ArrayList();
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = dataTable.Rows.GetEnumerator();
			while (enumerator.MoveNext())
			{
				DataRow dataRow = (DataRow)enumerator.Current;
				arrayList.Add(dataRow.ItemArray[0]!.ToString());
			}
			return arrayList;
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
		}
	}

	public void ExecuteNonQuery(string query)
	{
		IntPtr error = default(IntPtr);
		sqlite3_exec(database, StringToPointer(query), IntPtr.Zero, IntPtr.Zero, ref error);
		if (error != IntPtr.Zero)
		{
			throw new Exception(GClass0.smethod_0("d??????????????\u086d???\u0a37?????????\u0e70??????????????????????????????\u1979\u1a72??????????????????") + query + GClass0.smethod_0("!????") + PointerToString(sqlite3_errmsg(error)));
		}
	}

	public DataTable ExecuteQuery(string query)
	{
		IntPtr statement = default(IntPtr);
		IntPtr tail = default(IntPtr);
		sqlite3_prepare_v2(database, StringToPointer(query), GetPointerLenght(StringToPointer(query)), ref statement, ref tail);
		DataTable table = new DataTable();
		for (int num = ReadFirstRow(statement, ref table); num == 100; num = ReadNextRow(statement, ref table))
		{
		}
		sqlite3_finalize(statement);
		return table;
	}

	private int ReadFirstRow(IntPtr statement, ref DataTable table)
	{
		table = new DataTable(GClass0.smethod_0("y??????????\u0651????????\u0a64"));
		int num = sqlite3_step(statement);
		checked
		{
			if (num == 100)
			{
				int num2 = sqlite3_column_count(statement);
				string text = GClass0.smethod_0("");
				int num3 = 0;
				object[] array = new object[num2 - 1 + 1];
				int num4 = num2 - 1;
				for (int i = 0; i <= num4; i++)
				{
					text = PointerToString(sqlite3_column_name(statement, i));
					switch (sqlite3_column_type(statement, i))
					{
					default:
						table.Columns.Add(text, Type.GetType(GClass0.smethod_0("^??????????????\u0871????????????")));
						array[i] = GClass0.smethod_0("");
						break;
					case 1:
						table.Columns.Add(text, Type.GetType(GClass0.smethod_0("_????????????\u074c??????\u0a31???")));
						array[i] = sqlite3_column_int(statement, i);
						break;
					case 2:
						table.Columns.Add(text, Type.GetType(GClass0.smethod_0("^??????????????\u086c???\u0a64???\u0c64")));
						array[i] = sqlite3_column_double(statement, i);
						break;
					case 3:
						table.Columns.Add(text, Type.GetType(GClass0.smethod_0("^??????????????\u0871????????????")));
						array[i] = PointerToString(sqlite3_column_text(statement, i));
						break;
					case 4:
						table.Columns.Add(text, Type.GetType(GClass0.smethod_0("^??????????????\u0871????????????")));
						array[i] = PointerToString(sqlite3_column_blob(statement, i));
						break;
					}
				}
				table.Rows.Add(array);
			}
			return sqlite3_step(statement);
		}
	}

	private int ReadNextRow(IntPtr statement, ref DataTable table)
	{
		int num = sqlite3_column_count(statement);
		int num2 = 0;
		checked
		{
			object[] array = new object[num - 1 + 1];
			int num3 = num - 1;
			for (int i = 0; i <= num3; i++)
			{
				switch (sqlite3_column_type(statement, i))
				{
				default:
					array[i] = GClass0.smethod_0("");
					break;
				case 1:
					array[i] = sqlite3_column_int(statement, i);
					break;
				case 2:
					array[i] = sqlite3_column_double(statement, i);
					break;
				case 3:
					array[i] = PointerToString(sqlite3_column_text(statement, i));
					break;
				case 4:
					array[i] = PointerToString(sqlite3_column_blob(statement, i));
					break;
				}
			}
			table.Rows.Add(array);
			return sqlite3_step(statement);
		}
	}

	private IntPtr StringToPointer(string str)
	{
		if (str == null)
		{
			return IntPtr.Zero;
		}
		Encoding uTF = Encoding.UTF8;
		byte[] bytes = uTF.GetBytes(str);
		uint bytes2 = checked((uint)(bytes.Length + 1));
		IntPtr intPtr = HeapAlloc(GetProcessHeap(), 0u, bytes2);
		Marshal.Copy(bytes, 0, intPtr, bytes.Length);
		Marshal.WriteByte(intPtr, bytes.Length, 0);
		return intPtr;
	}

	private string PointerToString(IntPtr ptr)
	{
		if (ptr == IntPtr.Zero)
		{
			return null;
		}
		Encoding uTF = Encoding.UTF8;
		int pointerLenght = GetPointerLenght(ptr);
		byte[] array = new byte[checked(pointerLenght - 1 + 1)];
		Marshal.Copy(ptr, array, 0, pointerLenght);
		return uTF.GetString(array, 0, pointerLenght);
	}

	private int GetPointerLenght(IntPtr ptr)
	{
		if (ptr == IntPtr.Zero)
		{
			return 0;
		}
		return lstrlen(ptr);
	}
}
