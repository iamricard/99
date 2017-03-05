module ``NinetyNine Problems - Problem 8``

open NUnit.Framework
open FsUnit

type 'a node =
  | One of 'a
  | Many of 'a node list

let compress =
  let rec aux cs xs =
    match cs, xs with
    | [], x :: rest -> aux ([x]) rest
    | _, [] -> cs
    | c :: _, x :: rest ->
      if c = x then aux cs rest
      else aux (x :: cs) rest
  in
    aux [] >> List.rev

[<Test>]
let ``It should remove adjacent duplicate values`` () =
  compress ["a"; "a"; "a"; "a"; "b"; "c"; "c"; "a"; "a"; "d"; "e"; "e"; "e"; "e"]
  |> should equal ["a"; "b"; "c"; "a"; "d"; "e"]
