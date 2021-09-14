// Learn more about F# at http://fsharp.org

open System

let customFunc argv = 
    // other forms of for
    // for i in 0..argv.Length do
    for person in argv do
        printfn "Hello %s" person
    printfn "nice to meet you"
    0

[<EntryPoint>]
let main argv =
    let mutable person = if argv.Length > 0 then 
                            argv.[0]
                         else 
                            "some person"
    printfn "hello %s welcome" person
    // Array.iter functioname arrayname without using for inside the called function
    customFunc argv
    0 // return an integer exit code

