// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
    let mutable person = if argv.Length > 0 then 
                            argv.[0]
                         else 
                            "some person"
    printfn "hello %s welcome" person
    0 // return an integer exit code
