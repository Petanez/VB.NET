Imports System
Imports System.IO

Module Program
#Const conLANGUAGE = "ENGLISH"
    '   USE REGION TO PUT LARGE CHUNKS OF CODE IN TO BLOCKS
#Region "Main Method - Looping"
    Sub Main(args As String())
        '   COMPILER CONSTANTS 
        '   DEBUG IS A SPECIAL CONSTANT DEFINED BY VISUAL STUDIO TO RUN THE CODE INSIDE DEBUG IF RUN IN DEBUG MODE
#If conLANGUAGE = "ENGLISH" Then
        Console.WriteLine("Good Morning Mr. Jones")
#Else
        Console.WriteLine("Guten Morgen Herr Jones")
#End If

#If DEBUG Then
        Console.WriteLine("In DEBUG mode")
#Else
        Console.WriteLine("In RELEASE mode")
#End If
        Dim prod As New Product

        '   WITH/END WITH   //////////////////////////////////////////////////
        '   THIS CAN BE SHORTHANDED WITH/ENDWITH
        'prod.ProductID = 1
        'prod.Name = "A new product"
        'prod.ProductNumber = "A101"

        '   WITH/END WITH
        '   the with statement is followed by a variable that is 0of a data type of any class that has properties
        With prod
            .ProductID = 1
            .Name = "A new product"
            .ProductNumber = "A101"
            .StandardCost = 50
            .ListPrice = 100
        End With
        Console.WriteLine(prod.ToString())




        Dim products = LoadProduct()
        'Dim index As Integer = 0
        Dim sum As Decimal = 0
        '   SET TO MAX VALUE AND WHEN IN LOOP SOMETHING IS SMALLER IT GETS REPLACED
        Dim min As Decimal = Decimal.MaxValue
        Dim max As Decimal = Decimal.MinValue


        '   Switch in VB.NET    //////////////////////////////////////////////////
        'For index As Integer = 0 To (products.Count - 1)
        '    Select Case products(index).Size
        '        Case "58"
        '            Console.WriteLine("Size 58: " & products(index).Name)
        '        Case "L"
        '            Console.WriteLine("Size L: " & products(index).Name)
        '        Case "M"
        '            Console.WriteLine("Size M: " & products(index).Name)
        '        Case Else
        '            '   CASE ELSE IS DEFAULT CASE
        '            Console.WriteLine(products(index).Name _
        '                            & " has size " & products(index).Size)
        '    End Select
        'Next





        '   IF STATEMENT IN THE LOOPS   //////////////////////////////////////////////////
        'For index As Integer = 0 To (products.Count - 1)
        '    If (products(index).Color = "Red") Then
        '        Console.WriteLine("Red color product: " _
        '                         & products(index).ToString)
        '    ElseIf products(index).Color = "Black" Then
        '        Console.WriteLine("Black color product: " _
        '                         & products(index).ToString)

        '    Else
        '        Console.WriteLine("Other color product: " _
        '                         & products(index).ToString)
        '    End If
        'Next




        '   WHILE LOOP IN VB.NET      //////////////////////////////////////////////////////////
        'Do While index < (products.Count - 1)
        '    Console.WriteLine(products(index).ToString())
        '    sum += products(index).ListPrice

        '    index += 1
        'Loop




        '   DO WHILE SYNTAX IN VB.NET       //////////////////////////////////////////////////////////
        'Do
        '    Console.WriteLine(products(index).ToString())
        '    sum += products(index).ListPrice

        '    '   YOU CAN HAVE AN EXIT DO WITHIN A IF STATEMENT TO EXIT THE LOOP IN A SPECIFIC CONDITION
        '    '   Exit Do

        '    index += 1
        'Loop While index < (products.Count)

        '   DO UNTIL       ///////////////////////////////// 
        'Do Until index > (products.Count - 1)
        '    Console.WriteLine(products(index).ToString())

        '    '   IIf is like ternary operator so if the current listprice is smaller than min the current listPrice
        '    '   gets assigned to min
        '    min = Convert.ToDecimal(
        '        IIf(products(index).ListPrice < min,
        '            products(index).ListPrice,
        '            min))
        '    index += 1
        'Loop




        '   DO UNTIL       //////////////////////////////////////////////////////////
        'Do
        '    Console.WriteLine(products(index).ToString())

        '    '   IIf is like ternary operator so if the current listprice is smaller than min the current listPrice
        '    '   gets assigned to min
        '    max = Convert.ToDecimal(
        '        IIf(products(index).ListPrice > max,
        '            products(index).ListPrice,
        '            max))
        '    index += 1
        'Loop Until index > (products.Count - 1)
        'Console.WriteLine("Max value is: " & max.ToString("N2"))




        '   FOR NEXT    -AutoIncrements index on reaching Next  //////////////////////////////////////////////////////////
        'For index As Integer = 0 To (products.Count - 1)
        '    Console.WriteLine(products(index).ToString())
        'Next
        '   IN OPPOSITE ORDER - You can have any vlaue in step
        'For index As Integer = (products.Count - 1) To 0 Step -1
        '    Console.WriteLine(products(index).ToString())
        'Next



        '   FOR EACH    //////////////////////////////////////////////////////////
        '   Dont remove items from the collectiong using For Each statement, will cause errors
        'For Each prod As Product In products
        '    Console.WriteLine(prod.ToString())
        '    '   YOU CAN EXIT THE LOOP EARLY USING THE EXIT FOR inside a if statement
        '    '   Exit for
        'Next

        '   .ToString("N2") returns 2 numbers after the decimal
        'Console.WriteLine("Sum: " & sum.ToString("N2"))
    End Sub
#End Region




    Private Function LoadXElement(ByVal xmlFilePath) As XElement
        '   Declare doc as XElement -> Get the filePath for the XML element and load it 
        Dim doc As XElement
        Dim filePath As String = IIf(String.IsNullOrEmpty(xmlFilePath),
                                     Directory.GetCurrentDirectory().Replace("bin\Debug\netcoreapp3.1", ""),
                                     xmlFilePath)
        filePath &= "Products.xml"

        doc = XElement.Load(filePath)
        Return doc
    End Function


    Private Function LoadProduct() As List(Of Product)
        Dim products As List(Of Product)
        Dim doc = LoadXElement(Nothing)

        '   With query syntax iterate through all items with the tag <Product> in the xml file and convert them to proper datatype
        '   Returns a List of Product
        Dim productItems = From prod In doc.<Product>
                           Select New Product With {
                       .ProductID = Convert.ToInt32(prod.Element("ProductID").Value),
                       .Name = prod.Element("Name").Value,
                       .ProductNumber = prod.Element("ProductNumber").Value,
                       .Color = prod.Element("Color").Value,
                       .Size = prod.Element("Size").Value,
                       .Weight = Convert.ToDecimal(prod.Element("Weight").Value),
                       .StandardCost = Convert.ToDecimal(prod.Element("StandardCost").Value),
                       .ListPrice = Convert.ToDecimal(prod.Element("ListPrice").Value),
                       .SellStartDate = Convert.ToDateTime(prod.Element("SellStartDate").Value),
                       .SellEndDate = Convert.ToDateTime(prod.Element("SellEndDate").Value)
                     }

        products = New List(Of Product)(productItems.ToList())

        Return products
    End Function
End Module
