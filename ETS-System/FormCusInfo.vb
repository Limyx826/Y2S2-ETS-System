Public Class FormCusInfo
    Dim CusInfoPnlCount As Integer = 0

    Dim CurrentCusInfoPnlName As String = Nothing

    Public Sub CreateCusInfo()
        Dim CusInfoPanel As Panel
        CusInfoPanel = New Panel()

        With CusInfoPanel
            .BackColor = Color.Wheat
            .Size = New Size(500, 175)
            .Name = "PnlCusInfo" + (CusInfoPnlCount + 1).ToString
        End With

        FlowLayoutPanel1.Controls.Add(CusInfoPanel)

        CusInfoPnlCount += 1
        CurrentCusInfoPnlName = CusInfoPanel.Name
    End Sub

    Public Sub CreateSeatLabel(ByVal panelname As String)
        Dim SeatLabel As Label
        SeatLabel = New Label

        With SeatLabel
            .Location = New Point(43, 19)
            .Text = New String("Label")
        End With

        For Each controlObject As Control In FlowLayoutPanel1.Controls
            If controlObject.Name = panelname Then
                controlObject.Controls.Add(SeatLabel)
            End If
        Next
    End Sub

    Public Sub CreateNameLabel(ByVal panelname As String)
        Dim SeatLabel As Label
        SeatLabel = New Label

        With SeatLabel
            .Location = New Point(43, 19)
            .Text = New String("Label")
        End With

        For Each controlObject As Control In FlowLayoutPanel1.Controls
            If controlObject.Name = panelname Then
                controlObject.Controls.Add(SeatLabel)
            End If
        Next
    End Sub

    Public Sub CreateICLabel(ByVal panelname As String)
        Dim SeatLabel As Label
        SeatLabel = New Label

        With SeatLabel
            .Location = New Point(43, 19)
            .Text = New String("Label")
        End With

        For Each controlObject As Control In FlowLayoutPanel1.Controls
            If controlObject.Name = panelname Then
                controlObject.Controls.Add(SeatLabel)
            End If
        Next
    End Sub

    Public Sub CreateNameTB(ByVal panelname As String)
        Dim SeatLabel As Label
        SeatLabel = New Label

        With SeatLabel
            .Location = New Point(43, 53)
            .Text = New String("Label")
        End With

        For Each controlObject As Control In FlowLayoutPanel1.Controls
            If controlObject.Name = panelname Then
                controlObject.Controls.Add(SeatLabel)
            End If
        Next
    End Sub

    Public Sub CreateICTB(ByVal panelname As String)
        Dim SeatLabel As Label
        SeatLabel = New Label

        With SeatLabel
            .Location = New Point(43, 19)
            .Text = New String("Label")
        End With

        For Each controlObject As Control In FlowLayoutPanel1.Controls
            If controlObject.Name = panelname Then
                controlObject.Controls.Add(SeatLabel)
            End If
        Next
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
        CreateSeatLabel(CurrentCusInfoPnlName)
    End Sub
End Class