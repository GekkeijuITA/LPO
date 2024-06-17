let rec exist list item =
    match list with
    | [] -> false
    | head::tail -> if head = item then true else exist tail item

// Questa un po' inutile con l'accumulatore
let existAcc list item =
    let rec loop list acc =
        match list with
        | [] -> acc
        | head::tail -> if head=item then true else loop tail acc 
    loop list false