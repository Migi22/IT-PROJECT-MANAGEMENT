﻿Public Class Dashboard
    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        With Form1
            .TopLevel = False
            panelRight.Controls.Add(Form1)
            .BringToFront()
            .Show()
            .Focus()

        End With
    End Sub
End Class