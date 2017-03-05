module ``NinetyNine Problems - Problem 2``

open NUnit.Framework
open FsUnit

let rec last_two = function
  | [] | _ :: [] -> None
  | (x :: y :: []) -> Some (x, y)
  | (_ :: rest) -> last_two rest

[<Test>]
let ``Given an empty list, it should return None`` () =
  last_two [] |> should equal None

[<Test>]
let ``Given a list with two or more elements, it should return the last two element`` () =
  last_two [3; 2; 1] |> should equal (Some (2, 1))

[<Test>]
let ``Given a list with one element, it should return None`` () =
  last_two ["only one"] |> should equal None
