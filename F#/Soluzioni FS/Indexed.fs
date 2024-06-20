let indexed l = 
    let rec aux i l = 
        match l with
        | hd::tl -> (i, hd) :: aux (i + 1) tl 
        | _ -> []
    aux 0 l

let mapi_indexed l = List.mapi (fun i h -> (i, h)) l