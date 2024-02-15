Public Class Form1

    Dim checker As Boolean

    Private Sub Enable_False()
        btn11.Enabled = False
        btn12.Enabled = False
        btn13.Enabled = False
        btn21.Enabled = False
        btn22.Enabled = False
        btn23.Enabled = False
        btn31.Enabled = False
        btn32.Enabled = False
        btn33.Enabled = False
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn11_Click(sender As Object, e As EventArgs) Handles btn11.Click
        If (checker = False) Then
            btn11.Text = "X"
            checker = True
        Else
            btn11.Text = "O"
            checker = False
        End If
    End Sub

    Private Sub btn12_Click(sender As Object, e As EventArgs) Handles btn12.Click
        If (checker = False) Then
            btn12.Text = "X"
            checker = True
        Else
            btn12.Text = "O"
            checker = False
        End If
    End Sub

    Private Sub btn13_Click(sender As Object, e As EventArgs) Handles btn13.Click
        If (checker = False) Then
            btn13.Text = "X"
            checker = True
        Else
            btn13.Text = "O"
            checker = False
        End If
    End Sub

    Private Sub btn21_Click(sender As Object, e As EventArgs) Handles btn21.Click
        If (checker = False) Then
            btn21.Text = "X"
            checker = True
        Else
            btn21.Text = "O"
            checker = False
        End If
    End Sub

    Private Sub btn22_Click(sender As Object, e As EventArgs) Handles btn22.Click
        If (checker = False) Then
            btn22.Text = "X"
            checker = True
        Else
            btn22.Text = "O"
            checker = False
        End If
    End Sub

    Private Sub btn23_Click(sender As Object, e As EventArgs) Handles btn23.Click
        If (checker = False) Then
            btn23.Text = "X"
            checker = True
        Else
            btn23.Text = "O"
            checker = False
        End If
    End Sub

    Private Sub btn31_Click(sender As Object, e As EventArgs) Handles btn31.Click
        If (checker = False) Then
            btn31.Text = "X"
            checker = True
        Else
            btn31.Text = "O"
            checker = False
        End If
    End Sub

    Private Sub btn32_Click(sender As Object, e As EventArgs) Handles btn32.Click
        If (checker = False) Then
            btn32.Text = "X"
            checker = True
        Else
            btn32.Text = "O"
            checker = False
        End If
    End Sub

    Private Sub btn33_Click(sender As Object, e As EventArgs) Handles btn33.Click
        If (checker = False) Then
            btn33.Text = "X"
            checker = True
        Else
            btn33.Text = "O"
            checker = False
        End If
    End Sub
End Class
