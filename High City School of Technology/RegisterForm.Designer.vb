<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegisterForm
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
        Me.FemaleCheckBox = New System.Windows.Forms.CheckBox()
        Me.DoB = New System.Windows.Forms.DateTimePicker()
        Me.CountryTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.PhoneTextBox = New System.Windows.Forms.TextBox()
        Me.RegNoTextBox = New System.Windows.Forms.TextBox()
        Me.MaleCheckBox = New System.Windows.Forms.CheckBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NameTexBox = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.RegisterButton = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'FemaleCheckBox
        '
        Me.FemaleCheckBox.AutoSize = True
        Me.FemaleCheckBox.Font = New System.Drawing.Font("Poppins", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FemaleCheckBox.Location = New System.Drawing.Point(397, 33)
        Me.FemaleCheckBox.Name = "FemaleCheckBox"
        Me.FemaleCheckBox.Size = New System.Drawing.Size(93, 32)
        Me.FemaleCheckBox.TabIndex = 7
        Me.FemaleCheckBox.Text = "Female"
        Me.FemaleCheckBox.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.FemaleCheckBox.UseVisualStyleBackColor = True
        '
        'DoB
        '
        Me.DoB.CalendarMonthBackground = System.Drawing.Color.DarkGray
        Me.DoB.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DoB.Location = New System.Drawing.Point(170, 191)
        Me.DoB.Name = "DoB"
        Me.DoB.Size = New System.Drawing.Size(320, 25)
        Me.DoB.TabIndex = 6
        '
        'CountryTextBox
        '
        Me.CountryTextBox.BackColor = System.Drawing.Color.WhiteSmoke
        Me.CountryTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CountryTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CountryTextBox.Location = New System.Drawing.Point(3, 224)
        Me.CountryTextBox.Name = "CountryTextBox"
        Me.CountryTextBox.Size = New System.Drawing.Size(649, 28)
        Me.CountryTextBox.TabIndex = 5
        '
        'EmailTextBox
        '
        Me.EmailTextBox.BackColor = System.Drawing.Color.WhiteSmoke
        Me.EmailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.EmailTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailTextBox.Location = New System.Drawing.Point(3, 153)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(649, 28)
        Me.EmailTextBox.TabIndex = 4
        '
        'PhoneTextBox
        '
        Me.PhoneTextBox.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PhoneTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PhoneTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PhoneTextBox.Location = New System.Drawing.Point(3, 71)
        Me.PhoneTextBox.Name = "PhoneTextBox"
        Me.PhoneTextBox.Size = New System.Drawing.Size(649, 28)
        Me.PhoneTextBox.TabIndex = 3
        '
        'RegNoTextBox
        '
        Me.RegNoTextBox.BackColor = System.Drawing.Color.WhiteSmoke
        Me.RegNoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RegNoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RegNoTextBox.Location = New System.Drawing.Point(3, 112)
        Me.RegNoTextBox.Name = "RegNoTextBox"
        Me.RegNoTextBox.Size = New System.Drawing.Size(649, 28)
        Me.RegNoTextBox.TabIndex = 2
        '
        'MaleCheckBox
        '
        Me.MaleCheckBox.AutoSize = True
        Me.MaleCheckBox.Font = New System.Drawing.Font("Poppins", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaleCheckBox.Location = New System.Drawing.Point(170, 33)
        Me.MaleCheckBox.Name = "MaleCheckBox"
        Me.MaleCheckBox.Size = New System.Drawing.Size(72, 32)
        Me.MaleCheckBox.TabIndex = 1
        Me.MaleCheckBox.Text = "Male"
        Me.MaleCheckBox.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.MaleCheckBox.UseVisualStyleBackColor = True
        '
        'NameTextBox
        '
        Me.NameTextBox.BackColor = System.Drawing.Color.WhiteSmoke
        Me.NameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.NameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameTextBox.Location = New System.Drawing.Point(3, 3)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(649, 28)
        Me.NameTextBox.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Snow
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.FemaleCheckBox)
        Me.Panel1.Controls.Add(Me.DoB)
        Me.Panel1.Controls.Add(Me.CountryTextBox)
        Me.Panel1.Controls.Add(Me.EmailTextBox)
        Me.Panel1.Controls.Add(Me.PhoneTextBox)
        Me.Panel1.Controls.Add(Me.RegNoTextBox)
        Me.Panel1.Controls.Add(Me.MaleCheckBox)
        Me.Panel1.Controls.Add(Me.NameTextBox)
        Me.Panel1.Location = New System.Drawing.Point(123, 137)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(655, 259)
        Me.Panel1.TabIndex = 20
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.PeachPuff
        Me.Label9.Font = New System.Drawing.Font("Poppins", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(9, 215)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 37)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Country"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.PeachPuff
        Me.Label8.Font = New System.Drawing.Font("Poppins", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(22, 322)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 37)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "DoB"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.PeachPuff
        Me.Label7.Font = New System.Drawing.Font("Poppins", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(22, 285)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 37)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Email"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.PeachPuff
        Me.Label6.Font = New System.Drawing.Font("Poppins", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(22, 248)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 37)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Reg No."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.PeachPuff
        Me.Label5.Font = New System.Drawing.Font("Poppins", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(22, 211)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 37)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Phone"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.PeachPuff
        Me.Label4.Font = New System.Drawing.Font("Poppins", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(22, 174)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 37)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Gender"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Poppins SemiBold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(379, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 34)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Register"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bauhaus 93", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(77, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(699, 54)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "High City School of Technology"
        '
        'NameTexBox
        '
        Me.NameTexBox.AutoSize = True
        Me.NameTexBox.BackColor = System.Drawing.Color.PeachPuff
        Me.NameTexBox.Font = New System.Drawing.Font("Poppins", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameTexBox.Location = New System.Drawing.Point(9, 3)
        Me.NameTexBox.Name = "NameTexBox"
        Me.NameTexBox.Size = New System.Drawing.Size(81, 37)
        Me.NameTexBox.TabIndex = 11
        Me.NameTexBox.Text = "Name"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.PeachPuff
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.NameTexBox)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Location = New System.Drawing.Point(12, 137)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(814, 259)
        Me.Panel2.TabIndex = 21
        '
        'RegisterButton
        '
        Me.RegisterButton.BackColor = System.Drawing.Color.MistyRose
        Me.RegisterButton.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RegisterButton.Location = New System.Drawing.Point(374, 408)
        Me.RegisterButton.Name = "RegisterButton"
        Me.RegisterButton.Size = New System.Drawing.Size(99, 30)
        Me.RegisterButton.TabIndex = 22
        Me.RegisterButton.Text = "Register"
        Me.RegisterButton.UseVisualStyleBackColor = False
        '
        'RegisterForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.RegisterButton)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "RegisterForm"
        Me.Text = "RegisterForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FemaleCheckBox As CheckBox
    Friend WithEvents DoB As DateTimePicker
    Friend WithEvents CountryTextBox As TextBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents PhoneTextBox As TextBox
    Friend WithEvents RegNoTextBox As TextBox
    Friend WithEvents MaleCheckBox As CheckBox
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents NameTexBox As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents RegisterButton As Button
End Class
