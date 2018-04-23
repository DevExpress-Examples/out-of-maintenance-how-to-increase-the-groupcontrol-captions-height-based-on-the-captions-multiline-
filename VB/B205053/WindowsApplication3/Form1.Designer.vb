Imports Microsoft.VisualBasic
Imports System
Namespace WindowsApplication3
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Me.groupControl1 = New WindowsApplication3.MyGroupControl()
			CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' groupControl1
			' 
			Me.groupControl1.AppearanceCaption.Options.UseTextOptions = True
			Me.groupControl1.AppearanceCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
			Me.groupControl1.AppearanceCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
			Me.groupControl1.Location = New System.Drawing.Point(65, 30)
			Me.groupControl1.LookAndFeel.SkinName = "Blue"
			Me.groupControl1.LookAndFeel.UseDefaultLookAndFeel = False
			Me.groupControl1.Margin = New System.Windows.Forms.Padding(2)
			Me.groupControl1.Name = "groupControl1"
			Me.groupControl1.Size = New System.Drawing.Size(290, 204)
			Me.groupControl1.TabIndex = 1
			Me.groupControl1.Text = resources.GetString("groupControl1.Text")
'			Me.groupControl1.Paint += New System.Windows.Forms.PaintEventHandler(Me.groupControl1_Paint);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(414, 322)
			Me.Controls.Add(Me.groupControl1)
			Me.Margin = New System.Windows.Forms.Padding(2)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents groupControl1 As MyGroupControl


	End Class
End Namespace

