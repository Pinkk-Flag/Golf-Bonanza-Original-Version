<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class backupform
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.quantscroll = New System.Windows.Forms.VScrollBar()
        Me.Size = New System.Windows.Forms.GroupBox()
        Me.radSingleButton = New System.Windows.Forms.RadioButton()
        Me.radKidButton = New System.Windows.Forms.RadioButton()
        Me.grpFlavour = New System.Windows.Forms.GroupBox()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.chkGloves = New System.Windows.Forms.CheckBox()
        Me.chkShoes = New System.Windows.Forms.CheckBox()
        Me.chkTees = New System.Windows.Forms.CheckBox()
        Me.chkBuggy = New System.Windows.Forms.CheckBox()
        Me.chkBalls = New System.Windows.Forms.CheckBox()
        Me.chkBag = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCost = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.Size.SuspendLayout()
        Me.grpFlavour.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.txtQuantity)
        Me.GroupBox2.Controls.Add(Me.quantscroll)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 383)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(427, 431)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Quantity"
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(42, 104)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(150, 45)
        Me.txtQuantity.TabIndex = 1
        '
        'quantscroll
        '
        Me.quantscroll.LargeChange = 1
        Me.quantscroll.Location = New System.Drawing.Point(6, 41)
        Me.quantscroll.Maximum = 10
        Me.quantscroll.Minimum = 1
        Me.quantscroll.Name = "quantscroll"
        Me.quantscroll.Size = New System.Drawing.Size(33, 187)
        Me.quantscroll.TabIndex = 0
        Me.quantscroll.Value = 1
        '
        'Size
        '
        Me.Size.BackColor = System.Drawing.Color.White
        Me.Size.Controls.Add(Me.radSingleButton)
        Me.Size.Controls.Add(Me.radKidButton)
        Me.Size.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Size.Location = New System.Drawing.Point(12, 252)
        Me.Size.Name = "Size"
        Me.Size.Size = New System.Drawing.Size(427, 179)
        Me.Size.TabIndex = 6
        Me.Size.TabStop = False
        Me.Size.Text = "Orientation"
        '
        'radSingleButton
        '
        Me.radSingleButton.AutoSize = True
        Me.radSingleButton.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.radSingleButton.Location = New System.Drawing.Point(16, 77)
        Me.radSingleButton.Name = "radSingleButton"
        Me.radSingleButton.Size = New System.Drawing.Size(88, 32)
        Me.radSingleButton.TabIndex = 1
        Me.radSingleButton.TabStop = True
        Me.radSingleButton.Text = "Right"
        Me.radSingleButton.UseVisualStyleBackColor = True
        '
        'radKidButton
        '
        Me.radKidButton.AutoSize = True
        Me.radKidButton.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.radKidButton.Location = New System.Drawing.Point(16, 39)
        Me.radKidButton.Name = "radKidButton"
        Me.radKidButton.Size = New System.Drawing.Size(74, 32)
        Me.radKidButton.TabIndex = 0
        Me.radKidButton.TabStop = True
        Me.radKidButton.Text = "Left"
        Me.radKidButton.UseVisualStyleBackColor = True
        '
        'grpFlavour
        '
        Me.grpFlavour.BackColor = System.Drawing.Color.White
        Me.grpFlavour.Controls.Add(Me.RadioButton3)
        Me.grpFlavour.Controls.Add(Me.RadioButton2)
        Me.grpFlavour.Controls.Add(Me.RadioButton1)
        Me.grpFlavour.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.grpFlavour.Location = New System.Drawing.Point(12, 95)
        Me.grpFlavour.Name = "grpFlavour"
        Me.grpFlavour.Size = New System.Drawing.Size(427, 308)
        Me.grpFlavour.TabIndex = 4
        Me.grpFlavour.TabStop = False
        Me.grpFlavour.Text = "Brand"
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.RadioButton3.Location = New System.Drawing.Point(16, 73)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(310, 29)
        Me.RadioButton3.TabIndex = 2
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Callaway Complete Set $2349.50"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.RadioButton2.Location = New System.Drawing.Point(16, 99)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(293, 29)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Titleist Complete Set $1989.45"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.RadioButton1.Location = New System.Drawing.Point(17, 47)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(334, 29)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Taylormade Complete Set $2599.95"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.chkGloves)
        Me.GroupBox3.Controls.Add(Me.chkShoes)
        Me.GroupBox3.Controls.Add(Me.chkTees)
        Me.GroupBox3.Controls.Add(Me.chkBuggy)
        Me.GroupBox3.Controls.Add(Me.chkBalls)
        Me.GroupBox3.Controls.Add(Me.chkBag)
        Me.GroupBox3.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox3.Location = New System.Drawing.Point(445, 109)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(350, 307)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Extras"
        '
        'chkGloves
        '
        Me.chkGloves.AutoSize = True
        Me.chkGloves.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.chkGloves.Location = New System.Drawing.Point(14, 267)
        Me.chkGloves.Name = "chkGloves"
        Me.chkGloves.Size = New System.Drawing.Size(183, 36)
        Me.chkGloves.TabIndex = 5
        Me.chkGloves.Text = "Gloves ($23)"
        Me.chkGloves.UseVisualStyleBackColor = True
        '
        'chkShoes
        '
        Me.chkShoes.AutoSize = True
        Me.chkShoes.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.chkShoes.Location = New System.Drawing.Point(14, 225)
        Me.chkShoes.Name = "chkShoes"
        Me.chkShoes.Size = New System.Drawing.Size(187, 36)
        Me.chkShoes.TabIndex = 4
        Me.chkShoes.Text = "Shoes ($149)"
        Me.chkShoes.UseVisualStyleBackColor = True
        '
        'chkTees
        '
        Me.chkTees.AutoSize = True
        Me.chkTees.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.chkTees.Location = New System.Drawing.Point(14, 185)
        Me.chkTees.Name = "chkTees"
        Me.chkTees.Size = New System.Drawing.Size(246, 36)
        Me.chkTees.TabIndex = 3
        Me.chkTees.Text = "50 Golf Tees ($11)"
        Me.chkTees.UseVisualStyleBackColor = True
        '
        'chkBuggy
        '
        Me.chkBuggy.AutoSize = True
        Me.chkBuggy.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.chkBuggy.Location = New System.Drawing.Point(14, 143)
        Me.chkBuggy.Name = "chkBuggy"
        Me.chkBuggy.Size = New System.Drawing.Size(249, 36)
        Me.chkBuggy.TabIndex = 2
        Me.chkBuggy.Text = "Golf Buggy ($190)"
        Me.chkBuggy.UseVisualStyleBackColor = True
        '
        'chkBalls
        '
        Me.chkBalls.AutoSize = True
        Me.chkBalls.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.chkBalls.Location = New System.Drawing.Point(14, 101)
        Me.chkBalls.Name = "chkBalls"
        Me.chkBalls.Size = New System.Drawing.Size(215, 36)
        Me.chkBalls.TabIndex = 1
        Me.chkBalls.Text = "Golf Balls ($45)"
        Me.chkBalls.UseVisualStyleBackColor = True
        '
        'chkBag
        '
        Me.chkBag.AutoSize = True
        Me.chkBag.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.chkBag.Location = New System.Drawing.Point(14, 59)
        Me.chkBag.Name = "chkBag"
        Me.chkBag.Size = New System.Drawing.Size(219, 36)
        Me.chkBag.TabIndex = 0
        Me.chkBag.Text = "Golf Bag ($325)"
        Me.chkBag.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(459, 451)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 45)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Cost:"
        '
        'txtCost
        '
        Me.txtCost.Location = New System.Drawing.Point(560, 450)
        Me.txtCost.Multiline = True
        Me.txtCost.Name = "txtCost"
        Me.txtCost.Size = New System.Drawing.Size(150, 46)
        Me.txtCost.TabIndex = 9
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button1.Location = New System.Drawing.Point(350, 553)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(156, 45)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Calculate"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnQuit.Location = New System.Drawing.Point(656, 555)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(135, 43)
        Me.btnQuit.TabIndex = 11
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnReset.Location = New System.Drawing.Point(512, 555)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(138, 45)
        Me.btnReset.TabIndex = 10
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Golf_Bonanza.My.Resources.Resources.Golf_Bonanza_Logo
        Me.PictureBox1.Location = New System.Drawing.Point(290, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(190, 102)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button2.Location = New System.Drawing.Point(545, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(246, 45)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Ooops! I want to go back!"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button3.Location = New System.Drawing.Point(499, 63)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(292, 45)
        Me.Button3.TabIndex = 14
        Me.Button3.Text = "Information about Calcualtions"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'backupform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 636)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.txtCost)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Size)
        Me.Controls.Add(Me.grpFlavour)
        Me.Name = "backupform"
        Me.Text = "backupform"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Size.ResumeLayout(False)
        Me.Size.PerformLayout()
        Me.grpFlavour.ResumeLayout(False)
        Me.grpFlavour.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents quantscroll As VScrollBar
    Friend WithEvents Size As GroupBox
    Friend WithEvents radSingleButton As RadioButton
    Friend WithEvents radKidButton As RadioButton
    Friend WithEvents grpFlavour As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents chkGloves As CheckBox
    Friend WithEvents chkShoes As CheckBox
    Friend WithEvents chkTees As CheckBox
    Friend WithEvents chkBuggy As CheckBox
    Friend WithEvents chkBalls As CheckBox
    Friend WithEvents chkBag As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCost As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents btnQuit As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
