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
        Me.btnSelectCustomer = New System.Windows.Forms.Button()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.lblDateOfBirth = New System.Windows.Forms.Label()
        Me.lblActivationDate = New System.Windows.Forms.Label()
        Me.lblPhoneNumber = New System.Windows.Forms.Label()
        Me.lblZipCode = New System.Windows.Forms.Label()
        Me.lblState = New System.Windows.Forms.Label()
        Me.lblCity = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.lblMemberID = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
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
        Me.GroupBox2.Controls.Add(Me.lblAge)
        Me.GroupBox2.Controls.Add(Me.lblDateOfBirth)
        Me.GroupBox2.Controls.Add(Me.lblActivationDate)
        Me.GroupBox2.Controls.Add(Me.lblPhoneNumber)
        Me.GroupBox2.Controls.Add(Me.lblZipCode)
        Me.GroupBox2.Controls.Add(Me.lblState)
        Me.GroupBox2.Controls.Add(Me.lblCity)
        Me.GroupBox2.Controls.Add(Me.lblAddress)
        Me.GroupBox2.Controls.Add(Me.lblLastName)
        Me.GroupBox2.Controls.Add(Me.lblFirstName)
        Me.GroupBox2.Controls.Add(Me.lblMemberID)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
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
        Me.DataGridView1.Location = New System.Drawing.Point(33, 61)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 33
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(699, 547)
        Me.DataGridView1.TabIndex = 27
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
        'btnSelectCustomer
        '
        Me.btnSelectCustomer.Location = New System.Drawing.Point(430, 643)
        Me.btnSelectCustomer.Name = "btnSelectCustomer"
        Me.btnSelectCustomer.Size = New System.Drawing.Size(302, 49)
        Me.btnSelectCustomer.TabIndex = 7
        Me.btnSelectCustomer.Text = "Select This Customer"
        Me.btnSelectCustomer.UseVisualStyleBackColor = True
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.Location = New System.Drawing.Point(273, 540)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(48, 25)
        Me.lblAge.TabIndex = 26
        Me.lblAge.Text = "???"
        '
        'lblDateOfBirth
        '
        Me.lblDateOfBirth.AutoSize = True
        Me.lblDateOfBirth.Location = New System.Drawing.Point(273, 492)
        Me.lblDateOfBirth.Name = "lblDateOfBirth"
        Me.lblDateOfBirth.Size = New System.Drawing.Size(48, 25)
        Me.lblDateOfBirth.TabIndex = 25
        Me.lblDateOfBirth.Text = "???"
        '
        'lblActivationDate
        '
        Me.lblActivationDate.AutoSize = True
        Me.lblActivationDate.Location = New System.Drawing.Point(273, 446)
        Me.lblActivationDate.Name = "lblActivationDate"
        Me.lblActivationDate.Size = New System.Drawing.Size(48, 25)
        Me.lblActivationDate.TabIndex = 24
        Me.lblActivationDate.Text = "???"
        '
        'lblPhoneNumber
        '
        Me.lblPhoneNumber.AutoSize = True
        Me.lblPhoneNumber.Location = New System.Drawing.Point(273, 401)
        Me.lblPhoneNumber.Name = "lblPhoneNumber"
        Me.lblPhoneNumber.Size = New System.Drawing.Size(48, 25)
        Me.lblPhoneNumber.TabIndex = 23
        Me.lblPhoneNumber.Text = "???"
        '
        'lblZipCode
        '
        Me.lblZipCode.AutoSize = True
        Me.lblZipCode.Location = New System.Drawing.Point(273, 356)
        Me.lblZipCode.Name = "lblZipCode"
        Me.lblZipCode.Size = New System.Drawing.Size(48, 25)
        Me.lblZipCode.TabIndex = 22
        Me.lblZipCode.Text = "???"
        '
        'lblState
        '
        Me.lblState.AutoSize = True
        Me.lblState.Location = New System.Drawing.Point(273, 313)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(48, 25)
        Me.lblState.TabIndex = 21
        Me.lblState.Text = "???"
        '
        'lblCity
        '
        Me.lblCity.AutoSize = True
        Me.lblCity.Location = New System.Drawing.Point(273, 266)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(48, 25)
        Me.lblCity.TabIndex = 20
        Me.lblCity.Text = "???"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(273, 220)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(48, 25)
        Me.lblAddress.TabIndex = 19
        Me.lblAddress.Text = "???"
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Location = New System.Drawing.Point(273, 176)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(48, 25)
        Me.lblLastName.TabIndex = 18
        Me.lblLastName.Text = "???"
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Location = New System.Drawing.Point(273, 132)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(48, 25)
        Me.lblFirstName.TabIndex = 17
        Me.lblFirstName.Text = "???"
        '
        'lblMemberID
        '
        Me.lblMemberID.AutoSize = True
        Me.lblMemberID.Location = New System.Drawing.Point(273, 85)
        Me.lblMemberID.Name = "lblMemberID"
        Me.lblMemberID.Size = New System.Drawing.Size(48, 25)
        Me.lblMemberID.TabIndex = 16
        Me.lblMemberID.Text = "???"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(52, 540)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(56, 25)
        Me.Label14.TabIndex = 15
        Me.Label14.Text = "Age:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(52, 492)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(137, 25)
        Me.Label13.TabIndex = 14
        Me.Label13.Text = "Date of Birth:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(51, 446)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(163, 25)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "Activation Date:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(51, 401)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(161, 25)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "Phone Number:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(52, 356)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(105, 25)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Zip Code:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(52, 313)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 25)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "State:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(52, 266)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 25)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "City:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(52, 220)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(97, 25)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Address:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(51, 176)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(121, 25)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Last Name:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(51, 132)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(122, 25)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "First Name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(51, 85)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(162, 25)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Membership ID:"
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
        Me.GroupBox2.PerformLayout()
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
    Friend WithEvents Label4 As Label
    Friend WithEvents btnSelectCustomer As Button
    Friend WithEvents lblAge As Label
    Friend WithEvents lblDateOfBirth As Label
    Friend WithEvents lblActivationDate As Label
    Friend WithEvents lblPhoneNumber As Label
    Friend WithEvents lblZipCode As Label
    Friend WithEvents lblState As Label
    Friend WithEvents lblCity As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblLastName As Label
    Friend WithEvents lblFirstName As Label
    Friend WithEvents lblMemberID As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
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
