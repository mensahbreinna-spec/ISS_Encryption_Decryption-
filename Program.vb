Module Program

    Sub Main()

        Dim message As String
        Dim encrypted As String = ""
        Dim decrypted As String = ""

        Console.Write("Enter your message: ")
        message = Console.ReadLine()

        ' Encryption
        For Each letter As Char In message
            encrypted &= ChrW(AscW(letter) + 3)
        Next

        Console.WriteLine("Encrypted Message: " & encrypted)

        ' Decryption
        For Each letter As Char In encrypted
            decrypted &= ChrW(AscW(letter) - 3)
        Next

        Console.WriteLine("Decrypted Message: " & decrypted)

        Console.ReadLine()

    End Sub

End Module