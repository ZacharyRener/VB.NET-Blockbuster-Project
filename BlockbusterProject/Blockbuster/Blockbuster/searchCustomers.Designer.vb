<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class searchCustomers
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radLastName = New System.Windows.Forms.RadioButton()
        Me.radMembershipID = New System.Windows.Forms.RadioButton()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnSelectCustomer = New System.Windows.Forms.Button()
        Me.MembershipIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ZipCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhoneNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ActivationDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DOBDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AgeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MembershipsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BlockbustersDataSet = New Blockbuster.BlockbustersDataSet()
        Me.BlockbustersDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MembershipsTableAdapter = New Blockbuster.BlockbustersDataSetTableAdapters.MembershipsTableAdapter()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MembershipsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BlockbustersDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BlockbustersDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radLastName)
        Me.GroupBox1.Controls.Add(Me.radMembershipID)
        Me.GroupBox1.Controls.Add(Me.btnSearch)
        Me.GroupBox1.Controls.Add(Me.txtSearch)
        Me.GroupBox1.Location = New System.Drawing.Point(40, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(770, 246)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "I would like to search by:"
        '
        'radLastName
        '
        Me.radLastName.AutoSize = True
        Me.radLastName.Location = New System.Drawing.Point(56, 107)
        Me.radLastName.Name = "radLastName"
        Me.radLastName.Size = New System.Drawing.Size(146, 29)
        Me.radLastName.TabIndex = 9
        Me.radLastName.TabStop = True
        Me.radLastName.Text = "Last Name"
        Me.radLastName.UseVisualStyleBackColor = True
        '
        'radMembershipID
        '
        Me.radMembershipID.AutoSize = True
        Me.radMembershipID.Location = New System.Drawing.Point(56, 72)
        Me.radMembershipID.Name = "radMembershipID"
        Me.radMembershipID.Size = New System.Drawing.Size(187, 29)
        Me.radMembershipID.TabIndex = 7
        Me.radMembershipID.TabStop = True
        Me.radMembershipID.Text = "Membership ID"
        Me.radMembershipID.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(479, 166)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(226, 42)
        Me.btnSearch.TabIndex = 4
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(56, 166)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(386, 31)
        Me.txtSearch.TabIndex = 5
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Controls.Add(Me.btnSelectCustomer)
        Me.GroupBox2.Location = New System.Drawing.Point(40, 305)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(770, 730)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Customer Information"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MembershipIDDataGridViewTextBoxColumn, Me.FirstNameDataGridViewTextBoxColumn, Me.LastNameDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.CityDataGridViewTextBoxColumn, Me.StateDataGridViewTextBoxColumn, Me.ZipCodeDataGridViewTextBoxColumn, Me.PhoneNumberDataGridViewTextBoxColumn, Me.ActivationDateDataGridViewTextBoxColumn, Me.DOBDataGridViewTextBoxColumn, Me.AgeDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.MembershipsBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(33, 55)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 33
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(699, 547)
        Me.DataGridView1.TabIndex = 27
        '
        'btnSelectCustomer
        '
        Me.btnSelectCustomer.Location = New System.Drawing.Point(430, 643)
        Me.btnSelectCustomer.Name = "btnSelectCustomer"
        Me.btnSelectCustomer.Size = New System.Drawing.Size(302, 49)
        Me.btnSelectCustomer.TabIndex = 7
        Me.btnSelectCustomer.Text = "Select This Customer"
        Me.btnSelectCustomer.UseVisualStyleBackColor = True
        '
        'MembershipIDDataGridViewTextBoxColumn
        '
        Me.MembershipIDDataGridViewTextBoxColumn.DataPropertyName = "MembershipID#"
        Me.MembershipIDDataGridViewTextBoxColumn.HeaderText = "MembershipID#"
        Me.MembershipIDDataGridViewTextBoxColumn.Name = "MembershipIDDataGridViewTextBoxColumn"
        Me.MembershipIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FirstNameDataGridViewTextBoxColumn
        '
        Me.FirstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName"
        Me.FirstNameDataGridViewTextBoxColumn.HeaderText = "FirstName"
        Me.FirstNameDataGridViewTextBoxColumn.Name = "FirstNameDataGridViewTextBoxColumn"
        Me.FirstNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LastNameDataGridViewTextBoxColumn
        '
        Me.LastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName"
        Me.LastNameDataGridViewTextBoxColumn.HeaderText = "LastName"
        Me.LastNameDataGridViewTextBoxColumn.Name = "LastNameDataGridViewTextBoxColumn"
        Me.LastNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "Address"
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "Address"
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        Me.AddressDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CityDataGridViewTextBoxColumn
        '
        Me.CityDataGridViewTextBoxColumn.DataPropertyName = "City"
        Me.CityDataGridViewTextBoxColumn.HeaderText = "City"
        Me.CityDataGridViewTextBoxColumn.Name = "CityDataGridViewTextBoxColumn"
        Me.CityDataGridViewTextBoxColumn.ReadOnly = True
        '
        'StateDataGridViewTextBoxColumn
        '
        Me.StateDataGridViewTextBoxColumn.DataPropertyName = "State"
        Me.StateDataGridViewTextBoxColumn.HeaderText = "State"
        Me.StateDataGridViewTextBoxColumn.Name = "StateDataGridViewTextBoxColumn"
        Me.StateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ZipCodeDataGridViewTextBoxColumn
        '
        Me.ZipCodeDataGridViewTextBoxColumn.DataPropertyName = "ZipCode"
        Me.ZipCodeDataGridViewTextBoxColumn.HeaderText = "ZipCode"
        Me.ZipCodeDataGridViewTextBoxColumn.Name = "ZipCodeDataGridViewTextBoxColumn"
        Me.ZipCodeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PhoneNumberDataGridViewTextBoxColumn
        '
        Me.PhoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber"
        Me.PhoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber"
        Me.PhoneNumberDataGridViewTextBoxColumn.Name = "PhoneNumberDataGridViewTextBoxColumn"
        Me.PhoneNumberDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ActivationDateDataGridViewTextBoxColumn
        '
        Me.ActivationDateDataGridViewTextBoxColumn.DataPropertyName = "ActivationDate"
        Me.ActivationDateDataGridViewTextBoxColumn.HeaderText = "ActivationDate"
        Me.ActivationDateDataGridViewTextBoxColumn.Name = "ActivationDateDataGridViewTextBoxColumn"
        Me.ActivationDateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DOBDataGridViewTextBoxColumn
        '
        Me.DOBDataGridViewTextBoxColumn.DataPropertyName = "DOB"
        Me.DOBDataGridViewTextBoxColumn.HeaderText = "DOB"
        Me.DOBDataGridViewTextBoxColumn.Name = "DOBDataGridViewTextBoxColumn"
        Me.DOBDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AgeDataGridViewTextBoxColumn
        '
        Me.AgeDataGridViewTextBoxColumn.DataPropertyName = "Age"
        Me.AgeDataGridViewTextBoxColumn.HeaderText = "Age"
        Me.AgeDataGridViewTextBoxColumn.Name = "AgeDataGridViewTextBoxColumn"
        Me.AgeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MembershipsBindingSource
        '
        Me.MembershipsBindingSource.DataMember = "Memberships"
        Me.MembershipsBindingSource.DataSource = Me.BlockbustersDataSet
        '
        'BlockbustersDataSet
        '
        Me.BlockbustersDataSet.DataSetName = "BlockbustersDataSet"
        Me.BlockbustersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BlockbustersDataSetBindingSource
        '
        Me.BlockbustersDataSetBindingSource.DataSource = Me.BlockbustersDataSet
        Me.BlockbustersDataSetBindingSource.Position = 0
        '
        'MembershipsTableAdapter
        '
        Me.MembershipsTableAdapter.ClearBeforeFill = True
        '
        'searchCustomers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(858, 1074)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "searchCustomers"
        Me.Text = "Search Customers"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MembershipsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BlockbustersDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BlockbustersDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnSelectCustomer As Button
    Friend WithEvents radLastName As RadioButton
    Friend WithEvents radMembershipID As RadioButton
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BlockbustersDataSetBindingSource As BindingSource
    Friend WithEvents BlockbustersDataSet As BlockbustersDataSet
    Friend WithEvents MembershipsBindingSource As BindingSource
    Friend WithEvents MembershipsTableAdapter As BlockbustersDataSetTableAdapters.MembershipsTableAdapter
    Friend WithEvents MembershipIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ZipCodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PhoneNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ActivationDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DOBDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AgeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
