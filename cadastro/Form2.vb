Imports Microsoft.EntityFrameworkCore.DbLoggerCategory.Database
Imports MySql.Data.MySqlClient

Public Class Form2


    Private conexao As MySqlConnection
    Private comando As MySqlCommand
    Private da As MySqlDataAdapter
    Private dr As MySqlDataReader
    Private strSQL As String

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click

        Try
            Dim usuario As String
            Dim senha As String
            conexao = New MySqlConnection("Server=localhost;Database=crud;Uid=root;Pwd=;")

            strSQL = "select * from usuario where login = @usuario and senha = @senha"

            comando = New MySqlCommand(strSQL, conexao)
            comando.Parameters.AddWithValue("@usuario", txtuser.Text)
            comando.Parameters.AddWithValue("@senha", txtsenha.Text)


            conexao.Open()
            dr = comando.ExecuteReader()



            Do While dr.Read
                usuario = dr("login")
                senha = dr("senha")
            Loop

            If usuario = txtuser.Text And senha = txtsenha.Text Then

                Form1.ShowDialog()
            Else
                MessageBox.Show("usuario invalido")
            End If




        Catch ex As Exception

            MessageBox.Show(ex.Message)
        Finally
            comando.Clone()
            conexao = Nothing
            comando = Nothing
        End Try

    End Sub
End Class