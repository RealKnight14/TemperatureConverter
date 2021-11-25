Public Class FrmTemperature
    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        Dim c, f As Integer
        c = txtCelcius
        f = 9 * c / 5 + 32
        txtFahrenheit


        'Dim Celcius As Integer could be used instead of c'
        'Dim Cel As Integer could be used as c'
        'Dim Fahrenheit as Integer could be used instead of f'
        'Dim Fah as Integer could be used instead of f'

    End Sub

End Class
