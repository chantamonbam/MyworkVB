<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLab2
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtSalesVistra = New System.Windows.Forms.TextBox()
        Me.txtSalseFrista = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblTotalSalse = New System.Windows.Forms.Label()
        Me.lblCommission1 = New System.Windows.Forms.Label()
        Me.lblCommossion2 = New System.Windows.Forms.Label()
        Me.lblTotalCommission = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(283, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(208, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ยอดขายสินค้า 2 ยอด"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(28, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(183, 41)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "ยอดขาย Vistra Gluta"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(28, 176)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(183, 38)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "ยอดขาย Frista Gluta"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(28, 237)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(183, 38)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "ผลรวมยอดขาย"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(28, 304)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(183, 38)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "ค่าคอมมิชชั่น1"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(28, 369)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(183, 38)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "ค่าคอมมิชชั่น2"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Lime
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.Location = New System.Drawing.Point(28, 429)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(183, 38)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "ค่าคอมมิชชั่นรวม"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtSalesVistra
        '
        Me.txtSalesVistra.Location = New System.Drawing.Point(287, 101)
        Me.txtSalesVistra.Multiline = True
        Me.txtSalesVistra.Name = "txtSalesVistra"
        Me.txtSalesVistra.Size = New System.Drawing.Size(204, 41)
        Me.txtSalesVistra.TabIndex = 1
        '
        'txtSalseFrista
        '
        Me.txtSalseFrista.Location = New System.Drawing.Point(287, 173)
        Me.txtSalseFrista.Multiline = True
        Me.txtSalseFrista.Name = "txtSalseFrista"
        Me.txtSalseFrista.Size = New System.Drawing.Size(204, 41)
        Me.txtSalseFrista.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.Location = New System.Drawing.Point(283, 237)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(208, 38)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "ค่าคอมมิชชั่นรวม"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTotalSalse
        '
        Me.lblTotalSalse.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblTotalSalse.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblTotalSalse.Location = New System.Drawing.Point(283, 237)
        Me.lblTotalSalse.Name = "lblTotalSalse"
        Me.lblTotalSalse.Size = New System.Drawing.Size(208, 38)
        Me.lblTotalSalse.TabIndex = 3
        Me.lblTotalSalse.Text = " "
        Me.lblTotalSalse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCommission1
        '
        Me.lblCommission1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblCommission1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblCommission1.Location = New System.Drawing.Point(283, 304)
        Me.lblCommission1.Name = "lblCommission1"
        Me.lblCommission1.Size = New System.Drawing.Size(208, 38)
        Me.lblCommission1.TabIndex = 4
        Me.lblCommission1.Text = " "
        Me.lblCommission1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCommossion2
        '
        Me.lblCommossion2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblCommossion2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblCommossion2.Location = New System.Drawing.Point(283, 369)
        Me.lblCommossion2.Name = "lblCommossion2"
        Me.lblCommossion2.Size = New System.Drawing.Size(208, 38)
        Me.lblCommossion2.TabIndex = 5
        Me.lblCommossion2.Text = " "
        Me.lblCommossion2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTotalCommission
        '
        Me.lblTotalCommission.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblTotalCommission.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblTotalCommission.Location = New System.Drawing.Point(283, 429)
        Me.lblTotalCommission.Name = "lblTotalCommission"
        Me.lblTotalCommission.Size = New System.Drawing.Size(208, 38)
        Me.lblTotalCommission.TabIndex = 6
        Me.lblTotalCommission.Text = " "
        Me.lblTotalCommission.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(589, 246)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(115, 38)
        Me.btnCalculate.TabIndex = 7
        Me.btnCalculate.Text = "คำนวณ"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Yellow
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnClose.Location = New System.Drawing.Point(636, 305)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(115, 38)
        Me.btnClose.TabIndex = 8
        Me.btnClose.Text = "ปิด"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'frmLab2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(801, 507)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtSalseFrista)
        Me.Controls.Add(Me.txtSalesVistra)
        Me.Controls.Add(Me.lblTotalCommission)
        Me.Controls.Add(Me.lblCommossion2)
        Me.Controls.Add(Me.lblCommission1)
        Me.Controls.Add(Me.lblTotalSalse)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmLab2"
        Me.Text = "frmLab2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtSalesVistra As System.Windows.Forms.TextBox
    Friend WithEvents txtSalseFrista As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblTotalSalse As System.Windows.Forms.Label
    Friend WithEvents lblCommission1 As System.Windows.Forms.Label
    Friend WithEvents lblCommossion2 As System.Windows.Forms.Label
    Friend WithEvents lblTotalCommission As System.Windows.Forms.Label
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
End Class
