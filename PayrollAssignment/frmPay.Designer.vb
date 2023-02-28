<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPay
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPay))
        Me.picPay = New System.Windows.Forms.PictureBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblSub = New System.Windows.Forms.Label()
        Me.lblRequest = New System.Windows.Forms.Label()
        Me.btnTaxCalc = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.tbxInput = New System.Windows.Forms.TextBox()
        Me.lblFICA = New System.Windows.Forms.Label()
        Me.lblFed = New System.Windows.Forms.Label()
        Me.lblState = New System.Windows.Forms.Label()
        Me.lblNetLb = New System.Windows.Forms.Label()
        Me.lblFinal = New System.Windows.Forms.Label()
        Me.lblFiCalc = New System.Windows.Forms.Label()
        Me.lblFedCalc = New System.Windows.Forms.Label()
        Me.lblStateCalc = New System.Windows.Forms.Label()
        Me.lblError = New System.Windows.Forms.Label()
        CType(Me.picPay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picPay
        '
        Me.picPay.Image = CType(resources.GetObject("picPay.Image"), System.Drawing.Image)
        Me.picPay.Location = New System.Drawing.Point(0, 0)
        Me.picPay.Name = "picPay"
        Me.picPay.Size = New System.Drawing.Size(500, 334)
        Me.picPay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPay.TabIndex = 0
        Me.picPay.TabStop = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Impact", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(607, 19)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(276, 43)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Payroll Calculator"
        '
        'lblSub
        '
        Me.lblSub.AutoSize = True
        Me.lblSub.Font = New System.Drawing.Font("Source Code Pro", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSub.ForeColor = System.Drawing.Color.White
        Me.lblSub.Location = New System.Drawing.Point(637, 65)
        Me.lblSub.Name = "lblSub"
        Me.lblSub.Size = New System.Drawing.Size(209, 20)
        Me.lblSub.TabIndex = 2
        Me.lblSub.Text = "Paycheck Calculation"
        '
        'lblRequest
        '
        Me.lblRequest.AutoSize = True
        Me.lblRequest.Font = New System.Drawing.Font("Source Code Pro", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRequest.ForeColor = System.Drawing.Color.White
        Me.lblRequest.Location = New System.Drawing.Point(534, 116)
        Me.lblRequest.Name = "lblRequest"
        Me.lblRequest.Size = New System.Drawing.Size(192, 17)
        Me.lblRequest.TabIndex = 3
        Me.lblRequest.Text = "Please enter gross pay:"
        '
        'btnTaxCalc
        '
        Me.btnTaxCalc.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.btnTaxCalc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTaxCalc.Enabled = False
        Me.btnTaxCalc.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(171, Byte), Integer))
        Me.btnTaxCalc.FlatAppearance.BorderSize = 0
        Me.btnTaxCalc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTaxCalc.Font = New System.Drawing.Font("Source Code Pro", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTaxCalc.ForeColor = System.Drawing.Color.White
        Me.btnTaxCalc.Location = New System.Drawing.Point(580, 159)
        Me.btnTaxCalc.Name = "btnTaxCalc"
        Me.btnTaxCalc.Size = New System.Drawing.Size(95, 25)
        Me.btnTaxCalc.TabIndex = 4
        Me.btnTaxCalc.Text = "Compute Tax"
        Me.btnTaxCalc.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.btnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClear.Enabled = False
        Me.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(171, Byte), Integer))
        Me.btnClear.FlatAppearance.BorderSize = 0
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Source Code Pro", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Location = New System.Drawing.Point(692, 159)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(95, 25)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(171, Byte), Integer))
        Me.btnExit.FlatAppearance.BorderSize = 0
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Source Code Pro", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.Location = New System.Drawing.Point(804, 159)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(95, 25)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'tbxInput
        '
        Me.tbxInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxInput.Location = New System.Drawing.Point(733, 116)
        Me.tbxInput.Name = "tbxInput"
        Me.tbxInput.Size = New System.Drawing.Size(100, 20)
        Me.tbxInput.TabIndex = 7
        '
        'lblFICA
        '
        Me.lblFICA.AutoSize = True
        Me.lblFICA.Font = New System.Drawing.Font("Source Code Pro", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFICA.ForeColor = System.Drawing.Color.White
        Me.lblFICA.Location = New System.Drawing.Point(534, 204)
        Me.lblFICA.Name = "lblFICA"
        Me.lblFICA.Size = New System.Drawing.Size(48, 17)
        Me.lblFICA.TabIndex = 8
        Me.lblFICA.Text = "FICA:"
        '
        'lblFed
        '
        Me.lblFed.AutoSize = True
        Me.lblFed.Font = New System.Drawing.Font("Source Code Pro", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFed.ForeColor = System.Drawing.Color.White
        Me.lblFed.Location = New System.Drawing.Point(534, 223)
        Me.lblFed.Name = "lblFed"
        Me.lblFed.Size = New System.Drawing.Size(104, 17)
        Me.lblFed.TabIndex = 9
        Me.lblFed.Text = "Federal Tax:"
        '
        'lblState
        '
        Me.lblState.AutoSize = True
        Me.lblState.Font = New System.Drawing.Font("Source Code Pro", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblState.ForeColor = System.Drawing.Color.White
        Me.lblState.Location = New System.Drawing.Point(534, 242)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(88, 17)
        Me.lblState.TabIndex = 10
        Me.lblState.Text = "State Tax:"
        '
        'lblNetLb
        '
        Me.lblNetLb.AutoSize = True
        Me.lblNetLb.Font = New System.Drawing.Font("Source Code Pro", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNetLb.ForeColor = System.Drawing.Color.White
        Me.lblNetLb.Location = New System.Drawing.Point(535, 280)
        Me.lblNetLb.Name = "lblNetLb"
        Me.lblNetLb.Size = New System.Drawing.Size(168, 17)
        Me.lblNetLb.TabIndex = 11
        Me.lblNetLb.Text = "Net Paycheck Income:"
        '
        'lblFinal
        '
        Me.lblFinal.AutoSize = True
        Me.lblFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFinal.ForeColor = System.Drawing.Color.White
        Me.lblFinal.Location = New System.Drawing.Point(699, 280)
        Me.lblFinal.Name = "lblFinal"
        Me.lblFinal.Size = New System.Drawing.Size(0, 16)
        Me.lblFinal.TabIndex = 12
        '
        'lblFiCalc
        '
        Me.lblFiCalc.AutoSize = True
        Me.lblFiCalc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFiCalc.ForeColor = System.Drawing.Color.White
        Me.lblFiCalc.Location = New System.Drawing.Point(577, 204)
        Me.lblFiCalc.Name = "lblFiCalc"
        Me.lblFiCalc.Size = New System.Drawing.Size(0, 16)
        Me.lblFiCalc.TabIndex = 13
        '
        'lblFedCalc
        '
        Me.lblFedCalc.AutoSize = True
        Me.lblFedCalc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFedCalc.ForeColor = System.Drawing.Color.White
        Me.lblFedCalc.Location = New System.Drawing.Point(633, 223)
        Me.lblFedCalc.Name = "lblFedCalc"
        Me.lblFedCalc.Size = New System.Drawing.Size(0, 16)
        Me.lblFedCalc.TabIndex = 14
        '
        'lblStateCalc
        '
        Me.lblStateCalc.AutoSize = True
        Me.lblStateCalc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStateCalc.ForeColor = System.Drawing.Color.White
        Me.lblStateCalc.Location = New System.Drawing.Point(617, 243)
        Me.lblStateCalc.Name = "lblStateCalc"
        Me.lblStateCalc.Size = New System.Drawing.Size(0, 16)
        Me.lblStateCalc.TabIndex = 15
        '
        'lblError
        '
        Me.lblError.AutoSize = True
        Me.lblError.Font = New System.Drawing.Font("Source Code Pro", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblError.ForeColor = System.Drawing.Color.IndianRed
        Me.lblError.Location = New System.Drawing.Point(702, 280)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(232, 17)
        Me.lblError.TabIndex = 16
        Me.lblError.Text = "Can't calculate that; sorry!"
        Me.lblError.Visible = False
        '
        'frmPay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(964, 331)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.lblStateCalc)
        Me.Controls.Add(Me.lblFedCalc)
        Me.Controls.Add(Me.lblFiCalc)
        Me.Controls.Add(Me.lblFinal)
        Me.Controls.Add(Me.lblNetLb)
        Me.Controls.Add(Me.lblState)
        Me.Controls.Add(Me.lblFed)
        Me.Controls.Add(Me.lblFICA)
        Me.Controls.Add(Me.tbxInput)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnTaxCalc)
        Me.Controls.Add(Me.lblRequest)
        Me.Controls.Add(Me.lblSub)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.picPay)
        Me.Name = "frmPay"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Payroll Every Two Weeks"
        CType(Me.picPay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picPay As PictureBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblSub As Label
    Friend WithEvents lblRequest As Label
    Friend WithEvents btnTaxCalc As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents tbxInput As TextBox
    Friend WithEvents lblFICA As Label
    Friend WithEvents lblFed As Label
    Friend WithEvents lblState As Label
    Friend WithEvents lblNetLb As Label
    Friend WithEvents lblFinal As Label
    Friend WithEvents lblFiCalc As Label
    Friend WithEvents lblFedCalc As Label
    Friend WithEvents lblStateCalc As Label
    Friend WithEvents lblError As Label
End Class
