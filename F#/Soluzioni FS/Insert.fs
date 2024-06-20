// Senza accumulatore
let rec insert el index list =
    match index, list with
    | 0, _ -> el::list
    | _, [] -> failwith "Index out of bounds"
    | _, hd::tl -> hd::insert el (index-1) tl
// Con accumulatore
let insert list item pos =
    if pos < 0 || pos > List.length list then failwith "Index out of bounds"
    else
        let rec loop list p acc =
            match p, list with
            | 0, _ -> acc@(item::list)
            | p, hd::tl -> loop tl (p-1) (acc@[hd])
        loop list pos []
