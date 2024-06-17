let rec scalar (l1: int list) (l2: int list) =
    match l1, l2 with
    | hd1::tl1, hd2::tl2 -> hd1 * hd2 + scalar tl1 tl2
    | [], [] -> 0
    | _, _ -> failwith "scalar"

let acc_scalar (l1: int list) (l2: int list) =
    let rec aux acc l1 l2 =
        match l1, l2 with
        | hd1::tl1, hd2::tl2 -> aux (hd1 * hd2 + acc) tl1 tl2
        | [], [] -> acc
        | _, _ -> failwith "scalar"
    aux 0 l1 l2