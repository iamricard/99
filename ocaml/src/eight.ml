open OUnit2

let rec compress =
  function
  | [] -> []
  | x::[] -> [x]
  | x::y::rest ->
      if x = y then compress (x :: rest) else x :: (compress (y :: rest))

let test_case =
  "compress" >::
    (fun _  ->
       assert_equal ["a"; "b"; "c"; "a"; "d"; "e"]
         (compress
            ["a";
            "a";
            "a";
            "a";
            "b";
            "c";
            "c";
            "a";
            "a";
            "d";
            "e";
            "e";
            "e";
            "e"]))
