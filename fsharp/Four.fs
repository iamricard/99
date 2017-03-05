module ``NinetyNine Problems - Problem 4``

open NUnit.Framework
open FsUnit

let rec length = function
  | _ :: rest -> 1 + length rest
  | [] -> 0

[<Test>]
let ``Given a list it should return its length`` () =
  length [ "a" ; "b"; "c"; "d"; "e" ] |> should equal 5
