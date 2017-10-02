let oneToN (n:int) : int list =
    [1 .. n]

let lst = oneToN 15

let multiplicity (x:int) (xs:int list) : int =
    let mutable n = 0
    let len = xs.Length
    let mutable i = 0
    while i < len do
        if (xs.[i] = x) then
            n <- n + 1
        i <- i + 1
    n

printfn "%A" (multiplicity 19 [10; 2; 3; 10; 11; 10])
