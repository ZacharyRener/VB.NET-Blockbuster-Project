<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Update_Movie_Inventory
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
        Me.components = New System.ComponentModel.Container()
        Dim Label1 As System.Windows.Forms.Label
        Dim TitleLabel As System.Windows.Forms.Label
        Dim Release_DateLabel As System.Windows.Forms.Label
        Dim RatingLabel As System.Windows.Forms.Label
        Dim Movie_TypeLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Me.BTN_ADD = New System.Windows.Forms.Button()
        Me.BTNRemove = New System.Windows.Forms.Button()
        Me.AddGroupBox = New System.Windows.Forms.GroupBox()
        Me.TBMov_Type = New System.Windows.Forms.TextBox()
        Me.TBRate = New System.Windows.Forms.TextBox()
        Me.DTPRelease = New System.Windows.Forms.DateTimePicker()
        Me.TBTitle = New System.Windows.Forms.TextBox()
        Me.TBMovID = New System.Windows.Forms.TextBox()
        Me.DeleteGroupBox = New System.Windows.Forms.GroupBox()
        Me.TBMov_Type1 = New System.Windows.Forms.TextBox()
        Me.TBRate1 = New System.Windows.Forms.TextBox()
        Me.DTPRelease1 = New System.Windows.Forms.DateTimePicker()
        Me.TBTitle1 = New System.Windows.Forms.TextBox()
        Me.TBMovID1 = New System.Windows.Forms.TextBox()
        Me.BTNSave = New System.Windows.Forms.Button()
        Me.MoviesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BlockbustersDataSet = New Blockbuster.BlockbustersDataSet()
        Me.MoviesTableAdapter = New Blockbuster.BlockbustersDataSetTableAdapters.MoviesTableAdapter()
        Me.TableAdapterManager = New Blockbuster.BlockbustersDataSetTableAdapters.TableAdapterManager()
        Label1 = New System.Windows.Forms.Label()
        TitleLabel = New System.Windows.Forms.Label()
        Release_DateLabel = New System.Windows.Forms.Label()
        RatingLabel = New System.Windows.Forms.Label()
        Movie_TypeLabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Me.AddGroupBox.SuspendLayout()
        Me.DeleteGroupBox.SuspendLayout()
        CType(Me.MoviesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BlockbustersDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(38, 61)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(66, 17)
        Label1.TabIndex = 3
        Label1.Text = "Movie ID:"
        '
        'TitleLabel
        '
        TitleLabel.AutoSize = True
        TitleLabel.Location = New System.Drawing.Point(65, 108)
        TitleLabel.Name = "TitleLabel"
        TitleLabel.Size = New System.Drawing.Size(39, 17)
        TitleLabel.TabIndex = 4
        TitleLabel.Text = "Title:"
        '
        'Release_DateLabel
        '
        Release_DateLabel.AutoSize = True
        Release_DateLabel.Location = New System.Drawing.Point(6, 156)
        Release_DateLabel.Name = "Release_DateLabel"
        Release_DateLabel.Size = New System.Drawing.Size(98, 17)
        Release_DateLabel.TabIndex = 5
        Release_DateLabel.Text = "Release Date:"
        '
        'RatingLabel
        '
        RatingLabel.AutoSize = True
        RatingLabel.Location = New System.Drawing.Point(51, 203)
        RatingLabel.Name = "RatingLabel"
        RatingLabel.Size = New System.Drawing.Size(53, 17)
        RatingLabel.TabIndex = 7
        RatingLabel.Text = "Rating:"
        '
        'Movie_TypeLabel
        '
        Movie_TypeLabel.AutoSize = True
        Movie_TypeLabel.Location = New System.Drawing.Point(19, 250)
        Movie_TypeLabel.Name = "Movie_TypeLabel"
        Movie_TypeLabel.Size = New System.Drawing.Size(85, 17)
        Movie_TypeLabel.TabIndex = 9
        Movie_TypeLabel.Text = "Movie Type:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(17, 250)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(85, 17)
        Label2.TabIndex = 19
        Label2.Text = "Movie Type:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(49, 203)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(53, 17)
        Label3.TabIndex = 17
        Label3.Text = "Rating:"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(4, 156)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(98, 17)
        Label4.TabIndex = 14
        Label4.Text = "Release Date:"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(63, 108)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(39, 17)
        Label5.TabIndex = 12
        Label5.Text = "Title:"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Location = New System.Drawing.Point(36, 61)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(66, 17)
        Label6.TabIndex = 11
        Label6.Text = "Movie ID:"
        '
        'BTN_ADD
        '
        Me.BTN_ADD.Location = New System.Drawing.Point(293, 328)
        Me.BTN_ADD.Name = "BTN_ADD"
        Me.BTN_ADD.Size = New System.Drawing.Size(75, 23)
        Me.BTN_ADD.TabIndex = 0
        Me.BTN_ADD.Text = "ADD"
        Me.BTN_ADD.UseVisualStyleBackColor = True
        '
        'BTNRemove
        '
        Me.BTNRemove.Location = New System.Drawing.Point(291, 328)
        Me.BTNRemove.Name = "BTNRemove"
        Me.BTNRemove.Size = New System.Drawing.Size(75, 23)
        Me.BTNRemove.TabIndex = 1
        Me.BTNRemove.Text = "Remove"
        Me.BTNRemove.UseVisualStyleBackColor = True
        '
        'AddGroupBox
        '
        Me.AddGroupBox.Controls.Add(Me.BTNSave)
        Me.AddGroupBox.Controls.Add(Label2)
        Me.AddGroupBox.Controls.Add(Me.TBMov_Type)
        Me.AddGroupBox.Controls.Add(Label3)
        Me.AddGroupBox.Controls.Add(Me.TBRate)
        Me.AddGroupBox.Controls.Add(Label4)
        Me.AddGroupBox.Controls.Add(Me.DTPRelease)
        Me.AddGroupBox.Controls.Add(Label5)
        Me.AddGroupBox.Controls.Add(Me.TBTitle)
        Me.AddGroupBox.Controls.Add(Label6)
        Me.AddGroupBox.Controls.Add(Me.TBMovID)
        Me.AddGroupBox.Controls.Add(Me.BTN_ADD)
        Me.AddGroupBox.Location = New System.Drawing.Point(12, 46)
        Me.AddGroupBox.Name = "AddGroupBox"
        Me.AddGroupBox.Size = New System.Drawing.Size(374, 371)
        Me.AddGroupBox.TabIndex = 10
        Me.AddGroupBox.TabStop = False
        Me.AddGroupBox.Text = "ADD"
        '
        'TBMov_Type
        '
        Me.TBMov_Type.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MoviesBindingSource, "Movie Type", True))
        Me.TBMov_Type.Location = New System.Drawing.Point(108, 247)
        Me.TBMov_Type.Name = "TBMov_Type"
        Me.TBMov_Type.Size = New System.Drawing.Size(100, 22)
        Me.TBMov_Type.TabIndex = 20
        '
        'TBRate
        '
        Me.TBRate.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MoviesBindingSource, "Rating", True))
        Me.TBRate.Location = New System.Drawing.Point(108, 200)
        Me.TBRate.Name = "TBRate"
        Me.TBRate.Size = New System.Drawing.Size(100, 22)
        Me.TBRate.TabIndex = 18
        '
        'DTPRelease
        '
        Me.DTPRelease.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.MoviesBindingSource, "Release Date", True))
        Me.DTPRelease.Location = New System.Drawing.Point(108, 152)
        Me.DTPRelease.Name = "DTPRelease"
        Me.DTPRelease.Size = New System.Drawing.Size(254, 22)
        Me.DTPRelease.TabIndex = 16
        '
        'TBTitle
        '
        Me.TBTitle.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MoviesBindingSource, "Title", True))
        Me.TBTitle.Location = New System.Drawing.Point(108, 105)
        Me.TBTitle.Name = "TBTitle"
        Me.TBTitle.Size = New System.Drawing.Size(100, 22)
        Me.TBTitle.TabIndex = 15
        '
        'TBMovID
        '
        Me.TBMovID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MoviesBindingSource, "Movie ID", True))
        Me.TBMovID.Location = New System.Drawing.Point(108, 58)
        Me.TBMovID.Name = "TBMovID"
        Me.TBMovID.Size = New System.Drawing.Size(100, 22)
        Me.TBMovID.TabIndex = 13
        '
        'DeleteGroupBox
        '
        Me.DeleteGroupBox.Controls.Add(Movie_TypeLabel)
        Me.DeleteGroupBox.Controls.Add(Me.TBMov_Type1)
        Me.DeleteGroupBox.Controls.Add(RatingLabel)
        Me.DeleteGroupBox.Controls.Add(Me.TBRate1)
        Me.DeleteGroupBox.Controls.Add(Release_DateLabel)
        Me.DeleteGroupBox.Controls.Add(Me.DTPRelease1)
        Me.DeleteGroupBox.Controls.Add(TitleLabel)
        Me.DeleteGroupBox.Controls.Add(Me.TBTitle1)
        Me.DeleteGroupBox.Controls.Add(Label1)
        Me.DeleteGroupBox.Controls.Add(Me.TBMovID1)
        Me.DeleteGroupBox.Controls.Add(Me.BTNRemove)
        Me.DeleteGroupBox.Location = New System.Drawing.Point(409, 46)
        Me.DeleteGroupBox.Name = "DeleteGroupBox"
        Me.DeleteGroupBox.Size = New System.Drawing.Size(386, 371)
        Me.DeleteGroupBox.TabIndex = 11
        Me.DeleteGroupBox.TabStop = False
        Me.DeleteGroupBox.Text = "Delete"
        '
        'TBMov_Type1
        '
        Me.TBMov_Type1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MoviesBindingSource, "Movie Type", True))
        Me.TBMov_Type1.Location = New System.Drawing.Point(110, 247)
        Me.TBMov_Type1.Name = "TBMov_Type1"
        Me.TBMov_Type1.Size = New System.Drawing.Size(100, 22)
        Me.TBMov_Type1.TabIndex = 10
        '
        'TBRate1
        '
        Me.TBRate1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MoviesBindingSource, "Rating", True))
        Me.TBRate1.Location = New System.Drawing.Point(110, 200)
        Me.TBRate1.Name = "TBRate1"
        Me.TBRate1.Size = New System.Drawing.Size(100, 22)
        Me.TBRate1.TabIndex = 8
        '
        'DTPRelease1
        '
        Me.DTPRelease1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.MoviesBindingSource, "Release Date", True))
        Me.DTPRelease1.Location = New System.Drawing.Point(110, 152)
        Me.DTPRelease1.Name = "DTPRelease1"
        Me.DTPRelease1.Size = New System.Drawing.Size(254, 22)
        Me.DTPRelease1.TabIndex = 6
        '
        'TBTitle1
        '
        Me.TBTitle1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MoviesBindingSource, "Title", True))
        Me.TBTitle1.Location = New System.Drawing.Point(110, 105)
        Me.TBTitle1.Name = "TBTitle1"
        Me.TBTitle1.Size = New System.Drawing.Size(100, 22)
        Me.TBTitle1.TabIndex = 5
        '
        'TBMovID1
        '
        Me.TBMovID1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MoviesBindingSource, "Movie ID", True))
        Me.TBMovID1.Location = New System.Drawing.Point(110, 58)
        Me.TBMovID1.Name = "TBMovID1"
        Me.TBMovID1.Size = New System.Drawing.Size(100, 22)
        Me.TBMovID1.TabIndex = 4
        '
        'BTNSave
        '
        Me.BTNSave.Location = New System.Drawing.Point(212, 328)
        Me.BTNSave.Name = "BTNSave"
        Me.BTNSave.Size = New System.Drawing.Size(75, 23)
        Me.BTNSave.TabIndex = 21
        Me.BTNSave.Text = "Save"
        Me.BTNSave.UseVisualStyleBackColor = True
        '
        'MoviesBindingSource
        '
        Me.MoviesBindingSource.DataMember = "Movies"
        Me.MoviesBindingSource.DataSource = Me.BlockbustersDataSet
        '
        'BlockbustersDataSet
        '
        Me.BlockbustersDataSet.DataSetName = "BlockbustersDataSet"
        Me.BlockbustersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MoviesTableAdapter
        '
        Me.MoviesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.InvoiceTableAdapter = Nothing
        Me.TableAdapterManager.MembershipsTableAdapter = Nothing
        Me.TableAdapterManager.Movie_InventoryTableAdapter = Nothing
        Me.TableAdapterManager.MoviesTableAdapter = Me.MoviesTableAdapter
        Me.TableAdapterManager.RentalsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Blockbuster.BlockbustersDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Update_Movie_Inventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(844, 477)
        Me.Controls.Add(Me.DeleteGroupBox)
        Me.Controls.Add(Me.AddGroupBox)
        Me.Name = "Update_Movie_Inventory"
        Me.Text = "Update_Movie_Inventory"
        Me.AddGroupBox.ResumeLayout(False)
        Me.AddGroupBox.PerformLayout()
        Me.DeleteGroupBox.ResumeLayout(False)
        Me.DeleteGroupBox.PerformLayout()
        CType(Me.MoviesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BlockbustersDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BlockbustersDataSet As BlockbustersDataSet
    Friend WithEvents MoviesBindingSource As BindingSource
    Friend WithEvents MoviesTableAdapter As BlockbustersDataSetTableAdapters.MoviesTableAdapter
    Friend WithEvents TableAdapterManager As BlockbustersDataSetTableAdapters.TableAdapterManager
    Friend WithEvents BTN_ADD As Button
    Friend WithEvents BTNRemove As Button
    Friend WithEvents AddGroupBox As GroupBox
    Friend WithEvents DeleteGroupBox As GroupBox
    Friend WithEvents DTPRelease1 As DateTimePicker
    Friend WithEvents TBTitle1 As TextBox
    Friend WithEvents TBMovID1 As TextBox
    Friend WithEvents TBMov_Type As TextBox
    Friend WithEvents TBRate As TextBox
    Friend WithEvents DTPRelease As DateTimePicker
    Friend WithEvents TBTitle As TextBox
    Friend WithEvents TBMovID As TextBox
    Friend WithEvents TBMov_Type1 As TextBox
    Friend WithEvents TBRate1 As TextBox
    Friend WithEvents BTNSave As Button
End Class
