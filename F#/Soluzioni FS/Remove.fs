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