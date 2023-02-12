using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;
using MPOST;
using M_POST_for_EBDS_Demo_In_CSharp_DotNet.Properties;

namespace M_POST_for_EBDS_Demo_In_CSharp_DotNet
{
	// Token: 0x02000010 RID: 16
	public partial class Main : Form
	{
		// Token: 0x060000D0 RID: 208 RVA: 0x0000B447 File Offset: 0x00009647
		public void SetPortName(string port_name)
		{
			this.ComPortName = port_name;
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x0000B454 File Offset: 0x00009654
		public string GetPortName()
		{
			return this.ComPortName;
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x0000B46C File Offset: 0x0000966C
		public void SetUser(clsUsers value)
		{
			this.objUser = value;
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x0000B478 File Offset: 0x00009678
		public Main()
		{
			this.InitializeComponent();
			this.CalibrateFinishDelegate = new CalibrateFinishEventHandler(this.HandleCalibrateFinishEvent);
			this.CalibrateProgressDelegate = new CalibrateProgressEventHandler(this.HandleCalibrateProgressEvent);
			this.CalibrateStartDelegate = new CalibrateStartEventHandler(this.HandleCalibrateStartEvent);
			this.CashBoxCleanlinessDelegate = new CashBoxCleanlinessEventHandler(this.HandleCashBoxCleanlinessEvent);
			this.CashBoxAttachedDelegate = new CashBoxAttachedEventHandler(this.HandleCashBoxAttachedEvent);
			this.CashBoxRemovedDelegate = new CashBoxRemovedEventHandler(this.HandleCashBoxRemovedEvent);
			this.CheatedDelegate = new CheatedEventHandler(this.HandleCheatedEvent);
			this.ClearAuditDelegate = new ClearAuditEventHandler(this.HandleClearAuditEvent);
			this.ConnectedDelegate = new ConnectedEventHandler(this.HandleConnectedEvent);
			this.DisconnectedDelegate = new DisconnectedEventHandler(this.HandleDisconnectedEvent);
			this.DownloadFinishDelegate = new DownloadFinishEventHandler(this.HandleDownloadFinishEvent);
			this.DownloadProgressDelegate = new DownloadProgressEventHandler(this.HandleDownloadProgressEvent);
			this.DownloadRestartDelegate = new DownloadRestartEventHandler(this.HandleDownloadRestartEvent);
			this.DownloadStartDelegate = new DownloadStartEventHandler(this.HandleDownloadStartEvent);
			this.ErrorOnSendMessageDelegate = new ErrorOnSendMessageEventHandler(this.HandleSendMessageErrorEvent);
			this.EscrowedDelegate = new EscrowEventHandler(this.HandleEscrowedEvent);
			this.FailureClearedDelegate = new FailureClearedEventHandler(this.HandleFailureClearedEvent);
			this.FailureDetectedDelegate = new FailureDetectedEventHandler(this.HandleFailureDetectedEvent);
			this.InvalidCommandDelegate = new InvalidCommandEventHandler(this.HandleInvalidCommandEvent);
			this.JamClearedDelegate = new JamClearedEventHandler(this.HandleJamClearedEvent);
			this.JamDetectedDelegate = new JamDetectedEventHandler(this.HandleJamDetectedEvent);
			this.NoteRetrievedDelegate = new NoteRetrievedEventHandler(this.HandleNoteRetrievedEvent);
			this.PauseClearedDelegate = new PauseClearedEventHandler(this.HandlePauseClearedEvent);
			this.PauseDetectedDelegate = new PauseDetectedEventHandler(this.HandlePauseDetectedEvent);
			this.PowerUpCompleteDelegate = new PowerUpCompleteEventHandler(this.HandlePowerUpCompleteEvent);
			this.PowerUpDelegate = new PowerUpEventHandler(this.HandlePowerUpEvent);
			this.PUPEscrowDelegate = new PUPEscrowEventHandler(this.HandlePUPEscrowEvent);
			this.RejectedDelegate = new RejectedEventHandler(this.HandleRejectedEvent);
			this.ReturnedDelegate = new ReturnedEventHandler(this.HandleReturnedEvent);
			this.StackedDelegate = new StackedEventHandler(this.HandleStackedEvent);
			this.StackedWithDocInfoDelegate = new StackedWithDocInfoEventHandler(this.HandleStackedWithDocInfoEvent);
			this.StackerFullClearedDelegate = new StackerFullClearedEventHandler(this.HandleStackerFullClearedEvent);
			this.StackerFullDelegate = new StackerFullEventHandler(this.HandleStackerFullEvent);
			this.StallClearedDelegate = new StallClearedEventHandler(this.HandleStallClearedEvent);
			this.StallDetectedDelegate = new StallDetectedEventHandler(this.HandleStallDetectedEvent);
			this.BillAcceptor.OnCalibrateFinish += this.CalibrateFinishDelegate;
			this.BillAcceptor.OnCalibrateProgress += this.CalibrateProgressDelegate;
			this.BillAcceptor.OnCalibrateStart += this.CalibrateStartDelegate;
			this.BillAcceptor.OnCashBoxCleanlinessDetected += this.CashBoxCleanlinessDelegate;
			this.BillAcceptor.OnCashBoxAttached += this.CashBoxAttachedDelegate;
			this.BillAcceptor.OnCashBoxRemoved += this.CashBoxRemovedDelegate;
			this.BillAcceptor.OnCheated += this.CheatedDelegate;
			this.BillAcceptor.OnClearAuditComplete += this.ClearAuditDelegate;
			this.BillAcceptor.OnConnected += this.ConnectedDelegate;
			this.BillAcceptor.OnDisconnected += this.DisconnectedDelegate;
			this.BillAcceptor.OnDownloadFinish += this.DownloadFinishDelegate;
			this.BillAcceptor.OnDownloadProgress += this.DownloadProgressDelegate;
			this.BillAcceptor.OnDownloadRestart += this.DownloadRestartDelegate;
			this.BillAcceptor.OnDownloadStart += this.DownloadStartDelegate;
			this.BillAcceptor.OnSendMessageFailure += this.ErrorOnSendMessageDelegate;
			this.BillAcceptor.OnEscrow += this.EscrowedDelegate;
			this.BillAcceptor.OnFailureCleared += this.FailureClearedDelegate;
			this.BillAcceptor.OnFailureDetected += this.FailureDetectedDelegate;
			this.BillAcceptor.OnInvalidCommand += this.InvalidCommandDelegate;
			this.BillAcceptor.OnJamCleared += this.JamClearedDelegate;
			this.BillAcceptor.OnJamDetected += this.JamDetectedDelegate;
			this.BillAcceptor.OnNoteRetrieved += this.NoteRetrievedDelegate;
			this.BillAcceptor.OnPauseCleared += this.PauseClearedDelegate;
			this.BillAcceptor.OnPauseDetected += this.PauseDetectedDelegate;
			this.BillAcceptor.OnPowerUpComplete += this.PowerUpCompleteDelegate;
			this.BillAcceptor.OnPowerUp += this.PowerUpDelegate;
			this.BillAcceptor.OnPUPEscrow += this.PUPEscrowDelegate;
			this.BillAcceptor.OnRejected += this.RejectedDelegate;
			this.BillAcceptor.OnReturned += this.ReturnedDelegate;
			this.BillAcceptor.OnStacked += this.StackedDelegate;
			this.BillAcceptor.OnStackedWithDocInfo += this.StackedWithDocInfoDelegate;
			this.BillAcceptor.OnStackerFullCleared += this.StackerFullClearedDelegate;
			this.BillAcceptor.OnStackerFull += this.StackerFullDelegate;
			this.BillAcceptor.OnStallCleared += this.StallClearedDelegate;
			this.BillAcceptor.OnStallDetected += this.StallDetectedDelegate;
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x0000B9BC File Offset: 0x00009BBC
		private void ListEvent(string e)
		{
			Console.Write(e);
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x0000B9C8 File Offset: 0x00009BC8
		private string DocInfoToString(DocumentType docType, IDocument doc)
		{
			bool flag = docType == 0;
			string text;
			if (flag)
			{
				text = "Doc Type: None";
			}
			else
			{
				bool flag2 = docType == 1;
				if (flag2)
				{
					text = "Doc Type: No Value";
				}
				else
				{
					bool flag3 = docType == 2;
					if (flag3)
					{
						bool flag4 = doc == null;
						if (flag4)
						{
							text = "Doc Type Bill = null";
						}
						else
						{
							bool flag5 = !this.BillAcceptor.CapOrientationExt;
							if (flag5)
							{
								text = "Doc Type Bill = " + doc.ToString();
							}
							else
							{
								text = string.Concat(new string[]
								{
									"Doc Type Bill = ",
									doc.ToString(),
									" (",
									this.BillAcceptor.EscrowOrientation.ToString(),
									")"
								});
							}
						}
					}
					else
					{
						bool flag6 = docType == 3;
						if (flag6)
						{
							bool flag7 = doc == null;
							if (flag7)
							{
								text = "Doc Type Bar Code = null";
							}
							else
							{
								text = "Doc Type Bar Code = " + doc.ToString();
							}
						}
						else
						{
							bool flag8 = docType == 4;
							if (flag8)
							{
								bool flag9 = doc == null;
								if (flag9)
								{
									text = "Doc Type Coupon = null";
								}
								else
								{
									text = "Doc Type Coupon = " + doc.ToString();
								}
							}
							else
							{
								text = "Unknown Doc Type Error";
							}
						}
					}
				}
			}
			return text;
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x0000BAFC File Offset: 0x00009CFC
		private void HandleCalibrateFinishEvent(object sender, EventArgs e)
		{
			bool invokeRequired = base.InvokeRequired;
			if (invokeRequired)
			{
				base.BeginInvoke(this.CalibrateFinishDelegate, new object[] { sender, e });
			}
			else
			{
				this.ListEvent("Event: Calibrate Finish.");
			}
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x0000BB44 File Offset: 0x00009D44
		private void HandleCalibrateProgressEvent(object sender, EventArgs e)
		{
			bool invokeRequired = base.InvokeRequired;
			if (invokeRequired)
			{
				base.BeginInvoke(this.CalibrateProgressDelegate, new object[] { sender, e });
			}
			else
			{
				this.ListEvent("Event: Calibrate Progress.");
			}
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x0000BB8C File Offset: 0x00009D8C
		private void HandleCalibrateStartEvent(object sender, EventArgs e)
		{
			bool invokeRequired = base.InvokeRequired;
			if (invokeRequired)
			{
				base.BeginInvoke(this.CalibrateStartDelegate, new object[] { sender, e });
			}
			else
			{
				this.ListEvent("Event: Calibrate Start.");
			}
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x0000BBD4 File Offset: 0x00009DD4
		private void HandleCashBoxCleanlinessEvent(object sender, CashBoxCleanlinessEventArgs e)
		{
			bool invokeRequired = base.InvokeRequired;
			if (invokeRequired)
			{
				base.BeginInvoke(this.CashBoxCleanlinessDelegate, new object[] { sender, e });
			}
			else
			{
				this.ListEvent(string.Format("Event: Cashbox Cleanliness - {0}", e.Value.ToString()));
			}
		}

		// Token: 0x060000DA RID: 218 RVA: 0x0000BC34 File Offset: 0x00009E34
		private void HandleCashBoxAttachedEvent(object sender, EventArgs e)
		{
			bool invokeRequired = base.InvokeRequired;
			if (invokeRequired)
			{
				base.BeginInvoke(this.CashBoxAttachedDelegate, new object[] { sender, e });
			}
			else
			{
				this.ListEvent("Event: Cassette Installed.");
			}
		}

		// Token: 0x060000DB RID: 219 RVA: 0x0000BC7C File Offset: 0x00009E7C
		private void HandleCashBoxRemovedEvent(object sender, EventArgs e)
		{
			bool invokeRequired = base.InvokeRequired;
			if (invokeRequired)
			{
				base.BeginInvoke(this.CashBoxRemovedDelegate, new object[] { sender, e });
			}
			else
			{
				this.ListEvent("Event: Cassette Removed.");
			}
		}

		// Token: 0x060000DC RID: 220 RVA: 0x0000BCC4 File Offset: 0x00009EC4
		private void HandleCheatedEvent(object sender, EventArgs e)
		{
			bool invokeRequired = base.InvokeRequired;
			if (invokeRequired)
			{
				base.BeginInvoke(this.CheatedDelegate, new object[] { sender, e });
			}
			else
			{
				this.ListEvent("Event: Cheat Detected.");
			}
		}

		// Token: 0x060000DD RID: 221 RVA: 0x0000BD0C File Offset: 0x00009F0C
		private void HandleClearAuditEvent(object sender, ClearAuditEventArgs e)
		{
			bool invokeRequired = base.InvokeRequired;
			if (invokeRequired)
			{
				base.BeginInvoke(this.ClearAuditDelegate, new object[] { sender, e });
			}
			else
			{
				bool success = e.Success;
				if (success)
				{
					this.ListEvent("Event: Clear Audit Complete: Success");
				}
				else
				{
					this.ListEvent("Event: Clear Audit Complete: FAILED");
				}
			}
		}

		// Token: 0x060000DE RID: 222 RVA: 0x0000BD70 File Offset: 0x00009F70
		private void HandleConnectedEvent(object sender, EventArgs e)
		{
			bool invokeRequired = base.InvokeRequired;
			if (invokeRequired)
			{
				base.BeginInvoke(this.ConnectedDelegate, new object[] { sender, e });
			}
			else
			{
				this.BillAcceptor.EnableAcceptance = true;
				this.BillAcceptor.AutoStack = true;
				this.ListEvent("Event: Connected.");
			}
		}

		// Token: 0x060000DF RID: 223 RVA: 0x0000BDD0 File Offset: 0x00009FD0
		private void HandleDisconnectedEvent(object sender, EventArgs e)
		{
			bool invokeRequired = base.InvokeRequired;
			if (invokeRequired)
			{
				base.BeginInvoke(this.DisconnectedDelegate, new object[] { sender, e });
			}
			else
			{
				this.ListEvent("Event: Disconnected.");
			}
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x0000BE18 File Offset: 0x0000A018
		private void HandleDownloadFinishEvent(object sender, AcceptorDownloadFinishEventArgs e)
		{
			bool invokeRequired = base.InvokeRequired;
			if (invokeRequired)
			{
				base.BeginInvoke(this.DownloadFinishDelegate, new object[] { sender, e });
			}
			else
			{
				bool success = e.Success;
				if (success)
				{
					this.ListEvent("Event: Download Finished: OK");
				}
				else
				{
					this.ListEvent("Event: Download Finished: FAILED");
				}
			}
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x0000BE7C File Offset: 0x0000A07C
		private void HandleDownloadProgressEvent(object sender, AcceptorDownloadEventArgs e)
		{
			bool invokeRequired = base.InvokeRequired;
			if (invokeRequired)
			{
				base.BeginInvoke(this.DownloadProgressDelegate, new object[] { sender, e });
			}
			else
			{
				bool flag = e.SectorCount % 100 == 0;
				if (flag)
				{
					this.ListEvent("Event: Download Progress:" + e.SectorCount.ToString());
				}
			}
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x0000BEE8 File Offset: 0x0000A0E8
		private void HandleDownloadRestartEvent(object sender, EventArgs e)
		{
			bool invokeRequired = base.InvokeRequired;
			if (invokeRequired)
			{
				base.BeginInvoke(this.DownloadRestartDelegate, new object[] { sender, e });
			}
			else
			{
				this.ListEvent("Event: Download Restart.");
			}
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x0000BF30 File Offset: 0x0000A130
		private void HandleDownloadStartEvent(object sender, AcceptorDownloadEventArgs e)
		{
			bool invokeRequired = base.InvokeRequired;
			if (invokeRequired)
			{
				base.BeginInvoke(this.DownloadStartDelegate, new object[] { sender, e });
			}
			else
			{
				this.ListEvent("Event: Download Start. Total Sectors: " + e.SectorCount.ToString());
			}
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x0000BF88 File Offset: 0x0000A188
		private void HandleSendMessageErrorEvent(object sender, AcceptorMessageEventArgs e)
		{
			bool invokeRequired = base.InvokeRequired;
			if (invokeRequired)
			{
				base.BeginInvoke(this.ErrorOnSendMessageDelegate, new object[] { sender, e });
			}
			else
			{
				StringBuilder stringBuilder = new StringBuilder();
				stringBuilder.Append("Event: Error in send message. ");
				stringBuilder.Append(e.Msg.Description);
				stringBuilder.Append("  ");
				foreach (byte b in e.Msg.Payload)
				{
					stringBuilder.Append(b.ToString("X2") + " ");
				}
				this.ListEvent(stringBuilder.ToString());
				bool flag = this.BillAcceptor.DeviceState == 5;
				if (flag)
				{
				}
			}
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x0000C058 File Offset: 0x0000A258
		private void HandleEscrowedEvent(object sender, EventArgs e)
		{
			bool invokeRequired = base.InvokeRequired;
			if (invokeRequired)
			{
				base.BeginInvoke(this.EscrowedDelegate, new object[] { sender, e });
			}
			else
			{
				this.ListEvent("Event: Escrowed: " + this.DocInfoToString(this.BillAcceptor.DocType, this.BillAcceptor.getDocument()));
			}
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x0000C0C0 File Offset: 0x0000A2C0
		private void HandleFailureClearedEvent(object sender, EventArgs e)
		{
			bool invokeRequired = base.InvokeRequired;
			if (invokeRequired)
			{
				base.BeginInvoke(this.FailureClearedDelegate, new object[] { sender, e });
			}
			else
			{
				this.ListEvent("Event: Device Failure Cleared. ");
			}
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x0000C108 File Offset: 0x0000A308
		private void HandleFailureDetectedEvent(object sender, EventArgs e)
		{
			bool invokeRequired = base.InvokeRequired;
			if (invokeRequired)
			{
				base.BeginInvoke(this.FailureDetectedDelegate, new object[] { sender, e });
			}
			else
			{
				this.ListEvent("Event: Device Failure Detected. ");
			}
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x0000C150 File Offset: 0x0000A350
		private void HandleInvalidCommandEvent(object sender, EventArgs e)
		{
			bool invokeRequired = base.InvokeRequired;
			if (invokeRequired)
			{
				base.BeginInvoke(this.InvalidCommandDelegate, new object[] { sender, e });
			}
			else
			{
				this.ListEvent("Event: Invalid Command.");
			}
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x0000C198 File Offset: 0x0000A398
		private void HandleJamClearedEvent(object sender, EventArgs e)
		{
			bool invokeRequired = base.InvokeRequired;
			if (invokeRequired)
			{
				base.BeginInvoke(this.JamClearedDelegate, new object[] { sender, e });
			}
			else
			{
				this.ListEvent("Event: Jam Cleared.");
			}
		}

		// Token: 0x060000EA RID: 234 RVA: 0x0000C1E0 File Offset: 0x0000A3E0
		private void HandleJamDetectedEvent(object sender, EventArgs e)
		{
			bool invokeRequired = base.InvokeRequired;
			if (invokeRequired)
			{
				base.BeginInvoke(this.JamDetectedDelegate, new object[] { sender, e });
			}
			else
			{
				this.ListEvent("Event: Jam Detected.");
			}
		}

		// Token: 0x060000EB RID: 235 RVA: 0x0000C228 File Offset: 0x0000A428
		private void HandleNoteRetrievedEvent(object sender, EventArgs e)
		{
			bool invokeRequired = base.InvokeRequired;
			if (invokeRequired)
			{
				base.BeginInvoke(this.NoteRetrievedDelegate, new object[] { sender, e });
			}
			else
			{
				this.ListEvent("Event: Note Retrieved.");
			}
		}

		// Token: 0x060000EC RID: 236 RVA: 0x0000C270 File Offset: 0x0000A470
		private void HandlePauseClearedEvent(object sender, EventArgs e)
		{
			bool invokeRequired = base.InvokeRequired;
			if (invokeRequired)
			{
				base.BeginInvoke(this.PauseClearedDelegate, new object[] { sender, e });
			}
			else
			{
				this.ListEvent("Event: Pause Cleared.");
			}
		}

		// Token: 0x060000ED RID: 237 RVA: 0x0000C2B8 File Offset: 0x0000A4B8
		private void HandlePauseDetectedEvent(object sender, EventArgs e)
		{
			bool invokeRequired = base.InvokeRequired;
			if (invokeRequired)
			{
				base.BeginInvoke(this.PauseDetectedDelegate, new object[] { sender, e });
			}
			else
			{
				this.ListEvent("Event: Pause Detected.");
			}
		}

		// Token: 0x060000EE RID: 238 RVA: 0x0000C300 File Offset: 0x0000A500
		private void HandlePowerUpCompleteEvent(object sender, EventArgs e)
		{
			bool invokeRequired = base.InvokeRequired;
			if (invokeRequired)
			{
				base.BeginInvoke(this.PowerUpCompleteDelegate, new object[] { sender, e });
			}
			else
			{
				this.ListEvent("Event: Power Up Complete.");
			}
		}

		// Token: 0x060000EF RID: 239 RVA: 0x0000C348 File Offset: 0x0000A548
		private void HandlePowerUpEvent(object sender, EventArgs e)
		{
			bool invokeRequired = base.InvokeRequired;
			if (invokeRequired)
			{
				base.BeginInvoke(this.PowerUpDelegate, new object[] { sender, e });
			}
			else
			{
				this.ListEvent("Event: Power Up.");
			}
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x0000C390 File Offset: 0x0000A590
		private void HandlePUPEscrowEvent(object sender, EventArgs e)
		{
			bool invokeRequired = base.InvokeRequired;
			if (invokeRequired)
			{
				base.BeginInvoke(this.PUPEscrowDelegate, new object[] { sender, e });
			}
			else
			{
				this.ListEvent("Event: Power Up with Escrow: " + this.DocInfoToString(this.BillAcceptor.DocType, this.BillAcceptor.getDocument()));
			}
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x0000C3F8 File Offset: 0x0000A5F8
		private void HandleRejectedEvent(object sender, EventArgs e)
		{
			bool invokeRequired = base.InvokeRequired;
			if (invokeRequired)
			{
				base.BeginInvoke(this.RejectedDelegate, new object[] { sender, e });
			}
			else
			{
				this.ListEvent("Event: Rejected.");
			}
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x0000C440 File Offset: 0x0000A640
		private void HandleReturnedEvent(object sender, EventArgs e)
		{
			bool invokeRequired = base.InvokeRequired;
			if (invokeRequired)
			{
				base.BeginInvoke(this.ReturnedDelegate, new object[] { sender, e });
			}
			else
			{
				this.ListEvent("Event: Returned.");
			}
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x0000C488 File Offset: 0x0000A688
		private void HandleStackedEvent(object sender, EventArgs e)
		{
			bool invokeRequired = base.InvokeRequired;
			if (invokeRequired)
			{
				base.BeginInvoke(this.StackedDelegate, new object[] { sender, e });
			}
			else
			{
				this.ListEvent("Event: Stacked");
				bool capCashBoxTotal = this.BillAcceptor.CapCashBoxTotal;
				if (capCashBoxTotal)
				{
				}
			}
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x0000C4E0 File Offset: 0x0000A6E0
		private void HandleStackedWithDocInfoEvent(object sender, StackedEventArgs e)
		{
			bool invokeRequired = base.InvokeRequired;
			if (invokeRequired)
			{
				base.BeginInvoke(this.StackedWithDocInfoDelegate, new object[] { sender, e });
			}
			else
			{
				this.ListEvent("Event: StackedWithDocInfo: " + this.DocInfoToString(e.DocType, e.Document));
				bool flag = e.Document != null;
				if (flag)
				{
					this.timer3.Stop();
					this.timer3.Start();
					string text = e.Document.ToString();
					string[] array = text.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
					try
					{
						string rpiSerial = MyGlobalClass.GetRpiSerial();
					}
					catch (Exception ex)
					{
						Console.Write(ex.ToString());
					}
					string text2 = array[1].ToString();
					string text3 = text2;
					if (!(text3 == "5"))
					{
						if (!(text3 == "10"))
						{
							if (!(text3 == "20"))
							{
								if (!(text3 == "50"))
								{
									if (text3 == "100")
									{
										this.hundreds++;
										this.updateNoteCount();
									}
								}
								else
								{
									this.fifties++;
									this.updateNoteCount();
								}
							}
							else
							{
								this.twenties++;
								this.updateNoteCount();
							}
						}
						else
						{
							this.tens++;
							this.updateNoteCount();
						}
					}
					else
					{
						this.fives++;
						this.updateNoteCount();
					}
				}
				bool capCashBoxTotal = this.BillAcceptor.CapCashBoxTotal;
				if (capCashBoxTotal)
				{
				}
			}
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x0000C6A0 File Offset: 0x0000A8A0
		private void HandleStackerFullClearedEvent(object sender, EventArgs e)
		{
			bool invokeRequired = base.InvokeRequired;
			if (invokeRequired)
			{
				base.BeginInvoke(this.StackerFullClearedDelegate, new object[] { sender, e });
			}
			else
			{
				this.ListEvent("Event: Cassette Full Cleared.");
			}
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x0000C6E8 File Offset: 0x0000A8E8
		private void HandleStackerFullEvent(object sender, EventArgs e)
		{
			bool invokeRequired = base.InvokeRequired;
			if (invokeRequired)
			{
				base.BeginInvoke(this.StackerFullDelegate, new object[] { sender, e });
			}
			else
			{
				this.ListEvent("Event: Cassette Full.");
			}
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x0000C730 File Offset: 0x0000A930
		private void HandleStallClearedEvent(object sender, EventArgs e)
		{
			bool invokeRequired = base.InvokeRequired;
			if (invokeRequired)
			{
				base.BeginInvoke(this.StallClearedDelegate, new object[] { sender, e });
			}
			else
			{
				this.ListEvent("Event: Stall Cleared.");
			}
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x0000C778 File Offset: 0x0000A978
		private void HandleStallDetectedEvent(object sender, EventArgs e)
		{
			bool invokeRequired = base.InvokeRequired;
			if (invokeRequired)
			{
				base.BeginInvoke(this.StallDetectedDelegate, new object[] { sender, e });
			}
			else
			{
				this.ListEvent("Event: Stall Detected.");
			}
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x0000C7BD File Offset: 0x0000A9BD
		private void Main_FormClosed(object sender, FormClosedEventArgs e)
		{
			this.BillAcceptor.Close();
		}

		// Token: 0x060000FA RID: 250 RVA: 0x0000C7CC File Offset: 0x0000A9CC
		private void btnDone_Click(object sender, EventArgs e)
		{
			this.processBatchEncrypt();
		}

		// Token: 0x060000FB RID: 251 RVA: 0x0000C7D8 File Offset: 0x0000A9D8
		private void timer1_Tick_1(object sender, EventArgs e)
		{
			this.DeviceStateLabel.Text = this.BillAcceptor.DeviceState.ToString();
		}

		// Token: 0x060000FC RID: 252 RVA: 0x0000C7CC File Offset: 0x0000A9CC
		private void timer3_Tick(object sender, EventArgs e)
		{
			this.processBatchEncrypt();
		}

		// Token: 0x060000FD RID: 253 RVA: 0x0000C80C File Offset: 0x0000AA0C
		public void myAddNote(string noteValue)
		{
			this.timer3.Stop();
			this.timer3.Start();
			if (!(noteValue == "5"))
			{
				if (!(noteValue == "10"))
				{
					if (!(noteValue == "20"))
					{
						if (!(noteValue == "50"))
						{
							if (noteValue == "100")
							{
								this.hundreds++;
							}
						}
						else
						{
							this.fifties++;
						}
					}
					else
					{
						this.twenties++;
					}
				}
				else
				{
					this.tens++;
				}
			}
			else
			{
				this.fives++;
			}
			this.updateNoteCount();
		}

		// Token: 0x060000FE RID: 254 RVA: 0x0000C8CE File Offset: 0x0000AACE
		private void btnAddFive_Click(object sender, EventArgs e)
		{
			this.myAddNote("5");
		}

		// Token: 0x060000FF RID: 255 RVA: 0x0000C8DD File Offset: 0x0000AADD
		private void btnAddTen_Click(object sender, EventArgs e)
		{
			this.myAddNote("10");
		}

		// Token: 0x06000100 RID: 256 RVA: 0x0000C8EC File Offset: 0x0000AAEC
		private void btnAddTwenty_Click(object sender, EventArgs e)
		{
			this.myAddNote("20");
		}

		// Token: 0x06000101 RID: 257 RVA: 0x0000C8FB File Offset: 0x0000AAFB
		private void btnAddFifty_Click(object sender, EventArgs e)
		{
			this.myAddNote("50");
		}

		// Token: 0x06000102 RID: 258 RVA: 0x0000C90A File Offset: 0x0000AB0A
		private void btnAddHundred_Click(object sender, EventArgs e)
		{
			this.myAddNote("100");
		}

		// Token: 0x06000103 RID: 259 RVA: 0x0000C91C File Offset: 0x0000AB1C
		private void Main_Load(object sender, EventArgs e)
		{
			this.objUser = MyGlobalClass.TempLoginUser;
			MyGlobalClass.TempLoginUser = new clsUsers();
			this.SetPortName((string)Settings.Default["COMPort"]);
			this.objBankBatch = new clsBankBatchData();
			this.objBankBatch.DepositDateTime = DateTime.Now.ToString("yyyyMMddHHmmss");
			this.objBankBatch.UserID = this.objUser.ID;
			try
			{
				bool isDevelop = MyGlobalClass.isDevelop;
				if (isDevelop)
				{
					this.btnAddFive.Visible = true;
					this.btnAddTen.Visible = true;
					this.btnAddTwenty.Visible = true;
					this.btnAddFifty.Visible = true;
					this.btnAddHundred.Visible = true;
					this.timer2.Enabled = false;
				}
				else
				{
					this.btnAddFive.Visible = false;
					this.btnAddTen.Visible = false;
					this.btnAddTwenty.Visible = false;
					this.btnAddFifty.Visible = false;
					this.btnAddHundred.Visible = false;
					this.BillAcceptor.Open(this.ComPortName, this.PupMode);
					this.timer2.Interval = 5000;
					this.timer2.Enabled = true;
				}
				this.timer3.Interval = 30000;
				this.timer3.Enabled = true;
				this.timer3.Stop();
				bool isPi = MyGlobalClass.isPi;
				if (isPi)
				{
					this.filePath = string.Concat(new object[]
					{
						MyGlobalClass.batchDirectory,
						"/",
						DateTime.Now.ToString("yyyyMMdd-HHmmss"),
						"_",
						this.objUser.ID,
						".dat"
					});
					this.uploadFilePath = string.Concat(new object[]
					{
						MyGlobalClass.batchUploadDirectory,
						"/",
						DateTime.Now.ToString("yyyyMMdd-HHmmss"),
						"_",
						this.objUser.ID,
						".dat"
					});
				}
				else
				{
					this.filePath = string.Concat(new object[]
					{
						MyGlobalClass.batchDirectory,
						"\\",
						DateTime.Now.ToString("yyyyMMdd-HHmmss"),
						"_",
						this.objUser.ID,
						".dat"
					});
					this.uploadFilePath = string.Concat(new object[]
					{
						MyGlobalClass.batchUploadDirectory,
						"\\",
						DateTime.Now.ToString("yyyyMMdd-HHmmss"),
						"_",
						this.objUser.ID,
						".dat"
					});
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Unable to open the bill acceptor on com port <" + this.ComPortName + "> : " + ex.Message, "Open Bill Acceptor Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				((frmInitialPage)base.ParentForm).loadinForm("Login");
			}
		}

		// Token: 0x06000104 RID: 260 RVA: 0x0000CC78 File Offset: 0x0000AE78
		private void updateNoteCount()
		{
			this.objBankBatch.Five = this.fives;
			this.objBankBatch.Ten = this.tens;
			this.objBankBatch.Twenty = this.twenties;
			this.objBankBatch.Fifty = this.fifties;
			this.objBankBatch.Hundred = this.hundreds;
			this.objBankBatch.RefreshTotal();
			this.lbl5Count.Text = this.objBankBatch.Five.ToString();
			this.lbl10Count.Text = this.objBankBatch.Ten.ToString();
			this.lbl20Count.Text = this.objBankBatch.Twenty.ToString();
			this.lbl50Count.Text = this.objBankBatch.Fifty.ToString();
			this.lbl100Count.Text = this.objBankBatch.Hundred.ToString();
			this.lblTotalCount.Text = "$" + this.objBankBatch.DepositTotal.ToString();
			string text = this.filePath + Environment.NewLine + this.objBankBatch.outputString();
			this.objBankBatch.outputString();
			File.WriteAllText(this.filePath, text);
		}

		// Token: 0x06000105 RID: 261 RVA: 0x0000CDEC File Offset: 0x0000AFEC
		private void processBatchEncrypt()
		{
			this.BillAcceptor.Close();
			this.timer2.Enabled = false;
			this.timer3.Enabled = false;
			bool flag = this.objBankBatch.DepositTotal > 0;
			if (flag)
			{
				this.myButtonEnableDisable(false);
				clsEncryptDecrypt clsEncryptDecrypt = new clsEncryptDecrypt();
				Cursor.Current = Cursors.WaitCursor;
				Application.DoEvents();
				clsEncryptDecrypt.FileEncrypt(this.filePath, MyGlobalClass.FileEncryptDecryptKey);
				Cursor.Current = Cursors.Default;
				File.Delete(this.filePath);
				bool flag2 = MyGlobalClass.AcknowledgementToFernware();
				if (flag2)
				{
					string text = "";
					text = MyGlobalClass.GetRpiSerial();
					string text2 = MyGlobalClass.WebServerHostName + "/rp1/queries/insertBatchHeaderEncrypt.php";
					string text3 = string.Concat(new string[]
					{
						text,
						"@Q@",
						this.objBankBatch.DepositDateTime,
						"@Q@",
						this.objBankBatch.UserID.ToString(),
						"@Q@",
						this.objBankBatch.DepositTotal.ToString(),
						"@Q@",
						MyGlobalClass.StoreID.ToString(),
						"@Q@",
						DateTime.Now.ToString("yyyyMMddHHmmss")
					});
					string text4 = clsEncryptDecrypt.StringEncrypt(text3, MyGlobalClass.StringEncryptDecryptKey, MyGlobalClass.StringEncryptDecryptIV);
					using (WebClient webClient = new WebClient())
					{
						NameValueCollection nameValueCollection = new NameValueCollection { 
						{
							"data",
							text4.ToString()
						} };
						this.objBankBatch.ID = int.Parse(Encoding.UTF8.GetString(webClient.UploadValues(text2, nameValueCollection)));
					}
					text2 = MyGlobalClass.WebServerHostName + "/rp1/queries/insertBatchLinesBulkEncrypt.php";
					bool flag3 = this.objBankBatch.Five > 0;
					if (flag3)
					{
						text3 = string.Concat(new string[]
						{
							text,
							"@Q@",
							this.objBankBatch.ID.ToString(),
							"@Q@5@Q@",
							this.objBankBatch.Five.ToString(),
							"@Q@",
							DateTime.Now.ToString("yyyyMMddHHmmss")
						});
						text4 = clsEncryptDecrypt.StringEncrypt(text3, MyGlobalClass.StringEncryptDecryptKey, MyGlobalClass.StringEncryptDecryptIV);
						using (WebClient webClient2 = new WebClient())
						{
							NameValueCollection nameValueCollection2 = new NameValueCollection { 
							{
								"data",
								text4.ToString()
							} };
							webClient2.UploadValues(text2, nameValueCollection2);
						}
					}
					bool flag4 = this.objBankBatch.Ten > 0;
					if (flag4)
					{
						text3 = string.Concat(new string[]
						{
							text,
							"@Q@",
							this.objBankBatch.ID.ToString(),
							"@Q@10@Q@",
							this.objBankBatch.Ten.ToString(),
							"@Q@",
							DateTime.Now.ToString("yyyyMMddHHmmss")
						});
						text4 = clsEncryptDecrypt.StringEncrypt(text3, MyGlobalClass.StringEncryptDecryptKey, MyGlobalClass.StringEncryptDecryptIV);
						using (WebClient webClient3 = new WebClient())
						{
							NameValueCollection nameValueCollection3 = new NameValueCollection { 
							{
								"data",
								text4.ToString()
							} };
							webClient3.UploadValues(text2, nameValueCollection3);
						}
					}
					bool flag5 = this.objBankBatch.Twenty > 0;
					if (flag5)
					{
						text3 = string.Concat(new string[]
						{
							text,
							"@Q@",
							this.objBankBatch.ID.ToString(),
							"@Q@20@Q@",
							this.objBankBatch.Twenty.ToString(),
							"@Q@",
							DateTime.Now.ToString("yyyyMMddHHmmss")
						});
						text4 = clsEncryptDecrypt.StringEncrypt(text3, MyGlobalClass.StringEncryptDecryptKey, MyGlobalClass.StringEncryptDecryptIV);
						using (WebClient webClient4 = new WebClient())
						{
							NameValueCollection nameValueCollection4 = new NameValueCollection { 
							{
								"data",
								text4.ToString()
							} };
							webClient4.UploadValues(text2, nameValueCollection4);
						}
					}
					bool flag6 = this.objBankBatch.Fifty > 0;
					if (flag6)
					{
						text3 = string.Concat(new string[]
						{
							text,
							"@Q@",
							this.objBankBatch.ID.ToString(),
							"@Q@50@Q@",
							this.objBankBatch.Fifty.ToString(),
							"@Q@",
							DateTime.Now.ToString("yyyyMMddHHmmss")
						});
						text4 = clsEncryptDecrypt.StringEncrypt(text3, MyGlobalClass.StringEncryptDecryptKey, MyGlobalClass.StringEncryptDecryptIV);
						using (WebClient webClient5 = new WebClient())
						{
							NameValueCollection nameValueCollection5 = new NameValueCollection { 
							{
								"data",
								text4.ToString()
							} };
							webClient5.UploadValues(text2, nameValueCollection5);
						}
					}
					bool flag7 = this.objBankBatch.Hundred > 0;
					if (flag7)
					{
						text3 = string.Concat(new string[]
						{
							text,
							"@Q@",
							this.objBankBatch.ID.ToString(),
							"@Q@100@Q@",
							this.objBankBatch.Hundred.ToString(),
							"@Q@",
							DateTime.Now.ToString("yyyyMMddHHmmss")
						});
						text4 = clsEncryptDecrypt.StringEncrypt(text3, MyGlobalClass.StringEncryptDecryptKey, MyGlobalClass.StringEncryptDecryptIV);
						using (WebClient webClient6 = new WebClient())
						{
							NameValueCollection nameValueCollection6 = new NameValueCollection { 
							{
								"data",
								text4.ToString()
							} };
							webClient6.UploadValues(text2, nameValueCollection6);
						}
					}
					string text5 = this.uploadFilePath + Environment.NewLine + this.objBankBatch.outputString();
					File.WriteAllText(this.uploadFilePath, text5);
					Cursor.Current = Cursors.WaitCursor;
					Application.DoEvents();
					clsEncryptDecrypt.FileEncrypt(this.uploadFilePath, MyGlobalClass.FileEncryptDecryptKey);
					Cursor.Current = Cursors.Default;
					File.Delete(this.uploadFilePath);
					File.Delete(this.filePath + ".aes");
				}
				this.myButtonEnableDisable(true);
			}
			((frmInitialPage)base.ParentForm).loadinForm("Login");
		}

		// Token: 0x06000106 RID: 262 RVA: 0x0000D4F4 File Offset: 0x0000B6F4
		private void timer2_Tick(object sender, EventArgs e)
		{
			this.timer2.Enabled = false;
			bool flag = this.BillAcceptor.DeviceState.ToString() == "Disconnected";
			if (flag)
			{
				MessageBox.Show("Ensure device is powered ON and connected. Configure COM Port in Settings.");
				this.BillAcceptor.Close();
				((frmInitialPage)base.ParentForm).loadinForm("Login");
			}
		}

		// Token: 0x06000107 RID: 263 RVA: 0x0000D568 File Offset: 0x0000B768
		public void myButtonEnableDisable(bool isEnabled)
		{
			foreach (object obj in base.Controls)
			{
				bool flag = obj.GetType() == new Button().GetType();
				if (flag)
				{
					Button button = (Button)obj;
					button.Enabled = isEnabled;
				}
			}
			Application.DoEvents();
		}

		// Token: 0x04000092 RID: 146
		private int fives = 0;

		// Token: 0x04000093 RID: 147
		private int tens = 0;

		// Token: 0x04000094 RID: 148
		private int twenties = 0;

		// Token: 0x04000095 RID: 149
		private int fifties = 0;

		// Token: 0x04000096 RID: 150
		private int hundreds = 0;

		// Token: 0x04000097 RID: 151
		private string filePath;

		// Token: 0x04000098 RID: 152
		private string uploadFilePath;

		// Token: 0x04000099 RID: 153
		private string ComPortName;

		// Token: 0x0400009A RID: 154
		private PowerUp PupMode = 0;

		// Token: 0x0400009B RID: 155
		private clsUsers objUser;

		// Token: 0x0400009C RID: 156
		private clsBankBatchData objBankBatch;

		// Token: 0x0400009D RID: 157
		private Acceptor BillAcceptor = new Acceptor();

		// Token: 0x0400009E RID: 158
		private CalibrateFinishEventHandler CalibrateFinishDelegate;

		// Token: 0x0400009F RID: 159
		private CalibrateProgressEventHandler CalibrateProgressDelegate;

		// Token: 0x040000A0 RID: 160
		private CalibrateStartEventHandler CalibrateStartDelegate;

		// Token: 0x040000A1 RID: 161
		private CashBoxCleanlinessEventHandler CashBoxCleanlinessDelegate;

		// Token: 0x040000A2 RID: 162
		private CashBoxAttachedEventHandler CashBoxAttachedDelegate;

		// Token: 0x040000A3 RID: 163
		private CashBoxRemovedEventHandler CashBoxRemovedDelegate;

		// Token: 0x040000A4 RID: 164
		private CheatedEventHandler CheatedDelegate;

		// Token: 0x040000A5 RID: 165
		private ClearAuditEventHandler ClearAuditDelegate;

		// Token: 0x040000A6 RID: 166
		private ConnectedEventHandler ConnectedDelegate;

		// Token: 0x040000A7 RID: 167
		private DisconnectedEventHandler DisconnectedDelegate;

		// Token: 0x040000A8 RID: 168
		private DownloadFinishEventHandler DownloadFinishDelegate;

		// Token: 0x040000A9 RID: 169
		private DownloadProgressEventHandler DownloadProgressDelegate;

		// Token: 0x040000AA RID: 170
		private DownloadRestartEventHandler DownloadRestartDelegate;

		// Token: 0x040000AB RID: 171
		private DownloadStartEventHandler DownloadStartDelegate;

		// Token: 0x040000AC RID: 172
		private ErrorOnSendMessageEventHandler ErrorOnSendMessageDelegate;

		// Token: 0x040000AD RID: 173
		private EscrowEventHandler EscrowedDelegate;

		// Token: 0x040000AE RID: 174
		private FailureClearedEventHandler FailureClearedDelegate;

		// Token: 0x040000AF RID: 175
		private FailureDetectedEventHandler FailureDetectedDelegate;

		// Token: 0x040000B0 RID: 176
		private InvalidCommandEventHandler InvalidCommandDelegate;

		// Token: 0x040000B1 RID: 177
		private JamClearedEventHandler JamClearedDelegate;

		// Token: 0x040000B2 RID: 178
		private JamDetectedEventHandler JamDetectedDelegate;

		// Token: 0x040000B3 RID: 179
		private NoteRetrievedEventHandler NoteRetrievedDelegate;

		// Token: 0x040000B4 RID: 180
		private PauseClearedEventHandler PauseClearedDelegate;

		// Token: 0x040000B5 RID: 181
		private PauseDetectedEventHandler PauseDetectedDelegate;

		// Token: 0x040000B6 RID: 182
		private PowerUpCompleteEventHandler PowerUpCompleteDelegate;

		// Token: 0x040000B7 RID: 183
		private PowerUpEventHandler PowerUpDelegate;

		// Token: 0x040000B8 RID: 184
		private PUPEscrowEventHandler PUPEscrowDelegate;

		// Token: 0x040000B9 RID: 185
		private RejectedEventHandler RejectedDelegate;

		// Token: 0x040000BA RID: 186
		private ReturnedEventHandler ReturnedDelegate;

		// Token: 0x040000BB RID: 187
		private StackedEventHandler StackedDelegate;

		// Token: 0x040000BC RID: 188
		private StackedWithDocInfoEventHandler StackedWithDocInfoDelegate;

		// Token: 0x040000BD RID: 189
		private StackerFullClearedEventHandler StackerFullClearedDelegate;

		// Token: 0x040000BE RID: 190
		private StackerFullEventHandler StackerFullDelegate;

		// Token: 0x040000BF RID: 191
		private StallClearedEventHandler StallClearedDelegate;

		// Token: 0x040000C0 RID: 192
		private StallDetectedEventHandler StallDetectedDelegate;
	}
}
