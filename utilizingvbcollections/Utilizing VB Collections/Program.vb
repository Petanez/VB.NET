Imports System

Module Program
    Sub Main(args As String())
        '///////////   DEFINE AND INITIALIZE ARRAYS     ///////////////////////////////////////////////////////////////
        'Dim products(3) As String              --Length 4 because 0 index

        'products(0) = "10 Speed Bike"
        'products(1) = "Bike Helmet"
        'products(2) = "Inner Tube"

        'BETTER TO DECLARE ALL AT ONCE
        'Dim products As String() =
        '    {
        '    "10 Speed Bike",
        '    "Bike Helmet",
        '    "Inner Tube"
        '    }


        '///////////    LIST ARRAYS     ////////////////////////////////////////////////////////////////////////////////
        '   Can hold any data type  BUT INSIDE THE ARRAY IT WILL BE AN OBJECT DATA TYPE
        'Dim products As New ArrayList From {
        '    "10 Speed Bike",
        '    "Bike Helmet",
        '    "Inner Tube",
        '    1,
        '    3.35D,
        '    New Product() With {.ProductID = 1}
        '    }

        'Dim products As New ArrayList From {
        '    New Product() With {.ProductID = 1, .Name = "10 Speed Bike", .ProductNumber = "10-SP"},
        '    New Product() With {.ProductID = 2, .Name = "Bike Helmet", .ProductNumber = "BIKE-HE"},
        '    New Product() With {.ProductID = 3, .Name = "Inner Tube", .ProductNumber = "BIKE-IN-TU"}
        '    }

        ''   YOU HAVE TO USE DIRECT CAST ANYTIME YOU HAVE AN OBJECT DATA TYPE AND YOU NEED TO CONVERT IT TO ANOTHER DATA TYPE   
        ''   (The first parameter is the object you want to cast and the second what you want to cast it to)
        ''   Each element of the ArrayList is an object data type. Thus, you need to convert it to a real 
        ''   data type before accessing any properties.
        'Console.WriteLine(DirectCast(products(0), Product).Name)
        'Console.WriteLine(DirectCast(products(1), Product).Name)
        'Console.WriteLine(DirectCast(products(2), Product).Name)



        '///////////    DICTIONARY    ////////////////////////////////////////////////////////////////////////////////
        '///////////    REMEMBER THAT THE VALUE OF A KEY VALUE PAIR IS A LIST OF ITEMS
        'Dim products = LoadProducts()
        ''   IN THIS CASE 1 IS THE KEY -- it could be anytype
        ''Console.WriteLine(products(1).Name)
        ''Console.WriteLine(products(2).Name)
        ''Console.WriteLine(products(3).Name)

        ''   Display the total number of items in the dictionary
        'Console.WriteLine(products.Count)

        ''   Remove an item by the key
        'products.Remove(1)
        'Console.WriteLine(products.Count)

        ''   Remove all items
        'products.Clear()
        'Console.WriteLine(products.Count)

        ''   See if a specific key exists in the dictionary
        'Console.WriteLine(products.ContainsKey(1))



        '///////////    LINQ    ///////////////////////////////////////////////////////////////////////////////////
        'Dim products = LoadProducts()

        '   Display the sum of all list prices
        '   These LINQ expressions iterate over the collection and pass each item in the collection to the function
        '   in the LINQ method
        'Console.WriteLine(products.Values)

        'Console.WriteLine(
        '    products.Sum(Function(p)
        '                     Return p.Value.ListPrice
        '                     '  The ToString() on a numeric data type allows you to pass 
        '                     '  in formatters to specify how to format the return value c is for currency
        '                 End Function).ToString("c"))

        ''   Display the average of all list prices
        'Console.WriteLine(
        '    products.Average(Function(p) p.Value.ListPrice).ToString("c"))

        ''   Display the minimum of all list prices
        'Console.WriteLine(
        '    products.Min(Function(p) p.Value.ListPrice).ToString("c"))

        ''   Display the maximum of all list prices
        'Console.WriteLine(
        '    products.Max(Function(p) p.Value.ListPrice).ToString("c"))



        '   USING LINQ WITH A LIST IS VERY SIMILAR -- same but no need for Value
        '   Display the average of all list prices
        'Console.WriteLine(
        '    products.Average(Function(p) p.ListPrice).ToString("c"))




        '///////////    GENERIC LIST(Of T)    ///////////////////////////////////////////////////////////////////////////////////
        'Dim products = LoadProducts()

        ''Console.WriteLine(products(0).Name)
        ''Console.WriteLine(products(1).Name)
        ''Console.WriteLine(products(2).Name)

        '''   See if a a specific property exists in one of the products in the list
        ''Console.WriteLine(
        ''    products.Exists(Function(p) p.ProductID = 57))
        ''Console.WriteLine(
        ''    products.Exists(Function(p) p.ProductID = 1))

        ''   PROPERTIES AND METHODS OF LIST OF T
        ''   Display the total number of items in the list
        'Console.WriteLine(products.Count)

        ''   Remove an item by index
        'products.RemoveAt(1)
        'Console.WriteLine(products.Count)

        ''   Remove an item by a product property
        'products.Remove(products.Find(Function(p) p.ProductID = 620))
        'Console.WriteLine(products.Count)

        ''   Remove all items
        'products.Clear()
        'Console.WriteLine(products.Count)


    End Sub

    'FUNCTION Load products DICTIONARY
    Function LoadProducts() As List(Of Product)
        Dim products As New List(Of Product) From {
            New Product() With {.ProductID = 680, .Name = "Perkele"},
            New Product() With {.ProductID = 57, .Name = "saakeli"},
            New Product() With {.ProductID = 620, .Name = "ruukeli"},
            New Product() With {.ProductID = 440, .Name = "Eihä"},
            New Product() With {.ProductID = 340, .Name = "juupasen"},
            New Product() With {.ProductID = 20, .Name = "silaakki"}
        }
        Return products
    End Function

    'FUNCTION Load products DICTIONARY
    'Function LoadProducts() As Dictionary(Of Integer, Product)
    '    Dim products As New Dictionary(Of Integer, Product)
    '    Dim prod As Product

    '    '   You may reference the parameter names of any method using the := syntax
    '    '   key:=prod.ProductID    the := references prod.ProductID to key  
    '    prod = New Product() With {.ProductID = 1, .Name = "10 Speed Bike", .ProductNumber = "10-SP", .ListPrice = 1431.5D}
    '    products.Add(key:=prod.ProductID, value:=prod)

    '    '   If you dont use the ":=" syntax, you must pass the parameters in the exact order they are listed in the method.
    '    prod = New Product() With {.ProductID = 2, .Name = "Bike Helmet", .ProductNumber = "BIKE-HE", .ListPrice = 39.99D}
    '    products.Add(prod.ProductID, prod)

    '    prod = New Product() With {.ProductID = 3, .Name = "Inner Tube", .ProductNumber = "BIKE-IN-TU", .ListPrice = 4.99D}
    '    products.Add(key:=prod.ProductID, value:=prod)

    '    Return products
    'End Function
End Module
