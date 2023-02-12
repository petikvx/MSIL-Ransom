namespace M_POST_for_EBDS_Demo_In_CSharp_DotNet
{
	// Token: 0x0200000D RID: 13
	public partial class frmStoreSelection : global::System.Windows.Forms.Form
	{
		// Token: 0x060000A8 RID: 168 RVA: 0x00007E18 File Offset: 0x00006018
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00007E50 File Offset: 0x00006050
		private void InitializeComponent()
		{
			this.dgvStore = new global::System.Windows.Forms.DataGridView();
			this.colID = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colName = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colAddress = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colOrganisation = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colRegion = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnSave = new global::System.Windows.Forms.Button();
			this.btnCancel = new global::System.Windows.Forms.Button();
			this.lblHeader = new global::System.Windows.Forms.Label();
			((global::System.ComponentModel.ISupportInitialize)this.dgvStore).BeginInit();
			base.SuspendLayout();
			this.dgvStore.AllowUserToAddRows = false;
			this.dgvStore.AllowUserToDeleteRows = false;
			this.dgvStore.AllowUserToResizeColumns = false;
			this.dgvStore.AllowUserToResizeRows = false;
			this.dgvStore.Anchor = global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right;
			this.dgvStore.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvStore.Columns.AddRange(new global::System.Windows.Forms.DataGridViewColumn[] { this.colID, this.colName, this.colAddress, this.colOrganisation, this.colRegion });
			this.dgvStore.Location = new global::System.Drawing.Point(2, 35);
			this.dgvStore.MultiSelect = false;
			this.dgvStore.Name = "dgvStore";
			this.dgvStore.ReadOnly = true;
			this.dgvStore.RowHeadersVisible = false;
			this.dgvStore.SelectionMode = global::System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvStore.Size = new global::System.Drawing.Size(676, 334);
			this.dgvStore.TabIndex = 0;
			this.colID.HeaderText = "ID";
			this.colID.Name = "colID";
			this.colID.ReadOnly = true;
			this.colID.Visible = false;
			this.colName.HeaderText = "Name";
			this.colName.Name = "colName";
			this.colName.ReadOnly = true;
			this.colName.Width = 200;
			this.colAddress.HeaderText = "Address";
			this.colAddress.Name = "colAddress";
			this.colAddress.ReadOnly = true;
			this.colAddress.Width = 150;
			this.colOrganisation.HeaderText = "Organisation";
			this.colOrganisation.Name = "colOrganisation";
			this.colOrganisation.ReadOnly = true;
			this.colOrganisation.Width = 200;
			this.colRegion.HeaderText = "Region";
			this.colRegion.Name = "colRegion";
			this.colRegion.ReadOnly = true;
			this.btnSave.Anchor = global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right;
			this.btnSave.Font = new global::System.Drawing.Font("Calibri", 14.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnSave.Location = new global::System.Drawing.Point(492, 375);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new global::System.Drawing.Size(85, 39);
			this.btnSave.TabIndex = 10;
			this.btnSave.Text = "SAVE";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new global::System.EventHandler(this.btnSave_Click);
			this.btnCancel.Anchor = global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right;
			this.btnCancel.Font = new global::System.Drawing.Font("Calibri", 14.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnCancel.Location = new global::System.Drawing.Point(583, 375);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new global::System.Drawing.Size(85, 39);
			this.btnCancel.TabIndex = 9;
			this.btnCancel.Text = "CANCEL";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new global::System.EventHandler(this.btnCancel_Click);
			this.lblHeader.Anchor = global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right;
			this.lblHeader.BackColor = global::System.Drawing.Color.DodgerBlue;
			this.lblHeader.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblHeader.ForeColor = global::System.Drawing.Color.White;
			this.lblHeader.Location = new global::System.Drawing.Point(0, 0);
			this.lblHeader.Name = "lblHeader";
			this.lblHeader.Size = new global::System.Drawing.Size(680, 22);
			this.lblHeader.TabIndex = 28;
			this.lblHeader.Text = "First Time Setup";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(680, 426);
			base.Controls.Add(this.lblHeader);
			base.Controls.Add(this.btnSave);
			base.Controls.Add(this.btnCancel);
			base.Controls.Add(this.dgvStore);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = "frmStoreSelection";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "First Time Setup";
			base.WindowState = global::System.Windows.Forms.FormWindowState.Maximized;
			base.Load += new global::System.EventHandler(this.frmStoreSelection_Load);
			((global::System.ComponentModel.ISupportInitialize)this.dgvStore).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x0400006A RID: 106
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400006B RID: 107
		private global::System.Windows.Forms.DataGridView dgvStore;

		// Token: 0x0400006C RID: 108
		private global::System.Windows.Forms.DataGridViewTextBoxColumn colID;

		// Token: 0x0400006D RID: 109
		private global::System.Windows.Forms.DataGridViewTextBoxColumn colName;

		// Token: 0x0400006E RID: 110
		private global::System.Windows.Forms.DataGridViewTextBoxColumn colAddress;

		// Token: 0x0400006F RID: 111
		private global::System.Windows.Forms.DataGridViewTextBoxColumn colOrganisation;

		// Token: 0x04000070 RID: 112
		private global::System.Windows.Forms.DataGridViewTextBoxColumn colRegion;

		// Token: 0x04000071 RID: 113
		private global::System.Windows.Forms.Button btnSave;

		// Token: 0x04000072 RID: 114
		private global::System.Windows.Forms.Button btnCancel;

		// Token: 0x04000073 RID: 115
		private global::System.Windows.Forms.Label lblHeader;
	}
}
