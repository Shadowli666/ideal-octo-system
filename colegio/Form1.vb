' Imports database manager library
Imports System.Data.OleDb

Public Class Form1
    Dim connection_string As String = My.Settings.colegioConnectionString

    Private Sub EstudiantesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles EstudiantesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.EstudiantesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ColegioDataSet)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ColegioDataSet.estudiantes' Puede moverla o quitarla según sea necesario.
        Me.EstudiantesTableAdapter.Fill(Me.ColegioDataSet.estudiantes)
    End Sub

    Private Sub btn_insert_Click(sender As Object, e As EventArgs) Handles btn_insert.Click
        Dim student As New student With {
            .nombre = NombreTextBox.Text,
            .apellido = ApellidoTextBox.Text,
            .edad = Int(EdadTextBox.Text)
        }
        'TODO: Validaciones usando student.validate()

        'Conexión a la BBDD
        Using connection As New OleDbConnection(connection_string)
            Try
                'Apertura de conexión a bbdd
                connection.Open()
                'String para insertar datos en la bbdd
                'String parametrizada
                Dim sqlInsert As String = "INSERT INTO estudiantes (nombre,apellido,edad) VALUES (@nombre,@apellido,@edad)"
                'cmd es la contracción de "command"
                'OledbCommand lee dos parametros, el primero es la sentencia a ejecutar y el
                'segundo es la conexión
                Using cmd As New OleDbCommand(sqlInsert, connection)
                    'Se añaden los valores de la instancia a la consulta parametrizada
                    cmd.Parameters.AddWithValue("@nombre", student.nombre)
                    cmd.Parameters.AddWithValue("@apellido", student.apellido)
                    cmd.Parameters.AddWithValue("@edad", student.edad)
                    'rowsAffected me sirve para saber cuantas columnas fueron afectadas al ejeuctar la sentencia SQL
                    'cmd.ExecuteNonQuery() ejecuta la sentencia y retorna el valor de las columnas afectadas
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MessageBox.Show("Se insertó el registro")
                        NombreTextBox.Clear()
                        ApellidoTextBox.Clear()
                        EdadTextBox.Clear()
                        Me.EstudiantesTableAdapter.Fill(Me.ColegioDataSet.estudiantes)
                    Else
                        MessageBox.Show("ño")
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Hubo algun error: " & ex.Message)
            End Try
        End Using
    End Sub
End Class
