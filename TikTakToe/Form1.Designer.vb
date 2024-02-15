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
        Me.lblRound = New System.Windows.Forms.Label()
        Me.btn11 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.lblGiliran = New System.Windows.Forms.Label()
        Me.lblWaktu = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblScoreX = New System.Windows.Forms.Label()
        Me.lblScoreO = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btn12 = New System.Windows.Forms.Button()
        Me.btn13 = New System.Windows.Forms.Button()
        Me.btn23 = New System.Windows.Forms.Button()
        Me.btn22 = New System.Windows.Forms.Button()
        Me.btn21 = New System.Windows.Forms.Button()
        Me.btn33 = New System.Windows.Forms.Button()
        Me.btn32 = New System.Windows.Forms.Button()
        Me.btn31 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblRound
        '
        Me.lblRound.AutoSize = True
        Me.lblRound.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.lblRound.Location = New System.Drawing.Point(372, 25)
        Me.lblRound.Name = "lblRound"
        Me.lblRound.Size = New System.Drawing.Size(136, 39)
        Me.lblRound.TabIndex = 0
        Me.lblRound.Text = "Round :"
        '
        'btn11
        '
        Me.btn11.Font = New System.Drawing.Font("Microsoft Sans Serif", 79.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn11.Location = New System.Drawing.Point(22, 95)
        Me.btn11.Name = "btn11"
        Me.btn11.Size = New System.Drawing.Size(152, 157)
        Me.btn11.TabIndex = 1
        Me.btn11.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(174, 95)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(0, 0)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'lblGiliran
        '
        Me.lblGiliran.AutoSize = True
        Me.lblGiliran.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.lblGiliran.Location = New System.Drawing.Point(516, 138)
        Me.lblGiliran.Name = "lblGiliran"
        Me.lblGiliran.Size = New System.Drawing.Size(107, 58)
        Me.lblGiliran.TabIndex = 11
        Me.lblGiliran.Text = "Giliran " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Pemain:"
        '
        'lblWaktu
        '
        Me.lblWaktu.AutoSize = True
        Me.lblWaktu.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.lblWaktu.Location = New System.Drawing.Point(702, 138)
        Me.lblWaktu.Name = "lblWaktu"
        Me.lblWaktu.Size = New System.Drawing.Size(204, 58)
        Me.lblWaktu.TabIndex = 12
        Me.lblWaktu.Text = "Waktu Giliran" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Pemain Tersisa :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label3.Location = New System.Drawing.Point(676, 179)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 29)
        Me.Label3.TabIndex = 13
        '
        'lblScoreX
        '
        Me.lblScoreX.AutoSize = True
        Me.lblScoreX.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.lblScoreX.Location = New System.Drawing.Point(516, 337)
        Me.lblScoreX.Name = "lblScoreX"
        Me.lblScoreX.Size = New System.Drawing.Size(211, 29)
        Me.lblScoreX.TabIndex = 14
        Me.lblScoreX.Text = "Score Pemain X :"
        '
        'lblScoreO
        '
        Me.lblScoreO.AutoSize = True
        Me.lblScoreO.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.lblScoreO.Location = New System.Drawing.Point(516, 392)
        Me.lblScoreO.Name = "lblScoreO"
        Me.lblScoreO.Size = New System.Drawing.Size(213, 29)
        Me.lblScoreO.TabIndex = 15
        Me.lblScoreO.Text = "Score Pemain O :"
        '
        'btn12
        '
        Me.btn12.Font = New System.Drawing.Font("Microsoft Sans Serif", 79.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn12.Location = New System.Drawing.Point(172, 95)
        Me.btn12.Name = "btn12"
        Me.btn12.Size = New System.Drawing.Size(152, 157)
        Me.btn12.TabIndex = 16
        Me.btn12.UseVisualStyleBackColor = True
        '
        'btn13
        '
        Me.btn13.Font = New System.Drawing.Font("Microsoft Sans Serif", 79.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn13.Location = New System.Drawing.Point(322, 95)
        Me.btn13.Name = "btn13"
        Me.btn13.Size = New System.Drawing.Size(152, 157)
        Me.btn13.TabIndex = 17
        Me.btn13.UseVisualStyleBackColor = True
        '
        'btn23
        '
        Me.btn23.Font = New System.Drawing.Font("Microsoft Sans Serif", 79.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn23.Location = New System.Drawing.Point(322, 250)
        Me.btn23.Name = "btn23"
        Me.btn23.Size = New System.Drawing.Size(152, 157)
        Me.btn23.TabIndex = 20
        Me.btn23.UseVisualStyleBackColor = True
        '
        'btn22
        '
        Me.btn22.Font = New System.Drawing.Font("Microsoft Sans Serif", 79.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn22.Location = New System.Drawing.Point(172, 250)
        Me.btn22.Name = "btn22"
        Me.btn22.Size = New System.Drawing.Size(152, 157)
        Me.btn22.TabIndex = 19
        Me.btn22.UseVisualStyleBackColor = True
        '
        'btn21
        '
        Me.btn21.Font = New System.Drawing.Font("Microsoft Sans Serif", 79.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn21.Location = New System.Drawing.Point(22, 250)
        Me.btn21.Name = "btn21"
        Me.btn21.Size = New System.Drawing.Size(152, 157)
        Me.btn21.TabIndex = 18
        Me.btn21.UseVisualStyleBackColor = True
        '
        'btn33
        '
        Me.btn33.Font = New System.Drawing.Font("Microsoft Sans Serif", 79.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn33.Location = New System.Drawing.Point(322, 405)
        Me.btn33.Name = "btn33"
        Me.btn33.Size = New System.Drawing.Size(152, 157)
        Me.btn33.TabIndex = 23
        Me.btn33.UseVisualStyleBackColor = True
        '
        'btn32
        '
        Me.btn32.Font = New System.Drawing.Font("Microsoft Sans Serif", 79.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn32.Location = New System.Drawing.Point(172, 405)
        Me.btn32.Name = "btn32"
        Me.btn32.Size = New System.Drawing.Size(152, 157)
        Me.btn32.TabIndex = 22
        Me.btn32.UseVisualStyleBackColor = True
        '
        'btn31
        '
        Me.btn31.Font = New System.Drawing.Font("Microsoft Sans Serif", 79.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn31.Location = New System.Drawing.Point(22, 405)
        Me.btn31.Name = "btn31"
        Me.btn31.Size = New System.Drawing.Size(152, 157)
        Me.btn31.TabIndex = 21
        Me.btn31.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(962, 582)
        Me.Controls.Add(Me.btn33)
        Me.Controls.Add(Me.btn32)
        Me.Controls.Add(Me.btn31)
        Me.Controls.Add(Me.btn23)
        Me.Controls.Add(Me.btn22)
        Me.Controls.Add(Me.btn21)
        Me.Controls.Add(Me.btn13)
        Me.Controls.Add(Me.btn12)
        Me.Controls.Add(Me.lblScoreO)
        Me.Controls.Add(Me.lblScoreX)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblWaktu)
        Me.Controls.Add(Me.lblGiliran)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btn11)
        Me.Controls.Add(Me.lblRound)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblRound As Label
    Friend WithEvents btn11 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents lblGiliran As Label
    Friend WithEvents lblWaktu As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblScoreX As Label
    Friend WithEvents lblScoreO As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btn12 As Button
    Friend WithEvents btn13 As Button
    Friend WithEvents btn23 As Button
    Friend WithEvents btn22 As Button
    Friend WithEvents btn21 As Button
    Friend WithEvents btn33 As Button
    Friend WithEvents btn32 As Button
    Friend WithEvents btn31 As Button
End Class
