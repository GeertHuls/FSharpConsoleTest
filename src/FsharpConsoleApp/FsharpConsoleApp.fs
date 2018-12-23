module FsharpConsoleApp

open ClassLibTest

[<EntryPoint>]
let main argv =

    let testRecord = {
        prop1 = "abc";
        prop2 = "def";
    }

    printfn "%A %s %s" argv testRecord.prop1 testRecord.prop2
    0 // return an integer exit code
