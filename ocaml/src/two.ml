open OUnit2

let rec last_two =
  function
  | []|_::[] -> None
  | x::y::[] -> Some (x, y)
  | _::rest -> last_two rest

let test_case =
  "last_two" >::
    (fun _  ->
       assert_equal None (last_two ["d"]);
       assert_equal (Some ("c", "d")) (last_two ["a"; "b"; "c"; "d"]);
       assert_equal None (last_two []))
