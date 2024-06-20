let rec sumBy f l=
    match l with
    | hd::tl -> f hd + sumBy tl
    | _ -> 0

let accSumBy f l=
    let rec aux acc l=
        match l with
        | hd::tl -> aux (f hd + acc) tl
        | _ -> acc
    aux 0 l