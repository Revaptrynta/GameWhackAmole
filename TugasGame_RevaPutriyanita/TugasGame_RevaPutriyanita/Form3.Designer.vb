<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.lblScore1 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PicHome = New System.Windows.Forms.PictureBox()
        Me.PicData = New System.Windows.Forms.PictureBox()
        CType(Me.PicHome, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblScore1
        '
        Me.lblScore1.BackColor = System.Drawing.Color.Transparent
        Me.lblScore1.Font = New System.Drawing.Font("Goudy Stout", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblScore1.Image = CType(resources.GetObject("lblScore1.Image"), System.Drawing.Image)
        Me.lblScore1.Location = New System.Drawing.Point(252, 128)
        Me.lblScore1.Name = "lblScore1"
        Me.lblScore1.Size = New System.Drawing.Size(78, 28)
        Me.lblScore1.TabIndex = 13
        Me.lblScore1.Text = "0"
        Me.lblScore1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Goudy Stout", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.Location = New System.Drawing.Point(289, 158)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 27)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "0"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PicHome
        '
        Me.PicHome.BackColor = System.Drawing.Color.Transparent
        Me.PicHome.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicHome.Location = New System.Drawing.Point(80, 189)
        Me.PicHome.Name = "PicHome"
        Me.PicHome.Size = New System.Drawing.Size(90, 72)
        Me.PicHome.TabIndex = 15
        Me.PicHome.TabStop = False
        '
        'PicData
        '
        Me.PicData.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicData.Image = Global.TugasGame_RevaPutriyanita.My.Resources.Resources.data
        Me.PicData.Location = New System.Drawing.Point(316, 195)
        Me.PicData.Name = "PicData"
        Me.PicData.Size = New System.Drawing.Size(69, 59)
        Me.PicData.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicData.TabIndex = 16
        Me.PicData.TabStop = False
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(460, 298)
        Me.Controls.Add(Me.PicData)
        Me.Controls.Add(Me.PicHome)
        Me.Controls.Add(Me.lblScore1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form3"
        CType(Me.PicHome, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblScore1 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PicHome As PictureBox
    Friend WithEvents PicData As PictureBox
End Class
