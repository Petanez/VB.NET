Imports System.Collections.ObjectModel
Imports System.Configuration
Imports AdventureWorks.DataLayer
Imports AdventureWorks.EntityLayer
Imports Common.Library

Public Class CustomerViewModel
    Inherits ViewModelBase

    Sub New()
        LoadCustomers()
    End Sub

    '   Keep your property names consistent when they do the same thing from class to class
    Public Property Entity As Customer
    Public Property Customers As ObservableCollection(Of Customer)

    Function LoadCustomers(ByVal Optional startingPath As String = "") As ObservableCollection(Of Customer)
        ' Create a new instance of customer manager
        Dim mgr = New CustomerManager

        Customers = mgr.LoadCustomers(startingPath)

        Return Customers
    End Function


    Function LoadCustomer(ByVal customerId As Integer, ByVal Optional startingFilePath As String = "") As Customer
        ' Crate a new instance of customer manager
        Dim mgr = New CustomerManager

        Entity = mgr.LoadCustomer(customerId, startingFilePath)

        ' Inform UI that the Entity property changed
        RaisePropertyChanged("Entity")

        Return Entity
    End Function


End Class
