module ``NinetyNine Problems - Problem 7``

open NUnit.Framework
open FsUnit

type 'a node =
  | One of 'a
  | Many of 'a node list

let rec flatten = function
  | [] -> []
  | (One x) :: []  -> [x]
  | (One x) :: rest -> x :: flatten rest
  | (Many xs) :: rest -> flatten xs @ flatten rest

[<Test>]
let ``It should turn nested lists into a one-level list`` () =
  flatten [ One "a" ; Many [ One "b" ; Many [ One "c" ; One "d" ] ; One "e" ] ]
  |> should equal ["a" ; "b" ; "c" ; "d" ; "e"]
