module ``NinetyNine Problems - Problem 11``

open NUnit.Framework
open FsUnit

type 'a rle =
  | One of 'a
  | Many of int * 'a

let encode =
  let rec aux encoded xs =
    match encoded, xs with
    | _, [] -> encoded
    | [], x :: rest -> aux [(One x)] rest
    | (One current_x) as current :: encoded_rest, x :: rest ->
      if current_x = x
        then aux ((Many (2, current_x)) :: encoded_rest) rest
        else aux ((One x) :: current :: encoded_rest) rest
    | (Many (count, current_x)) as current :: encoded_rest, x :: rest ->
      if current_x = x
        then aux ((Many (count + 1, current_x)) :: encoded_rest) rest
        else aux ((One x) :: current :: encoded_rest) rest
  in
    aux [] >> List.rev

[<Test>]
let ``It should turn nested lists into a one-level list`` () =
  encode ["a"; "a"; "a"; "a"; "b"; "c"; "c"; "a"; "a"; "d"; "e"; "e"; "e"; "e"]
  |> should equal [ Many (4, "a")
                  ; One "b"
                  ; Many (2, "c")
                  ; Many (2, "a")
                  ; One "d"
                  ; Many (4, "e")
                  ]
