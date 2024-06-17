let sumBy f =
    let rec aux = function
        | hd::tl -> f hd + aux tl
        | [] -> 0
    aux

let accSumBy f =
    let rec aux acc = function
        | hd::tl -> aux (f hd + acc) tl
        | [] -> acc
    aux 0