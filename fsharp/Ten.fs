module ``NinetyNine Problems - Problem 10``

open NUnit.Framework
open FsUnit

let encode =
  let rec aux encoded xs =
    match encoded, xs with
    | _, [] -> encoded
    | [], x :: x_rest -> aux ([(1, x)]) x_rest 
    | (count, x) as group :: p_rest, x' :: xs_rest ->
      if x = x' then aux ((count + 1, x) :: p_rest) xs_rest
      else aux ((1, x') :: group :: p_rest) xs_rest
  in
    aux [] >> List.rev

[<Test>]
let ``It should make groups of adjacent equal values`` () =
  encode [ "a"; "a"; "a"; "a"; "b"; "c"; "c"; "a"; "a"; "d"; "e"; "e"; "e"; "e" ]
  |> should equal [(4, "a"); (1, "b"); (2, "c"); (2, "a"); (1, "d"); (4, "e")]

