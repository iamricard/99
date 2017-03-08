module ``NinetyNine Problems - Problem 09``

open NUnit.Framework
open FsUnit

let pack =
  let rec aux packs xs =
    match packs, xs with
    | _, [] -> packs
    | [], x :: x_rest -> aux ([[x]]) x_rest 
    | p :: p_rest, x :: x_rest ->
      if List.contains x p then aux ((x :: p) :: p_rest) x_rest
      else aux ([x] :: p :: p_rest) x_rest
  in
    aux [] >> List.rev

[<Test>]
let ``It should make groups of adjacent equal values`` () =
  pack [1; 1; 1; 1; 2; 3; 3; 1; 1; 4; 4; 5; 5; 5; 5]
  |> should equal [
      [1; 1; 1; 1];
      [2];
      [3; 3];
      [1; 1];
      [4; 4];
      [5; 5; 5; 5]
    ]
