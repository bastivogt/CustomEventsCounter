Imports System
Imports CustomEvent.Sevo


Module Program

    Dim WithEvents c As Counter = New Counter

    Sub Main(args As String())
        AddHandler c.StartEvent, AddressOf c_StartEvent
        'RemoveHandler c.StartEvent, AddressOf c_StartEvent
        c.Run()

    End Sub


    Sub c_StartEvent(sender As Object, args As CounterEventArgs)
        Dim s As Counter = CType(sender, Counter)
        Console.WriteLine("START_EVENT Count = " & s.Count)
        Console.WriteLine("START_EVENT CountValue (from CounterEventsArgs) = " & args.CountValue)
    End Sub

    'Sub c_StartEvent(sender As Object, args As CounterEventArgs) Handles c.StartEvent
    '    Dim s As Counter = CType(sender, Counter)
    '    Console.WriteLine("START_EVENT Count = " & s.Count)
    'End Sub

    Sub c_ChangeEvent(sender As Object, args As CounterEventArgs) Handles c.ChangeEvent
        Dim s As Counter = CType(sender, Counter)
        Console.WriteLine("CHANGE_EVENT Count = " & s.Count)
    End Sub

    Sub c_FinishEvent(sender As Object, args As CounterEventArgs) Handles c.FinishEvent
        Dim s As Counter = CType(sender, Counter)
        Console.WriteLine("FINISH_EVENT Count = " & s.Count)
    End Sub

End Module


