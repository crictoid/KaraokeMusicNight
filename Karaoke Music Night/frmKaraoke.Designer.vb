<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKaraoke
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.cboOption = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblSongs = New System.Windows.Forms.Label()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnTotalCost = New System.Windows.Forms.Button()
        Me.txtRental = New System.Windows.Forms.TextBox()
        Me.lblHourly = New System.Windows.Forms.Label()
        Me.lblChoose = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Black
        Me.lblTitle.Font = New System.Drawing.Font("Myanmar Text", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(47, 10)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(309, 51)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Karaoke Music Night"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cboOption
        '
        Me.cboOption.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboOption.FormattingEnabled = True
        Me.cboOption.Items.AddRange(New Object() {"Number of Songs ($2.99 per song)", "Hours in Private Karaoke Booth ($8.99 per hour)"})
        Me.cboOption.Location = New System.Drawing.Point(20, 83)
        Me.cboOption.Name = "cboOption"
        Me.cboOption.Size = New System.Drawing.Size(363, 28)
        Me.cboOption.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.lblChoose)
        Me.Panel1.Controls.Add(Me.lblSongs)
        Me.Panel1.Controls.Add(Me.lblCost)
        Me.Panel1.Controls.Add(Me.btnClear)
        Me.Panel1.Controls.Add(Me.btnTotalCost)
        Me.Panel1.Controls.Add(Me.txtRental)
        Me.Panel1.Controls.Add(Me.lblHourly)
        Me.Panel1.Controls.Add(Me.lblTitle)
        Me.Panel1.Controls.Add(Me.cboOption)
        Me.Panel1.Location = New System.Drawing.Point(395, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(403, 464)
        Me.Panel1.TabIndex = 5
        '
        'lblSongs
        '
        Me.lblSongs.AutoSize = True
        Me.lblSongs.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSongs.ForeColor = System.Drawing.Color.White
        Me.lblSongs.Location = New System.Drawing.Point(73, 134)
        Me.lblSongs.Name = "lblSongs"
        Me.lblSongs.Size = New System.Drawing.Size(256, 25)
        Me.lblSongs.TabIndex = 10
        Me.lblSongs.Text = "Number of Songs to Play:"
        Me.lblSongs.Visible = False
        '
        'lblCost
        '
        Me.lblCost.AutoSize = True
        Me.lblCost.BackColor = System.Drawing.Color.Black
        Me.lblCost.Font = New System.Drawing.Font("Myanmar Text", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCost.ForeColor = System.Drawing.Color.White
        Me.lblCost.Location = New System.Drawing.Point(30, 346)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(343, 34)
        Me.lblCost.TabIndex = 9
        Me.lblCost.Text = "Total Cost of Karaoke Night - $XX.XX"
        Me.lblCost.Visible = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.White
        Me.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClear.Font = New System.Drawing.Font("Myanmar Text", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.Black
        Me.btnClear.Location = New System.Drawing.Point(209, 233)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(174, 56)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Clear Form"
        Me.btnClear.UseVisualStyleBackColor = False
        Me.btnClear.Visible = False
        '
        'btnTotalCost
        '
        Me.btnTotalCost.BackColor = System.Drawing.Color.White
        Me.btnTotalCost.Font = New System.Drawing.Font("Myanmar Text", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTotalCost.ForeColor = System.Drawing.Color.Black
        Me.btnTotalCost.Location = New System.Drawing.Point(20, 233)
        Me.btnTotalCost.Name = "btnTotalCost"
        Me.btnTotalCost.Size = New System.Drawing.Size(174, 56)
        Me.btnTotalCost.TabIndex = 6
        Me.btnTotalCost.Text = "Total Cost"
        Me.btnTotalCost.UseVisualStyleBackColor = False
        Me.btnTotalCost.Visible = False
        '
        'txtRental
        '
        Me.txtRental.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRental.Location = New System.Drawing.Point(170, 187)
        Me.txtRental.Name = "txtRental"
        Me.txtRental.Size = New System.Drawing.Size(63, 31)
        Me.txtRental.TabIndex = 4
        Me.txtRental.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtRental.Visible = False
        '
        'lblHourly
        '
        Me.lblHourly.AutoSize = True
        Me.lblHourly.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHourly.ForeColor = System.Drawing.Color.White
        Me.lblHourly.Location = New System.Drawing.Point(41, 134)
        Me.lblHourly.Name = "lblHourly"
        Me.lblHourly.Size = New System.Drawing.Size(320, 25)
        Me.lblHourly.TabIndex = 3
        Me.lblHourly.Text = "Hourly Rental of Karaoke Room:"
        Me.lblHourly.Visible = False
        '
        'lblChoose
        '
        Me.lblChoose.AutoSize = True
        Me.lblChoose.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChoose.ForeColor = System.Drawing.Color.White
        Me.lblChoose.Location = New System.Drawing.Point(37, 134)
        Me.lblChoose.Name = "lblChoose"
        Me.lblChoose.Size = New System.Drawing.Size(329, 25)
        Me.lblChoose.TabIndex = 11
        Me.lblChoose.Text = "Enter Number of Songs or Hours:"
        Me.lblChoose.Visible = False
        '
        'frmKaraoke
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Karaoke_Music_Night.My.Resources.Resources.karaoke
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmKaraoke"
        Me.Text = "Karaoke Music Night"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents cboOption As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblCost As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents btnTotalCost As Button
    Friend WithEvents txtRental As TextBox
    Friend WithEvents lblHourly As Label
    Friend WithEvents lblSongs As Label
    Friend WithEvents lblChoose As Label
End Class
