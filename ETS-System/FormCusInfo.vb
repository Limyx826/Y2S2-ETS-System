Public Class FormCusInfo
    Dim CusInfoPnlCount As Integer = 0

    Dim CurrentCusInfoPnlName As String = Nothing

    Public Sub CreateCusInfo()
        Dim CusInfoPanel As Panel
        CusInfoPanel = New Panel()

        With CusInfoPanel
            '.BackColor = Color.Wheat
            .Location = New Point(13, 8)
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
            .Text = New String("Label" + CusInfoPnlCount.ToString)
        End With

        For Each controlObject As Control In FlowLayoutPanel1.Controls
            If controlObject.Name = panelname Then
                controlObject.Controls.Add(SeatLabel)
            End If
        Next
    End Sub

    Public Sub CreateNameLabel(ByVal panelname As String)
        Dim NameLabel As Label
        NameLabel = New Label

        With NameLabel
            .Location = New Point(43, 53)
            .Text = New String("Name:")
        End With

        For Each controlObject As Control In FlowLayoutPanel1.Controls
            If controlObject.Name = panelname Then
                controlObject.Controls.Add(NameLabel)
            End If
        Next
    End Sub

    Public Sub CreateICLabel(ByVal panelname As String)
        Dim ICLabel As Label
        ICLabel = New Label

        With ICLabel
            .Location = New Point(43, 126)
            .Text = New String("IC:")
        End With

        For Each controlObject As Control In FlowLayoutPanel1.Controls
            If controlObject.Name = panelname Then
                controlObject.Controls.Add(ICLabel)
            End If
        Next
    End Sub

    Public Sub CreateNameTB(ByVal panelname As String)
        Dim NameTB As TextBox
        NameTB = New TextBox

        With NameTB
            .Location = New Point(157, 53)
            .Size = New Size(328, 22)
        End With

        For Each controlObject As Control In FlowLayoutPanel1.Controls
            If controlObject.Name = panelname Then
                controlObject.Controls.Add(NameTB)
            End If
        Next
    End Sub

    Public Sub CreateICTB(ByVal panelname As String)
        Dim ICTB As TextBox
        ICTB = New TextBox

        With ICTB
            .Location = New Point(157, 126)
            .Size = New Size(328, 22)
        End With

        For Each controlObject As Control In FlowLayoutPanel1.Controls
            If controlObject.Name = panelname Then
                controlObject.Controls.Add(ICTB)
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

    Private Sub FormCusInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For x As Integer = 1 To FormSeat.TotalPass
            CreateCusInfo()
            CreateSeatLabel(CurrentCusInfoPnlName)
            CreateNameLabel(CurrentCusInfoPnlName)
            CreateICLabel(CurrentCusInfoPnlName)
            CreateNameTB(CurrentCusInfoPnlName)
            CreateICTB(CurrentCusInfoPnlName)
        Next
    End Sub

    Private Sub Button_Add_Click(sender As Object, e As EventArgs) Handles Button_Add.Click
        CreateCusInfo()
        CreateSeatLabel(CurrentCusInfoPnlName)
        CreateNameLabel(CurrentCusInfoPnlName)
        CreateICLabel(CurrentCusInfoPnlName)
        CreateNameTB(CurrentCusInfoPnlName)
        CreateICTB(CurrentCusInfoPnlName)
    End Sub
End Class