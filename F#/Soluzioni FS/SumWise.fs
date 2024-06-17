// Senza accumulatore
let rec sum_wise list1 list2 =
    match list1, list2 with
    | [], [] -> []
    | head1 :: tail1, head2 :: tail2 -> (head1 + head2) :: sum_wise tail1 tail2
    | _, _ -> failwith "Lists must have the same length"
// Con accumulatore 
let sum_wise_acc list1 list2 =
    let rec loop list1 list2 acc =
        match list1, list2 with
        | [], [] -> List.rev acc
        | head1 :: tail1, head2 :: tail2 -> loop tail1 tail2 ((head1 + head2) :: acc)
        | _, _ -> failwith "Lists must have the same length"
    loop list1 list2 []