Imports AdventureWorks.ViewModelLayer
Public Class ProductDetailControl
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        '   Construct the instance of viewModel by doing a direct cast, The first object is the value you want to cast
        '   and the second what you want to cast it into
        _viewModel = DirectCast(Me.Resources("viewModel"), ProductViewModel)
    End Sub
    '   viewModel is whats defined in ProductDetailControl.xaml
    Private _viewModel As ProductViewModel
    Private Sub UserControl_Loaded(sender As Object, e As RoutedEventArgs)
        _viewModel.LoadProduct(706)
    End Sub
End Class
