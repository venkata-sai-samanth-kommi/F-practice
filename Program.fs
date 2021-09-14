// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
    let mutable person = "some person"
    if argv.Length > 0 then 
        person <- argv.[0]
    printfn "hello %s welcome" person
    0 // return an integer exit code
