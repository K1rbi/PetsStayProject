Imports System.Data.SqlClient
Imports System.Configuration

Public Class WebForm1
    Inherits System.Web.UI.Page

    Private dteNewEntrydate As New Date
    Private dteNewExitDate As New Date

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnOSubmit_Click(sender As Object, e As EventArgs) Handles btnOSubmit.Click
        'this Is The sumbit for owners infomation 
        Call InsertRecordO

    End Sub

    Protected Sub btnPSubmit_Click(sender As Object, e As EventArgs) Handles btnPSubmit.Click
        'this is the sumbit for the pets infomation
        Call InsertRecordP()

    End Sub

    Private Sub InsertRecordO()
        Dim strOName As String = txtOName.Text
        Dim strOEmail As String = txtOEmail.Text
        Dim strOPhone As String = txtOPhone.Text
        Dim strONotes As String = txtONotes.Text

        ' insert record
        'Dim strConn As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='|DataDirectory|\Database1.mdf;Integrated Security=True"
        Dim strSQL As String = "INSERT INTO [dbo].[tblCustomers] ([Name],[Phone],[Email],[Notes]) Values(@Name ,@phone ,@Email ,@Notes)"
        Dim sqlCMD As SqlCommand
        Dim sqlConn As New SqlConnection(strConn)

        ' open conection

        Try
            'try open
            sqlConn.Open()
            sqlCMD = New SqlCommand(strSQL, sqlConn)


            With sqlCMD.Parameters
                .AddWithValue("@Name", strOName)
                .AddWithValue("@Phone", strOPhone)
                .AddWithValue("@Email", strOEmail)
                .AddWithValue("@Notes", strONotes)
            End With

            'execute 
            sqlCMD.ExecuteNonQuery()

            'success
            Call OwnerClear()
        Catch ex As Exception
            'if error ocours 
            MsgBox("An error occoured while processing your request",, "Processing Error")

        Finally
            'close conection
            If sqlConn.State = ConnectionState.Open Then

                sqlConn.Close()
            End If

        End Try
        Call SetSessionIDO(strOName, strOEmail, strOPhone, strONotes)
        Response.Redirect("SuccessO.aspx")

    End Sub
    Private Sub InsertRecordP()
        Dim strPName As String = txtPName.Text
        Dim strPAge As String = txtPAge.Text
        Dim strPBreed As String = txtPBreed.Text
        Dim strPNotes As String = txtPNotes.Text
        Dim strPOwner As String = ddlPOwner.SelectedValue
        Dim strPLocationLetter As String = ddlPLocationLetter.Text
        Dim strPLocationNum As String = ddlPLocationNum.Text
        ' combining low and Num
        Dim strPlocation As String = strPLocationLetter + strPLocationNum

        ' Dates 
        ' date is currently out of order 
        Dim strTempPEntery As String = cldPEntery.SelectedDate
        Dim strTempPExit As String = cldPExit.SelectedDate
        ' setup for date passing


        Dim provider As System.Globalization.CultureInfo = System.Globalization.CultureInfo.InvariantCulture
        Dim dteNewEntrydate As Date = cldPEntery.SelectedDate
        Dim dteNewExitDate As Date = cldPExit.SelectedDate

        ' MsgBox(date1)

        'setting 
        'dteNewEntrydate = Date.ParseExact(dteNewEntrydate, "dd/MM/yyyy", provider)
        'dteNewExitDate = Date.ParseExact(dteNewExitDate, "dd/MM/yyyy", provider)




        ' insert record
        'Dim strConn As String = "Data Source=(LocalDB) \ MSSQLLocalDB;AttachDbFilename='|DataDirectory|\Database1.mdf;Integrated Security=True"
        Dim strSQL As String = "INSERT INTO tblPets ([Name],[Breed],[Location],[Age],[Owner],[Notes],[Entry],[Exit]) Values"
        strSQL &= "(@Name ,@Breed ,@location ,@Age ,@Owner ,@Notes ,@Entery ,@Exit)"
        Dim sqlCMD As SqlCommand
        Dim sqlConn As New SqlConnection(strConn)

        'message box for testing date entry /  date is lossing month 
        'MsgBox(dteNewEntrydate)
        ' open conection

        Try
            'try open
            sqlConn.Open()
            sqlCMD = New SqlCommand(strSQL, sqlConn)


            With sqlCMD.Parameters
                .AddWithValue("@Name", strPName)
                .AddWithValue("@Breed", strPBreed)
                .AddWithValue("@Location", strPlocation)
                .AddWithValue("@Age", strPAge)
                .AddWithValue("@Owner", strPOwner)
                .AddWithValue("@Notes", strPNotes)
                .AddWithValue("@Entery", dteNewEntrydate)
                .AddWithValue("@Exit", dteNewExitDate)
            End With

            'execute  ' failing here 
            sqlCMD.ExecuteNonQuery()

            'success
            Call PetsClear()
        Catch ex As Exception
            'if error ocours 
            MsgBox("An error occoured while processing your request",, "Processing Error")

        Finally
            'close conection
            If sqlConn.State = ConnectionState.Open Then

                sqlConn.Close()
            End If

        End Try

        Call SetSessionIDP(strPName, strPBreed, strPlocation, strPAge, strPOwner, strPNotes, dteNewEntrydate, dteNewExitDate)
        Response.Redirect("SuccessP.aspx")

    End Sub

    Private Sub ClearAll()
        'clearing owner
        txtOEmail.Text = ""
        txtOName.Text = ""
        txtONotes.Text = ""
        txtOPhone.Text = ""
        'clearing pet 
        txtPAge.Text = ""
        txtPBreed.Text = ""
        txtPName.Text = ""
        txtPNotes.Text = ""
    End Sub


    Private Sub PetsClear()

        'clearing pet 
        txtPAge.Text = ""
        txtPBreed.Text = ""
        txtPName.Text = ""
        txtPNotes.Text = ""

    End Sub

    Private Sub OwnerClear()

        'clearing owner
        txtOEmail.Text = ""
        txtOName.Text = ""
        txtONotes.Text = ""
        txtOPhone.Text = ""

    End Sub


    Protected Sub btnOClear_Click(sender As Object, e As EventArgs) Handles btnOClear.Click

        PetsClear()

    End Sub

    Protected Sub btnPClear_Click(sender As Object, e As EventArgs) Handles btnPClear.Click

        OwnerClear()

    End Sub

    Protected Sub cldPEntery_SelectionChanged(sender As Object, e As EventArgs) Handles cldPEntery.SelectionChanged
        dteNewEntrydate = cldPEntery.SelectedDate

    End Sub

    Protected Sub cldPExit_SelectionChanged(sender As Object, e As EventArgs) Handles cldPExit.SelectionChanged
        dteNewExitDate = cldPExit.SelectedDate
    End Sub


    Private Sub SetSessionIDO(strOName As String, strOEmail As String, strOPhone As String, strONotes As String)

        Dim strSQL As String = " SELECT id From tblCustomers WHERE [Name] = @name AND [Email] = @email AND [Phone] = @phone AND [Notes] = @notes"


        Dim sqlCmd As New SqlCommand()



        With sqlCmd.Parameters
            .AddWithValue("@Name", strOName)
            .AddWithValue("@Phone", strOPhone)
            .AddWithValue("@Email", strOEmail)
            .AddWithValue("@Notes", strONotes)
        End With
        sqlCmd.CommandText = strSQL
        Dim ds As DataSet = QueryDataTest(sqlCmd)

        If ds.Tables(0).Rows.Count > 0 Then
            Dim intID As Integer = ds.Tables(0).Rows(0).Item(0)

            Session("BID") = intID
        End If

    End Sub


    Private Sub SetSessionIDP(strPName As String, strPBreed As String, strPlocation As String, strPAge As String, strPOwner As String, strPNotes As String, dteNewEntrydate As Date, dteNewExitDate As Date)

        Dim strSQL As String = " SELECT id From tblPets WHERE [Name] = @name AND [Breed] = @Breed AND [Location] = @Loc AND [Age] = @Age AND [Owner] = @Owner AND [Notes] = @Notes"


        Dim sqlCmd As New SqlCommand()

        With sqlCmd.Parameters
            .AddWithValue("@Name", strPName)
            .AddWithValue("@Breed", strPBreed)
            .AddWithValue("@Loc", strPlocation)
            .AddWithValue("@Age", strPAge)
            .AddWithValue("@Owner", strPOwner)
            .AddWithValue("@Notes", strPNotes)
            .AddWithValue("@Entery", dteNewEntrydate)
            .AddWithValue("@Exit", dteNewExitDate)
        End With
        sqlCmd.CommandText = strSQL
        Dim ds As DataSet = QueryDataTest(sqlCmd)

        If ds.Tables(0).Rows.Count > 0 Then
            Dim intID As Integer = ds.Tables(0).Rows(0).Item(0)

            Session("PID") = intID
        End If

    End Sub












End Class