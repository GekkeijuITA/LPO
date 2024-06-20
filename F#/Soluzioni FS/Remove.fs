// Senza accumulatore
let rec remove i =
    function
    | hd :: tl -> if i = 0 then tl else hd :: remove (i - 1) tl
    | _ -> []
// Con accumulatore
let accRemove i =
    let rec loop acc i =
        function
        | hd :: tl -> loop (if i = 0 then acc else hd :: acc) (i - 1) tl
        | _ -> List.rev acc

    loop [] i

let rec remove l i =
    match i,l with
    | i, _ when i < 0 || i >= List.length l -> l
    | 0, _ :: tl -> tl
    | _, hd :: tl -> hd :: remove tl (i - 1)

let removeAcc l i =
    if i < 0 || i >= List.length l then l
    else
        let rec loop l i acc =
        match i,l with
        | 0, _ :: tl -> acc @ tl
        | _, hd :: tl -> loop tl (i - 1) (hd :: acc)
