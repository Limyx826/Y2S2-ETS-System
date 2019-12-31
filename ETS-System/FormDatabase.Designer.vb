<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDatabase
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.JCLODataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.JCLODataSet = New ETS_System.JCLODataSet()
        Me.TimetableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TimetableTableAdapter = New ETS_System.JCLODataSetTableAdapters.TimetableTableAdapter()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PadangBesarDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ArauDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AnakBukitDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AlorStarDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GurunDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SungaiPetaniDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ButterworthDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BukitMertajamDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TaipingDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KualaKangsarDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IpohDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BatuGajahDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KamparDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TanjungMalimDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KualaLumpurDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KLSentralDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JCLODataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JCLODataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TimetableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.PadangBesarDataGridViewTextBoxColumn, Me.ArauDataGridViewTextBoxColumn, Me.AnakBukitDataGridViewTextBoxColumn, Me.AlorStarDataGridViewTextBoxColumn, Me.GurunDataGridViewTextBoxColumn, Me.SungaiPetaniDataGridViewTextBoxColumn, Me.ButterworthDataGridViewTextBoxColumn, Me.BukitMertajamDataGridViewTextBoxColumn, Me.TaipingDataGridViewTextBoxColumn, Me.KualaKangsarDataGridViewTextBoxColumn, Me.IpohDataGridViewTextBoxColumn, Me.BatuGajahDataGridViewTextBoxColumn, Me.KamparDataGridViewTextBoxColumn, Me.TanjungMalimDataGridViewTextBoxColumn, Me.KualaLumpurDataGridViewTextBoxColumn, Me.KLSentralDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TimetableBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(39, 62)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(708, 198)
        Me.DataGridView1.TabIndex = 0
        '
        'JCLODataSetBindingSource
        '
        Me.JCLODataSetBindingSource.DataSource = Me.JCLODataSet
        Me.JCLODataSetBindingSource.Position = 0
        '
        'JCLODataSet
        '
        Me.JCLODataSet.DataSetName = "JCLODataSet"
        Me.JCLODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TimetableBindingSource
        '
        Me.TimetableBindingSource.DataMember = "Timetable"
        Me.TimetableBindingSource.DataSource = Me.JCLODataSetBindingSource
        '
        'TimetableTableAdapter
        '
        Me.TimetableTableAdapter.ClearBeforeFill = True
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.Width = 125
        '
        'PadangBesarDataGridViewTextBoxColumn
        '
        Me.PadangBesarDataGridViewTextBoxColumn.DataPropertyName = "Padang Besar"
        Me.PadangBesarDataGridViewTextBoxColumn.HeaderText = "Padang Besar"
        Me.PadangBesarDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PadangBesarDataGridViewTextBoxColumn.Name = "PadangBesarDataGridViewTextBoxColumn"
        Me.PadangBesarDataGridViewTextBoxColumn.Width = 125
        '
        'ArauDataGridViewTextBoxColumn
        '
        Me.ArauDataGridViewTextBoxColumn.DataPropertyName = "Arau"
        Me.ArauDataGridViewTextBoxColumn.HeaderText = "Arau"
        Me.ArauDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ArauDataGridViewTextBoxColumn.Name = "ArauDataGridViewTextBoxColumn"
        Me.ArauDataGridViewTextBoxColumn.Width = 125
        '
        'AnakBukitDataGridViewTextBoxColumn
        '
        Me.AnakBukitDataGridViewTextBoxColumn.DataPropertyName = "Anak Bukit"
        Me.AnakBukitDataGridViewTextBoxColumn.HeaderText = "Anak Bukit"
        Me.AnakBukitDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.AnakBukitDataGridViewTextBoxColumn.Name = "AnakBukitDataGridViewTextBoxColumn"
        Me.AnakBukitDataGridViewTextBoxColumn.Width = 125
        '
        'AlorStarDataGridViewTextBoxColumn
        '
        Me.AlorStarDataGridViewTextBoxColumn.DataPropertyName = "Alor Star"
        Me.AlorStarDataGridViewTextBoxColumn.HeaderText = "Alor Star"
        Me.AlorStarDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.AlorStarDataGridViewTextBoxColumn.Name = "AlorStarDataGridViewTextBoxColumn"
        Me.AlorStarDataGridViewTextBoxColumn.Width = 125
        '
        'GurunDataGridViewTextBoxColumn
        '
        Me.GurunDataGridViewTextBoxColumn.DataPropertyName = "Gurun"
        Me.GurunDataGridViewTextBoxColumn.HeaderText = "Gurun"
        Me.GurunDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.GurunDataGridViewTextBoxColumn.Name = "GurunDataGridViewTextBoxColumn"
        Me.GurunDataGridViewTextBoxColumn.Width = 125
        '
        'SungaiPetaniDataGridViewTextBoxColumn
        '
        Me.SungaiPetaniDataGridViewTextBoxColumn.DataPropertyName = "Sungai Petani"
        Me.SungaiPetaniDataGridViewTextBoxColumn.HeaderText = "Sungai Petani"
        Me.SungaiPetaniDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.SungaiPetaniDataGridViewTextBoxColumn.Name = "SungaiPetaniDataGridViewTextBoxColumn"
        Me.SungaiPetaniDataGridViewTextBoxColumn.Width = 125
        '
        'ButterworthDataGridViewTextBoxColumn
        '
        Me.ButterworthDataGridViewTextBoxColumn.DataPropertyName = "Butterworth"
        Me.ButterworthDataGridViewTextBoxColumn.HeaderText = "Butterworth"
        Me.ButterworthDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ButterworthDataGridViewTextBoxColumn.Name = "ButterworthDataGridViewTextBoxColumn"
        Me.ButterworthDataGridViewTextBoxColumn.Width = 125
        '
        'BukitMertajamDataGridViewTextBoxColumn
        '
        Me.BukitMertajamDataGridViewTextBoxColumn.DataPropertyName = "Bukit Mertajam"
        Me.BukitMertajamDataGridViewTextBoxColumn.HeaderText = "Bukit Mertajam"
        Me.BukitMertajamDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.BukitMertajamDataGridViewTextBoxColumn.Name = "BukitMertajamDataGridViewTextBoxColumn"
        Me.BukitMertajamDataGridViewTextBoxColumn.Width = 125
        '
        'TaipingDataGridViewTextBoxColumn
        '
        Me.TaipingDataGridViewTextBoxColumn.DataPropertyName = "Taiping"
        Me.TaipingDataGridViewTextBoxColumn.HeaderText = "Taiping"
        Me.TaipingDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TaipingDataGridViewTextBoxColumn.Name = "TaipingDataGridViewTextBoxColumn"
        Me.TaipingDataGridViewTextBoxColumn.Width = 125
        '
        'KualaKangsarDataGridViewTextBoxColumn
        '
        Me.KualaKangsarDataGridViewTextBoxColumn.DataPropertyName = "Kuala Kangsar"
        Me.KualaKangsarDataGridViewTextBoxColumn.HeaderText = "Kuala Kangsar"
        Me.KualaKangsarDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.KualaKangsarDataGridViewTextBoxColumn.Name = "KualaKangsarDataGridViewTextBoxColumn"
        Me.KualaKangsarDataGridViewTextBoxColumn.Width = 125
        '
        'IpohDataGridViewTextBoxColumn
        '
        Me.IpohDataGridViewTextBoxColumn.DataPropertyName = "Ipoh"
        Me.IpohDataGridViewTextBoxColumn.HeaderText = "Ipoh"
        Me.IpohDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IpohDataGridViewTextBoxColumn.Name = "IpohDataGridViewTextBoxColumn"
        Me.IpohDataGridViewTextBoxColumn.Width = 125
        '
        'BatuGajahDataGridViewTextBoxColumn
        '
        Me.BatuGajahDataGridViewTextBoxColumn.DataPropertyName = "Batu Gajah"
        Me.BatuGajahDataGridViewTextBoxColumn.HeaderText = "Batu Gajah"
        Me.BatuGajahDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.BatuGajahDataGridViewTextBoxColumn.Name = "BatuGajahDataGridViewTextBoxColumn"
        Me.BatuGajahDataGridViewTextBoxColumn.Width = 125
        '
        'KamparDataGridViewTextBoxColumn
        '
        Me.KamparDataGridViewTextBoxColumn.DataPropertyName = "Kampar"
        Me.KamparDataGridViewTextBoxColumn.HeaderText = "Kampar"
        Me.KamparDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.KamparDataGridViewTextBoxColumn.Name = "KamparDataGridViewTextBoxColumn"
        Me.KamparDataGridViewTextBoxColumn.Width = 125
        '
        'TanjungMalimDataGridViewTextBoxColumn
        '
        Me.TanjungMalimDataGridViewTextBoxColumn.DataPropertyName = "Tanjung Malim"
        Me.TanjungMalimDataGridViewTextBoxColumn.HeaderText = "Tanjung Malim"
        Me.TanjungMalimDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TanjungMalimDataGridViewTextBoxColumn.Name = "TanjungMalimDataGridViewTextBoxColumn"
        Me.TanjungMalimDataGridViewTextBoxColumn.Width = 125
        '
        'KualaLumpurDataGridViewTextBoxColumn
        '
        Me.KualaLumpurDataGridViewTextBoxColumn.DataPropertyName = "Kuala Lumpur"
        Me.KualaLumpurDataGridViewTextBoxColumn.HeaderText = "Kuala Lumpur"
        Me.KualaLumpurDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.KualaLumpurDataGridViewTextBoxColumn.Name = "KualaLumpurDataGridViewTextBoxColumn"
        Me.KualaLumpurDataGridViewTextBoxColumn.Width = 125
        '
        'KLSentralDataGridViewTextBoxColumn
        '
        Me.KLSentralDataGridViewTextBoxColumn.DataPropertyName = "KL Sentral"
        Me.KLSentralDataGridViewTextBoxColumn.HeaderText = "KL Sentral"
        Me.KLSentralDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.KLSentralDataGridViewTextBoxColumn.Name = "KLSentralDataGridViewTextBoxColumn"
        Me.KLSentralDataGridViewTextBoxColumn.Width = 125
        '
        'FormDatabase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "FormDatabase"
        Me.Text = "FormDatabase"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JCLODataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JCLODataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TimetableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents JCLODataSetBindingSource As BindingSource
    Friend WithEvents JCLODataSet As JCLODataSet
    Friend WithEvents TimetableBindingSource As BindingSource
    Friend WithEvents TimetableTableAdapter As JCLODataSetTableAdapters.TimetableTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PadangBesarDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ArauDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AnakBukitDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AlorStarDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GurunDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SungaiPetaniDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ButterworthDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BukitMertajamDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TaipingDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents KualaKangsarDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IpohDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BatuGajahDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents KamparDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TanjungMalimDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents KualaLumpurDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents KLSentralDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
