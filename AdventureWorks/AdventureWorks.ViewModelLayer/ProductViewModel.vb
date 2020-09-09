Imports System.Collections.ObjectModel
Imports AdventureWorks.EntityLayer
Imports Common.Library
Imports AdventureWorks.DataLayer

Public Class ProductViewModel
    Inherits ViewModelBase

    Sub New()
        LoadProducts()
    End Sub

    '   Entity in object-oriented programming is close in meaning to object
    '   The Entity Property was created to hold an instance of a single Product
    Public Property Entity As Product
    '   USE OBSERVABLE COLLECTION IF THE DATA CAN CHANGE. THIS COLLECTION RAISES AN EVENT TO INFORM ANY BOUND CONTROLS
    '   TO RE-READ THE DATA WHEN IT CHANGES
    Public Property Products As ObservableCollection(Of Product)

    Function LoadProducts() As ObservableCollection(Of Product)
        Return LoadProducts(Nothing)
    End Function
    Function LoadProducts(ByVal startingFilePath As String) As ObservableCollection(Of Product)
        Dim mgr = New ProductManager

        Products = mgr.LoadProducts(startingFilePath)
        Return Products
    End Function
    Function LoadProduct(ByVal productId As Integer) As Product
        Return LoadProduct(productId, Nothing)
    End Function

    Function LoadProduct(ByVal productId As Integer,
                         ByVal startingFilePath As String) As Product
        Dim mgr = New ProductManager

        Entity = mgr.LoadProduct(productId, startingFilePath)

        RaisePropertyChanged("Entity")

        Return Entity
    End Function
End Class
