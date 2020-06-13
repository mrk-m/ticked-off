Public Class BoardCostCalculator
    Friend Shared Function validateData(weight As String, length As String) As Boolean
        If Not Decimal.TryParse(weight, New Decimal) Then
            MessageBox.Show("Please enter a valid pet weight", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        ElseIf Not Integer.TryParse(length, New Integer) Then
            MessageBox.Show("Please enter a valid stay length", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        Return True
    End Function

    Friend Shared Function calculateCost(species As String, weightS As String, lengthS As String) As Double
        Dim weight = Double.Parse(weightS)
        Dim length = Integer.Parse(lengthS)

        ' Base Rate
        Dim baseRate = 20
        ' Daily Rate
        Dim petDailyRate = 0
        If (species = "Rabbit") Then
            petDailyRate = 3
        ElseIf (species = "Cat" Or species = "Dog" Or species = "Ferret") Then
            petDailyRate = 5
        ElseIf (species = "Goat") Then
            petDailyRate = 12
        ElseIf (species = "Snake") Then
            petDailyRate = 15
        ElseIf (species = "Koala") Then
            petDailyRate = 20
        ElseIf (species = "Horse") Then
            petDailyRate = 22
        ElseIf (species = "Yak") Then
            petDailyRate = 108
        End If

        ' Fatty Factor
        Dim fattyFactor = 0
        If (weight >= 12) Then
            fattyFactor = 1.5 * weight
        End If

        ' Dumpling Discount
        Dim dumplingDiscount = 0
        If (length > 10) Then
            dumplingDiscount = 0.1
        End If

        Return (baseRate + petDailyRate) * Integer.Parse(length) + fattyFactor * (1 - dumplingDiscount)
    End Function
End Class
