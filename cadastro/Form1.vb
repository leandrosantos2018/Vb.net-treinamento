
Imports MySql.Data.MySqlClient


Public Class Form1


    Private conexao As MySqlConnection
    Private comando As MySqlCommand
    Private da As MySqlDataAdapter
    Private dr As MySqlDataReader
    Private strSQL As String

    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click

        Try

            conexao = New MySqlConnection("Server=localhost;Database=crud;Uid=root;Pwd=;")


            strSQL = "insert into cadcliente (nome,numero) values(@Nome, @Numero)"

            comando = New MySqlCommand(strSQL, conexao)
            comando.Parameters.AddWithValue("@Nome", txtNome.Text)
            comando.Parameters.AddWithValue("@Numero", txtnumero.Text)

            conexao.Open()
            comando.ExecuteNonQuery()


        Catch ex As Exception

            MessageBox.Show(ex.Message)
        Finally
            comando.Clone()
            conexao = Nothing
            comando = Nothing
            txtNome.Text = Nothing
            txtId.Text = Nothing
            txtnumero.Text = Nothing
        End Try

        carregargrid()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click

        Try
            conexao = New MySqlConnection("Server=localhost;Database=crud;Uid=root;Pwd=;")

            strSQL = "update cadcliente set nome = @Nome, numero = @Numero where id = @Id"

            comando = New MySqlCommand(strSQL, conexao)
            comando.Parameters.AddWithValue("@Id", txtId.Text)
            comando.Parameters.AddWithValue("@Nome", txtNome.Text)
            comando.Parameters.AddWithValue("@Numero", txtnumero.Text)

            conexao.Open()
            comando.ExecuteNonQuery()


        Catch ex As Exception

            MessageBox.Show(ex.Message)
        Finally
            comando.Clone()
            conexao = Nothing
            comando = Nothing
            txtNome.Text = Nothing
            txtId.Text = Nothing
            txtnumero.Text = Nothing
        End Try

    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        Try
            conexao = New MySqlConnection("Server=localhost;Database=crud;Uid=root;Pwd=;")

            strSQL = "delete from cadcliente where id=@Id or nome = @Nome or numero = @Numero"

            comando = New MySqlCommand(strSQL, conexao)
            comando.Parameters.AddWithValue("@Id", txtId.Text)
            comando.Parameters.AddWithValue("@Nome", txtNome.Text)
            comando.Parameters.AddWithValue("@Numero", txtnumero.Text)

            conexao.Open()
            comando.ExecuteNonQuery()





        Catch ex As Exception

            MessageBox.Show(ex.Message)
        Finally
            comando.Clone()
            conexao = Nothing
            comando = Nothing
            txtNome.Text = Nothing
            txtId.Text = Nothing
            txtnumero.Text = Nothing
        End Try
        carregargrid()




    End Sub

    Private Sub btnConsulta_Click(sender As Object, e As EventArgs) Handles btnConsulta.Click
        Try
            txtId.Enabled = False
            conexao = New MySqlConnection("Server=localhost;Database=crud;Uid=root;Pwd=;")

            strSQL = "select * from cadcliente where id = @Id"

            comando = New MySqlCommand(strSQL, conexao)
            comando.Parameters.AddWithValue("@Id", txtId.Text)


            conexao.Open()
            dr = comando.ExecuteReader()

            Do While dr.Read
                txtNome.Text = dr("nome")
                txtnumero.Text = dr("numero")
            Loop


        Catch ex As Exception

            MessageBox.Show(ex.Message)
        Finally
            comando.Clone()
            conexao = Nothing
            comando = Nothing
        End Try

    End Sub

    Private Sub btnExibir_Click(sender As Object, e As EventArgs) Handles btnExibir.Click
        carregargrid()
    End Sub

    Private Sub carregargrid()
        Try
            conexao = New MySqlConnection("Server=localhost;Database=crud;Uid=root;Pwd=;")

            strSQL = "select * from cadcliente"

            Dim dt As New DataTable

            da = New MySqlDataAdapter(strSQL, conexao)

            da.Fill(dt)

            dgGrid.DataSource = dt
            ' conexao.Open()



        Catch ex As Exception

            MessageBox.Show(ex.Message)
        Finally
            '  comando.Clone()
            conexao = Nothing
            comando = Nothing
        End Try
    End Sub
End Class
