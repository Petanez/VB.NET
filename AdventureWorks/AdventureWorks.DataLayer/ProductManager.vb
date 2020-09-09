Imports System.Collections.ObjectModel
Imports AdventureWorks.EntityLayer
Imports System.Configuration
Imports Common.Library

' A MANAGER CLASS IS RESPONSIBLE FOR MAKING CALLS TO THE DATABASE, OR OTHER DATA REPOSITORY
'   The ConfigurationManager class reads key/value paris from your App.config or Web.config file
Public Class ProductManager
    Inherits DataManagerBase

    Function LoadProducts() As ObservableCollection(Of Product)
        Return LoadProducts(Nothing)
    End Function

    Function LoadProducts(ByVal startingFilePath As String) As ObservableCollection(Of Product)
        '   Create a new instance of products
        Dim ret = New ObservableCollection(Of Product)()

        Try
            'Attempt to read from XML file ProductsFile is the key to access the value from config
            Dim doc = MyBase.LoadXElement(
                ConfigurationManager.AppSettings("ProductsFile"),
                startingFilePath)

            Dim products = From prod In doc.<Product>
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

            ret = New ObservableCollection(Of Product)(products.ToList())
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.ToString())
        End Try
        Return ret
    End Function

    Function LoadProduct(ByVal productId As Integer) As Product
        Return LoadProduct(productId, Nothing)
    End Function

    Function LoadProduct(ByVal productId As Integer, ByVal startingFilePath As String) As Product
        '   Create a new instance of a product
        Dim ret = New Product()

        Try
            Dim list = LoadProducts(startingFilePath)
            If list IsNot Nothing Then
                If list.Count > 0 Then
                    '   First or default means if it cant find the value it'll return the default value
                    '   null in this case
                    ret = list.FirstOrDefault(Function(p) p.ProductID = productId)
                End If
            End If
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.ToString())
        End Try
        Return ret
    End Function
End Class
