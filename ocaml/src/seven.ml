open OUnit2

type 'a node =
  | One of 'a
  | Many of 'a node list

let rec flatten =
  function
  | [] -> []
  | (One x)::rest -> x :: (flatten rest)
  | (Many xs)::rest -> (flatten xs) @ (flatten rest)

let test_case =
  "flatten" >::
    (fun _  ->
       assert_equal ["a"; "b"; "c"; "d"; "e"]
         (flatten [One "a"; Many [One "b"; Many [One "c"; One "d"]; One "e"]]))
