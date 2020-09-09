'   ITS A GOOD PRACTISE TO CREATE FOLDERS INTO WHICH TO PLACE RELATED USER CONTROLS

'   When you work with WPF, you will be building alot of view model classes. Each of them should inherit from a base class.
'                      Windows Presentation Foundation
'   Common.Library is to hold classes that can be used across all kinds of applications
'
'   the Product class and the Customer class are called entity classes, or data transfer objects they are typically classes
'   that have nothing more but properties in them maybe a couple methods, THEY ARE TYPICALLY USED TO REPRESENT DATA IN A TABLE
'   so if you have a table with 10 COLUMNS you will have a class with 10 PROPERTIES
'   Below Adventure Works .NET FRAMEWORK CLASS LIBRARIES
'   AdventureWorks.ViewModelLayer (holds viewModel classes), AdventureWorks.EntityLayer (holds entity classes), 
'   Common.Library (holds common reusable classes)
'   ProductControl folder holds -- ProductControls -> Add UserControl -> UserControl (WPF)
'   To Bring in viewModels Add Refererence to AdventureWorks -> Reference all to get all in
'   "Me" is a Visual Basic keyword that refers to the current object
'   If a XAML control has a Name set, it appears in the intelliSense in the editor

'   contentArea is in MainWindows.xaml
Class MainWindow
    Private Sub Exit_Click(sender As Object, e As RoutedEventArgs)
        Me.Close()
    End Sub

    Private Sub ProductDetail_Click(sender As Object, e As RoutedEventArgs)
        '   uses the xaml grid named contentArea and inserts New ProductDetailControl() which is 
        '   "The page" with the product information, by doing this it injects the data into the xaml
        '   when the Product Detail button is clicked
        contentArea.Children.Clear()
        contentArea.Children.Add(New ProductDetailControl())
    End Sub
    Private Sub ProductList_Click(sender As Object, e As RoutedEventArgs)
        contentArea.Children.Clear()
        contentArea.Children.Add(New ProductListControl())
    End Sub

    Private Sub CustomerDetail_Click(sender As Object, e As RoutedEventArgs)
        contentArea.Children.Clear()
        contentArea.Children.Add(New CustomerDetailControl())
    End Sub

End Class
