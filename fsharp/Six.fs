module ``NinetyNine Problems - Problem 6``

open NUnit.Framework
open FsUnit

// for `rev`
open ``NinetyNine Problems - Problem 5``

let is_palindrome xs =
  xs = (rev xs)

[<Test>]
let ``It should return true if it is a palindrome`` () =
  is_palindrome [ "x" ; "a" ; "m" ; "a" ; "x" ] |> should be True

[<Test>]
let ``It should return false if it is not a palindrome`` () =
  is_palindrome [ "a" ; "b" ] |> should be False
