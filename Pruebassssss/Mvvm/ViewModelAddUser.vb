Imports System.ComponentModel

Namespace ViewModel

    Public Class ViewModelAddUser
        Implements INotifyPropertyChanged, ICommand

#Region "Variables"
        Private _viewModelMain As ViewModelMain

        Private _nombreUsuario As String
        Private _pass As String
        Private _role As String
#End Region

#Region "Propiedades"


        Public Property NombreUsuario As String
            Get
                Return _nombreUsuario
            End Get
            Set(value As String)
                _nombreUsuario = value
                NotifyChanged("NombreUsuario")
            End Set
        End Property

        Public Property Pass As String
            Get
                Return _pass
            End Get
            Set(value As String)
                _pass = value
                NotifyChanged("Pass")
            End Set
        End Property

        Public Property Rol As String
            Get
                Return _role
            End Get
            Set(value As String)
                _role = value
                NotifyChanged("Rol")
            End Set
        End Property

#End Region

#Region "Sub"
        Public Sub NotifyChanged(ByVal _Property As String)
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(_Property))
        End Sub
#End Region


        Public Event PropertyChanged(sender As Object, e As PropertyChangedEventArgs) Implements INotifyPropertyChanged.PropertyChanged

        Public Function CanExecute(parameter As Object) As Boolean Implements ICommand.CanExecute
            Return True
        End Function

        Public Event CanExecuteChanged(sender As Object, e As EventArgs) Implements ICommand.CanExecuteChanged

        Public Sub Execute(parameter As Object) Implements ICommand.Execute

            Dim baseT As New ColegioEntities
            Dim user As New Usuario

            user.nombre = NombreUsuario
            user.contraseña = Pass
            user.idRol = Rol

            baseT.Usuarios.Add(user)
            baseT.SaveChanges()

            MsgBox("Se ha ingresado con Exito")

        End Sub
        Public Sub New(ByVal _viewModelMain As ViewModelMain)
            Me._viewModelMain = _viewModelMain

        End Sub
    End Class

End Namespace

