// Senza accumulatore
let rec pairWithIndex list index=
    match list with
    | [] -> []
    | head :: tail -> (head, index) :: pairWithIndex tail (index+1)
// Con accumulatore
let pairWithIndexAcc list =
    let rec loop list acc =
        match list with
        | [] -> []
        | head :: tail -> (head, acc) :: loop tail (acc + 1)
    loop list 1