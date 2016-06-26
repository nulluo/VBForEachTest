Public Class Form1

    Private testArrayA(4) As TestStructure

    Private Sub forButton_Click(sender As System.Object, e As System.EventArgs) Handles forButton.Click

        For i As Integer = 0 To testArrayA.Length - 1
            testArrayA(i).Initialize()
        Next

        checkData(testArrayA)
    End Sub

    Private testArrayB(4) As TestStructure

    Private Sub forNextButton_Click(sender As System.Object, e As System.EventArgs) Handles forNextButton.Click

        For Each test As TestStructure In testArrayB
            test.Initialize()
        Next

        checkData(testArrayB)
    End Sub

    Private Sub checkData(target As TestStructure())
        For Each test As TestStructure In target
            With test
                System.Diagnostics.Debug.WriteLine(
                    "member(0):{0} member(1):{1} member(2):{2}", .member(0), .member(1), .member(2))
            End With
        Next
    End Sub

End Class
