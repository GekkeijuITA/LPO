// Senza accumulatore
let rec dup = function
| h::t -> h::h::dup t
| _ -> []
// Con accumulatore
let accDup (l: 'a list) =
    let rec aux (acc: 'a list) = function
        | h::t -> aux (h::h::acc) t
        | _ -> acc
    List.rev (aux [] l)