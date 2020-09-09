Imports System

Module Program
    'Dim prod As New Product    ---INITS PRODUCT WITH DEFAULT VALUES
    Sub Main()
        '   The With keyword allows you to assign multiple properties
        '   within a class
        Dim prod As New Product With {
            .ProductID = 700,
            .Name = "10 Speed Bike"
        }
        '   The .ToString() method calls the top-most overriden GetClassData() method in the inheritance chain
        Console.WriteLine(prod.ToString())

        Dim cust As New Customer With {
            .CustomerID = 1,
            .CompanyName = "Beach Computer Computing",
            .FirstName = "Bruce",
            .LastName = "Jones"
        }
        Console.WriteLine(cust.ToString())
        'Console.WriteLine(cust.GetClassData()) --- WONT WORK BECAUSE PROGRAM IS NOT INTHE HERITANCE CHAIN

        'Dim sellDate As DateTime
        'prod.SellStartDate = #5/1/2019#
        'sellDate = prod.CalulateSellEndDate(30)
        'Console.WriteLine(sellDate)

        '   USING A SHARED FUNCTION
        'Console.WriteLine(Product.SharedCalulateProfit(10, 20))


    End Sub

End Module
