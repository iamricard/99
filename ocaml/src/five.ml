open OUnit2

let rev =
  let rec go reversed =
    function | [] -> reversed | x::rest -> go (x :: reversed) rest in
  go []

let test_case =
  "rev" >:: (fun _  -> assert_equal ["c"; "b"; "a"] (rev ["a"; "b"; "c"]))
