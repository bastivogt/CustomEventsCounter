Imports System
Imports CustomEvent.Sevo


Module Program

    Dim WithEvents MyCounter As Counter = New Counter

    Sub Main(args As String())
        AddHandler MyCounter.StartEvent, AddressOf MyCounter_StartEvent
        'RemoveHandler c.StartEvent, AddressOf c_StartEvent
        MyCounter.Run()

    End Sub


    Sub MyCounter_StartEvent(sender As Object, args As CounterEventArgs)
        Dim s As Counter = CType(sender, Counter)
        Console.WriteLine("START_EVENT Count = " & s.Count)
        Console.WriteLine("START_EVENT CountValue (from CounterEventsArgs) = " & args.CountValue)
    End Sub

    'Sub MyCounter_StartEvent(sender As Object, args As CounterEventArgs) Handles MyCounter.StartEvent
    '    Dim s As Counter = CType(sender, Counter)
    '    Console.WriteLine("START_EVENT Count = " & s.Count)
    'End Sub

    Sub MyCounter_ChangeEvent(sender As Object, args As CounterEventArgs) Handles MyCounter.ChangeEvent
        Dim s As Counter = CType(sender, Counter)
        Console.WriteLine("CHANGE_EVENT Count = " & s.Count)
    End Sub

    Sub MyCounter_FinishEvent(sender As Object, args As CounterEventArgs) Handles MyCounter.FinishEvent
        Dim s As Counter = CType(sender, Counter)
        Console.WriteLine("FINISH_EVENT Count = " & s.Count)
    End Sub

End Module


