// Senza accumulatore
let rec select comparer list1 list2 =
    match list1, list2 with
    | [], [] -> []
    | head1 :: tail1, head2 :: tail2 -> 
        if comparer head1 head2 then 
            head1 :: select comparer tail1 tail2
        else 
            head2 :: select comparer tail1 tail2
    | _, _ -> failwith "Lists must have the same length"
// Con accumulatore
let select_acc comparer list1 list2 =
    let rec loop list1 list2 acc =
        match list1, list2 with
        | [], [] -> List.rev acc
        | head1 :: tail1, head2 :: tail2 -> 
            if comparer head1 head2 then 
                loop tail1 tail2 (head1 :: acc)
            else 
                loop tail1 tail2 (head2 :: acc)
        | _, _ -> failwith "Lists must have the same length"
    loop list1 list2 []