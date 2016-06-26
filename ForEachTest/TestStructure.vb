Public Structure TestStructure

    Dim member As ArrayList

    Public Sub Initialize()
        member = New ArrayList()
        For i As Integer = 0 To 2
            member.Add("hoge")
        Next
    End Sub

End Structure
