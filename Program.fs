// Learn more about F# at http://fsharp.org

open System

let customFunc argv = 
    // other forms of for
    // for i in 0..argv.Length do
    for person in argv do
        printfn "Hello %s" person
    printfn "nice to meet you"

let isValid person = 
    String.IsNullOrWhiteSpace person |> not

let filter persons = 
    persons |> Array.filter isValid

let print person = printfn "hello babai %s" person 

let printValidPersons persons = 
    persons |> filter |> Array.iter print

[<EntryPoint>]
let main argv =
    let mutable person = if argv.Length > 0 then 
                            argv.[0]
                         else 
                            "some person"
    printfn "hello %s welcome" person
    printValidPersons argv
    // Array.iter functioname arrayname without using for inside the called function
    customFunc argv
    0 // return an integer exit code

