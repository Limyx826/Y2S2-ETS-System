Public Class FormCusInfo
    Dim CusInfoPnlCount As Integer = 0

    Dim CurrentCusInfoPnlName As String = Nothing

    Public Sub CreateCusInfo()
        Dim CusInfoPanel As Panel
        CusInfoPanel = New Panel()

        With CusInfoPanel
            .Size = New Size(695, 175)
            .Name = "PnlCusInfo" + (CusInfoPnlCount + 1).ToString
        End With

        FlowLayoutPanel1.Controls.Add(CusInfoPanel)

        CusInfoPnlCount += 1
        CurrentCusInfoPnlName = CusInfoPanel.Name
    End Sub
    Private Sub Button_Back_Click(sender As Object, e As EventArgs) Handles Button_Back.Click
        FormSeat.Show()
        Me.Close()
    End Sub

    Private Sub Button_Next_Click(sender As Object, e As EventArgs) Handles Button_Next.Click
        FormConfirm.Show()
        Me.Close()
    End Sub

    Private Sub Button_Add_Click(sender As Object, e As EventArgs) Handles Button_Add.Click
        CreateCusInfo()
    End Sub
End Class