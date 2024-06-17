let rec map2 f l1 l2 =
    match l1, l2 with
    | hd1::tl1, hd2::tl2 -> f hd1 hd2 :: map2 f tl1 tl2
    | [], [] -> []
    | _ -> invalidArg "l2" "List lengths do not match"

let map2der f l1 l2 = List.map (fun (x,y) -> f x y) (List.zip l1 l2)