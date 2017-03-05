module ``NinetyNine Problems - Problem 5``

open NUnit.Framework
open FsUnit

let rev =
  let rec aux reversed = function
    | x :: rest -> aux (x :: reversed) rest
    | [] -> reversed
  in
    aux []

[<Test>]
let ``Given a list it should return its reversed version`` () =
  rev [ "a" ; "b"; "c"; "d"; "e" ] |> should equal [ "e" ; "d" ; "c" ; "b" ; "a" ]
