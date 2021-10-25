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
        Me.lblJam = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.ChkON = New System.Windows.Forms.CheckBox()
        Me.TxtNada = New System.Windows.Forms.TextBox()
        Me.AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.btnPilih = New System.Windows.Forms.Button()
        Me.tmr1 = New System.Windows.Forms.Timer(Me.components)
        Me.tmr2 = New System.Windows.Forms.Timer(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.TANGGAL = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblJam
        '
        Me.lblJam.AutoSize = True
        Me.lblJam.BackColor = System.Drawing.Color.Transparent
        Me.lblJam.Font = New System.Drawing.Font("Trajan Pro 3", 69.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJam.ForeColor = System.Drawing.Color.Red
        Me.lblJam.Location = New System.Drawing.Point(-1, -15)
        Me.lblJam.Name = "lblJam"
        Me.lblJam.Size = New System.Drawing.Size(458, 143)
        Me.lblJam.TabIndex = 2
        Me.lblJam.Text = "WAKTU"
        Me.lblJam.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tw Cen MT", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(247, 116)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 24)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "ALARM"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarFont = New System.Drawing.Font("Trajan Pro 3", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.MenuText
        Me.DateTimePicker1.Font = New System.Drawing.Font("Trajan Pro 3", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DateTimePicker1.Location = New System.Drawing.Point(325, 117)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.ShowUpDown = True
        Me.DateTimePicker1.Size = New System.Drawing.Size(96, 23)
        Me.DateTimePicker1.TabIndex = 5
        '
        'ChkON
        '
        Me.ChkON.AutoSize = True
        Me.ChkON.BackColor = System.Drawing.Color.Transparent
        Me.ChkON.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ChkON.Font = New System.Drawing.Font("Tw Cen MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkON.ForeColor = System.Drawing.Color.Red
        Me.ChkON.Location = New System.Drawing.Point(427, 120)
        Me.ChkON.Name = "ChkON"
        Me.ChkON.Size = New System.Drawing.Size(56, 23)
        Me.ChkON.TabIndex = 6
        Me.ChkON.Text = "OFF"
        Me.ChkON.UseVisualStyleBackColor = False
        '
        'TxtNada
        '
        Me.TxtNada.BackColor = System.Drawing.Color.Gray
        Me.TxtNada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtNada.Location = New System.Drawing.Point(296, 151)
        Me.TxtNada.Name = "TxtNada"
        Me.TxtNada.ReadOnly = True
        Me.TxtNada.Size = New System.Drawing.Size(165, 20)
        Me.TxtNada.TabIndex = 7
        '
        'AxWindowsMediaPlayer1
        '
        Me.AxWindowsMediaPlayer1.Enabled = True
        Me.AxWindowsMediaPlayer1.Location = New System.Drawing.Point(254, 146)
        Me.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        Me.AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer1.Size = New System.Drawing.Size(37, 33)
        Me.AxWindowsMediaPlayer1.TabIndex = 8
        '
        'btnPilih
        '
        Me.btnPilih.BackColor = System.Drawing.Color.Transparent
        Me.btnPilih.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPilih.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnPilih.FlatAppearance.BorderSize = 2
        Me.btnPilih.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPilih.Font = New System.Drawing.Font("Tw Cen MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPilih.ForeColor = System.Drawing.Color.Red
        Me.btnPilih.Location = New System.Drawing.Point(469, 143)
        Me.btnPilih.Name = "btnPilih"
        Me.btnPilih.Size = New System.Drawing.Size(75, 36)
        Me.btnPilih.TabIndex = 9
        Me.btnPilih.Text = "PILIH"
        Me.btnPilih.UseVisualStyleBackColor = False
        '
        'tmr1
        '
        Me.tmr1.Interval = 1000
        '
        'tmr2
        '
        Me.tmr2.Interval = 1000
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'TANGGAL
        '
        Me.TANGGAL.CalendarMonthBackground = System.Drawing.Color.White
        Me.TANGGAL.Font = New System.Drawing.Font("Tw Cen MT Condensed", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TANGGAL.Location = New System.Drawing.Point(31, 94)
        Me.TANGGAL.Name = "TANGGAL"
        Me.TANGGAL.Size = New System.Drawing.Size(192, 23)
        Me.TANGGAL.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(441, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 45)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "WIB"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(552, 189)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TANGGAL)
        Me.Controls.Add(Me.btnPilih)
        Me.Controls.Add(Me.AxWindowsMediaPlayer1)
        Me.Controls.Add(Me.TxtNada)
        Me.Controls.Add(Me.ChkON)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblJam)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Jam Farras"
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblJam As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents ChkON As System.Windows.Forms.CheckBox
    Friend WithEvents TxtNada As System.Windows.Forms.TextBox
    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents btnPilih As System.Windows.Forms.Button
    Friend WithEvents tmr1 As System.Windows.Forms.Timer
    Friend WithEvents tmr2 As System.Windows.Forms.Timer
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents TANGGAL As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
