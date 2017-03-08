module ``NinetyNine Problems - Problem 03``

open NUnit.Framework
open FsUnit

let rec at n xs =
  match n, xs with
  | _, [] -> None
  | 1, x :: _ -> Some x
  | _, _ :: rest -> at (n - 1) rest

[<Test>]
let ``Given a list and an index smaller or equal to its length, it should return the element at said index`` () =
  at 3 [ "a" ; "b"; "c"; "d"; "e" ] |> should equal (Some "c")

[<Test>]
let ``Given an index greater than the length of a list, it should return None`` () =
  at 3 [ "a" ] |> should equal None
