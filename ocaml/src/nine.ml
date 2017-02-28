open OUnit2

let pack xs =
  let rec go packed xs =
    match (packed, xs) with
    | ([],x::rest) -> go [[x]] rest
    | (ps,[]) -> ps
    | (p::ps,x::rest) ->
        if List.mem x p
        then go ((x :: p) :: ps) rest
        else go ([x] :: p :: ps) rest in
  List.rev (go [] xs)

let test_case =
  "pack" >::
    (fun _  ->
       assert_equal
         [["a"; "a"; "a"; "a"];
         ["b"];
         ["c"; "c"];
         ["a"; "a"];
         ["d"; "d"];
         ["e"; "e"; "e"; "e"]]
         (pack
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
            "d";
            "e";
            "e";
            "e";
            "e"]))
