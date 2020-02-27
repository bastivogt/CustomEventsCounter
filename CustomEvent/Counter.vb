Namespace Sevo

    Public Class CounterEventArgs
        Inherits EventArgs

        Public CountValue As Integer

        Public Sub New(countValue As Integer)
            MyBase.New()
            Me.CountValue = countValue
        End Sub
    End Class

    Public Class Counter

        Private _count As Integer

        Public Property StartValue As Integer
        Public Property FinishValue As Integer
        Public Property StepValue As Integer
        Public ReadOnly Property Count As Integer
            Get
                Return Me._count
            End Get
        End Property

        Public Event StartEvent(sender As Object, args As CounterEventArgs)
        Public Event ChangeEvent(sender As Object, args As CounterEventArgs)
        Public Event FinishEvent(sender As Object, args As CounterEventArgs)

        Public Sub New(Optional startValue As Integer = 0, Optional finishValue As Integer = 10, Optional stepValue As Integer = 1)
            Me.StartValue = startValue
            Me.FinishValue = finishValue
            Me.StepValue = stepValue
        End Sub

        Public Sub Run()

            RaiseEvent StartEvent(Me, New CounterEventArgs(Me._count))
            For Me._count = 0 To Me.FinishValue Step StepValue
                RaiseEvent ChangeEvent(Me, New CounterEventArgs(Me._count))
            Next
            RaiseEvent FinishEvent(Me, New CounterEventArgs(Me._count))
        End Sub


    End Class
End Namespace

