open OUnit2

let rec is_palindrome xs =
  Five.rev xs = xs

let test_case =
  "is_palindrome" >::
    (fun _  ->
       assert_bool "failed" (is_palindrome ["x"; "a"; "m"; "a"; "x"]);
       assert_bool "failed" (not (is_palindrome ["a"; "b"])))
