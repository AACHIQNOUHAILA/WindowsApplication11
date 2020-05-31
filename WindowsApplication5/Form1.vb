Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'ComandeDataSet1.client'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.ClientTableAdapter1.Fill(Me.ComandeDataSet1.client)
        'TODO: cette ligne de code charge les données dans la table 'ComandeDataSet.client'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.ClientTableAdapter.Fill(Me.ComandeDataSet.client)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        BindingSource1.MoveFirst()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        BindingSource1.MoveNext()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        BindingSource1.MovePrevious()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        BindingSource1.MoveLast()
    End Sub

    Private Sub BindingSource1_CurrentChanged(sender As Object, e As EventArgs) Handles BindingSource1.CurrentChanged

    End Sub
End Class
