Imports System.ComponentModel

Namespace ViewModel

    Public Class ViewModelAcceso
        Implements INotifyPropertyChanged, ICommand

#Region "Variables"
        Private _nombreUsuario As String
        Private _viewModelMain As ViewModelMain
        
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

            Select Case parameter.ToString

                Case "Aceptar"
                    _viewModelMain.VViewAcceso = Visibility.Collapsed
                    _viewModelMain.StartPage = Visibility.Visible

                Case "Agregar"
                    _viewModelMain.StartPage = Visibility.Collapsed
                    _viewModelMain.AddPage = Visibility.Visible


                Case "Cancelar"
                    _viewModelMain.AddPage = Visibility.Collapsed
                    _viewModelMain.StartPage = Visibility.Visible


                    ' MsgBox(NombreUsuario)
                    'MsgBox(parameter.ToString)

            End Select

            
        End Sub
        Public Sub New(ByVal _viewModelMain As ViewModelMain)
            Me._viewModelMain = _viewModelMain
        End Sub
    End Class
End Namespace
