<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblctime = New System.Windows.Forms.Label()
        Me.txtsettime = New System.Windows.Forms.MaskedTextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblmsg = New System.Windows.Forms.Label()
        Me.AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(12, 114)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(129, 48)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "SET"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblctime
        '
        Me.lblctime.AutoSize = True
        Me.lblctime.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblctime.Location = New System.Drawing.Point(12, 24)
        Me.lblctime.Name = "lblctime"
        Me.lblctime.Size = New System.Drawing.Size(71, 30)
        Me.lblctime.TabIndex = 1
        Me.lblctime.Text = "Label1"
        '
        'txtsettime
        '
        Me.txtsettime.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsettime.Location = New System.Drawing.Point(12, 73)
        Me.txtsettime.Mask = "90:00:00 AM"
        Me.txtsettime.Name = "txtsettime"
        Me.txtsettime.Size = New System.Drawing.Size(129, 35)
        Me.txtsettime.TabIndex = 2
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'lblmsg
        '
        Me.lblmsg.AutoSize = True
        Me.lblmsg.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmsg.Location = New System.Drawing.Point(12, 183)
        Me.lblmsg.Name = "lblmsg"
        Me.lblmsg.Size = New System.Drawing.Size(56, 21)
        Me.lblmsg.TabIndex = 3
        Me.lblmsg.Text = "Label2"
        '
        'AxWindowsMediaPlayer1
        '
        Me.AxWindowsMediaPlayer1.Enabled = True
        Me.AxWindowsMediaPlayer1.Location = New System.Drawing.Point(12, 325)
        Me.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        Me.AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer1.Size = New System.Drawing.Size(256, 53)
        Me.AxWindowsMediaPlayer1.TabIndex = 4
        Me.AxWindowsMediaPlayer1.Visible = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(13, 296)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(102, 23)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "SET Tone"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 390)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.AxWindowsMediaPlayer1)
        Me.Controls.Add(Me.lblmsg)
        Me.Controls.Add(Me.txtsettime)
        Me.Controls.Add(Me.lblctime)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lblctime As System.Windows.Forms.Label
    Friend WithEvents txtsettime As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lblmsg As System.Windows.Forms.Label
    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog

End Class
