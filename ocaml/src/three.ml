open OUnit2

let rec at n xs =
  match n, xs with
  | 1, x :: _ -> Some x
  | _, _ :: rest -> at (n - 1) rest
  | _, [] -> None

let test_case =
  "at" >::
    (fun _  ->
       assert_equal (Some "c") (at 3 [ "a" ; "b"; "c"; "d"; "e" ]);
       assert_equal None (at 3 [ "a" ]))
