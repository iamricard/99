module ``NinetyNine Problems - Problem 12``

open NUnit.Framework
open FsUnit

type 'a rle =
  | One of 'a
  | Many of int * 'a

let decode =
  let rec aux decoded xs =
    match xs with
    | [] -> decoded
    | (Many (2, x)) :: rest ->
      aux (x :: decoded) ((One x) :: rest)
    | (Many (count, x)) :: rest ->
      aux (x :: decoded) ((Many (count - 1, x)) :: rest)
    | (One x) :: rest ->
      aux (x :: decoded) rest
  in
    aux [] >> List.rev

[<Test>]
let ``It should turn nested lists into a one-level list`` () =
  decode [Many (4, "a"); One "b"; Many (2, "c"); Many (2, "a"); One "d"; Many (4, "e")]
  |> should equal ["a"; "a"; "a"; "a"; "b"; "c"; "c"; "a"; "a"; "d"; "e"; "e"; "e"; "e"]

