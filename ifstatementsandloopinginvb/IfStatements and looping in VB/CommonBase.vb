Imports System.ComponentModel

Public Class CommonBase
    '   NEED TO IMPLEMENT INOTIFYPROPERTYCHANGED TO USE THE PROPERTYCHANGEDEVENTHANDLER
    Implements INotifyPropertyChanged
    '   Part of the Common.Library
    '   Which is .Net FrameWork Class Library
    Sub New()
        IsActive = True
        ModifiedDate = DateTime.Now
        '   The Environment class in .NET has properties to help you query information about the computer
        CreatedBy = Environment.UserName
    End Sub

    Public Property IsActive As Boolean

    Public Property ModifiedDate As DateTime
    Public Property CreatedBy As String
    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

    Sub RaisePropertyChanged(ByVal propertyName As String)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
    End Sub

    '   Overrides ToString() from all classes in the inheritance chain
    Public Overrides Function ToString() As String
        Return GetClassData()
    End Function

    '   Marking a method as Overridable informs inheriting classes they must use
    '   the keyword Overrides in order to implement a method with the same name
    '   a Protected method is only available from inherited classes
    Protected Overridable Function GetClassData() As String
        Dim sb As New Text.StringBuilder(1024)

        sb.AppendLine("Is Active: " + IsActive.ToString())
        sb.AppendLine("Modified Date: " + ModifiedDate.ToLongDateString())
        sb.AppendLine("Created by: " + CreatedBy)

        Return sb.ToString()
    End Function
End Class
