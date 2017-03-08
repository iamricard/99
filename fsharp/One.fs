module ``NinetyNine Problems - Problem 01``

open NUnit.Framework
open FsUnit

let rec last = function
  | [] -> None
  | (x :: []) -> Some x
  | (_ :: rest) -> last rest

[<Test>]
let ``Given an empty list, it should return None`` () =
  last [] |> should equal None

[<Test>]
let ``Give a list with multiple elements, it should return the last element`` () =
  last [3; 2; 1] |> should equal (Some 1)

[<Test>]
let ``Given a list with one element, it should return the last element`` () =
  last ["only one"] |> should equal (Some "only one")
