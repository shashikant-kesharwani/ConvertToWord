Public Class NumberToWord
    Dim num As Integer
    Dim numword As String

    Private Sub btnconvert_Click(sender As Object, e As EventArgs) Handles btnconvert.Click
        txtword.Clear()
        numword = ""
        num = txtnumber.Text
        If num = 0 Then
            numword += "Zero"
        End If
        If num Mod 10 = 0 And num \ 10 < 10 Then
            Dim num1 As Integer = num \ 10
            TenToNinety(num1)
        ElseIf num <= 9 Then
            oneToNine(num)
        ElseIf num > 10 And num <= 19 Then
            elevenToNineteen(num)
        ElseIf num > 20 And num <= 99 Then
            Dim numdiv As Integer = num \ 10
            TenToNinety(numdiv)
            Dim nummod As Integer = num Mod 10
            oneToNine(nummod)

        ElseIf num > 99 And num <= 999 Then
            Dim numdiv100 As Integer = num \ 100
            oneToNine(numdiv100)
            hundred()
            Dim nummod100 As Integer = num Mod 100
            If nummod100 < 20 Then
                elevenToNineteen(nummod100)
            Else
                Dim numdiv As Integer = nummod100 \ 10
                TenToNinety(numdiv)
                Dim nummod As Integer = nummod100 Mod 10
                oneToNine(nummod)
            End If

        ElseIf num > 999 And num <= 9999 Then
            Dim num100 As Integer
            Dim numdiv1000 As Integer = num \ 1000
            oneToNine(numdiv1000)
            thousand()
            Dim nummod1000 As Integer = num Mod 1000
            Dim numdiv100 As Integer = nummod1000 \ 100
            If nummod1000 > 99 Then
                oneToNine(numdiv100)
                hundred()
                num100 = nummod1000 Mod 100
            End If
            If (nummod1000 < 20 And nummod1000 > 10) Or (num100 < 20 And num100 > 10) Then
                elevenToNineteen(nummod1000)
                elevenToNineteen(num100)
            Else
                Dim nummod100 As Integer = nummod1000 Mod 100
                Dim numdiv As Integer = nummod100 \ 10
                TenToNinety(numdiv)
                Dim nummod As Integer = nummod100 Mod 10
                oneToNine(nummod)
            End If
        ElseIf num > 9999 And num < 99999 Then
            Dim numdiv10000 As Integer = num \ 10000
            Dim nummod10000 As Integer = num Mod 10000
            Dim num100 As Integer
            Dim numdiv1000 As Integer = nummod10000 \ 1000
            If numdiv10000 = 1 And nummod10000 > 1000 Then
                Dim num1000 As Integer = num \ 1000
                elevenToNineteen(num1000)
            Else
                TenToNinety(numdiv10000)
                oneToNine(numdiv1000)
            End If
            thousand()
            Dim nummod1000 As Integer = nummod10000 Mod 1000
            Dim numdiv100 As Integer = nummod1000 \ 100
            If nummod1000 > 99 Then
                oneToNine(numdiv100)
                hundred()
                num100 = nummod1000 Mod 100
            End If
            If (nummod1000 < 20 And nummod1000 > 10) Or (num100 < 20 And num100 > 10) Then
                elevenToNineteen(nummod1000)
                elevenToNineteen(num100)
            Else
                Dim nummod100 As Integer = nummod1000 Mod 100
                Dim numdiv As Integer = nummod100 \ 10
                TenToNinety(numdiv)
                Dim nummod As Integer = nummod100 Mod 10
                oneToNine(nummod)
            End If

        ElseIf num > 99999 And num < 999999 Then
            Dim numdiv100000 As Integer = num \ 100000
            oneToNine(numdiv100000)
            lack()
            Dim nummod100000 As Integer = num Mod 100000
            Dim numdiv10000 As Integer = nummod100000 \ 10000
            Dim nummod10000 As Integer = nummod100000 Mod 10000
            Dim num100 As Integer
            Dim numdiv1000 As Integer = nummod10000 \ 1000
            If numdiv10000 = 1 And nummod10000 > 1000 Then
                Dim num1000 As Integer = nummod100000 \ 1000
                elevenToNineteen(num1000)
            Else
                TenToNinety(numdiv10000)
                oneToNine(numdiv1000)
            End If
            If num <> 100000 Then
                thousand()
            End If
            Dim nummod1000 As Integer = nummod10000 Mod 1000
            Dim numdiv100 As Integer = nummod1000 \ 100
            If nummod1000 > 99 Then

                oneToNine(numdiv100)
                hundred()
                num100 = nummod1000 Mod 100
            End If
            If (nummod1000 < 20 And nummod1000 > 10) Or (num100 < 20 And num100 > 10) Then
                elevenToNineteen(nummod1000)
                elevenToNineteen(num100)
            Else
                Dim nummod100 As Integer = nummod1000 Mod 100
                Dim numdiv As Integer = nummod100 \ 10
                TenToNinety(numdiv)
                Dim nummod As Integer = nummod100 Mod 10
                oneToNine(nummod)
            End If

        End If
        txtword.Text = numword
    End Sub

    Sub oneToNine(num1 As Integer)
        If num1 = 1 Then
            numword += " one"
        ElseIf num1 = 2 Then
            numword += " Two"
        ElseIf num1 = 3 Then
            numword += " Three"
        ElseIf num1 = 4 Then
            numword += " Four"
        ElseIf num1 = 5 Then
            numword += " Five"
        ElseIf num1 = 6 Then
            numword += " Six"
        ElseIf num1 = 7 Then
            numword += " Seven"
        ElseIf num1 = 8 Then
            numword += " Eight"
        ElseIf num1 = 9 Then
            numword += " Nine"
        End If
    End Sub

    Sub elevenToNineteen(num1 As Integer)
        If num1 = 11 Then
            numword += " Eleven"
        ElseIf num1 = 12 Then
            numword += " Twelve"
        ElseIf num1 = 13 Then
            numword += " Thirteen"
        ElseIf num1 = 14 Then
            numword += " Fourteen"
        ElseIf num1 = 15 Then
            numword += " Fiveteen"
        ElseIf num1 = 16 Then
            numword += " Sixteen"
        ElseIf num1 = 17 Then
            numword += " Seventeen"
        ElseIf num1 = 18 Then
            numword += " Eighteen"
        ElseIf num1 = 19 Then
            numword += " Nineteen"
        End If
    End Sub

    Sub TenToNinety(num1 As Integer)
        If num1 = 1 Then
            numword += " Ten"
        ElseIf num1 = 2 Then
            numword += " Twenty"
        ElseIf num1 = 3 Then
            numword += " Thirty"
        ElseIf num1 = 4 Then
            numword += " Fourty"
        ElseIf num1 = 5 Then
            numword += " Fivety"
        ElseIf num1 = 6 Then
            numword += " Sixty"
        ElseIf num1 = 7 Then
            numword += " Seventy"
        ElseIf num1 = 8 Then
            numword += " Eighty"
        ElseIf num1 = 9 Then
            numword += " Ninety"

        End If
    End Sub
    Sub hundred()
        numword += " Hundred"
    End Sub

    Sub thousand()
        numword += " Thousand"
    End Sub
    Sub lack()
        numword += " Lack"
    End Sub
End Class