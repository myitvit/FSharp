let SayHello() =
    printfn "Hello"


[<EntryPoint>]
let main args =
    SayHello()
    System.Console.ReadKey() |> ignore
    // Return 0. This indicates success.
    0