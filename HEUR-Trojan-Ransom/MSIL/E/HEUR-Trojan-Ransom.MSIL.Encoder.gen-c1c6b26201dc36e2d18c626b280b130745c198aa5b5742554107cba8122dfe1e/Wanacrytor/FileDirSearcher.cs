using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Wanacrytor;

public sealed class FileDirSearcher
{
	public static IEnumerable<FileInfo> GetFiles(string dirPath, SearchOption searchOption, IEnumerable<string> fileNamePatterns = null, IEnumerable<string> fileExtPatterns = null, bool ignoreCase = true, bool throwOnError = false)
	{
		AnalyzePath(ref dirPath);
		if (!Directory.Exists(dirPath))
		{
			throw new ArgumentException($"Directory doesn't exists: '{dirPath}'", "dirPath");
		}
		if (searchOption != 0 && searchOption != SearchOption.AllDirectories)
		{
			throw new ArgumentException($"Value of '{Conversions.ToString((int)searchOption)}' is not valid enumeration value.", "searchOption");
		}
		ConcurrentQueue<FileInfo> concurrentQueue = new ConcurrentQueue<FileInfo>();
		CollectFiles(concurrentQueue, dirPath, searchOption, fileNamePatterns, fileExtPatterns, ignoreCase, throwOnError);
		return concurrentQueue.AsEnumerable();
	}

	public static IEnumerable<string> GetFilePaths(string dirPath, SearchOption searchOption, IEnumerable<string> fileNamePatterns = null, IEnumerable<string> fileExtPatterns = null, bool ignoreCase = true, bool throwOnError = false)
	{
		AnalyzePath(ref dirPath);
		if (!Directory.Exists(dirPath))
		{
			throw new ArgumentException($"Directory doesn't exists: '{dirPath}'", "dirPath");
		}
		if (searchOption != 0 && searchOption != SearchOption.AllDirectories)
		{
			throw new ArgumentException($"Value of '{Conversions.ToString((int)searchOption)}' is not valid enumeration value.", "searchOption");
		}
		ConcurrentQueue<string> concurrentQueue = new ConcurrentQueue<string>();
		CollectFilePaths(concurrentQueue, dirPath, searchOption, fileNamePatterns, fileExtPatterns, ignoreCase, throwOnError);
		return concurrentQueue.AsEnumerable();
	}

	public static IEnumerable<DirectoryInfo> GetDirs(string dirPath, SearchOption searchOption, IEnumerable<string> dirPathPatterns = null, IEnumerable<string> dirNamePatterns = null, bool ignoreCase = true, bool throwOnError = false)
	{
		AnalyzePath(ref dirPath);
		if (!Directory.Exists(dirPath))
		{
			throw new ArgumentException($"Directory doesn't exists: '{dirPath}'", "dirPath");
		}
		if (searchOption != 0 && searchOption != SearchOption.AllDirectories)
		{
			throw new ArgumentException($"Value of '{Conversions.ToString((int)searchOption)}' is not valid enumeration value.", "searchOption");
		}
		ConcurrentQueue<DirectoryInfo> concurrentQueue = new ConcurrentQueue<DirectoryInfo>();
		CollectDirs(concurrentQueue, dirPath, searchOption, dirPathPatterns, dirNamePatterns, ignoreCase, throwOnError);
		return concurrentQueue.AsEnumerable();
	}

	public static IEnumerable<string> GetDirPaths(string dirPath, SearchOption searchOption, IEnumerable<string> dirPathPatterns = null, IEnumerable<string> dirNamePatterns = null, bool ignoreCase = true, bool throwOnError = false)
	{
		AnalyzePath(ref dirPath);
		if (!Directory.Exists(dirPath))
		{
			throw new ArgumentException($"Directory doesn't exists: '{dirPath}'", "dirPath");
		}
		if (searchOption != 0 && searchOption != SearchOption.AllDirectories)
		{
			throw new ArgumentException($"Value of '{Conversions.ToString((int)searchOption)}' is not valid enumeration value.", "searchOption");
		}
		ConcurrentQueue<string> concurrentQueue = new ConcurrentQueue<string>();
		CollectDirPaths(concurrentQueue, dirPath, searchOption, dirPathPatterns, dirNamePatterns, ignoreCase, throwOnError);
		return concurrentQueue.AsEnumerable();
	}

	private static void AnalyzePath(ref string dirPath)
	{
		if (!string.IsNullOrEmpty(dirPath) && !string.IsNullOrWhiteSpace(dirPath))
		{
			dirPath = dirPath.TrimStart(new char[1] { ' ' }).TrimEnd(new char[1] { ' ' });
			if (Path.IsPathRooted(dirPath))
			{
				dirPath = Conversions.ToString(char.ToUpper(dirPath.First())) + dirPath.Substring(1);
			}
			if (!dirPath.EndsWith("\\"))
			{
				dirPath = dirPath.Insert(dirPath.Length, "\\");
			}
			return;
		}
		throw new ArgumentNullException("dirPath", "Value is null, empty, or white-spaced.");
	}

	private static void CollectFiles(ConcurrentQueue<FileInfo> queue, string dirPath, SearchOption searchOption, IEnumerable<string> fileNamePatterns, IEnumerable<string> fileExtPatterns, bool ignoreCase, bool throwOnError)
	{
		_Closure_0024__6_002D0 arg = default(_Closure_0024__6_002D0);
		_Closure_0024__6_002D1 CS_0024_003C_003E8__locals0 = new _Closure_0024__6_002D0(arg);
		CS_0024_003C_003E8__locals0._0024VB_0024Local_queue = queue;
		CS_0024_003C_003E8__locals0._0024VB_0024Local_fileNamePatterns = fileNamePatterns;
		CS_0024_003C_003E8__locals0._0024VB_0024Local_fileExtPatterns = fileExtPatterns;
		CS_0024_003C_003E8__locals0._0024VB_0024Local_ignoreCase = ignoreCase;
		CS_0024_003C_003E8__locals0._0024VB_0024Local_throwOnError = throwOnError;
		DirectoryInfo directoryInfo = null;
		IEnumerable<FileInfo> enumerable = null;
		try
		{
			directoryInfo = new DirectoryInfo(dirPath);
		}
		catch (ArgumentNullException projectError)
		{
			ProjectData.SetProjectError((Exception)projectError);
			if (CS_0024_003C_003E8__locals0._0024VB_0024Local_throwOnError)
			{
				throw;
			}
			ProjectData.ClearProjectError();
		}
		catch (ArgumentException projectError2)
		{
			ProjectData.SetProjectError((Exception)projectError2);
			if (CS_0024_003C_003E8__locals0._0024VB_0024Local_throwOnError)
			{
				throw;
			}
			ProjectData.ClearProjectError();
		}
		catch (SecurityException projectError3)
		{
			ProjectData.SetProjectError((Exception)projectError3);
			if (CS_0024_003C_003E8__locals0._0024VB_0024Local_throwOnError)
			{
				throw;
			}
			ProjectData.ClearProjectError();
		}
		catch (PathTooLongException projectError4)
		{
			ProjectData.SetProjectError((Exception)projectError4);
			if (CS_0024_003C_003E8__locals0._0024VB_0024Local_throwOnError)
			{
				throw;
			}
			ProjectData.ClearProjectError();
		}
		try
		{
			enumerable = ((CS_0024_003C_003E8__locals0._0024VB_0024Local_fileExtPatterns == null) ? directoryInfo.GetFiles("*", SearchOption.TopDirectoryOnly) : directoryInfo.GetFiles("*.*", SearchOption.TopDirectoryOnly));
		}
		catch (UnauthorizedAccessException projectError5)
		{
			ProjectData.SetProjectError((Exception)projectError5);
			if (CS_0024_003C_003E8__locals0._0024VB_0024Local_throwOnError)
			{
				throw;
			}
			ProjectData.ClearProjectError();
		}
		catch (DirectoryNotFoundException projectError6)
		{
			ProjectData.SetProjectError((Exception)projectError6);
			if (CS_0024_003C_003E8__locals0._0024VB_0024Local_throwOnError)
			{
				throw;
			}
			ProjectData.ClearProjectError();
		}
		catch (Exception projectError7)
		{
			ProjectData.SetProjectError(projectError7);
			if (CS_0024_003C_003E8__locals0._0024VB_0024Local_throwOnError)
			{
				throw;
			}
			ProjectData.ClearProjectError();
		}
		if (enumerable != null)
		{
			foreach (FileInfo item in enumerable)
			{
				bool flag = false;
				bool flag2 = false;
				if (CS_0024_003C_003E8__locals0._0024VB_0024Local_fileNamePatterns != null)
				{
					foreach (string _0024VB_0024Local_fileNamePattern in CS_0024_003C_003E8__locals0._0024VB_0024Local_fileNamePatterns)
					{
						if (!_0024VB_0024Local_fileNamePattern.Equals("*", StringComparison.OrdinalIgnoreCase))
						{
							if (CS_0024_003C_003E8__locals0._0024VB_0024Local_ignoreCase)
							{
								if (LikeOperator.LikeString(item.get_Name().ToLower(), _0024VB_0024Local_fileNamePattern.ToLower(), (CompareMethod)0))
								{
									flag = true;
									break;
								}
							}
							else if (LikeOperator.LikeString(item.get_Name(), _0024VB_0024Local_fileNamePattern, (CompareMethod)0))
							{
								flag = true;
								break;
							}
							continue;
						}
						flag = true;
						break;
					}
				}
				else
				{
					flag = true;
				}
				if (CS_0024_003C_003E8__locals0._0024VB_0024Local_fileExtPatterns != null)
				{
					foreach (string _0024VB_0024Local_fileExtPattern in CS_0024_003C_003E8__locals0._0024VB_0024Local_fileExtPatterns)
					{
						if (!_0024VB_0024Local_fileExtPattern.Equals("*", StringComparison.OrdinalIgnoreCase))
						{
							if (CS_0024_003C_003E8__locals0._0024VB_0024Local_ignoreCase)
							{
								if (LikeOperator.LikeString(item.Extension.ToLower(), _0024VB_0024Local_fileExtPattern.ToLower(), (CompareMethod)0))
								{
									flag2 = true;
									break;
								}
							}
							else if (LikeOperator.LikeString(item.Extension, _0024VB_0024Local_fileExtPattern, (CompareMethod)0))
							{
								flag2 = true;
								break;
							}
							continue;
						}
						flag2 = true;
						break;
					}
				}
				else
				{
					flag2 = true;
				}
				if (flag && flag2)
				{
					CS_0024_003C_003E8__locals0._0024VB_0024Local_queue.Enqueue(item);
				}
			}
		}
		if (searchOption != SearchOption.AllDirectories)
		{
			return;
		}
		try
		{
			Task.WaitAll(directoryInfo.GetDirectories().Select(delegate(DirectoryInfo dir)
			{
				_Closure_0024__6_002D1 arg2 = default(_Closure_0024__6_002D1);
				CS_0024_003C_003E8__locals0 = new _Closure_0024__6_002D1(arg2);
				CS_0024_003C_003E8__locals0._0024VB_0024NonLocal__0024VB_0024Closure_2 = CS_0024_003C_003E8__locals0;
				CS_0024_003C_003E8__locals0._0024VB_0024Local_dir = dir;
				return Task.Factory.StartNew(delegate
				{
					CollectFiles(CS_0024_003C_003E8__locals0._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_queue, CS_0024_003C_003E8__locals0._0024VB_0024Local_dir.FullName, SearchOption.AllDirectories, CS_0024_003C_003E8__locals0._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_fileNamePatterns, CS_0024_003C_003E8__locals0._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_fileExtPatterns, CS_0024_003C_003E8__locals0._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_ignoreCase, CS_0024_003C_003E8__locals0._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_throwOnError);
				});
			}).ToArray());
		}
		catch (UnauthorizedAccessException projectError8)
		{
			ProjectData.SetProjectError((Exception)projectError8);
			if (CS_0024_003C_003E8__locals0._0024VB_0024Local_throwOnError)
			{
				throw;
			}
			ProjectData.ClearProjectError();
		}
		catch (DirectoryNotFoundException projectError9)
		{
			ProjectData.SetProjectError((Exception)projectError9);
			if (CS_0024_003C_003E8__locals0._0024VB_0024Local_throwOnError)
			{
				throw;
			}
			ProjectData.ClearProjectError();
		}
		catch (Exception projectError10)
		{
			ProjectData.SetProjectError(projectError10);
			if (CS_0024_003C_003E8__locals0._0024VB_0024Local_throwOnError)
			{
				throw;
			}
			ProjectData.ClearProjectError();
		}
	}

	private static void CollectFilePaths(ConcurrentQueue<string> queue, string dirPath, SearchOption searchOption, IEnumerable<string> fileNamePatterns, IEnumerable<string> fileExtPatterns, bool ignoreCase, bool throwOnError)
	{
		_Closure_0024__7_002D0 arg = default(_Closure_0024__7_002D0);
		_Closure_0024__7_002D1 CS_0024_003C_003E8__locals0 = new _Closure_0024__7_002D0(arg);
		CS_0024_003C_003E8__locals0._0024VB_0024Local_queue = queue;
		CS_0024_003C_003E8__locals0._0024VB_0024Local_fileNamePatterns = fileNamePatterns;
		CS_0024_003C_003E8__locals0._0024VB_0024Local_fileExtPatterns = fileExtPatterns;
		CS_0024_003C_003E8__locals0._0024VB_0024Local_ignoreCase = ignoreCase;
		CS_0024_003C_003E8__locals0._0024VB_0024Local_throwOnError = throwOnError;
		IEnumerable<string> enumerable = null;
		try
		{
			enumerable = ((CS_0024_003C_003E8__locals0._0024VB_0024Local_fileExtPatterns == null) ? Directory.GetFiles(dirPath, "*", SearchOption.TopDirectoryOnly) : Directory.GetFiles(dirPath, "*.*", SearchOption.TopDirectoryOnly));
		}
		catch (UnauthorizedAccessException projectError)
		{
			ProjectData.SetProjectError((Exception)projectError);
			if (CS_0024_003C_003E8__locals0._0024VB_0024Local_throwOnError)
			{
				throw;
			}
			ProjectData.ClearProjectError();
		}
		catch (DirectoryNotFoundException projectError2)
		{
			ProjectData.SetProjectError((Exception)projectError2);
			if (CS_0024_003C_003E8__locals0._0024VB_0024Local_throwOnError)
			{
				throw;
			}
			ProjectData.ClearProjectError();
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			if (CS_0024_003C_003E8__locals0._0024VB_0024Local_throwOnError)
			{
				throw;
			}
			ProjectData.ClearProjectError();
		}
		if (enumerable != null)
		{
			foreach (string item in enumerable)
			{
				bool flag = false;
				bool flag2 = false;
				if (CS_0024_003C_003E8__locals0._0024VB_0024Local_fileNamePatterns != null)
				{
					foreach (string _0024VB_0024Local_fileNamePattern in CS_0024_003C_003E8__locals0._0024VB_0024Local_fileNamePatterns)
					{
						if (!_0024VB_0024Local_fileNamePattern.Equals("*", StringComparison.OrdinalIgnoreCase))
						{
							if (CS_0024_003C_003E8__locals0._0024VB_0024Local_ignoreCase)
							{
								if (LikeOperator.LikeString(Path.GetFileNameWithoutExtension(item)!.ToLower(), _0024VB_0024Local_fileNamePattern.ToLower(), (CompareMethod)0))
								{
									flag = true;
									break;
								}
							}
							else if (LikeOperator.LikeString(Path.GetFileNameWithoutExtension(item), _0024VB_0024Local_fileNamePattern, (CompareMethod)0))
							{
								flag = true;
								break;
							}
							continue;
						}
						flag = true;
						break;
					}
				}
				else
				{
					flag = true;
				}
				if (CS_0024_003C_003E8__locals0._0024VB_0024Local_fileExtPatterns != null)
				{
					foreach (string _0024VB_0024Local_fileExtPattern in CS_0024_003C_003E8__locals0._0024VB_0024Local_fileExtPatterns)
					{
						if (!_0024VB_0024Local_fileExtPattern.Equals("*", StringComparison.OrdinalIgnoreCase))
						{
							if (CS_0024_003C_003E8__locals0._0024VB_0024Local_ignoreCase)
							{
								if (LikeOperator.LikeString(Path.GetExtension(item)!.ToLower(), _0024VB_0024Local_fileExtPattern.ToLower(), (CompareMethod)0))
								{
									flag2 = true;
									break;
								}
							}
							else if (LikeOperator.LikeString(Path.GetExtension(item), _0024VB_0024Local_fileExtPattern, (CompareMethod)0))
							{
								flag2 = true;
								break;
							}
							continue;
						}
						flag2 = true;
						break;
					}
				}
				else
				{
					flag2 = true;
				}
				if (flag && flag2)
				{
					CS_0024_003C_003E8__locals0._0024VB_0024Local_queue.Enqueue(item);
				}
			}
		}
		if (searchOption != SearchOption.AllDirectories)
		{
			return;
		}
		try
		{
			Task.WaitAll(new DirectoryInfo(dirPath).GetDirectories().Select(delegate(DirectoryInfo dir)
			{
				_Closure_0024__7_002D1 arg2 = default(_Closure_0024__7_002D1);
				CS_0024_003C_003E8__locals0 = new _Closure_0024__7_002D1(arg2);
				CS_0024_003C_003E8__locals0._0024VB_0024NonLocal__0024VB_0024Closure_2 = CS_0024_003C_003E8__locals0;
				CS_0024_003C_003E8__locals0._0024VB_0024Local_dir = dir;
				return Task.Factory.StartNew(delegate
				{
					CollectFilePaths(CS_0024_003C_003E8__locals0._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_queue, CS_0024_003C_003E8__locals0._0024VB_0024Local_dir.FullName, SearchOption.AllDirectories, CS_0024_003C_003E8__locals0._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_fileNamePatterns, CS_0024_003C_003E8__locals0._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_fileExtPatterns, CS_0024_003C_003E8__locals0._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_ignoreCase, CS_0024_003C_003E8__locals0._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_throwOnError);
				});
			}).ToArray());
		}
		catch (UnauthorizedAccessException projectError4)
		{
			ProjectData.SetProjectError((Exception)projectError4);
			if (CS_0024_003C_003E8__locals0._0024VB_0024Local_throwOnError)
			{
				throw;
			}
			ProjectData.ClearProjectError();
		}
		catch (DirectoryNotFoundException projectError5)
		{
			ProjectData.SetProjectError((Exception)projectError5);
			if (CS_0024_003C_003E8__locals0._0024VB_0024Local_throwOnError)
			{
				throw;
			}
			ProjectData.ClearProjectError();
		}
		catch (Exception projectError6)
		{
			ProjectData.SetProjectError(projectError6);
			if (CS_0024_003C_003E8__locals0._0024VB_0024Local_throwOnError)
			{
				throw;
			}
			ProjectData.ClearProjectError();
		}
	}

	private static void CollectDirs(ConcurrentQueue<DirectoryInfo> queue, string dirPath, SearchOption searchOption, IEnumerable<string> dirPathPatterns, IEnumerable<string> dirNamePatterns, bool ignoreCase, bool throwOnError)
	{
		_Closure_0024__8_002D0 arg = default(_Closure_0024__8_002D0);
		_Closure_0024__8_002D1 CS_0024_003C_003E8__locals0 = new _Closure_0024__8_002D0(arg);
		CS_0024_003C_003E8__locals0._0024VB_0024Local_queue = queue;
		CS_0024_003C_003E8__locals0._0024VB_0024Local_dirPathPatterns = dirPathPatterns;
		CS_0024_003C_003E8__locals0._0024VB_0024Local_dirNamePatterns = dirNamePatterns;
		CS_0024_003C_003E8__locals0._0024VB_0024Local_ignoreCase = ignoreCase;
		CS_0024_003C_003E8__locals0._0024VB_0024Local_throwOnError = throwOnError;
		DirectoryInfo directoryInfo = null;
		IEnumerable<DirectoryInfo> enumerable = null;
		try
		{
			directoryInfo = new DirectoryInfo(dirPath);
		}
		catch (ArgumentNullException projectError)
		{
			ProjectData.SetProjectError((Exception)projectError);
			if (CS_0024_003C_003E8__locals0._0024VB_0024Local_throwOnError)
			{
				throw;
			}
			ProjectData.ClearProjectError();
		}
		catch (ArgumentException projectError2)
		{
			ProjectData.SetProjectError((Exception)projectError2);
			if (CS_0024_003C_003E8__locals0._0024VB_0024Local_throwOnError)
			{
				throw;
			}
			ProjectData.ClearProjectError();
		}
		catch (SecurityException projectError3)
		{
			ProjectData.SetProjectError((Exception)projectError3);
			if (CS_0024_003C_003E8__locals0._0024VB_0024Local_throwOnError)
			{
				throw;
			}
			ProjectData.ClearProjectError();
		}
		catch (PathTooLongException projectError4)
		{
			ProjectData.SetProjectError((Exception)projectError4);
			if (CS_0024_003C_003E8__locals0._0024VB_0024Local_throwOnError)
			{
				throw;
			}
			ProjectData.ClearProjectError();
		}
		try
		{
			enumerable = directoryInfo.GetDirectories("*", SearchOption.TopDirectoryOnly);
		}
		catch (UnauthorizedAccessException projectError5)
		{
			ProjectData.SetProjectError((Exception)projectError5);
			if (CS_0024_003C_003E8__locals0._0024VB_0024Local_throwOnError)
			{
				throw;
			}
			ProjectData.ClearProjectError();
		}
		catch (DirectoryNotFoundException projectError6)
		{
			ProjectData.SetProjectError((Exception)projectError6);
			if (CS_0024_003C_003E8__locals0._0024VB_0024Local_throwOnError)
			{
				throw;
			}
			ProjectData.ClearProjectError();
		}
		catch (Exception projectError7)
		{
			ProjectData.SetProjectError(projectError7);
			if (CS_0024_003C_003E8__locals0._0024VB_0024Local_throwOnError)
			{
				throw;
			}
			ProjectData.ClearProjectError();
		}
		if (enumerable != null)
		{
			foreach (DirectoryInfo item in enumerable)
			{
				bool flag = false;
				bool flag2 = false;
				if (CS_0024_003C_003E8__locals0._0024VB_0024Local_dirPathPatterns != null)
				{
					foreach (string _0024VB_0024Local_dirPathPattern in CS_0024_003C_003E8__locals0._0024VB_0024Local_dirPathPatterns)
					{
						if (!_0024VB_0024Local_dirPathPattern.Equals("*", StringComparison.OrdinalIgnoreCase))
						{
							if (CS_0024_003C_003E8__locals0._0024VB_0024Local_ignoreCase)
							{
								if (LikeOperator.LikeString(item.FullName.ToLower(), _0024VB_0024Local_dirPathPattern.ToLower(), (CompareMethod)0))
								{
									flag = true;
									break;
								}
							}
							else if (LikeOperator.LikeString(item.FullName, _0024VB_0024Local_dirPathPattern, (CompareMethod)0))
							{
								flag = true;
								break;
							}
							continue;
						}
						flag = true;
						break;
					}
				}
				else
				{
					flag = true;
				}
				if (CS_0024_003C_003E8__locals0._0024VB_0024Local_dirNamePatterns != null)
				{
					foreach (string _0024VB_0024Local_dirNamePattern in CS_0024_003C_003E8__locals0._0024VB_0024Local_dirNamePatterns)
					{
						if (!_0024VB_0024Local_dirNamePattern.Equals("*", StringComparison.OrdinalIgnoreCase))
						{
							if (CS_0024_003C_003E8__locals0._0024VB_0024Local_ignoreCase)
							{
								if (LikeOperator.LikeString(item.get_Name().ToLower(), _0024VB_0024Local_dirNamePattern.ToLower(), (CompareMethod)0))
								{
									flag2 = true;
									break;
								}
							}
							else if (LikeOperator.LikeString(item.get_Name(), _0024VB_0024Local_dirNamePattern, (CompareMethod)0))
							{
								flag2 = true;
								break;
							}
							continue;
						}
						flag2 = true;
						break;
					}
				}
				else
				{
					flag2 = true;
				}
				if (flag && flag2)
				{
					CS_0024_003C_003E8__locals0._0024VB_0024Local_queue.Enqueue(item);
				}
			}
		}
		if (searchOption != SearchOption.AllDirectories)
		{
			return;
		}
		try
		{
			Task.WaitAll(directoryInfo.GetDirectories().Select(delegate(DirectoryInfo dir)
			{
				_Closure_0024__8_002D1 arg2 = default(_Closure_0024__8_002D1);
				CS_0024_003C_003E8__locals0 = new _Closure_0024__8_002D1(arg2);
				CS_0024_003C_003E8__locals0._0024VB_0024NonLocal__0024VB_0024Closure_2 = CS_0024_003C_003E8__locals0;
				CS_0024_003C_003E8__locals0._0024VB_0024Local_dir = dir;
				return Task.Factory.StartNew(delegate
				{
					CollectDirs(CS_0024_003C_003E8__locals0._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_queue, CS_0024_003C_003E8__locals0._0024VB_0024Local_dir.FullName, SearchOption.AllDirectories, CS_0024_003C_003E8__locals0._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_dirPathPatterns, CS_0024_003C_003E8__locals0._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_dirNamePatterns, CS_0024_003C_003E8__locals0._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_ignoreCase, CS_0024_003C_003E8__locals0._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_throwOnError);
				});
			}).ToArray());
		}
		catch (UnauthorizedAccessException projectError8)
		{
			ProjectData.SetProjectError((Exception)projectError8);
			if (CS_0024_003C_003E8__locals0._0024VB_0024Local_throwOnError)
			{
				throw;
			}
			ProjectData.ClearProjectError();
		}
		catch (DirectoryNotFoundException projectError9)
		{
			ProjectData.SetProjectError((Exception)projectError9);
			if (CS_0024_003C_003E8__locals0._0024VB_0024Local_throwOnError)
			{
				throw;
			}
			ProjectData.ClearProjectError();
		}
		catch (Exception projectError10)
		{
			ProjectData.SetProjectError(projectError10);
			if (CS_0024_003C_003E8__locals0._0024VB_0024Local_throwOnError)
			{
				throw;
			}
			ProjectData.ClearProjectError();
		}
	}

	private static void CollectDirPaths(ConcurrentQueue<string> queue, string dirPath, SearchOption searchOption, IEnumerable<string> dirPathPatterns, IEnumerable<string> dirNamePatterns, bool ignoreCase, bool throwOnError)
	{
		_Closure_0024__9_002D0 arg = default(_Closure_0024__9_002D0);
		_Closure_0024__9_002D1 CS_0024_003C_003E8__locals0 = new _Closure_0024__9_002D0(arg);
		CS_0024_003C_003E8__locals0._0024VB_0024Local_queue = queue;
		CS_0024_003C_003E8__locals0._0024VB_0024Local_dirPathPatterns = dirPathPatterns;
		CS_0024_003C_003E8__locals0._0024VB_0024Local_dirNamePatterns = dirNamePatterns;
		CS_0024_003C_003E8__locals0._0024VB_0024Local_ignoreCase = ignoreCase;
		CS_0024_003C_003E8__locals0._0024VB_0024Local_throwOnError = throwOnError;
		IEnumerable<string> enumerable = null;
		try
		{
			enumerable = Directory.GetDirectories(dirPath, "*", SearchOption.TopDirectoryOnly);
		}
		catch (UnauthorizedAccessException projectError)
		{
			ProjectData.SetProjectError((Exception)projectError);
			if (CS_0024_003C_003E8__locals0._0024VB_0024Local_throwOnError)
			{
				throw;
			}
			ProjectData.ClearProjectError();
		}
		catch (DirectoryNotFoundException projectError2)
		{
			ProjectData.SetProjectError((Exception)projectError2);
			if (CS_0024_003C_003E8__locals0._0024VB_0024Local_throwOnError)
			{
				throw;
			}
			ProjectData.ClearProjectError();
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			if (CS_0024_003C_003E8__locals0._0024VB_0024Local_throwOnError)
			{
				throw;
			}
			ProjectData.ClearProjectError();
		}
		if (enumerable != null)
		{
			foreach (string item in enumerable)
			{
				bool flag = false;
				bool flag2 = false;
				if (CS_0024_003C_003E8__locals0._0024VB_0024Local_dirPathPatterns != null)
				{
					foreach (string _0024VB_0024Local_dirPathPattern in CS_0024_003C_003E8__locals0._0024VB_0024Local_dirPathPatterns)
					{
						if (!_0024VB_0024Local_dirPathPattern.Equals("*", StringComparison.OrdinalIgnoreCase))
						{
							if (CS_0024_003C_003E8__locals0._0024VB_0024Local_ignoreCase)
							{
								if (LikeOperator.LikeString(item.ToLower(), _0024VB_0024Local_dirPathPattern.ToLower(), (CompareMethod)0))
								{
									flag = true;
									break;
								}
							}
							else if (LikeOperator.LikeString(item, _0024VB_0024Local_dirPathPattern, (CompareMethod)0))
							{
								flag = true;
								break;
							}
							continue;
						}
						flag = true;
						break;
					}
				}
				else
				{
					flag = true;
				}
				if (CS_0024_003C_003E8__locals0._0024VB_0024Local_dirNamePatterns != null)
				{
					foreach (string _0024VB_0024Local_dirNamePattern in CS_0024_003C_003E8__locals0._0024VB_0024Local_dirNamePatterns)
					{
						if (!_0024VB_0024Local_dirNamePattern.Equals("*", StringComparison.OrdinalIgnoreCase))
						{
							if (CS_0024_003C_003E8__locals0._0024VB_0024Local_ignoreCase)
							{
								if (LikeOperator.LikeString(Path.GetFileName(item)!.ToLower(), _0024VB_0024Local_dirNamePattern.ToLower(), (CompareMethod)0))
								{
									flag2 = true;
									break;
								}
							}
							else if (LikeOperator.LikeString(Path.GetFileName(item), _0024VB_0024Local_dirNamePattern, (CompareMethod)0))
							{
								flag2 = true;
								break;
							}
							continue;
						}
						flag2 = true;
						break;
					}
				}
				else
				{
					flag2 = true;
				}
				if (flag && flag2)
				{
					CS_0024_003C_003E8__locals0._0024VB_0024Local_queue.Enqueue(item);
				}
			}
		}
		if (searchOption != SearchOption.AllDirectories)
		{
			return;
		}
		try
		{
			Task.WaitAll(new DirectoryInfo(dirPath).GetDirectories().Select(delegate(DirectoryInfo dir)
			{
				_Closure_0024__9_002D1 arg2 = default(_Closure_0024__9_002D1);
				CS_0024_003C_003E8__locals0 = new _Closure_0024__9_002D1(arg2);
				CS_0024_003C_003E8__locals0._0024VB_0024NonLocal__0024VB_0024Closure_2 = CS_0024_003C_003E8__locals0;
				CS_0024_003C_003E8__locals0._0024VB_0024Local_dir = dir;
				return Task.Factory.StartNew(delegate
				{
					CollectDirPaths(CS_0024_003C_003E8__locals0._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_queue, CS_0024_003C_003E8__locals0._0024VB_0024Local_dir.FullName, SearchOption.AllDirectories, CS_0024_003C_003E8__locals0._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_dirPathPatterns, CS_0024_003C_003E8__locals0._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_dirNamePatterns, CS_0024_003C_003E8__locals0._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_ignoreCase, CS_0024_003C_003E8__locals0._0024VB_0024NonLocal__0024VB_0024Closure_2._0024VB_0024Local_throwOnError);
				});
			}).ToArray());
		}
		catch (UnauthorizedAccessException projectError4)
		{
			ProjectData.SetProjectError((Exception)projectError4);
			if (CS_0024_003C_003E8__locals0._0024VB_0024Local_throwOnError)
			{
				throw;
			}
			ProjectData.ClearProjectError();
		}
		catch (DirectoryNotFoundException projectError5)
		{
			ProjectData.SetProjectError((Exception)projectError5);
			if (CS_0024_003C_003E8__locals0._0024VB_0024Local_throwOnError)
			{
				throw;
			}
			ProjectData.ClearProjectError();
		}
		catch (Exception projectError6)
		{
			ProjectData.SetProjectError(projectError6);
			if (CS_0024_003C_003E8__locals0._0024VB_0024Local_throwOnError)
			{
				throw;
			}
			ProjectData.ClearProjectError();
		}
	}
}
