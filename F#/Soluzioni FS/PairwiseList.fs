let rec pairwise lst =
    match lst with
    | x::y::tl -> (x, y)::pairwise tl
    | _ -> []

let acc_pairwise lst =
    let rec aux acc lst =
        match lst with
        | x::y::tl -> aux ((x, y)::acc) (y::tl)
        | _ -> List.rev acc
    aux [] lst