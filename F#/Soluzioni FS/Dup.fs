// Senza accumulatore
let rec dup = function
| h::t -> h::h::dup t
| _ -> []
// Con accumulatore
let accDup list =
    let rec aux acc = function
        | h::t -> aux (h::h::acc) t
        | _ -> acc
    List.rev (aux [] list)