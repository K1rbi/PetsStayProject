Imports System.Data.SqlClient
Module GlobalModule

    Public strConn As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='|DataDirectory|\Database1.mdf';Integrated Security=True"


    Public Function QueryDataTest(sqlCmd As SqlCommand)
        Dim sqlConn As New SqlConnection(strConn)
        sqlCmd.Connection = sqlConn
        Dim sqlDA As New SqlDataAdapter
        Dim ds As New DataSet


        Try

            sqlConn.Open()

            sqlDA.SelectCommand = sqlCmd
            sqlDA.Fill(ds)

        Catch ex As Exception
            MsgBox("Error")

        Finally
            sqlDA.Dispose()
            ds.Dispose()

            If sqlConn.State = ConnectionState.Open Then
                sqlConn.Close()
            End If

        End Try

        Return ds

    End Function



End Module
