Public Class Product
    Inherits CommonBase
    '   INHERITANCE
    '/////////////////////////////////////////////////////////////////////////////////////////////////////////////
    '   Constructor for the class
    Sub New()
        StandardCost = 500
        ListPrice = 900
        SellStartDate = DateTime.Now
    End Sub
    '   AUTO IMPLEMENTED PROPERTIES
    Public Property ProductID As Integer
    Public Property Name As String
    Public Property ProductNumber As String
    Public Property Color As String
    Public Property StandardCost As Decimal
    Public Property ListPrice As Decimal
    Public Property Size As String
    Public Property Weight As Decimal
    Public Property SellStartDate As DateTime
    Public Property SellEndDate As DateTime
    '/////////////////////////////////////////////////////////////////////////////////////////////////////////////
    '   USE THIS METHOD IF YOU NEED TO WRITE SOMETHING IN GET OR SET
    ' pressing p and hitting tab twice creates a property declaration
    'Private _IsActive As Boolean
    'Public Property IsActive() As Boolean
    '    Get
    '        Return _IsActive
    '    End Get
    '    Set(ByVal value As Boolean)
    '        _IsActive = value
    '    End Set
    'End Property

    'Private _Name As String
    'Public Property Name() As String
    '    Get
    '        Return _Name
    '    End Get
    '    Set(ByVal value As String)
    '        _Name = value
    '    End Set
    'End Property

    'Private _ProductNumber As String
    'Public Property ProductNumber() As String
    '    Get
    '        Return _ProductNumber
    '    End Get
    '    Set(ByVal value As String)
    '        _ProductNumber = value
    '    End Set
    'End Property

    '/////////////////////////////////////////////////////////////////////////////////////////////////////////////

    Function CalulateSellEndDate(ByVal days As Integer) As DateTime
        SellEndDate = SellStartDate.AddDays(days)

        Return SellEndDate
    End Function

    Protected Overrides Function GetClassData() As String
        '   The stringbuilder class is an efficient method of conatenating strings together
        '   The 1024 is the capacity the builder is initialized with
        Dim sb As New Text.StringBuilder(1024)

        sb.AppendLine("Product ID: " + ProductID.ToString())
        sb.AppendLine("Product Name: " + Name)
        sb.AppendLine("Product Number: " + ProductNumber)
        sb.AppendLine(MyBase.GetClassData())
        '   THESE ARE INCLUDED IN THE MyBase.GetClassData()
        'sb.AppendLine("Is Active: " + IsActive.ToString())
        'sb.AppendLine("Modified Date: " + ModifiedDate.ToLongDateString())
        'sb.AppendLine("Created by: " + CreatedBy)
        Return sb.ToString()
    End Function

    '   OPTIONAL NEEDS A DEFAULT VALUE
    'Function CalulateProfit(Optional ByVal newCost As Decimal = 0) As Decimal
    '    If newCost <> 0 Then
    '        StandardCost = newCost
    '    End If

    '    Return ListPrice - StandardCost
    'End Function

    '   OVERLOADING IS MORE OBJECT ORIENTED WAY --- depends on the amount of arguments and the types which one will be 
    Overloads Function CalulateProfit() As Decimal
        '   Returns the CalulateProfit below with StandardCost as the argument
        Return CalulateProfit(StandardCost)
    End Function

    Overloads Function CalulateProfit(ByVal newCost As Decimal) As Decimal
        If newCost <> 0 Then
            StandardCost = newCost
        End If

        '   This will work anyway because StandardCost is a decimal therefore instantiated with 0 as the value
        Return ListPrice - StandardCost
    End Function

    '   SHARED FUNCTION CAN BE ACCESSED BY USING (className).(functionName)
    Shared Function SharedCalulateProfit(ByVal cost As Integer, ByVal price As Integer) As Integer
        Return price - cost
    End Function

    '/////////////////////////////////////////////////////////////////////////////////////////////////////////////
    '   SUB PROCEDURE ---   is a method that does not return a value
    '   ByVal means if you pass a variable to the 'days' parameter, 
    '   the calling variable Is Not affected by any changes To the 'days' parameter
    '   ByRef can change code in other classes  - in this example it changes the sellDate in Program.vb
    'Sub CalculateSellEndDate(ByVal days As Integer,
    '                         ByRef sellDate As DateTime)
    '    SellEndDate = SellStartDate.AddDays(days)
    '    '   Set the ByRef parameter
    '    sellDate = SellEndDate
    'End Sub

    '/////////////////////////////////////////////////////////////////////////////////////////////////////////////
    '   READ ONLY PROPERTY  --- HAS NO SET
    'Public ReadOnly Property NameAndNumber() As String
    '    Get
    '        Return Name + "-" + ProductNumber
    '    End Get
    'End Property

End Class
