<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormDatabase
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormDatabase))
        Me.TimetableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.JCLODataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.JCLODataSet = New ETS_System.JCLODataSet()
        Me.TimetableTableAdapter = New ETS_System.JCLODataSetTableAdapters.TimetableTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.KLSentralDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KualaLumpurDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TanjungMalimDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KamparDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BatuGajahDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IpohDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KualaKangsarDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TaipingDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BukitMertajamDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ButterworthDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SungaiPetaniDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GurunDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AlorStarDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AnakBukitDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ArauDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PadangBesarDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TimetableBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.TimetableBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.TableAdapterManager = New ETS_System.JCLODataSetTableAdapters.TableAdapterManager()
        CType(Me.TimetableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JCLODataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JCLODataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TimetableBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TimetableBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'TimetableBindingSource
        '
        Me.TimetableBindingSource.DataMember = "Timetable"
        Me.TimetableBindingSource.DataSource = Me.JCLODataSetBindingSource
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
        'TimetableTableAdapter
        '
        Me.TimetableTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(63, 355)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'KLSentralDataGridViewTextBoxColumn
        '
        Me.KLSentralDataGridViewTextBoxColumn.DataPropertyName = "KL Sentral"
        Me.KLSentralDataGridViewTextBoxColumn.HeaderText = "KL Sentral"
        Me.KLSentralDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.KLSentralDataGridViewTextBoxColumn.Name = "KLSentralDataGridViewTextBoxColumn"
        Me.KLSentralDataGridViewTextBoxColumn.Width = 125
        '
        'KualaLumpurDataGridViewTextBoxColumn
        '
        Me.KualaLumpurDataGridViewTextBoxColumn.DataPropertyName = "Kuala Lumpur"
        Me.KualaLumpurDataGridViewTextBoxColumn.HeaderText = "Kuala Lumpur"
        Me.KualaLumpurDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.KualaLumpurDataGridViewTextBoxColumn.Name = "KualaLumpurDataGridViewTextBoxColumn"
        Me.KualaLumpurDataGridViewTextBoxColumn.Width = 125
        '
        'TanjungMalimDataGridViewTextBoxColumn
        '
        Me.TanjungMalimDataGridViewTextBoxColumn.DataPropertyName = "Tanjung Malim"
        Me.TanjungMalimDataGridViewTextBoxColumn.HeaderText = "Tanjung Malim"
        Me.TanjungMalimDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TanjungMalimDataGridViewTextBoxColumn.Name = "TanjungMalimDataGridViewTextBoxColumn"
        Me.TanjungMalimDataGridViewTextBoxColumn.Width = 125
        '
        'KamparDataGridViewTextBoxColumn
        '
        Me.KamparDataGridViewTextBoxColumn.DataPropertyName = "Kampar"
        Me.KamparDataGridViewTextBoxColumn.HeaderText = "Kampar"
        Me.KamparDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.KamparDataGridViewTextBoxColumn.Name = "KamparDataGridViewTextBoxColumn"
        Me.KamparDataGridViewTextBoxColumn.Width = 125
        '
        'BatuGajahDataGridViewTextBoxColumn
        '
        Me.BatuGajahDataGridViewTextBoxColumn.DataPropertyName = "Batu Gajah"
        Me.BatuGajahDataGridViewTextBoxColumn.HeaderText = "Batu Gajah"
        Me.BatuGajahDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.BatuGajahDataGridViewTextBoxColumn.Name = "BatuGajahDataGridViewTextBoxColumn"
        Me.BatuGajahDataGridViewTextBoxColumn.Width = 125
        '
        'IpohDataGridViewTextBoxColumn
        '
        Me.IpohDataGridViewTextBoxColumn.DataPropertyName = "Ipoh"
        Me.IpohDataGridViewTextBoxColumn.HeaderText = "Ipoh"
        Me.IpohDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IpohDataGridViewTextBoxColumn.Name = "IpohDataGridViewTextBoxColumn"
        Me.IpohDataGridViewTextBoxColumn.Width = 125
        '
        'KualaKangsarDataGridViewTextBoxColumn
        '
        Me.KualaKangsarDataGridViewTextBoxColumn.DataPropertyName = "Kuala Kangsar"
        Me.KualaKangsarDataGridViewTextBoxColumn.HeaderText = "Kuala Kangsar"
        Me.KualaKangsarDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.KualaKangsarDataGridViewTextBoxColumn.Name = "KualaKangsarDataGridViewTextBoxColumn"
        Me.KualaKangsarDataGridViewTextBoxColumn.Width = 125
        '
        'TaipingDataGridViewTextBoxColumn
        '
        Me.TaipingDataGridViewTextBoxColumn.DataPropertyName = "Taiping"
        Me.TaipingDataGridViewTextBoxColumn.HeaderText = "Taiping"
        Me.TaipingDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TaipingDataGridViewTextBoxColumn.Name = "TaipingDataGridViewTextBoxColumn"
        Me.TaipingDataGridViewTextBoxColumn.Width = 125
        '
        'BukitMertajamDataGridViewTextBoxColumn
        '
        Me.BukitMertajamDataGridViewTextBoxColumn.DataPropertyName = "Bukit Mertajam"
        Me.BukitMertajamDataGridViewTextBoxColumn.HeaderText = "Bukit Mertajam"
        Me.BukitMertajamDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.BukitMertajamDataGridViewTextBoxColumn.Name = "BukitMertajamDataGridViewTextBoxColumn"
        Me.BukitMertajamDataGridViewTextBoxColumn.Width = 125
        '
        'ButterworthDataGridViewTextBoxColumn
        '
        Me.ButterworthDataGridViewTextBoxColumn.DataPropertyName = "Butterworth"
        Me.ButterworthDataGridViewTextBoxColumn.HeaderText = "Butterworth"
        Me.ButterworthDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ButterworthDataGridViewTextBoxColumn.Name = "ButterworthDataGridViewTextBoxColumn"
        Me.ButterworthDataGridViewTextBoxColumn.Width = 125
        '
        'SungaiPetaniDataGridViewTextBoxColumn
        '
        Me.SungaiPetaniDataGridViewTextBoxColumn.DataPropertyName = "Sungai Petani"
        Me.SungaiPetaniDataGridViewTextBoxColumn.HeaderText = "Sungai Petani"
        Me.SungaiPetaniDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.SungaiPetaniDataGridViewTextBoxColumn.Name = "SungaiPetaniDataGridViewTextBoxColumn"
        Me.SungaiPetaniDataGridViewTextBoxColumn.Width = 125
        '
        'GurunDataGridViewTextBoxColumn
        '
        Me.GurunDataGridViewTextBoxColumn.DataPropertyName = "Gurun"
        Me.GurunDataGridViewTextBoxColumn.HeaderText = "Gurun"
        Me.GurunDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.GurunDataGridViewTextBoxColumn.Name = "GurunDataGridViewTextBoxColumn"
        Me.GurunDataGridViewTextBoxColumn.Width = 125
        '
        'AlorStarDataGridViewTextBoxColumn
        '
        Me.AlorStarDataGridViewTextBoxColumn.DataPropertyName = "Alor Star"
        Me.AlorStarDataGridViewTextBoxColumn.HeaderText = "Alor Star"
        Me.AlorStarDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.AlorStarDataGridViewTextBoxColumn.Name = "AlorStarDataGridViewTextBoxColumn"
        Me.AlorStarDataGridViewTextBoxColumn.Width = 125
        '
        'AnakBukitDataGridViewTextBoxColumn
        '
        Me.AnakBukitDataGridViewTextBoxColumn.DataPropertyName = "Anak Bukit"
        Me.AnakBukitDataGridViewTextBoxColumn.HeaderText = "Anak Bukit"
        Me.AnakBukitDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.AnakBukitDataGridViewTextBoxColumn.Name = "AnakBukitDataGridViewTextBoxColumn"
        Me.AnakBukitDataGridViewTextBoxColumn.Width = 125
        '
        'ArauDataGridViewTextBoxColumn
        '
        Me.ArauDataGridViewTextBoxColumn.DataPropertyName = "Arau"
        Me.ArauDataGridViewTextBoxColumn.HeaderText = "Arau"
        Me.ArauDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ArauDataGridViewTextBoxColumn.Name = "ArauDataGridViewTextBoxColumn"
        Me.ArauDataGridViewTextBoxColumn.Width = 125
        '
        'PadangBesarDataGridViewTextBoxColumn
        '
        Me.PadangBesarDataGridViewTextBoxColumn.DataPropertyName = "Padang Besar"
        Me.PadangBesarDataGridViewTextBoxColumn.HeaderText = "Padang Besar"
        Me.PadangBesarDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PadangBesarDataGridViewTextBoxColumn.Name = "PadangBesarDataGridViewTextBoxColumn"
        Me.PadangBesarDataGridViewTextBoxColumn.Width = 125
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.Width = 125
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
        'TimetableBindingNavigator
        '
        Me.TimetableBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TimetableBindingNavigator.BindingSource = Me.TimetableBindingSource
        Me.TimetableBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TimetableBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TimetableBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.TimetableBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TimetableBindingNavigatorSaveItem})
        Me.TimetableBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TimetableBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TimetableBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TimetableBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TimetableBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TimetableBindingNavigator.Name = "TimetableBindingNavigator"
        Me.TimetableBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TimetableBindingNavigator.Size = New System.Drawing.Size(800, 27)
        Me.TimetableBindingNavigator.TabIndex = 22
        Me.TimetableBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(45, 24)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 27)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'TimetableBindingNavigatorSaveItem
        '
        Me.TimetableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TimetableBindingNavigatorSaveItem.Image = CType(resources.GetObject("TimetableBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TimetableBindingNavigatorSaveItem.Name = "TimetableBindingNavigatorSaveItem"
        Me.TimetableBindingNavigatorSaveItem.Size = New System.Drawing.Size(29, 24)
        Me.TimetableBindingNavigatorSaveItem.Text = "Save Data"
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.TicketTableAdapter = Nothing
        Me.TableAdapterManager.TimetableTableAdapter = Me.TimetableTableAdapter
        Me.TableAdapterManager.UpdateOrder = ETS_System.JCLODataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'FormDatabase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TimetableBindingNavigator)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "FormDatabase"
        Me.Text = "FormDatabase"
        CType(Me.TimetableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JCLODataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JCLODataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TimetableBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TimetableBindingNavigator.ResumeLayout(False)
        Me.TimetableBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents JCLODataSetBindingSource As BindingSource
    Friend WithEvents JCLODataSet As JCLODataSet
    Friend WithEvents TimetableBindingSource As BindingSource
    Friend WithEvents TimetableTableAdapter As JCLODataSetTableAdapters.TimetableTableAdapter
    Friend WithEvents Button1 As Button
    Friend WithEvents KLSentralDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents KualaLumpurDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TanjungMalimDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents KamparDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BatuGajahDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IpohDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents KualaKangsarDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TaipingDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BukitMertajamDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ButterworthDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SungaiPetaniDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GurunDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AlorStarDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AnakBukitDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ArauDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PadangBesarDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TimetableBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents TimetableBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents TableAdapterManager As JCLODataSetTableAdapters.TableAdapterManager
End Class
