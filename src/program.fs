open HTS
open System
open FSharp.Text.Lexing
open lexer
open parser

let evaluate (input:string) =
    let lexbuf = LexBuffer<char>.FromString input
    let output = parser.parse lexer.tokenize lexbuf
    string output

[<EntryPoint>]
let main argv =
    printfn "%A" <| evaluate "(1)"
    0