<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim NombreLabel As System.Windows.Forms.Label
        Dim ApellidoLabel As System.Windows.Forms.Label
        Dim EdadLabel As System.Windows.Forms.Label
        Me.EstudiantesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.EstudiantesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.EstudiantesDataGridView = New System.Windows.Forms.DataGridView()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.ApellidoTextBox = New System.Windows.Forms.TextBox()
        Me.EdadTextBox = New System.Windows.Forms.TextBox()
        Me.EstudiantesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ColegioDataSet = New colegio.colegioDataSet()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstudiantesTableAdapter = New colegio.colegioDataSetTableAdapters.estudiantesTableAdapter()
        Me.TableAdapterManager = New colegio.colegioDataSetTableAdapters.TableAdapterManager()
        Me.btn_insert = New System.Windows.Forms.Button()
        NombreLabel = New System.Windows.Forms.Label()
        ApellidoLabel = New System.Windows.Forms.Label()
        EdadLabel = New System.Windows.Forms.Label()
        CType(Me.EstudiantesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EstudiantesBindingNavigator.SuspendLayout()
        CType(Me.EstudiantesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EstudiantesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColegioDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EstudiantesBindingNavigator
        '
        Me.EstudiantesBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.EstudiantesBindingNavigator.BindingSource = Me.EstudiantesBindingSource
        Me.EstudiantesBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.EstudiantesBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.EstudiantesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.EstudiantesBindingNavigatorSaveItem})
        Me.EstudiantesBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.EstudiantesBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.EstudiantesBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.EstudiantesBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.EstudiantesBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.EstudiantesBindingNavigator.Name = "EstudiantesBindingNavigator"
        Me.EstudiantesBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.EstudiantesBindingNavigator.Size = New System.Drawing.Size(405, 25)
        Me.EstudiantesBindingNavigator.TabIndex = 0
        Me.EstudiantesBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'EstudiantesBindingNavigatorSaveItem
        '
        Me.EstudiantesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.EstudiantesBindingNavigatorSaveItem.Image = CType(resources.GetObject("EstudiantesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.EstudiantesBindingNavigatorSaveItem.Name = "EstudiantesBindingNavigatorSaveItem"
        Me.EstudiantesBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.EstudiantesBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'EstudiantesDataGridView
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.EstudiantesDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.EstudiantesDataGridView.AutoGenerateColumns = False
        Me.EstudiantesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EstudiantesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.EstudiantesDataGridView.DataSource = Me.EstudiantesBindingSource
        Me.EstudiantesDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.EstudiantesDataGridView.Location = New System.Drawing.Point(0, 167)
        Me.EstudiantesDataGridView.Name = "EstudiantesDataGridView"
        Me.EstudiantesDataGridView.Size = New System.Drawing.Size(405, 220)
        Me.EstudiantesDataGridView.TabIndex = 1
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(21, 54)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(47, 13)
        NombreLabel.TabIndex = 2
        NombreLabel.Text = "Nombre:"
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EstudiantesBindingSource, "nombre", True))
        Me.NombreTextBox.Location = New System.Drawing.Point(72, 51)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NombreTextBox.TabIndex = 3
        '
        'ApellidoLabel
        '
        ApellidoLabel.AutoSize = True
        ApellidoLabel.Location = New System.Drawing.Point(20, 80)
        ApellidoLabel.Name = "ApellidoLabel"
        ApellidoLabel.Size = New System.Drawing.Size(47, 13)
        ApellidoLabel.TabIndex = 4
        ApellidoLabel.Text = "Apellido:"
        '
        'ApellidoTextBox
        '
        Me.ApellidoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EstudiantesBindingSource, "apellido", True))
        Me.ApellidoTextBox.Location = New System.Drawing.Point(72, 77)
        Me.ApellidoTextBox.Name = "ApellidoTextBox"
        Me.ApellidoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ApellidoTextBox.TabIndex = 5
        '
        'EdadLabel
        '
        EdadLabel.AutoSize = True
        EdadLabel.Location = New System.Drawing.Point(32, 106)
        EdadLabel.Name = "EdadLabel"
        EdadLabel.Size = New System.Drawing.Size(35, 13)
        EdadLabel.TabIndex = 6
        EdadLabel.Text = "Edad:"
        '
        'EdadTextBox
        '
        Me.EdadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EstudiantesBindingSource, "edad", True))
        Me.EdadTextBox.Location = New System.Drawing.Point(72, 103)
        Me.EdadTextBox.Name = "EdadTextBox"
        Me.EdadTextBox.Size = New System.Drawing.Size(100, 20)
        Me.EdadTextBox.TabIndex = 7
        '
        'EstudiantesBindingSource
        '
        Me.EstudiantesBindingSource.DataMember = "estudiantes"
        Me.EstudiantesBindingSource.DataSource = Me.ColegioDataSet
        '
        'ColegioDataSet
        '
        Me.ColegioDataSet.DataSetName = "colegioDataSet"
        Me.ColegioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "nombre"
        Me.DataGridViewTextBoxColumn2.HeaderText = "nombre"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "apellido"
        Me.DataGridViewTextBoxColumn3.HeaderText = "apellido"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "edad"
        Me.DataGridViewTextBoxColumn4.HeaderText = "edad"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'EstudiantesTableAdapter
        '
        Me.EstudiantesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.estudiantesTableAdapter = Me.EstudiantesTableAdapter
        Me.TableAdapterManager.UpdateOrder = colegio.colegioDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'btn_insert
        '
        Me.btn_insert.Location = New System.Drawing.Point(187, 80)
        Me.btn_insert.Name = "btn_insert"
        Me.btn_insert.Size = New System.Drawing.Size(75, 23)
        Me.btn_insert.TabIndex = 8
        Me.btn_insert.Text = "Añadir"
        Me.btn_insert.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(405, 387)
        Me.Controls.Add(Me.btn_insert)
        Me.Controls.Add(EdadLabel)
        Me.Controls.Add(Me.EdadTextBox)
        Me.Controls.Add(ApellidoLabel)
        Me.Controls.Add(Me.ApellidoTextBox)
        Me.Controls.Add(NombreLabel)
        Me.Controls.Add(Me.NombreTextBox)
        Me.Controls.Add(Me.EstudiantesDataGridView)
        Me.Controls.Add(Me.EstudiantesBindingNavigator)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.EstudiantesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EstudiantesBindingNavigator.ResumeLayout(False)
        Me.EstudiantesBindingNavigator.PerformLayout()
        CType(Me.EstudiantesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EstudiantesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColegioDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ColegioDataSet As colegio.colegioDataSet
    Friend WithEvents EstudiantesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EstudiantesTableAdapter As colegio.colegioDataSetTableAdapters.estudiantesTableAdapter
    Friend WithEvents TableAdapterManager As colegio.colegioDataSetTableAdapters.TableAdapterManager
    Friend WithEvents EstudiantesBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents EstudiantesBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents EstudiantesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ApellidoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EdadTextBox As System.Windows.Forms.TextBox
    Friend WithEvents btn_insert As System.Windows.Forms.Button

End Class
