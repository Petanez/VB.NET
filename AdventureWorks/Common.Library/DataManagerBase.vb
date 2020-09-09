Public Class DataManagerBase
    Public Function LoadXElement(ByVal partialFileName As String) As XElement
        Return LoadXElement(partialFileName, Nothing)
    End Function
    Public Function LoadXElement(ByVal partialFileName As String,
                                 ByVal Optional startingFileName As String = "") As XElement
        '   IIf is like ternary if the String.IsNullOrEmpty its gonna return the current directory if not, the starting fileName
        Dim path As String = IIf(String.IsNullOrEmpty(startingFileName), Environment.CurrentDirectory, startingFileName).ToString
        Dim doc As XElement

        '   Concatenates the two strings
        path &= partialFileName
        '   Environment.CurrentDirectory returns something like "D:\Samples\AdventureWorks\bin\Debug"
        '   because thats where the app is running, so we need to replace the ending to access the XML folder
        path = path.Replace("bin\Debug\", "")
        Console.WriteLine(path)

        doc = XElement.Load(path)
        Return doc
    End Function
End Class
