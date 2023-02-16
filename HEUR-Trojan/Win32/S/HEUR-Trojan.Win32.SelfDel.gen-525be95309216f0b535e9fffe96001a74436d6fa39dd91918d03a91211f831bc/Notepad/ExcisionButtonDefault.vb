Imports System
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace vHack_Loader
	' Token: 0x0200000C RID: 12
	Public Class ExcisionButtonDefault
		Inherits Control

		' Token: 0x06000025 RID: 37 RVA: 0x00002BE0 File Offset: 0x00000DE0
		Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
			MyBase.OnMouseDown(e)
			Me.State = MouseState.Down
			MyBase.Invalidate()
		End Sub

		' Token: 0x06000026 RID: 38 RVA: 0x00002BF6 File Offset: 0x00000DF6
		Protected Overrides Sub OnMouseUp(e As MouseEventArgs)
			MyBase.OnMouseUp(e)
			Me.State = MouseState.Over
			MyBase.Invalidate()
		End Sub

		' Token: 0x06000027 RID: 39 RVA: 0x00002C0C File Offset: 0x00000E0C
		Protected Overrides Sub OnMouseEnter(e As EventArgs)
			MyBase.OnMouseEnter(e)
			Me.State = MouseState.Over
			MyBase.Invalidate()
		End Sub

		' Token: 0x06000028 RID: 40 RVA: 0x00002C22 File Offset: 0x00000E22
		Protected Overrides Sub OnMouseLeave(e As EventArgs)
			MyBase.OnMouseLeave(e)
			Me.State = MouseState.None
			MyBase.Invalidate()
		End Sub

		' Token: 0x06000029 RID: 41 RVA: 0x00002C38 File Offset: 0x00000E38
		Public Sub New()
			Me.State = MouseState.None
			MyBase.SetStyle(ControlStyles.UserPaint Or ControlStyles.SupportsTransparentBackColor, True)
			Me.BackColor = Color.Transparent
			Me.ForeColor = Color.FromArgb(205, 205, 205)
			Me.DoubleBuffered = True
		End Sub

		' Token: 0x0600002A RID: 42 RVA: 0x00002C8C File Offset: 0x00000E8C
		Protected Overrides Sub OnPaint(e As PaintEventArgs)
			Dim bitmap As Bitmap = New Bitmap(MyBase.Width, MyBase.Height)
			Dim graphics As Graphics = Graphics.FromImage(bitmap)
			Dim rectangle As Rectangle = New Rectangle(0, 0, MyBase.Width - 1, MyBase.Height - 1)
			Dim rectangle2 As Rectangle = New Rectangle(1, 1, MyBase.Width - 3, MyBase.Height - 3)
			MyBase.OnPaint(e)
			graphics.Clear(Me.BackColor)
			Dim font As Font = New Font("Tahoma", 10F, FontStyle.Bold)
			graphics.SmoothingMode = SmoothingMode.HighQuality
			Dim bitmap2 As Bitmap = CType(New ImageToCodeClass().CodeToImage("/9j/4AAQSkZJRgABAQEAYABgAAD/2wBDAAIBAQIBAQICAgICAgICAwUDAwMDAwYEBAMFBwYHBwcGBwcICQsJCAgKCAcHCg0KCgsMDAwMBwkODw0MDgsMDAz/2wBDAQICAgMDAwYDAwYMCAcIDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAz/wAARCAA1AHUDASIAAhEBAxEB/8QAHwAAAQUBAQEBAQEAAAAAAAAAAAECAwQFBgcICQoL/8QAtRAAAgEDAwIEAwUFBAQAAAF9AQIDAAQRBRIhMUEGE1FhByJxFDKBkaEII0KxwRVS0fAkM2JyggkKFhcYGRolJicoKSo0NTY3ODk6Q0RFRkdISUpTVFVWV1hZWmNkZWZnaGlqc3R1dnd4eXqDhIWGh4iJipKTlJWWl5iZmqKjpKWmp6ipqrKztLW2t7i5usLDxMXGx8jJytLT1NXW19jZ2uHi4+Tl5ufo6erx8vP09fb3+Pn6/8QAHwEAAwEBAQEBAQEBAQAAAAAAAAECAwQFBgcICQoL/8QAtREAAgECBAQDBAcFBAQAAQJ3AAECAxEEBSExBhJBUQdhcRMiMoEIFEKRobHBCSMzUvAVYnLRChYkNOEl8RcYGRomJygpKjU2Nzg5OkNERUZHSElKU1RVVldYWVpjZGVmZ2hpanN0dXZ3eHl6goOEhYaHiImKkpOUlZaXmJmaoqOkpaanqKmqsrO0tba3uLm6wsPExcbHyMnK0tPU1dbX2Nna4uPk5ebn6Onq8vP09fb3+Pn6/9oADAMBAAIRAxEAPwD8nk3IuWycY6HFDsFIJYHnPTPB9aUAMc4OFxz05oCbmxgKDz1xxQUgYGTJzvYf/qoQkglQwPUnOfaiP94xyOnT34pVjC5ABGDgjPXigaEkZiWVsceopFLeVtXvwBjilRMMTJkdvunmkjAJ68g8Y60CE37woJwMHOTxT45AMEBiMYx26daRgrIPlICt2HShXVUBIy2RyOKBjRG2wFslc8+tGQvHuRzyacRuBIJYevak3/NuJLA8EZ6UCFZCVJYDJ5z/AEpRl4yAAS3f0oPCAlWIznIPWo1I4GCR6E0DFGGfBAyfwxRwCW3AAnIyKdncAcKQvJyfWgox+TIIH48UBYVQhGGVyw6kUU0kEA7ACfVaKBIG7sATkntxQu7gEjJA56/hQoYspGcnjjAFKBlgBwT6CgY7Z935dox1J703c27DZO71pQGXqdzjqDzgU0syoBjHHWgLDlYKQFLIT0GOKbExJJIIJ4pVBJBBI47DH40oO1yWGS2CMc0AGCN43AY496FJZDkgAHjPAo3/ADE4AOc+9NZl6hT9TyaBAc5BKlgPTikXjduJA7jHSiNgzlgRjHGTTtuDkEkk8+lACgFUUqAMjk570nDrk5BBxxSTKyYBACjvTmbeVXDYPH/16AGiUK4Gcgnnnt9KHbYFBBO3npg0uN0hHBKjuMUNhGJBIDde9Axy2vmEjfnaB+tFJGzKSASD3xRQJDWcbyVAGTjHp70oyFVWyB7AGhlBByCCTnnpRtLNgnJPP0oC4MoJKqpUNxQ6HauF5I5HTNJtKIcAkHucE0u0CJQwyT0OKAuIoCttCg7eMZORSgoEA24btzgjrSlcYZQpJ54poyzZBJI4ANADombgkDB6np3ppjzgsTgnGcUofPyg7c5Ht+tIg5AJ68YyKBodEAxJyFAH6004yPmYkHGf/rUqgjcM5J49h1pHKnAIBI7+poEKcBiCBg8ZFNY4PGcD88UrZHAPygjj8KVV5I6Y7ngCgBqDMgzuyOeAc053boMBicj/ADmguwQhiGweM4NL8zEADbg8cUDTGjbyWDEHpzRSuFLYIGR6ciigVwjYvjPIwOvNICGYHBG4kHFFFA0JwzEqNuQf5U8sUUk4ZSenTtRRQJBuEiYAK454pquFQrtyVzz3oooBMCxOAMLkHkdetPiUPKytzlcknk0UUAQl96g4wQaeF+QE9G9PqKKKAYMuVLAkZJp+3MUj5IYn8KKKBoYSWbGcY4HApAxMjAk/KfWiigTY5CyLlTt3UUUUCbP/2Q=="), Bitmap)
			Dim textureBrush As TextureBrush = New TextureBrush(bitmap2, WrapMode.TileFlipXY)
			graphics.FillPath(textureBrush, Draw.RoundRect(rectangle, 4))
			New Pen(New SolidBrush(Color.FromArgb(117, 120, 117)))
			graphics.DrawPath(Pens.Black, Draw.RoundRect(rectangle, 4))
			Dim pen As Pen = New Pen(Color.FromArgb(45, Color.White))
			graphics.DrawPath(pen, Draw.RoundRect(rectangle2, 4))
			Select Case Me.State
				Case MouseState.None
					graphics.DrawString(Me.Text, font, New SolidBrush(Color.FromArgb(178, 178, 178)), New Rectangle(0, 1, MyBase.Width - 1, MyBase.Height - 1), New StringFormat() With { .Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center })
				Case MouseState.Over
					graphics.DrawString(Me.Text, font, New SolidBrush(Color.WhiteSmoke), New Rectangle(0, 1, MyBase.Width - 1, MyBase.Height - 1), New StringFormat() With { .Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center })
				Case MouseState.Down
					graphics.DrawString(Me.Text, font, New SolidBrush(Color.FromArgb(178, 178, 178)), New Rectangle(0, 1, MyBase.Width - 1, MyBase.Height - 1), New StringFormat() With { .Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center })
			End Select
			NewLateBinding.LateCall(e.Graphics, Nothing, "DrawImage", New Object() { bitmap.Clone(), 0, 0 }, Nothing, Nothing, Nothing, True)
			graphics.Dispose()
			bitmap.Dispose()
		End Sub

		' Token: 0x04000016 RID: 22
		Private State As MouseState
	End Class
End Namespace
