open OUnit2

let test_cases =
  "NinetyNine" >:::
    [One.test_case;
    Two.test_case;
    Three.test_case;
    Four.test_case;
    Five.test_case;
    Six.test_case;
    Seven.test_case;
    Eight.test_case;
    Nine.test_case]

let _ = run_test_tt_main test_cases
