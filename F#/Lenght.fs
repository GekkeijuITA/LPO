let rec len list = 
    match list with
    | [] -> 0
    | head::tail -> 1+ len tail

let lenAcc list =
    let rec loop list acc =
        match list with
        | [] -> acc
        | head::tail -> 1+ (loop tail acc)
    loop list 0