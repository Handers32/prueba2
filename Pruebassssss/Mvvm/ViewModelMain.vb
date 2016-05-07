Imports System.ComponentModel

Namespace ViewModel

    Public Class ViewModelMain
        Implements INotifyPropertyChanged, ICommand

#Region "Varibles"
        Private _viewModelAcceso As ViewModelAcceso
        Private _viewModelAddUser As ViewModelAddUser

        Private _vViewAcceso As Visibility = Visibility.Visible
        Private _sTartPage As Visibility = Visibility.Hidden
        Private _addPage As Visibility = Visibility.Hidden

#End Region

#Region "Propiedades"
        Public ReadOnly Property VCViewModelAcceso As ViewModelAcceso
            Get
                Return _viewModelAcceso
            End Get
        End Property

        Public ReadOnly Property AddUsers As ViewModelAddUser
            Get
                Return _viewModelAddUser
            End Get
        End Property

        Public Property VViewAcceso As Visibility
            Get
                Return _vViewAcceso
            End Get
            Set(value As Visibility)
                _vViewAcceso = value
                NotifyChange("VViewAcceso")
            End Set
        End Property

        Public Property StartPage As Visibility
            Get
                Return _sTartPage
            End Get
            Set(value As Visibility)
                _sTartPage = value
                NotifyChange("StartPage")
            End Set
        End Property

        Public Property AddPage As Visibility
            Get
                Return _addPage
            End Get
            Set(value As Visibility)
                _addPage = value
                NotifyChange("AddPage")
            End Set
        End Property

#End Region

        Public Sub NotifyChange(ByVal _property As String)
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(_property))
        End Sub

        Public Event PropertyChanged(sender As Object, e As PropertyChangedEventArgs) Implements INotifyPropertyChanged.PropertyChanged

        Public Function CanExecute(parameter As Object) As Boolean Implements ICommand.CanExecute
            Return True
        End Function

        Public Event CanExecuteChanged(sender As Object, e As EventArgs) Implements ICommand.CanExecuteChanged

        Public Sub Execute(parameter As Object) Implements ICommand.Execute


        End Sub

        Public Sub New()
            _viewModelAcceso = New ViewModelAcceso(Me)
            _viewModelAddUser = New ViewModelAddUser(Me)
        End Sub

    End Class
End Namespace