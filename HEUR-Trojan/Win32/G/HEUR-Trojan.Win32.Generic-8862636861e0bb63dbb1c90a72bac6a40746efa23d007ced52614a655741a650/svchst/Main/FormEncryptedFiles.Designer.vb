Namespace Main
	' Token: 0x02000008 RID: 8
	Public Partial Class FormEncryptedFiles
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x06000019 RID: 25 RVA: 0x000034C0 File Offset: 0x000016C0
		Protected Overrides Sub Dispose(disposing As Boolean)
			If disposing AndAlso Me.components IsNot Nothing Then
				Me.components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		' Token: 0x0600001A RID: 26 RVA: 0x000034F0 File Offset: 0x000016F0
		Private Sub InitializeComponent()
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.Main.FormEncryptedFiles))
			Me.dataGridViewEncryptedFiles = New Global.System.Windows.Forms.DataGridView()
			Me.ColumnDeleted = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.ColumnPath = New Global.System.Windows.Forms.DataGridViewTextBoxColumn()
			CType(Me.dataGridViewEncryptedFiles, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			MyBase.SuspendLayout()
			Me.dataGridViewEncryptedFiles.AutoSizeColumnsMode = Global.System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
			Me.dataGridViewEncryptedFiles.AutoSizeRowsMode = Global.System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
			Me.dataGridViewEncryptedFiles.ColumnHeadersHeightSizeMode = Global.System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
			Me.dataGridViewEncryptedFiles.Columns.AddRange(New Global.System.Windows.Forms.DataGridViewColumn() { Me.ColumnDeleted, Me.ColumnPath })
			Me.dataGridViewEncryptedFiles.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Me.dataGridViewEncryptedFiles.Location = New Global.System.Drawing.Point(0, 0)
			Me.dataGridViewEncryptedFiles.Name = "dataGridViewEncryptedFiles"
			Me.dataGridViewEncryptedFiles.Size = New Global.System.Drawing.Size(594, 326)
			Me.dataGridViewEncryptedFiles.TabIndex = 0
			Me.ColumnDeleted.HeaderText = "Deleted"
			Me.ColumnDeleted.Name = "ColumnDeleted"
			Me.ColumnDeleted.[ReadOnly] = True
			Me.ColumnDeleted.Width = 69
			Me.ColumnPath.HeaderText = "Path"
			Me.ColumnPath.Name = "ColumnPath"
			Me.ColumnPath.[ReadOnly] = True
			Me.ColumnPath.Width = 54
			MyBase.AutoScaleDimensions = New Global.System.Drawing.SizeF(6F, 13F)
			MyBase.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			MyBase.ClientSize = New Global.System.Drawing.Size(594, 326)
			MyBase.Controls.Add(Me.dataGridViewEncryptedFiles)
			MyBase.Icon = CType(componentResourceManager.GetObject("$this.Icon"), Global.System.Drawing.Icon)
			MyBase.Name = "FormEncryptedFiles"
			Me.Text = "EncryptedFiles"
			AddHandler MyBase.Load, AddressOf Me.FormEncryptedFiles_Load
			CType(Me.dataGridViewEncryptedFiles, Global.System.ComponentModel.ISupportInitialize).EndInit()
			MyBase.ResumeLayout(False)
		End Sub

		' Token: 0x04000053 RID: 83
		Private components As Global.System.ComponentModel.IContainer = Nothing

		' Token: 0x04000054 RID: 84
		Private dataGridViewEncryptedFiles As Global.System.Windows.Forms.DataGridView

		' Token: 0x04000055 RID: 85
		Private ColumnDeleted As Global.System.Windows.Forms.DataGridViewTextBoxColumn

		' Token: 0x04000056 RID: 86
		Private ColumnPath As Global.System.Windows.Forms.DataGridViewTextBoxColumn
	End Class
End Namespace
