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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BlockbustersDataSet = New Blockbuster.BlockbustersDataSet()
        Me.BlockbustersDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MoviesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MoviesTableAdapter = New Blockbuster.BlockbustersDataSetTableAdapters.MoviesTableAdapter()
        Me.MovieTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MovieInventoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Movie_InventoryTableAdapter = New Blockbuster.BlockbustersDataSetTableAdapters.Movie_InventoryTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BlockbustersDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BlockbustersDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MoviesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MovieInventoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(898, 549)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(112, 46)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MovieTypeDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.MovieInventoryBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(125, 72)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 33
        Me.DataGridView1.Size = New System.Drawing.Size(440, 278)
        Me.DataGridView1.TabIndex = 2
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
        'MovieTypeDataGridViewTextBoxColumn
        '
        Me.MovieTypeDataGridViewTextBoxColumn.DataPropertyName = "Movie Type"
        Me.MovieTypeDataGridViewTextBoxColumn.HeaderText = "Movie Type"
        Me.MovieTypeDataGridViewTextBoxColumn.Name = "MovieTypeDataGridViewTextBoxColumn"
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
        'AddRemoveInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1082, 638)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnClose)
        Me.Name = "AddRemoveInventory"
        Me.Text = "Inventory"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BlockbustersDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BlockbustersDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MoviesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MovieInventoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnClose As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BlockbustersDataSetBindingSource As BindingSource
    Friend WithEvents BlockbustersDataSet As BlockbustersDataSet
    Friend WithEvents MoviesBindingSource As BindingSource
    Friend WithEvents MoviesTableAdapter As BlockbustersDataSetTableAdapters.MoviesTableAdapter
    Friend WithEvents MovieTypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MovieInventoryBindingSource As BindingSource
    Friend WithEvents Movie_InventoryTableAdapter As BlockbustersDataSetTableAdapters.Movie_InventoryTableAdapter
End Class
