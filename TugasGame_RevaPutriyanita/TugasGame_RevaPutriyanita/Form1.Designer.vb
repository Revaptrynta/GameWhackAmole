<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lblScore = New System.Windows.Forms.Label()
        Me.PicPlay = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PicPlay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblScore
        '
        Me.lblScore.BackColor = System.Drawing.Color.Transparent
        Me.lblScore.Font = New System.Drawing.Font("Goudy Stout", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblScore.Image = CType(resources.GetObject("lblScore.Image"), System.Drawing.Image)
        Me.lblScore.Location = New System.Drawing.Point(406, 73)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(78, 21)
        Me.lblScore.TabIndex = 18
        Me.lblScore.Text = "0"
        '
        'PicPlay
        '
        Me.PicPlay.BackColor = System.Drawing.Color.Transparent
        Me.PicPlay.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicPlay.Location = New System.Drawing.Point(281, 296)
        Me.PicPlay.Name = "PicPlay"
        Me.PicPlay.Size = New System.Drawing.Size(125, 92)
        Me.PicPlay.TabIndex = 17
        Me.PicPlay.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.ForeColor = System.Drawing.Color.BurlyWood
        Me.Button1.Location = New System.Drawing.Point(581, 433)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Data Score"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(656, 457)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.PicPlay)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PicPlay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblScore As Label
    Friend WithEvents PicPlay As PictureBox
    Friend WithEvents Button1 As Button
End Class
