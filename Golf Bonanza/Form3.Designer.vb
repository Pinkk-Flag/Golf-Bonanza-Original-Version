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
        Me.btnNext = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.NoneSelected = New System.Windows.Forms.CheckBox()
        Me.GolfGloves = New System.Windows.Forms.CheckBox()
        Me.GolfShoes = New System.Windows.Forms.CheckBox()
        Me.chkSauceBox = New System.Windows.Forms.CheckBox()
        Me.chkFruitBox = New System.Windows.Forms.CheckBox()
        Me.chkNutBox = New System.Windows.Forms.CheckBox()
        Me.GolfTees = New System.Windows.Forms.CheckBox()
        Me.GolfBuggy = New System.Windows.Forms.CheckBox()
        Me.GolfBalls = New System.Windows.Forms.CheckBox()
        Me.GolfBag = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnNext
        '
        Me.btnNext.Font = New System.Drawing.Font("Yu Gothic", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnNext.Location = New System.Drawing.Point(678, 13)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(112, 45)
        Me.btnNext.TabIndex = 29
        Me.btnNext.Text = "Back"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Yu Gothic", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(300, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 29)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Golf Bonanza"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Yu Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(10, 147)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(692, 23)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Select the extras that you want to get (optional) or press none if you don't want" &
    " any"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Golf_Bonanza.My.Resources.Resources.Frame__1_
        Me.PictureBox2.Location = New System.Drawing.Point(14, 185)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(776, 254)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 21
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Golf_Bonanza.My.Resources.Resources.Golf_Bonanza_Logo
        Me.PictureBox1.Location = New System.Drawing.Point(330, 42)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(102, 95)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.NoneSelected)
        Me.GroupBox3.Controls.Add(Me.GolfGloves)
        Me.GroupBox3.Controls.Add(Me.GolfShoes)
        Me.GroupBox3.Controls.Add(Me.chkSauceBox)
        Me.GroupBox3.Controls.Add(Me.chkFruitBox)
        Me.GroupBox3.Controls.Add(Me.chkNutBox)
        Me.GroupBox3.Controls.Add(Me.GolfTees)
        Me.GroupBox3.Controls.Add(Me.GolfBuggy)
        Me.GroupBox3.Controls.Add(Me.GolfBalls)
        Me.GroupBox3.Controls.Add(Me.GolfBag)
        Me.GroupBox3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox3.Location = New System.Drawing.Point(29, 198)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(600, 224)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Extras"
        '
        'NoneSelected
        '
        Me.NoneSelected.AutoSize = True
        Me.NoneSelected.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.NoneSelected.Location = New System.Drawing.Point(14, 185)
        Me.NoneSelected.Name = "NoneSelected"
        Me.NoneSelected.Size = New System.Drawing.Size(124, 32)
        Me.NoneSelected.TabIndex = 9
        Me.NoneSelected.Text = "None: $0"
        Me.NoneSelected.UseVisualStyleBackColor = True
        '
        'GolfGloves
        '
        Me.GolfGloves.AutoSize = True
        Me.GolfGloves.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GolfGloves.Location = New System.Drawing.Point(330, 143)
        Me.GolfGloves.Name = "GolfGloves"
        Me.GolfGloves.Size = New System.Drawing.Size(251, 32)
        Me.GolfGloves.TabIndex = 8
        Me.GolfGloves.Text = "Golf Gloves (Pair): $23"
        Me.GolfGloves.UseVisualStyleBackColor = True
        '
        'GolfShoes
        '
        Me.GolfShoes.AutoSize = True
        Me.GolfShoes.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GolfShoes.Location = New System.Drawing.Point(330, 101)
        Me.GolfShoes.Name = "GolfShoes"
        Me.GolfShoes.Size = New System.Drawing.Size(198, 32)
        Me.GolfShoes.TabIndex = 7
        Me.GolfShoes.Text = "Golf Shoes: $149"
        Me.GolfShoes.UseVisualStyleBackColor = True
        '
        'chkSauceBox
        '
        Me.chkSauceBox.AutoSize = True
        Me.chkSauceBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.chkSauceBox.Location = New System.Drawing.Point(14, 309)
        Me.chkSauceBox.Name = "chkSauceBox"
        Me.chkSauceBox.Size = New System.Drawing.Size(226, 36)
        Me.chkSauceBox.TabIndex = 6
        Me.chkSauceBox.Text = "Chocolate Sauce"
        Me.chkSauceBox.UseVisualStyleBackColor = True
        '
        'chkFruitBox
        '
        Me.chkFruitBox.AutoSize = True
        Me.chkFruitBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.chkFruitBox.Location = New System.Drawing.Point(14, 267)
        Me.chkFruitBox.Name = "chkFruitBox"
        Me.chkFruitBox.Size = New System.Drawing.Size(104, 36)
        Me.chkFruitBox.TabIndex = 5
        Me.chkFruitBox.Text = "Fruits"
        Me.chkFruitBox.UseVisualStyleBackColor = True
        '
        'chkNutBox
        '
        Me.chkNutBox.AutoSize = True
        Me.chkNutBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.chkNutBox.Location = New System.Drawing.Point(14, 225)
        Me.chkNutBox.Name = "chkNutBox"
        Me.chkNutBox.Size = New System.Drawing.Size(203, 36)
        Me.chkNutBox.TabIndex = 4
        Me.chkNutBox.Text = "Chopped Nuts"
        Me.chkNutBox.UseVisualStyleBackColor = True
        '
        'GolfTees
        '
        Me.GolfTees.AutoSize = True
        Me.GolfTees.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GolfTees.Location = New System.Drawing.Point(330, 59)
        Me.GolfTees.Name = "GolfTees"
        Me.GolfTees.Size = New System.Drawing.Size(266, 32)
        Me.GolfTees.TabIndex = 3
        Me.GolfTees.Text = "Golf Tees (50 Pack): $11"
        Me.GolfTees.UseVisualStyleBackColor = True
        '
        'GolfBuggy
        '
        Me.GolfBuggy.AutoSize = True
        Me.GolfBuggy.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GolfBuggy.Location = New System.Drawing.Point(14, 143)
        Me.GolfBuggy.Name = "GolfBuggy"
        Me.GolfBuggy.Size = New System.Drawing.Size(203, 32)
        Me.GolfBuggy.TabIndex = 2
        Me.GolfBuggy.Text = "Golf Buggy: $190"
        Me.GolfBuggy.UseVisualStyleBackColor = True
        '
        'GolfBalls
        '
        Me.GolfBalls.AutoSize = True
        Me.GolfBalls.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GolfBalls.Location = New System.Drawing.Point(14, 101)
        Me.GolfBalls.Name = "GolfBalls"
        Me.GolfBalls.Size = New System.Drawing.Size(270, 32)
        Me.GolfBalls.TabIndex = 1
        Me.GolfBalls.Text = "Golf Balls (12 Pack): $45"
        Me.GolfBalls.UseVisualStyleBackColor = True
        '
        'GolfBag
        '
        Me.GolfBag.AutoSize = True
        Me.GolfBag.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GolfBag.Location = New System.Drawing.Point(14, 59)
        Me.GolfBag.Name = "GolfBag"
        Me.GolfBag.Size = New System.Drawing.Size(179, 32)
        Me.GolfBag.TabIndex = 0
        Me.GolfBag.Text = "Golf Bag: $325"
        Me.GolfBag.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Yu Gothic", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button1.Location = New System.Drawing.Point(282, 407)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 45)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Next"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form3"
        Me.Text = "Form3"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnNext As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GolfGloves As CheckBox
    Friend WithEvents GolfShoes As CheckBox
    Friend WithEvents chkSauceBox As CheckBox
    Friend WithEvents chkFruitBox As CheckBox
    Friend WithEvents chkNutBox As CheckBox
    Friend WithEvents GolfTees As CheckBox
    Friend WithEvents GolfBuggy As CheckBox
    Friend WithEvents GolfBalls As CheckBox
    Friend WithEvents GolfBag As CheckBox
    Friend WithEvents Button1 As Button
    Friend WithEvents NoneSelected As CheckBox
End Class
