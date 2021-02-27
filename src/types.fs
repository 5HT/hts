namespace HTS

open System
open System.Numerics

[<AutoOpen>]
module Types =

    type Term =
        | Byte   of byte
        | Int    of Int32
        | Float  of float
        | Atom   of string
        | Tuple  of Term list
        | String of string
        | List   of Term list * Term
        | Binary of byte array
        | Bigint of BigInteger
        | Dict   of Map<Term, Term>
        | Error  of string
        | Nil

