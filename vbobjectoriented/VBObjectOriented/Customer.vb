Public Class Customer
    Inherits CommonBase
    Sub New()
        '   The MyBase keyword is specific to Visual Basic and allows you to access any public property 
        '   or method in the inherited class --- Means my base class and .New calls ITS constructor
        '   YOU CAN CALL METHODS FROM COMMONBASE USING MyBase.(methodName)
        MyBase.New()

        CustomerID = 1
    End Sub

    Public Property CustomerID As Integer
    Public Property FirstName As String
    Public Property LastName As String
    Public Property CompanyName As String

    '   Needs the keyword overrides because the base class has a function with the same name but with overridable
    '   and   the keyword Protected to be in the same scope with the inherited protected GetClassData
    Protected Overrides Function GetClassData() As String
        '   The stringbuilder class is an efficient method of conatenating strings together
        '   The 1024 is the capacity the builder is initialized with
        Dim sb As New Text.StringBuilder(1024)

        sb.AppendLine("Customer ID: " + CustomerID.ToString())
        sb.AppendLine("Company Name: " + CompanyName)
        sb.AppendLine("First Name: " + FirstName)
        sb.AppendLine("Last Name: " + LastName)
        sb.AppendLine(MyBase.GetClassData())
        '   THESE ARE INCLUDED IN THE MyBase.GetClassData()
        'sb.AppendLine("Is Active: " + IsActive.ToString())
        'sb.AppendLine("Modified Date: " + ModifiedDate.ToString())
        'sb.AppendLine("Created by: " + CreatedBy)

        Return sb.ToString()
    End Function

End Class
