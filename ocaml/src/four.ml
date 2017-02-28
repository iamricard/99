open OUnit2

let rec length = function | [] -> 0 | _::rest -> 1 + (length rest)

let test_case =
  "length" >::
    (fun _  ->
       assert_equal 3 (length ["a"; "b"; "c"]); assert_equal 0 (length []))
