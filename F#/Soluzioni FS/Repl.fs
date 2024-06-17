let repl (el: 'a) (i: int) =
    let rec aux i =
        if i <= 0 then []
        else el :: aux (i - 1)
    aux i

let acc_repl (el: 'a) (i: int) =
    let rec aux acc i =
        if i <= 0 then acc
        else aux (el :: acc) (i - 1)
    aux [] i