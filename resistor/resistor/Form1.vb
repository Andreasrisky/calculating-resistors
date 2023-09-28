Public Class Form1
    Dim w1, w2, w3, w4, jum, resistor As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        jum = w1 + w2
        resistor = jum * w3
        TextBox1.Text = resistor
        TextBox2.Text = w4
    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox4.SelectedIndexChanged
        If ComboBox4.SelectedItem = "Coklat" Then
            w4 = 1
        ElseIf ComboBox4.SelectedItem = "Merah" Then
            w4 = 2
        ElseIf ComboBox4.SelectedItem = "Hijau" Then
            w4 = 0.5
        ElseIf ComboBox4.SelectedItem = "Biru" Then
            w4 = 0.25
        ElseIf ComboBox4.SelectedItem = "Ungu" Then
            w4 = 0.1
        ElseIf ComboBox4.SelectedItem = "Abu-Abu" Then
            w4 = 0.05
        ElseIf ComboBox4.SelectedItem = "Emas" Then
            w4 = 5
        ElseIf ComboBox4.SelectedItem = "Perak" Then
            w4 = 10
        End If
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        If ComboBox3.SelectedItem = "Hitam" Then
            w3 = 1
        ElseIf ComboBox3.SelectedItem = "Coklat" Then
            w3 = 10
        ElseIf ComboBox3.SelectedItem = "Merah" Then
            w3 = 100
        ElseIf ComboBox3.SelectedItem = "Jingga" Then
            w3 = 1000
        ElseIf ComboBox3.SelectedItem = "Kuning" Then
            w3 = 10000
        ElseIf ComboBox3.SelectedItem = "Hijau" Then
            w3 = 100000
        ElseIf ComboBox3.SelectedItem = "Biru" Then
            w3 = 1000000
        ElseIf ComboBox3.SelectedItem = "Ungu" Then
            w3 = 10000000
        ElseIf ComboBox3.SelectedItem = "Emas" Then
            w3 = 0.1
        ElseIf ComboBox3.SelectedItem = "Perak" Then
            w3 = 0.01
        End If
    End Sub


    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        If ComboBox2.SelectedItem = "Hitam" Then
            w2 = 0
        ElseIf ComboBox2.SelectedItem = "Coklat" Then
            w2 = 1
        ElseIf ComboBox2.SelectedItem = "Merah" Then
            w2 = 2
        ElseIf ComboBox2.SelectedItem = "Jingga" Then
            w2 = 3
        ElseIf ComboBox2.SelectedItem = "Kuning" Then
            w2 = 4
        ElseIf ComboBox2.SelectedItem = "Hijau" Then
            w2 = 5
        ElseIf ComboBox2.SelectedItem = "Biru" Then
            w2 = 6
        ElseIf ComboBox2.SelectedItem = "Ungu" Then
            w2 = 7
        ElseIf ComboBox2.SelectedItem = "Abu-Abu" Then
            w2 = 8
        ElseIf ComboBox2.SelectedItem = "Putih" Then
            w2 = 9
        End If
    End Sub


    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedItem = "Hitam" Then
            w1 = 0
        ElseIf ComboBox1.SelectedItem = "Coklat" Then
            w1 = 10
        ElseIf ComboBox1.SelectedItem = "Merah" Then
            w1 = 20
        ElseIf ComboBox1.SelectedItem = "Jingga" Then
            w1 = 30
        ElseIf ComboBox1.SelectedItem = "Kuning" Then
            w1 = 40
        ElseIf ComboBox1.SelectedItem = "Hijau" Then
            w1 = 50
        ElseIf ComboBox1.SelectedItem = "Biru" Then
            w1 = 60
        ElseIf ComboBox1.SelectedItem = "Ungu" Then
            w1 = 70
        ElseIf ComboBox1.SelectedItem = "Abu-Abu" Then
            w1 = 80
        ElseIf ComboBox1.SelectedItem = "Putih" Then
            w1 = 90
        End If
    End Sub
End Class
