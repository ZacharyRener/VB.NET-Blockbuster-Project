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
        Dim Movie_IDLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim TitleLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Release_DateLabel As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.AddGroupBox = New System.Windows.Forms.GroupBox()
        Me.DeleteGroupBox = New System.Windows.Forms.GroupBox()
        Me.MoviesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BlockbustersDataSet = New Blockbuster.BlockbustersDataSet()
        Me.MoviesTableAdapter = New Blockbuster.BlockbustersDataSetTableAdapters.MoviesTableAdapter()
        Me.TableAdapterManager = New Blockbuster.BlockbustersDataSetTableAdapters.TableAdapterManager()
        Me.Movie_IDTextBox = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TitleTextBox = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Release_DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Movie_IDLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        TitleLabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Release_DateLabel = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Me.AddGroupBox.SuspendLayout()
        Me.DeleteGroupBox.SuspendLayout()
        CType(Me.MoviesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BlockbustersDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(246, 314)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "ADD"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(289, 314)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Remove"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'AddGroupBox
        '
        Me.AddGroupBox.Controls.Add(Label3)
        Me.AddGroupBox.Controls.Add(Me.DateTimePicker1)
        Me.AddGroupBox.Controls.Add(Label2)
        Me.AddGroupBox.Controls.Add(Me.TextBox2)
        Me.AddGroupBox.Controls.Add(Movie_IDLabel)
        Me.AddGroupBox.Controls.Add(Me.Movie_IDTextBox)
        Me.AddGroupBox.Controls.Add(Me.Button1)
        Me.AddGroupBox.Location = New System.Drawing.Point(12, 46)
        Me.AddGroupBox.Name = "AddGroupBox"
        Me.AddGroupBox.Size = New System.Drawing.Size(368, 357)
        Me.AddGroupBox.TabIndex = 10
        Me.AddGroupBox.TabStop = False
        Me.AddGroupBox.Text = "ADD"
        '
        'DeleteGroupBox
        '
        Me.DeleteGroupBox.Controls.Add(Release_DateLabel)
        Me.DeleteGroupBox.Controls.Add(Me.Release_DateDateTimePicker)
        Me.DeleteGroupBox.Controls.Add(TitleLabel)
        Me.DeleteGroupBox.Controls.Add(Me.TitleTextBox)
        Me.DeleteGroupBox.Controls.Add(Label1)
        Me.DeleteGroupBox.Controls.Add(Me.TextBox1)
        Me.DeleteGroupBox.Controls.Add(Me.Button2)
        Me.DeleteGroupBox.Location = New System.Drawing.Point(380, 46)
        Me.DeleteGroupBox.Name = "DeleteGroupBox"
        Me.DeleteGroupBox.Size = New System.Drawing.Size(438, 357)
        Me.DeleteGroupBox.TabIndex = 11
        Me.DeleteGroupBox.TabStop = False
        Me.DeleteGroupBox.Text = "Delete"
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
        'Movie_IDLabel
        '
        Movie_IDLabel.AutoSize = True
        Movie_IDLabel.Location = New System.Drawing.Point(60, 46)
        Movie_IDLabel.Name = "Movie_IDLabel"
        Movie_IDLabel.Size = New System.Drawing.Size(66, 17)
        Movie_IDLabel.TabIndex = 1
        Movie_IDLabel.Text = "Movie ID:"
        '
        'Movie_IDTextBox
        '
        Me.Movie_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MoviesBindingSource, "Movie ID", True))
        Me.Movie_IDTextBox.Location = New System.Drawing.Point(132, 43)
        Me.Movie_IDTextBox.Name = "Movie_IDTextBox"
        Me.Movie_IDTextBox.Size = New System.Drawing.Size(100, 22)
        Me.Movie_IDTextBox.TabIndex = 2
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(91, 46)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(66, 17)
        Label1.TabIndex = 3
        Label1.Text = "Movie ID:"
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MoviesBindingSource, "Movie ID", True))
        Me.TextBox1.Location = New System.Drawing.Point(163, 43)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 22)
        Me.TextBox1.TabIndex = 4
        '
        'TitleLabel
        '
        TitleLabel.AutoSize = True
        TitleLabel.Location = New System.Drawing.Point(108, 103)
        TitleLabel.Name = "TitleLabel"
        TitleLabel.Size = New System.Drawing.Size(39, 17)
        TitleLabel.TabIndex = 4
        TitleLabel.Text = "Title:"
        '
        'TitleTextBox
        '
        Me.TitleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MoviesBindingSource, "Title", True))
        Me.TitleTextBox.Location = New System.Drawing.Point(153, 100)
        Me.TitleTextBox.Name = "TitleTextBox"
        Me.TitleTextBox.Size = New System.Drawing.Size(100, 22)
        Me.TitleTextBox.TabIndex = 5
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(87, 103)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(39, 17)
        Label2.TabIndex = 6
        Label2.Text = "Title:"
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MoviesBindingSource, "Title", True))
        Me.TextBox2.Location = New System.Drawing.Point(132, 100)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 22)
        Me.TextBox2.TabIndex = 7
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
        'Release_DateDateTimePicker
        '
        Me.Release_DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.MoviesBindingSource, "Release Date", True))
        Me.Release_DateDateTimePicker.Location = New System.Drawing.Point(110, 152)
        Me.Release_DateDateTimePicker.Name = "Release_DateDateTimePicker"
        Me.Release_DateDateTimePicker.Size = New System.Drawing.Size(254, 22)
        Me.Release_DateDateTimePicker.TabIndex = 6
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(6, 155)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(98, 17)
        Label3.TabIndex = 8
        Label3.Text = "Release Date:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.MoviesBindingSource, "Release Date", True))
        Me.DateTimePicker1.Location = New System.Drawing.Point(110, 151)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(252, 22)
        Me.DateTimePicker1.TabIndex = 9
        '
        'Update_Movie_Inventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(844, 453)
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
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents AddGroupBox As GroupBox
    Friend WithEvents DeleteGroupBox As GroupBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Movie_IDTextBox As TextBox
    Friend WithEvents Release_DateDateTimePicker As DateTimePicker
    Friend WithEvents TitleTextBox As TextBox
    Friend WithEvents TextBox1 As TextBox
End Class
