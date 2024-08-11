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
        dataGridView1 = New DataGridView()
        txtFirstName = New TextBox()
        txtLastName = New TextBox()
        btnAdd = New Button()
        btnDelete = New Button()
        CType(dataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dataGridView1
        ' 
        dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dataGridView1.Location = New Point(279, 75)
        dataGridView1.Name = "dataGridView1"
        dataGridView1.RowHeadersWidth = 102
        dataGridView1.Size = New Size(826, 375)
        dataGridView1.TabIndex = 0
        ' 
        ' txtFirstName
        ' 
        txtFirstName.Location = New Point(279, 534)
        txtFirstName.Name = "txtFirstName"
        txtFirstName.Size = New Size(250, 47)
        txtFirstName.TabIndex = 1
        txtFirstName.Text = vbCrLf & "First Name"
        ' 
        ' txtLastName
        ' 
        txtLastName.Location = New Point(573, 534)
        txtLastName.Name = "txtLastName"
        txtLastName.Size = New Size(250, 47)
        txtLastName.TabIndex = 2
        txtLastName.Text = "Last Name"
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(279, 612)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(188, 58)
        btnAdd.TabIndex = 3
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(1111, 218)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(188, 58)
        btnDelete.TabIndex = 4
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(17.0F, 41.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1404, 1005)
        Controls.Add(btnDelete)
        Controls.Add(btnAdd)
        Controls.Add(txtLastName)
        Controls.Add(txtFirstName)
        Controls.Add(dataGridView1)
        Name = "Form1"
        Text = "Form1"
        CType(dataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dataGridView1 As DataGridView
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnDelete As Button

End Class
