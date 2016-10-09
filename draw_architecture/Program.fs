open FsUnit
open NUnit.Framework

module csproj_parser = 
    let parse = 
        ""

    type Project = {Name:string}

let draw_architecture = 
    csproj_parser.parse

[<Test>]
let ``Something should fail``() =
    false |> should equal false

let ``Should be able to find csproj files in subdirectories``() =
    draw_architecture 

open System.IO

[<EntryPoint>]
let main argv = 
    printfn "Parsing (%A)" argv

//    Directory.EnumerateFiles("/", "*.csproj")
//    |> List.map (fun file -> )

    draw_architecture
    |> System.Console.Write

    System.Console.ReadKey() |> ignore
    0