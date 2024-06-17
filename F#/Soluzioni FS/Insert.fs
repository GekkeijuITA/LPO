// Senza accumulatore
let rec insert el index list =
    match index, list with
    | 0, _ -> el::list
    | _, [] -> failwith "Index out of bounds"
    | _, hd::tl -> hd::insert el (index-1) tl
// Con accumulatore
let insertAcc e =
    let rec aux i = function
        | hd::tl as l when i = 0 -> e::l
        | hd::tl -> hd::aux (i-1) tl
        | [] when i = 0 -> [e]
        | _ -> failwith "insert: index out of bounds"
    aux
