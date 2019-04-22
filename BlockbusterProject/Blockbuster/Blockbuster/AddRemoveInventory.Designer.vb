<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddRemoveInventory
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
        Me.btnClose = New System.Windows.Forms.Button()
        Me.BlockbustersDataSet = New Blockbuster.BlockbustersDataSet()
        Me.BlockbustersDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MoviesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MoviesTableAdapter = New Blockbuster.BlockbustersDataSetTableAdapters.MoviesTableAdapter()
        Me.MovieInventoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Movie_InventoryTableAdapter = New Blockbuster.BlockbustersDataSetTableAdapters.Movie_InventoryTableAdapter()
        Me.Movie_InventoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableAdapterManager = New Blockbuster.BlockbustersDataSetTableAdapters.TableAdapterManager()
        Me.Movie_InventoryDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnSave = New System.Windows.Forms.Button()
        CType(Me.BlockbustersDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BlockbustersDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MoviesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MovieInventoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Movie_InventoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Movie_InventoryDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(840, 548)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(112, 46)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = True
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
        'MoviesBindingSource
        '
        Me.MoviesBindingSource.DataMember = "Movies"
        Me.MoviesBindingSource.DataSource = Me.BlockbustersDataSet
        '
        'MoviesTableAdapter
        '
        Me.MoviesTableAdapter.ClearBeforeFill = True
        '
        'MovieInventoryBindingSource
        '
        Me.MovieInventoryBindingSource.DataMember = "Movie Inventory"
        Me.MovieInventoryBindingSource.DataSource = Me.BlockbustersDataSetBindingSource
        '
        'Movie_InventoryTableAdapter
        '
        Me.Movie_InventoryTableAdapter.ClearBeforeFill = True
        '
        'Movie_InventoryBindingSource
        '
        Me.Movie_InventoryBindingSource.DataMember = "Movie Inventory"
        Me.Movie_InventoryBindingSource.DataSource = Me.BlockbustersDataSet
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.InvoiceTableAdapter = Nothing
        Me.TableAdapterManager.MembershipsTableAdapter = Nothing
        Me.TableAdapterManager.Movie_InventoryTableAdapter = Nothing
        Me.TableAdapterManager.MoviesTableAdapter = Nothing
        Me.TableAdapterManager.RentalsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Blockbuster.BlockbustersDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Movie_InventoryDataGridView
        '
        Me.Movie_InventoryDataGridView.AutoGenerateColumns = False
        Me.Movie_InventoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Movie_InventoryDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.Movie_InventoryDataGridView.DataSource = Me.Movie_InventoryBindingSource
        Me.Movie_InventoryDataGridView.Location = New System.Drawing.Point(111, 91)
        Me.Movie_InventoryDataGridView.Name = "Movie_InventoryDataGridView"
        Me.Movie_InventoryDataGridView.RowTemplate.Height = 33
        Me.Movie_InventoryDataGridView.Size = New System.Drawing.Size(841, 391)
        Me.Movie_InventoryDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Movie Type"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Movie Type"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Number in Stock"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Number in Stock"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Available"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Available"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(111, 549)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(112, 45)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'AddRemoveInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1084, 638)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Movie_InventoryDataGridView)
        Me.Controls.Add(Me.btnClose)
        Me.Name = "AddRemoveInventory"
        Me.Text = "Inventory"
        CType(Me.BlockbustersDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BlockbustersDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MoviesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MovieInventoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Movie_InventoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Movie_InventoryDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnClose As Button
    Friend WithEvents BlockbustersDataSetBindingSource As BindingSource
    Friend WithEvents BlockbustersDataSet As BlockbustersDataSet
    Friend WithEvents MoviesBindingSource As BindingSource
    Friend WithEvents MoviesTableAdapter As BlockbustersDataSetTableAdapters.MoviesTableAdapter
    Friend WithEvents MovieInventoryBindingSource As BindingSource
    Friend WithEvents Movie_InventoryTableAdapter As BlockbustersDataSetTableAdapters.Movie_InventoryTableAdapter
    Friend WithEvents Movie_InventoryBindingSource As BindingSource
    Friend WithEvents TableAdapterManager As BlockbustersDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Movie_InventoryDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents btnSave As Button
End Class
