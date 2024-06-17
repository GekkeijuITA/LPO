// Senza accumulatore
let rec combine f l1 l2 =
    match l1, l2 with
    | h1::t1, h2::t2 -> (f h1 h2)::(combine f t1 t2)
    | [], [] -> []
    | _ -> raise (System.ArgumentException("combine"))
// Con accumulatore
let accCombine f =
    let rec aux acc l1 l2 =
        match l1, l2 with
        | h1::t1, h2::t2 -> aux (f h1 h2 :: acc) t1 t2
        | [], [] -> List.rev acc
        | _ -> raise (System.ArgumentException("combine"))
    aux []