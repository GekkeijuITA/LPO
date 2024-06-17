// Senza accumulatore
let rec agg = function
    | h1::h2::t -> h1+h2::agg t
    | l -> l
// Con accumulatore
let acc_agg =
    let rec aux acc = function
        | h1::h2::t -> aux (h1+h2::acc) t
        | [h] -> List.rev (h::acc)
        | _ -> List.rev acc
    in aux []