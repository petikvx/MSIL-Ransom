using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Newtonsoft.Json;
using UNIVERSALGAME.Models;

public static class GClass6
{
	[StructLayout(LayoutKind.Auto)]
	private struct Struct9 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncTaskMethodBuilder<List<GClass0>> asyncTaskMethodBuilder_0;

		private HttpClient httpClient_0;

		private HttpResponseMessage httpResponseMessage_0;

		private TaskAwaiter<string> taskAwaiter_0;

		private void MoveNext()
		{
			int num = int_0;
			List<GClass0> result;
			try
			{
				if (num != 0)
				{
					httpClient_0 = new HttpClient();
				}
				try
				{
					if (num != 0)
					{
						httpClient_0.BaseAddress = new Uri(Class60.smethod_0(-2050218299));
						httpClient_0.DefaultRequestHeaders.Accept.Clear();
						httpClient_0.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(Class60.smethod_0(-2050218332)));
						httpClient_0.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(Class60.smethod_0(-2050218357), string_0);
					}
					try
					{
						if (num != 0)
						{
							httpResponseMessage_0 = httpClient_0.GetAsync(Class60.smethod_0(-2050218344)).Result;
						}
						try
						{
							TaskAwaiter<string> awaiter;
							if (num == 0)
							{
								awaiter = taskAwaiter_0;
								taskAwaiter_0 = default(TaskAwaiter<string>);
								num = -1;
								int_0 = -1;
								goto IL_012a;
							}
							if (httpResponseMessage_0.IsSuccessStatusCode)
							{
								awaiter = httpResponseMessage_0.Content.ReadAsStringAsync().GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									num = 0;
									int_0 = 0;
									taskAwaiter_0 = awaiter;
									asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								}
								goto IL_012a;
							}
							result = null;
							goto end_IL_00b5;
							IL_012a:
							string result2 = awaiter.GetResult();
							string text = result2;
							List<GClass0> list = JsonConvert.DeserializeObject<List<GClass0>>(Class55.smethod_6(text.Substring(1, text.Length - 2)));
							result = list;
							end_IL_00b5:;
						}
						finally
						{
							if (num < 0 && httpResponseMessage_0 != null)
							{
								((IDisposable)httpResponseMessage_0).Dispose();
							}
						}
					}
					catch
					{
						result = null;
					}
				}
				finally
				{
					if (num < 0 && httpClient_0 != null)
					{
						((IDisposable)httpClient_0).Dispose();
					}
				}
			}
			catch (Exception exception)
			{
				int_0 = -2;
				asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			int_0 = -2;
			asyncTaskMethodBuilder_0.SetResult(result);
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	private struct Struct10 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncTaskMethodBuilder<GClass1> asyncTaskMethodBuilder_0;

		private HttpClient httpClient_0;

		private HttpResponseMessage httpResponseMessage_0;

		private TaskAwaiter<string> taskAwaiter_0;

		private void MoveNext()
		{
			int num = int_0;
			GClass1 result;
			try
			{
				if (num != 0)
				{
					httpClient_0 = new HttpClient();
				}
				try
				{
					if (num != 0)
					{
						httpClient_0.BaseAddress = new Uri(Class60.smethod_0(-2050218299));
						httpClient_0.DefaultRequestHeaders.Accept.Clear();
						httpClient_0.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(Class60.smethod_0(-2050218332)));
						httpClient_0.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(Class60.smethod_0(-2050218357), string_0);
					}
					try
					{
						if (num != 0)
						{
							httpResponseMessage_0 = httpClient_0.GetAsync(Class60.smethod_0(-2050218503)).Result;
						}
						try
						{
							TaskAwaiter<string> awaiter;
							if (num == 0)
							{
								awaiter = taskAwaiter_0;
								taskAwaiter_0 = default(TaskAwaiter<string>);
								num = -1;
								int_0 = -1;
								goto IL_0127;
							}
							if (httpResponseMessage_0.IsSuccessStatusCode)
							{
								awaiter = httpResponseMessage_0.Content.ReadAsStringAsync().GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									num = 0;
									int_0 = 0;
									taskAwaiter_0 = awaiter;
									asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								}
								goto IL_0127;
							}
							result = null;
							goto end_IL_00b5;
							IL_0127:
							string result2 = awaiter.GetResult();
							string text = result2;
							result = JsonConvert.DeserializeObject<GClass1>(text);
							end_IL_00b5:;
						}
						finally
						{
							if (num < 0 && httpResponseMessage_0 != null)
							{
								((IDisposable)httpResponseMessage_0).Dispose();
							}
						}
					}
					catch
					{
						result = null;
					}
				}
				finally
				{
					if (num < 0 && httpClient_0 != null)
					{
						((IDisposable)httpClient_0).Dispose();
					}
				}
			}
			catch (Exception exception)
			{
				int_0 = -2;
				asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			int_0 = -2;
			asyncTaskMethodBuilder_0.SetResult(result);
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	private struct Struct11 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncTaskMethodBuilder<List<GClass3>> asyncTaskMethodBuilder_0;

		private HttpClient httpClient_0;

		private HttpResponseMessage httpResponseMessage_0;

		private TaskAwaiter<string> taskAwaiter_0;

		private void MoveNext()
		{
			int num = int_0;
			List<GClass3> result;
			try
			{
				if (num != 0)
				{
					httpClient_0 = new HttpClient();
				}
				try
				{
					if (num != 0)
					{
						httpClient_0.BaseAddress = new Uri(Class60.smethod_0(-2050218299));
						httpClient_0.DefaultRequestHeaders.Accept.Clear();
						httpClient_0.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(Class60.smethod_0(-2050218332)));
						httpClient_0.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(Class60.smethod_0(-2050218357), string_0);
					}
					try
					{
						if (num != 0)
						{
							httpResponseMessage_0 = httpClient_0.GetAsync(Class60.smethod_0(-2050218385)).Result;
						}
						try
						{
							TaskAwaiter<string> awaiter;
							if (num == 0)
							{
								awaiter = taskAwaiter_0;
								taskAwaiter_0 = default(TaskAwaiter<string>);
								num = -1;
								int_0 = -1;
								goto IL_012a;
							}
							if (httpResponseMessage_0.IsSuccessStatusCode)
							{
								awaiter = httpResponseMessage_0.Content.ReadAsStringAsync().GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									num = 0;
									int_0 = 0;
									taskAwaiter_0 = awaiter;
									asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								}
								goto IL_012a;
							}
							result = null;
							goto end_IL_00b5;
							IL_012a:
							string result2 = awaiter.GetResult();
							string text = result2;
							List<GClass3> list = JsonConvert.DeserializeObject<List<GClass3>>(Class55.smethod_6(text.Substring(1, text.Length - 2)));
							result = list;
							end_IL_00b5:;
						}
						finally
						{
							if (num < 0 && httpResponseMessage_0 != null)
							{
								((IDisposable)httpResponseMessage_0).Dispose();
							}
						}
					}
					catch
					{
						result = null;
					}
				}
				finally
				{
					if (num < 0 && httpClient_0 != null)
					{
						((IDisposable)httpClient_0).Dispose();
					}
				}
			}
			catch (Exception exception)
			{
				int_0 = -2;
				asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			int_0 = -2;
			asyncTaskMethodBuilder_0.SetResult(result);
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	private struct Struct12 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

		private HttpClient httpClient_0;

		private HttpRequestMessage httpRequestMessage_0;

		private Stream stream_0;

		private Stream stream_1;

		private TaskAwaiter<HttpResponseMessage> taskAwaiter_0;

		private TaskAwaiter<Stream> taskAwaiter_1;

		private TaskAwaiter taskAwaiter_2;

		private void MoveNext()
		{
			int num = int_0;
			try
			{
				try
				{
					if ((uint)num > 17u)
					{
						httpClient_0 = new HttpClient();
					}
					try
					{
						switch (num)
						{
						default:
							httpRequestMessage_0 = new HttpRequestMessage(HttpMethod.Get, Class60.smethod_0(-2050218560));
							goto case 0;
						case 0:
						case 1:
						case 2:
							try
							{
								TaskAwaiter<HttpResponseMessage> awaiter2;
								TaskAwaiter<Stream> awaiter;
								Stream stream;
								HttpResponseMessage result;
								switch (num)
								{
								default:
									awaiter2 = httpClient_0.SendAsync(httpRequestMessage_0).GetAwaiter();
									if (!awaiter2.IsCompleted)
									{
										num = 0;
										int_0 = 0;
										taskAwaiter_0 = awaiter2;
										asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
										return;
									}
									goto IL_00f2;
								case 0:
									awaiter2 = taskAwaiter_0;
									taskAwaiter_0 = default(TaskAwaiter<HttpResponseMessage>);
									num = -1;
									int_0 = -1;
									goto IL_00f2;
								case 1:
									awaiter = taskAwaiter_1;
									taskAwaiter_1 = default(TaskAwaiter<Stream>);
									num = -1;
									int_0 = -1;
									goto IL_0155;
								case 2:
									break;
									IL_0155:
									stream = (stream_0 = awaiter.GetResult());
									break;
									IL_00f2:
									result = awaiter2.GetResult();
									awaiter = result.Content.ReadAsStreamAsync().GetAwaiter();
									if (!awaiter.IsCompleted)
									{
										num = 1;
										int_0 = 1;
										taskAwaiter_1 = awaiter;
										asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
										return;
									}
									goto IL_0155;
								}
								try
								{
									if (num != 2)
									{
										stream_1 = new FileStream(Class60.smethod_0(-2050210047), FileMode.Create, FileAccess.Write, FileShare.None);
									}
									try
									{
										TaskAwaiter awaiter3;
										if (num != 2)
										{
											awaiter3 = stream_0.CopyToAsync(stream_1).GetAwaiter();
											if (!awaiter3.IsCompleted)
											{
												num = 2;
												int_0 = 2;
												taskAwaiter_2 = awaiter3;
												asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
												return;
											}
										}
										else
										{
											awaiter3 = taskAwaiter_2;
											taskAwaiter_2 = default(TaskAwaiter);
											num = -1;
											int_0 = -1;
										}
										awaiter3.GetResult();
									}
									finally
									{
										if (num < 0 && stream_1 != null)
										{
											((IDisposable)stream_1).Dispose();
										}
									}
								}
								finally
								{
									if (num < 0 && stream_0 != null)
									{
										((IDisposable)stream_0).Dispose();
									}
								}
								stream_0 = null;
								stream_1 = null;
							}
							finally
							{
								if (num < 0 && httpRequestMessage_0 != null)
								{
									((IDisposable)httpRequestMessage_0).Dispose();
								}
							}
							httpRequestMessage_0 = null;
							httpRequestMessage_0 = new HttpRequestMessage(HttpMethod.Get, Class60.smethod_0(-2050218570));
							goto case 3;
						case 3:
						case 4:
						case 5:
							try
							{
								TaskAwaiter<HttpResponseMessage> awaiter8;
								TaskAwaiter<Stream> awaiter7;
								Stream stream3;
								HttpResponseMessage result3;
								switch (num)
								{
								default:
									awaiter8 = httpClient_0.SendAsync(httpRequestMessage_0).GetAwaiter();
									if (!awaiter8.IsCompleted)
									{
										num = 3;
										int_0 = 3;
										taskAwaiter_0 = awaiter8;
										asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter8, ref this);
										return;
									}
									goto IL_02e2;
								case 3:
									awaiter8 = taskAwaiter_0;
									taskAwaiter_0 = default(TaskAwaiter<HttpResponseMessage>);
									num = -1;
									int_0 = -1;
									goto IL_02e2;
								case 4:
									awaiter7 = taskAwaiter_1;
									taskAwaiter_1 = default(TaskAwaiter<Stream>);
									num = -1;
									int_0 = -1;
									goto IL_0348;
								case 5:
									break;
									IL_0348:
									stream3 = (stream_1 = awaiter7.GetResult());
									break;
									IL_02e2:
									result3 = awaiter8.GetResult();
									awaiter7 = result3.Content.ReadAsStreamAsync().GetAwaiter();
									if (!awaiter7.IsCompleted)
									{
										num = 4;
										int_0 = 4;
										taskAwaiter_1 = awaiter7;
										asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter7, ref this);
										return;
									}
									goto IL_0348;
								}
								try
								{
									if (num != 5)
									{
										stream_0 = new FileStream(Class60.smethod_0(-2050210056), FileMode.Create, FileAccess.Write, FileShare.None);
									}
									try
									{
										TaskAwaiter awaiter9;
										if (num != 5)
										{
											awaiter9 = stream_1.CopyToAsync(stream_0).GetAwaiter();
											if (!awaiter9.IsCompleted)
											{
												num = 5;
												int_0 = 5;
												taskAwaiter_2 = awaiter9;
												asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter9, ref this);
												return;
											}
										}
										else
										{
											awaiter9 = taskAwaiter_2;
											taskAwaiter_2 = default(TaskAwaiter);
											num = -1;
											int_0 = -1;
										}
										awaiter9.GetResult();
									}
									finally
									{
										if (num < 0 && stream_0 != null)
										{
											((IDisposable)stream_0).Dispose();
										}
									}
								}
								finally
								{
									if (num < 0 && stream_1 != null)
									{
										((IDisposable)stream_1).Dispose();
									}
								}
								stream_1 = null;
								stream_0 = null;
							}
							finally
							{
								if (num < 0 && httpRequestMessage_0 != null)
								{
									((IDisposable)httpRequestMessage_0).Dispose();
								}
							}
							httpRequestMessage_0 = null;
							httpRequestMessage_0 = new HttpRequestMessage(HttpMethod.Get, Class60.smethod_0(-2050218626));
							goto case 6;
						case 6:
						case 7:
						case 8:
							try
							{
								TaskAwaiter<HttpResponseMessage> awaiter14;
								TaskAwaiter<Stream> awaiter13;
								Stream stream5;
								HttpResponseMessage result5;
								switch (num)
								{
								default:
									awaiter14 = httpClient_0.SendAsync(httpRequestMessage_0).GetAwaiter();
									if (!awaiter14.IsCompleted)
									{
										num = 6;
										int_0 = 6;
										taskAwaiter_0 = awaiter14;
										asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter14, ref this);
										return;
									}
									goto IL_04d8;
								case 6:
									awaiter14 = taskAwaiter_0;
									taskAwaiter_0 = default(TaskAwaiter<HttpResponseMessage>);
									num = -1;
									int_0 = -1;
									goto IL_04d8;
								case 7:
									awaiter13 = taskAwaiter_1;
									taskAwaiter_1 = default(TaskAwaiter<Stream>);
									num = -1;
									int_0 = -1;
									goto IL_053e;
								case 8:
									break;
									IL_053e:
									stream5 = (stream_0 = awaiter13.GetResult());
									break;
									IL_04d8:
									result5 = awaiter14.GetResult();
									awaiter13 = result5.Content.ReadAsStreamAsync().GetAwaiter();
									if (!awaiter13.IsCompleted)
									{
										num = 7;
										int_0 = 7;
										taskAwaiter_1 = awaiter13;
										asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter13, ref this);
										return;
									}
									goto IL_053e;
								}
								try
								{
									if (num != 8)
									{
										stream_1 = new FileStream(Class60.smethod_0(-2050210095), FileMode.Create, FileAccess.Write, FileShare.None);
									}
									try
									{
										TaskAwaiter awaiter15;
										if (num != 8)
										{
											awaiter15 = stream_0.CopyToAsync(stream_1).GetAwaiter();
											if (!awaiter15.IsCompleted)
											{
												num = 8;
												int_0 = 8;
												taskAwaiter_2 = awaiter15;
												asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter15, ref this);
												return;
											}
										}
										else
										{
											awaiter15 = taskAwaiter_2;
											taskAwaiter_2 = default(TaskAwaiter);
											num = -1;
											int_0 = -1;
										}
										awaiter15.GetResult();
									}
									finally
									{
										if (num < 0 && stream_1 != null)
										{
											((IDisposable)stream_1).Dispose();
										}
									}
								}
								finally
								{
									if (num < 0 && stream_0 != null)
									{
										((IDisposable)stream_0).Dispose();
									}
								}
								stream_0 = null;
								stream_1 = null;
							}
							finally
							{
								if (num < 0 && httpRequestMessage_0 != null)
								{
									((IDisposable)httpRequestMessage_0).Dispose();
								}
							}
							httpRequestMessage_0 = null;
							httpRequestMessage_0 = new HttpRequestMessage(HttpMethod.Get, Class60.smethod_0(-2050218714));
							goto case 9;
						case 9:
						case 10:
						case 11:
							try
							{
								TaskAwaiter<HttpResponseMessage> awaiter11;
								TaskAwaiter<Stream> awaiter10;
								Stream stream4;
								HttpResponseMessage result4;
								switch (num)
								{
								default:
									awaiter11 = httpClient_0.SendAsync(httpRequestMessage_0).GetAwaiter();
									if (!awaiter11.IsCompleted)
									{
										num = 9;
										int_0 = 9;
										taskAwaiter_0 = awaiter11;
										asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter11, ref this);
										return;
									}
									goto IL_06d1;
								case 9:
									awaiter11 = taskAwaiter_0;
									taskAwaiter_0 = default(TaskAwaiter<HttpResponseMessage>);
									num = -1;
									int_0 = -1;
									goto IL_06d1;
								case 10:
									awaiter10 = taskAwaiter_1;
									taskAwaiter_1 = default(TaskAwaiter<Stream>);
									num = -1;
									int_0 = -1;
									goto IL_0739;
								case 11:
									break;
									IL_0739:
									stream4 = (stream_1 = awaiter10.GetResult());
									break;
									IL_06d1:
									result4 = awaiter11.GetResult();
									awaiter10 = result4.Content.ReadAsStreamAsync().GetAwaiter();
									if (!awaiter10.IsCompleted)
									{
										num = 10;
										int_0 = 10;
										taskAwaiter_1 = awaiter10;
										asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter10, ref this);
										return;
									}
									goto IL_0739;
								}
								try
								{
									if (num != 11)
									{
										stream_0 = new FileStream(Class60.smethod_0(-2050210166), FileMode.Create, FileAccess.Write, FileShare.None);
									}
									try
									{
										TaskAwaiter awaiter12;
										if (num != 11)
										{
											awaiter12 = stream_1.CopyToAsync(stream_0).GetAwaiter();
											if (!awaiter12.IsCompleted)
											{
												num = 11;
												int_0 = 11;
												taskAwaiter_2 = awaiter12;
												asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter12, ref this);
												return;
											}
										}
										else
										{
											awaiter12 = taskAwaiter_2;
											taskAwaiter_2 = default(TaskAwaiter);
											num = -1;
											int_0 = -1;
										}
										awaiter12.GetResult();
									}
									finally
									{
										if (num < 0 && stream_0 != null)
										{
											((IDisposable)stream_0).Dispose();
										}
									}
								}
								finally
								{
									if (num < 0 && stream_1 != null)
									{
										((IDisposable)stream_1).Dispose();
									}
								}
								stream_1 = null;
								stream_0 = null;
							}
							finally
							{
								if (num < 0 && httpRequestMessage_0 != null)
								{
									((IDisposable)httpRequestMessage_0).Dispose();
								}
							}
							httpRequestMessage_0 = null;
							httpRequestMessage_0 = new HttpRequestMessage(HttpMethod.Get, Class60.smethod_0(-2050218771));
							goto case 12;
						case 12:
						case 13:
						case 14:
							try
							{
								TaskAwaiter<HttpResponseMessage> awaiter5;
								TaskAwaiter<Stream> awaiter4;
								Stream stream2;
								HttpResponseMessage result2;
								switch (num)
								{
								default:
									awaiter5 = httpClient_0.SendAsync(httpRequestMessage_0).GetAwaiter();
									if (!awaiter5.IsCompleted)
									{
										num = 12;
										int_0 = 12;
										taskAwaiter_0 = awaiter5;
										asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter5, ref this);
										return;
									}
									goto IL_08d0;
								case 12:
									awaiter5 = taskAwaiter_0;
									taskAwaiter_0 = default(TaskAwaiter<HttpResponseMessage>);
									num = -1;
									int_0 = -1;
									goto IL_08d0;
								case 13:
									awaiter4 = taskAwaiter_1;
									taskAwaiter_1 = default(TaskAwaiter<Stream>);
									num = -1;
									int_0 = -1;
									goto IL_0938;
								case 14:
									break;
									IL_0938:
									stream2 = (stream_0 = awaiter4.GetResult());
									break;
									IL_08d0:
									result2 = awaiter5.GetResult();
									awaiter4 = result2.Content.ReadAsStreamAsync().GetAwaiter();
									if (!awaiter4.IsCompleted)
									{
										num = 13;
										int_0 = 13;
										taskAwaiter_1 = awaiter4;
										asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter4, ref this);
										return;
									}
									goto IL_0938;
								}
								try
								{
									if (num != 14)
									{
										stream_1 = new FileStream(Class60.smethod_0(-2050210206), FileMode.Create, FileAccess.Write, FileShare.None);
									}
									try
									{
										TaskAwaiter awaiter6;
										if (num != 14)
										{
											awaiter6 = stream_0.CopyToAsync(stream_1).GetAwaiter();
											if (!awaiter6.IsCompleted)
											{
												num = 14;
												int_0 = 14;
												taskAwaiter_2 = awaiter6;
												asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter6, ref this);
												return;
											}
										}
										else
										{
											awaiter6 = taskAwaiter_2;
											taskAwaiter_2 = default(TaskAwaiter);
											num = -1;
											int_0 = -1;
										}
										awaiter6.GetResult();
									}
									finally
									{
										if (num < 0 && stream_1 != null)
										{
											((IDisposable)stream_1).Dispose();
										}
									}
								}
								finally
								{
									if (num < 0 && stream_0 != null)
									{
										((IDisposable)stream_0).Dispose();
									}
								}
								stream_0 = null;
								stream_1 = null;
							}
							finally
							{
								if (num < 0 && httpRequestMessage_0 != null)
								{
									((IDisposable)httpRequestMessage_0).Dispose();
								}
							}
							httpRequestMessage_0 = null;
							httpRequestMessage_0 = new HttpRequestMessage(HttpMethod.Get, Class60.smethod_0(-2050218794));
							break;
						case 15:
						case 16:
						case 17:
							break;
						}
						try
						{
							TaskAwaiter<HttpResponseMessage> awaiter17;
							TaskAwaiter<Stream> awaiter16;
							Stream stream6;
							HttpResponseMessage result6;
							switch (num)
							{
							default:
								awaiter17 = httpClient_0.SendAsync(httpRequestMessage_0).GetAwaiter();
								if (!awaiter17.IsCompleted)
								{
									num = 15;
									int_0 = 15;
									taskAwaiter_0 = awaiter17;
									asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter17, ref this);
									return;
								}
								goto IL_0acf;
							case 15:
								awaiter17 = taskAwaiter_0;
								taskAwaiter_0 = default(TaskAwaiter<HttpResponseMessage>);
								num = -1;
								int_0 = -1;
								goto IL_0acf;
							case 16:
								awaiter16 = taskAwaiter_1;
								taskAwaiter_1 = default(TaskAwaiter<Stream>);
								num = -1;
								int_0 = -1;
								goto IL_0b37;
							case 17:
								break;
								IL_0b37:
								stream6 = (stream_1 = awaiter16.GetResult());
								break;
								IL_0acf:
								result6 = awaiter17.GetResult();
								awaiter16 = result6.Content.ReadAsStreamAsync().GetAwaiter();
								if (!awaiter16.IsCompleted)
								{
									num = 16;
									int_0 = 16;
									taskAwaiter_1 = awaiter16;
									asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter16, ref this);
									return;
								}
								goto IL_0b37;
							}
							try
							{
								if (num != 17)
								{
									stream_0 = new FileStream(Class60.smethod_0(-2050210212), FileMode.Create, FileAccess.Write, FileShare.None);
								}
								try
								{
									TaskAwaiter awaiter18;
									if (num != 17)
									{
										awaiter18 = stream_1.CopyToAsync(stream_0).GetAwaiter();
										if (!awaiter18.IsCompleted)
										{
											num = 17;
											int_0 = 17;
											taskAwaiter_2 = awaiter18;
											asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter18, ref this);
											return;
										}
									}
									else
									{
										awaiter18 = taskAwaiter_2;
										taskAwaiter_2 = default(TaskAwaiter);
										num = -1;
										int_0 = -1;
									}
									awaiter18.GetResult();
								}
								finally
								{
									if (num < 0 && stream_0 != null)
									{
										((IDisposable)stream_0).Dispose();
									}
								}
							}
							finally
							{
								if (num < 0 && stream_1 != null)
								{
									((IDisposable)stream_1).Dispose();
								}
							}
							stream_1 = null;
							stream_0 = null;
						}
						finally
						{
							if (num < 0 && httpRequestMessage_0 != null)
							{
								((IDisposable)httpRequestMessage_0).Dispose();
							}
						}
						httpRequestMessage_0 = null;
					}
					finally
					{
						if (num < 0 && httpClient_0 != null)
						{
							((IDisposable)httpClient_0).Dispose();
						}
					}
					httpClient_0 = null;
				}
				catch
				{
				}
			}
			catch (Exception exception)
			{
				int_0 = -2;
				asyncVoidMethodBuilder_0.SetException(exception);
				return;
			}
			int_0 = -2;
			asyncVoidMethodBuilder_0.SetResult();
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			asyncVoidMethodBuilder_0.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	private struct Struct13 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncTaskMethodBuilder<DateTime> asyncTaskMethodBuilder_0;

		private HttpClient httpClient_0;

		private HttpResponseMessage httpResponseMessage_0;

		private TaskAwaiter<string> taskAwaiter_0;

		private void MoveNext()
		{
			int num = int_0;
			DateTime result;
			try
			{
				if (num != 0)
				{
					httpClient_0 = new HttpClient();
				}
				try
				{
					if (num != 0)
					{
						httpClient_0.BaseAddress = new Uri(Class60.smethod_0(-2050218299));
						httpClient_0.DefaultRequestHeaders.Accept.Clear();
						httpClient_0.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(Class60.smethod_0(-2050218332)));
						httpClient_0.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(Class60.smethod_0(-2050218357), string_0);
					}
					try
					{
						if (num != 0)
						{
							httpResponseMessage_0 = httpClient_0.GetAsync(Class60.smethod_0(-2050218423)).Result;
						}
						try
						{
							TaskAwaiter<string> awaiter;
							if (num == 0)
							{
								awaiter = taskAwaiter_0;
								taskAwaiter_0 = default(TaskAwaiter<string>);
								num = -1;
								int_0 = -1;
								goto IL_012e;
							}
							if (httpResponseMessage_0.IsSuccessStatusCode)
							{
								awaiter = httpResponseMessage_0.Content.ReadAsStringAsync().GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									num = 0;
									int_0 = 0;
									taskAwaiter_0 = awaiter;
									asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								}
								goto IL_012e;
							}
							result = DateTime.MinValue;
							goto end_IL_00b5;
							IL_012e:
							string result2 = awaiter.GetResult();
							string text = result2;
							GClass16 gClass = JsonConvert.DeserializeObject<GClass16>(text);
							result = gClass.Now;
							end_IL_00b5:;
						}
						finally
						{
							if (num < 0 && httpResponseMessage_0 != null)
							{
								((IDisposable)httpResponseMessage_0).Dispose();
							}
						}
					}
					catch
					{
						result = DateTime.MinValue;
					}
				}
				finally
				{
					if (num < 0 && httpClient_0 != null)
					{
						((IDisposable)httpClient_0).Dispose();
					}
				}
			}
			catch (Exception exception)
			{
				int_0 = -2;
				asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			int_0 = -2;
			asyncTaskMethodBuilder_0.SetResult(result);
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	private struct Struct14 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncTaskMethodBuilder<GClass1> asyncTaskMethodBuilder_0;

		public UserLogin userLogin_0;

		private HttpClient httpClient_0;

		private HttpResponseMessage httpResponseMessage_0;

		private TaskAwaiter<string> taskAwaiter_0;

		private TaskAwaiter<GClass1> taskAwaiter_1;

		private void MoveNext()
		{
			int num = int_0;
			GClass1 result;
			try
			{
				if ((uint)num > 1u)
				{
					httpClient_0 = new HttpClient();
				}
				try
				{
					if ((uint)num > 1u)
					{
						httpClient_0.BaseAddress = new Uri(Class60.smethod_0(-2050218299));
						httpClient_0.DefaultRequestHeaders.Accept.Clear();
						httpClient_0.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(Class60.smethod_0(-2050218332)));
					}
					try
					{
						if ((uint)num > 1u)
						{
							httpResponseMessage_0 = HttpClientExtensions.PostAsJsonAsync<UserLogin>(httpClient_0, Class60.smethod_0(-2050218849), userLogin_0).Result;
						}
						try
						{
							TaskAwaiter<string> awaiter;
							if (num == 0)
							{
								awaiter = taskAwaiter_0;
								taskAwaiter_0 = default(TaskAwaiter<string>);
								num = -1;
								int_0 = -1;
								goto IL_0184;
							}
							TaskAwaiter<GClass1> awaiter2;
							if (num == 1)
							{
								awaiter2 = taskAwaiter_1;
								taskAwaiter_1 = default(TaskAwaiter<GClass1>);
								num = -1;
								int_0 = -1;
								goto IL_01e9;
							}
							if (httpResponseMessage_0.IsSuccessStatusCode)
							{
								awaiter = httpResponseMessage_0.Content.ReadAsStringAsync().GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									num = 0;
									int_0 = 0;
									taskAwaiter_0 = awaiter;
									asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								}
								goto IL_0184;
							}
							if (httpResponseMessage_0.StatusCode.Equals(HttpStatusCode.BadRequest))
							{
								GClass1 gClass = new GClass1();
								gClass.DisplayName = Class60.smethod_0(-2050208239);
								result = gClass;
							}
							else
							{
								result = null;
							}
							goto end_IL_009a;
							IL_01e9:
							GClass1 result2 = awaiter2.GetResult();
							result = result2;
							goto end_IL_009a;
							IL_0184:
							string result3 = awaiter.GetResult();
							string text = result3;
							GClass1 gClass2 = JsonConvert.DeserializeObject<GClass1>(text);
							if (!string.IsNullOrEmpty(gClass2.Token))
							{
								string_0 = gClass2.Token;
								gClass2 = null;
								awaiter2 = smethod_2().GetAwaiter();
								if (!awaiter2.IsCompleted)
								{
									num = 1;
									int_0 = 1;
									taskAwaiter_1 = awaiter2;
									asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
									return;
								}
								goto IL_01e9;
							}
							result = null;
							end_IL_009a:;
						}
						finally
						{
							if (num < 0 && httpResponseMessage_0 != null)
							{
								((IDisposable)httpResponseMessage_0).Dispose();
							}
						}
					}
					catch
					{
						result = null;
					}
				}
				finally
				{
					if (num < 0 && httpClient_0 != null)
					{
						((IDisposable)httpClient_0).Dispose();
					}
				}
			}
			catch (Exception exception)
			{
				int_0 = -2;
				asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			int_0 = -2;
			asyncTaskMethodBuilder_0.SetResult(result);
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	private struct Struct15 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncTaskMethodBuilder<GClass12> asyncTaskMethodBuilder_0;

		public int int_1;

		private HttpClient httpClient_0;

		private HttpResponseMessage httpResponseMessage_0;

		private TaskAwaiter<string> taskAwaiter_0;

		private void MoveNext()
		{
			int num = int_0;
			GClass12 result;
			try
			{
				if (num != 0)
				{
					httpClient_0 = new HttpClient();
				}
				try
				{
					if (num != 0)
					{
						httpClient_0.BaseAddress = new Uri(Class60.smethod_0(-2050218299));
						httpClient_0.DefaultRequestHeaders.Accept.Clear();
						httpClient_0.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(Class60.smethod_0(-2050218332)));
						httpClient_0.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(Class60.smethod_0(-2050218357), string_0);
					}
					try
					{
						if (num != 0)
						{
							JsonData jsonData = new JsonData();
							jsonData.id = int_1;
							httpResponseMessage_0 = HttpClientExtensions.PostAsJsonAsync<JsonData>(httpClient_0, Class60.smethod_0(-2050218461), jsonData).Result;
						}
						try
						{
							TaskAwaiter<string> awaiter;
							if (num == 0)
							{
								awaiter = taskAwaiter_0;
								taskAwaiter_0 = default(TaskAwaiter<string>);
								num = -1;
								int_0 = -1;
								goto IL_0140;
							}
							if (httpResponseMessage_0.IsSuccessStatusCode)
							{
								awaiter = httpResponseMessage_0.Content.ReadAsStringAsync().GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									num = 0;
									int_0 = 0;
									taskAwaiter_0 = awaiter;
									asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								}
								goto IL_0140;
							}
							result = null;
							goto end_IL_00c8;
							IL_0140:
							string result2 = awaiter.GetResult();
							string text = result2;
							result = JsonConvert.DeserializeObject<GClass12>(Class55.smethod_6(text.Substring(1, text.Length - 2)));
							end_IL_00c8:;
						}
						finally
						{
							if (num < 0 && httpResponseMessage_0 != null)
							{
								((IDisposable)httpResponseMessage_0).Dispose();
							}
						}
					}
					catch
					{
						result = null;
					}
				}
				finally
				{
					if (num < 0 && httpClient_0 != null)
					{
						((IDisposable)httpClient_0).Dispose();
					}
				}
			}
			catch (Exception exception)
			{
				int_0 = -2;
				asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			int_0 = -2;
			asyncTaskMethodBuilder_0.SetResult(result);
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	private struct Struct16 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncTaskMethodBuilder<GClass5> asyncTaskMethodBuilder_0;

		private HttpClient httpClient_0;

		private HttpResponseMessage httpResponseMessage_0;

		private TaskAwaiter<string> taskAwaiter_0;

		private void MoveNext()
		{
			int num = int_0;
			GClass5 result;
			try
			{
				if (num != 0)
				{
					httpClient_0 = new HttpClient();
				}
				try
				{
					if (num != 0)
					{
						httpClient_0.BaseAddress = new Uri(Class60.smethod_0(-2050218299));
						httpClient_0.DefaultRequestHeaders.Accept.Clear();
						httpClient_0.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(Class60.smethod_0(-2050218332)));
						httpClient_0.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(Class60.smethod_0(-2050218357), string_0);
					}
					try
					{
						if (num != 0)
						{
							JsonData jsonData = new JsonData();
							jsonData.id = GClass6.int_0;
							httpResponseMessage_0 = HttpClientExtensions.PostAsJsonAsync<JsonData>(httpClient_0, Class60.smethod_0(-2050218416), jsonData).Result;
						}
						try
						{
							TaskAwaiter<string> awaiter;
							if (num == 0)
							{
								awaiter = taskAwaiter_0;
								taskAwaiter_0 = default(TaskAwaiter<string>);
								num = -1;
								int_0 = -1;
								goto IL_013c;
							}
							if (httpResponseMessage_0.IsSuccessStatusCode)
							{
								awaiter = httpResponseMessage_0.Content.ReadAsStringAsync().GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									num = 0;
									int_0 = 0;
									taskAwaiter_0 = awaiter;
									asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								}
								goto IL_013c;
							}
							result = null;
							goto end_IL_00c7;
							IL_013c:
							string result2 = awaiter.GetResult();
							string text = result2;
							result = JsonConvert.DeserializeObject<GClass5>(text);
							end_IL_00c7:;
						}
						finally
						{
							if (num < 0 && httpResponseMessage_0 != null)
							{
								((IDisposable)httpResponseMessage_0).Dispose();
							}
						}
					}
					catch
					{
						result = null;
					}
				}
				finally
				{
					if (num < 0 && httpClient_0 != null)
					{
						((IDisposable)httpClient_0).Dispose();
					}
				}
			}
			catch (Exception exception)
			{
				int_0 = -2;
				asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			int_0 = -2;
			asyncTaskMethodBuilder_0.SetResult(result);
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	private struct Struct17 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncTaskMethodBuilder<GClass15> asyncTaskMethodBuilder_0;

		private HttpClient httpClient_0;

		private HttpResponseMessage httpResponseMessage_0;

		private TaskAwaiter<string> taskAwaiter_0;

		private void MoveNext()
		{
			int num = int_0;
			GClass15 result;
			try
			{
				if (num != 0)
				{
					httpClient_0 = new HttpClient();
				}
				try
				{
					if (num != 0)
					{
						httpClient_0.BaseAddress = new Uri(Class60.smethod_0(-2050218299));
						httpClient_0.DefaultRequestHeaders.Accept.Clear();
						httpClient_0.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(Class60.smethod_0(-2050218332)));
						httpClient_0.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(Class60.smethod_0(-2050218357), string_0);
					}
					try
					{
						if (num != 0)
						{
							JsonData jsonData = new JsonData();
							jsonData.id = GClass6.int_0;
							httpResponseMessage_0 = HttpClientExtensions.PostAsJsonAsync<JsonData>(httpClient_0, Class60.smethod_0(-2050218483), jsonData).Result;
						}
						try
						{
							TaskAwaiter<string> awaiter;
							if (num == 0)
							{
								awaiter = taskAwaiter_0;
								taskAwaiter_0 = default(TaskAwaiter<string>);
								num = -1;
								int_0 = -1;
								goto IL_013c;
							}
							if (httpResponseMessage_0.IsSuccessStatusCode)
							{
								awaiter = httpResponseMessage_0.Content.ReadAsStringAsync().GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									num = 0;
									int_0 = 0;
									taskAwaiter_0 = awaiter;
									asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								}
								goto IL_013c;
							}
							result = null;
							goto end_IL_00c7;
							IL_013c:
							string result2 = awaiter.GetResult();
							string text = result2;
							result = JsonConvert.DeserializeObject<GClass15>(text);
							end_IL_00c7:;
						}
						finally
						{
							if (num < 0 && httpResponseMessage_0 != null)
							{
								((IDisposable)httpResponseMessage_0).Dispose();
							}
						}
					}
					catch
					{
						result = null;
					}
				}
				finally
				{
					if (num < 0 && httpClient_0 != null)
					{
						((IDisposable)httpClient_0).Dispose();
					}
				}
			}
			catch (Exception exception)
			{
				int_0 = -2;
				asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			int_0 = -2;
			asyncTaskMethodBuilder_0.SetResult(result);
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	private struct Struct18 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncTaskMethodBuilder<List<GClass9>> asyncTaskMethodBuilder_0;

		private HttpClient httpClient_0;

		private HttpResponseMessage httpResponseMessage_0;

		private TaskAwaiter<string> taskAwaiter_0;

		private void MoveNext()
		{
			int num = int_0;
			List<GClass9> result;
			try
			{
				if (num != 0)
				{
					httpClient_0 = new HttpClient();
				}
				try
				{
					if (num != 0)
					{
						httpClient_0.BaseAddress = new Uri(Class60.smethod_0(-2050218299));
						httpClient_0.DefaultRequestHeaders.Accept.Clear();
						httpClient_0.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(Class60.smethod_0(-2050218332)));
						httpClient_0.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(Class60.smethod_0(-2050218357), string_0);
					}
					try
					{
						if (num != 0)
						{
							httpResponseMessage_0 = httpClient_0.GetAsync(Class60.smethod_0(-2050218480)).Result;
						}
						try
						{
							TaskAwaiter<string> awaiter;
							if (num == 0)
							{
								awaiter = taskAwaiter_0;
								taskAwaiter_0 = default(TaskAwaiter<string>);
								num = -1;
								int_0 = -1;
								goto IL_0127;
							}
							if (httpResponseMessage_0.IsSuccessStatusCode)
							{
								awaiter = httpResponseMessage_0.Content.ReadAsStringAsync().GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									num = 0;
									int_0 = 0;
									taskAwaiter_0 = awaiter;
									asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								}
								goto IL_0127;
							}
							result = null;
							goto end_IL_00b5;
							IL_0127:
							string result2 = awaiter.GetResult();
							string text = result2;
							result = JsonConvert.DeserializeObject<List<GClass9>>(text);
							end_IL_00b5:;
						}
						finally
						{
							if (num < 0 && httpResponseMessage_0 != null)
							{
								((IDisposable)httpResponseMessage_0).Dispose();
							}
						}
					}
					catch
					{
						result = null;
					}
				}
				finally
				{
					if (num < 0 && httpClient_0 != null)
					{
						((IDisposable)httpClient_0).Dispose();
					}
				}
			}
			catch (Exception exception)
			{
				int_0 = -2;
				asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			int_0 = -2;
			asyncTaskMethodBuilder_0.SetResult(result);
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	private static int int_0 = 1;

	private static string string_0;

	public static int smethod_0()
	{
		return int_0;
	}

	public static async Task<GClass1> smethod_1(UserLogin userLogin_0)
	{
		using HttpClient httpClient = new HttpClient();
		httpClient.BaseAddress = new Uri(Class60.smethod_0(-2050218299));
		httpClient.DefaultRequestHeaders.Accept.Clear();
		httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(Class60.smethod_0(-2050218332)));
		try
		{
			using HttpResponseMessage httpResponseMessage = HttpClientExtensions.PostAsJsonAsync<UserLogin>(httpClient, Class60.smethod_0(-2050218849), userLogin_0).Result;
			if (!httpResponseMessage.IsSuccessStatusCode)
			{
				if (httpResponseMessage.StatusCode.Equals(HttpStatusCode.BadRequest))
				{
					GClass1 gClass = new GClass1();
					gClass.DisplayName = Class60.smethod_0(-2050208239);
					return gClass;
				}
				return null;
			}
			GClass1 gClass2 = JsonConvert.DeserializeObject<GClass1>(await httpResponseMessage.Content.ReadAsStringAsync());
			if (!string.IsNullOrEmpty(gClass2.Token))
			{
				string_0 = gClass2.Token;
				return await smethod_2();
			}
			return null;
		}
		catch
		{
			return null;
		}
	}

	public static async Task<GClass1> smethod_2()
	{
		using HttpClient httpClient = new HttpClient();
		httpClient.BaseAddress = new Uri(Class60.smethod_0(-2050218299));
		httpClient.DefaultRequestHeaders.Accept.Clear();
		httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(Class60.smethod_0(-2050218332)));
		httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(Class60.smethod_0(-2050218357), string_0);
		try
		{
			using HttpResponseMessage httpResponseMessage = httpClient.GetAsync(Class60.smethod_0(-2050218503)).Result;
			if (!httpResponseMessage.IsSuccessStatusCode)
			{
				return null;
			}
			return JsonConvert.DeserializeObject<GClass1>(await httpResponseMessage.Content.ReadAsStringAsync());
		}
		catch
		{
			return null;
		}
	}

	public static async Task<GClass15> smethod_3()
	{
		using HttpClient httpClient = new HttpClient();
		httpClient.BaseAddress = new Uri(Class60.smethod_0(-2050218299));
		httpClient.DefaultRequestHeaders.Accept.Clear();
		httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(Class60.smethod_0(-2050218332)));
		httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(Class60.smethod_0(-2050218357), string_0);
		try
		{
			JsonData jsonData = new JsonData();
			jsonData.id = int_0;
			using HttpResponseMessage httpResponseMessage = HttpClientExtensions.PostAsJsonAsync<JsonData>(httpClient, Class60.smethod_0(-2050218483), jsonData).Result;
			if (!httpResponseMessage.IsSuccessStatusCode)
			{
				return null;
			}
			return JsonConvert.DeserializeObject<GClass15>(await httpResponseMessage.Content.ReadAsStringAsync());
		}
		catch
		{
			return null;
		}
	}

	public static async Task<List<GClass9>> smethod_4()
	{
		using HttpClient httpClient = new HttpClient();
		httpClient.BaseAddress = new Uri(Class60.smethod_0(-2050218299));
		httpClient.DefaultRequestHeaders.Accept.Clear();
		httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(Class60.smethod_0(-2050218332)));
		httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(Class60.smethod_0(-2050218357), string_0);
		try
		{
			using HttpResponseMessage httpResponseMessage = httpClient.GetAsync(Class60.smethod_0(-2050218480)).Result;
			if (!httpResponseMessage.IsSuccessStatusCode)
			{
				return null;
			}
			return JsonConvert.DeserializeObject<List<GClass9>>(await httpResponseMessage.Content.ReadAsStringAsync());
		}
		catch
		{
			return null;
		}
	}

	public static async Task<GClass12> smethod_5(int int_1)
	{
		using HttpClient httpClient = new HttpClient();
		httpClient.BaseAddress = new Uri(Class60.smethod_0(-2050218299));
		httpClient.DefaultRequestHeaders.Accept.Clear();
		httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(Class60.smethod_0(-2050218332)));
		httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(Class60.smethod_0(-2050218357), string_0);
		try
		{
			JsonData jsonData = new JsonData();
			jsonData.id = int_1;
			using HttpResponseMessage httpResponseMessage = HttpClientExtensions.PostAsJsonAsync<JsonData>(httpClient, Class60.smethod_0(-2050218461), jsonData).Result;
			if (!httpResponseMessage.IsSuccessStatusCode)
			{
				return null;
			}
			string text = await httpResponseMessage.Content.ReadAsStringAsync();
			return JsonConvert.DeserializeObject<GClass12>(Class55.smethod_6(text.Substring(1, text.Length - 2)));
		}
		catch
		{
			return null;
		}
	}

	public static async Task<List<GClass0>> smethod_6()
	{
		using HttpClient httpClient = new HttpClient();
		httpClient.BaseAddress = new Uri(Class60.smethod_0(-2050218299));
		httpClient.DefaultRequestHeaders.Accept.Clear();
		httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(Class60.smethod_0(-2050218332)));
		httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(Class60.smethod_0(-2050218357), string_0);
		try
		{
			using HttpResponseMessage httpResponseMessage = httpClient.GetAsync(Class60.smethod_0(-2050218344)).Result;
			if (!httpResponseMessage.IsSuccessStatusCode)
			{
				return null;
			}
			string text = await httpResponseMessage.Content.ReadAsStringAsync();
			return JsonConvert.DeserializeObject<List<GClass0>>(Class55.smethod_6(text.Substring(1, text.Length - 2)));
		}
		catch
		{
			return null;
		}
	}

	public static async Task<List<GClass3>> smethod_7()
	{
		using HttpClient httpClient = new HttpClient();
		httpClient.BaseAddress = new Uri(Class60.smethod_0(-2050218299));
		httpClient.DefaultRequestHeaders.Accept.Clear();
		httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(Class60.smethod_0(-2050218332)));
		httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(Class60.smethod_0(-2050218357), string_0);
		try
		{
			using HttpResponseMessage httpResponseMessage = httpClient.GetAsync(Class60.smethod_0(-2050218385)).Result;
			if (!httpResponseMessage.IsSuccessStatusCode)
			{
				return null;
			}
			string text = await httpResponseMessage.Content.ReadAsStringAsync();
			return JsonConvert.DeserializeObject<List<GClass3>>(Class55.smethod_6(text.Substring(1, text.Length - 2)));
		}
		catch
		{
			return null;
		}
	}

	public static async Task<GClass5> smethod_8()
	{
		using HttpClient httpClient = new HttpClient();
		httpClient.BaseAddress = new Uri(Class60.smethod_0(-2050218299));
		httpClient.DefaultRequestHeaders.Accept.Clear();
		httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(Class60.smethod_0(-2050218332)));
		httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(Class60.smethod_0(-2050218357), string_0);
		try
		{
			JsonData jsonData = new JsonData();
			jsonData.id = int_0;
			using HttpResponseMessage httpResponseMessage = HttpClientExtensions.PostAsJsonAsync<JsonData>(httpClient, Class60.smethod_0(-2050218416), jsonData).Result;
			if (!httpResponseMessage.IsSuccessStatusCode)
			{
				return null;
			}
			return JsonConvert.DeserializeObject<GClass5>(await httpResponseMessage.Content.ReadAsStringAsync());
		}
		catch
		{
			return null;
		}
	}

	public static async Task<DateTime> smethod_9()
	{
		using HttpClient httpClient = new HttpClient();
		httpClient.BaseAddress = new Uri(Class60.smethod_0(-2050218299));
		httpClient.DefaultRequestHeaders.Accept.Clear();
		httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(Class60.smethod_0(-2050218332)));
		httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(Class60.smethod_0(-2050218357), string_0);
		try
		{
			using HttpResponseMessage httpResponseMessage = httpClient.GetAsync(Class60.smethod_0(-2050218423)).Result;
			if (!httpResponseMessage.IsSuccessStatusCode)
			{
				return DateTime.MinValue;
			}
			GClass16 gClass = JsonConvert.DeserializeObject<GClass16>(await httpResponseMessage.Content.ReadAsStringAsync());
			return gClass.Now;
		}
		catch
		{
			return DateTime.MinValue;
		}
	}

	public static async void smethod_10()
	{
		try
		{
			using HttpClient httpClient = new HttpClient();
			using (HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, Class60.smethod_0(-2050218560)))
			{
				using Stream stream = await (await httpClient.SendAsync(request)).Content.ReadAsStreamAsync();
				using Stream destination = new FileStream(Class60.smethod_0(-2050210047), FileMode.Create, FileAccess.Write, FileShare.None);
				await stream.CopyToAsync(destination);
			}
			using (HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, Class60.smethod_0(-2050218570)))
			{
				using Stream destination = await (await httpClient.SendAsync(request)).Content.ReadAsStreamAsync();
				using Stream stream = new FileStream(Class60.smethod_0(-2050210056), FileMode.Create, FileAccess.Write, FileShare.None);
				await destination.CopyToAsync(stream);
			}
			using (HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, Class60.smethod_0(-2050218626)))
			{
				using Stream stream = await (await httpClient.SendAsync(request)).Content.ReadAsStreamAsync();
				using Stream destination = new FileStream(Class60.smethod_0(-2050210095), FileMode.Create, FileAccess.Write, FileShare.None);
				await stream.CopyToAsync(destination);
			}
			using (HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, Class60.smethod_0(-2050218714)))
			{
				using Stream destination = await (await httpClient.SendAsync(request)).Content.ReadAsStreamAsync();
				using Stream stream = new FileStream(Class60.smethod_0(-2050210166), FileMode.Create, FileAccess.Write, FileShare.None);
				await destination.CopyToAsync(stream);
			}
			using (HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, Class60.smethod_0(-2050218771)))
			{
				using Stream stream = await (await httpClient.SendAsync(request)).Content.ReadAsStreamAsync();
				using Stream destination = new FileStream(Class60.smethod_0(-2050210206), FileMode.Create, FileAccess.Write, FileShare.None);
				await stream.CopyToAsync(destination);
			}
			using HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, Class60.smethod_0(-2050218794));
			using Stream destination = await (await httpClient.SendAsync(request)).Content.ReadAsStreamAsync();
			using Stream stream = new FileStream(Class60.smethod_0(-2050210212), FileMode.Create, FileAccess.Write, FileShare.None);
			await destination.CopyToAsync(stream);
		}
		catch
		{
		}
	}
}
