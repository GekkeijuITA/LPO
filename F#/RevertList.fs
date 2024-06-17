let rec revertList list = 
    match list with
    | [] -> []
    | head::tail -> (revertList tail)@[head]

let revertListAcc list =
    let rec loop list acc = 
        match list with
        | [] -> acc
        | head::tail -> loop tail (head::acc)
    loop list []

let my_list = [1;2;3];;
let my_list2 = [1;2;3;4;5];;
printfn "%A" (revertList my_list);;
printfn "%A" (revertListAcc my_list2);;