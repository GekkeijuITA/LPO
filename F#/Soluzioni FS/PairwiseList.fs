let pairwise lst =
    let rec aux acc = function
        | x::y::tl -> aux ((x, y)::acc) (y::tl)
        | _ -> List.rev acc
    aux [] lst

let acc_pairwise lst =
    let rec aux acc = function
        | x::y::tl -> aux ((x, y)::acc) (y::tl)
        | _ -> List.rev acc
    aux [] lst