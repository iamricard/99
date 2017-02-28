open OUnit2

let rec last = function | [] -> None | x::[] -> Some x | _::rest -> last rest

let test_case =
  "last" >::
    (fun _  ->
       assert_equal (Some "d") (last ["d"]);
       assert_equal (Some "d") (last ["a"; "b"; "c"; "d"]);
       assert_equal None (last []))
