printfn "5.0"

let oneToN (n:int) : int list =
    [1 .. n]

let lst = oneToN 15
printfn "%A\n" lst

printfn "5.1"
let multiplicity (x:int) (xs:int list) : int =
    let mutable n = 0
    let len = xs.Length
    let mutable i = 0
    while i < len do
        if (xs.[i] = x) then
            n <- n + 1
        i <- i + 1
    n

printfn "%A\n" (multiplicity 19 [10; 2; 3; 10; 11; 10])
printfn "5.2"
let split (xs:int list) : (int list * int list) =
    let x1 = List.init (xs.Length / 2 + xs.Length % 2) (fun x -> xs.[x * 2])
    let x2 = List.init (xs.Length / 2) (fun x -> xs.[x * 2 + 1])
    (x1, x2)

printfn "%A\n" (split (oneToN 10))

printfn "5.3"
let reverseApply x f =
    f x

printfn "%A\n" (reverseApply lst split)

//5.4
let func1 (n : int) =
    oneToN

let func2 (f) : int =
    f 19 [10; 2; 3; 10; 11; 10]

printfn "5.5"
let evens (lst : int list) : int list =
    List.filter (fun x -> x % 2 = 0) lst

printfn "%A\n" (evens lst)

printfn "5.6"
let add2 x =
  x + 2

let sub2 x =
  x - 2


let applyList (lst : ('a -> 'b) list) (n : 'a) : 'b list =
  List.map (reverseApply n) lst

printfn "%A\n" (applyList [sub2; add2] 18)

printfn "5.8"
let ssort (xs : int list) : int list =
  Set.toList (Set.ofList xs)

printfn "%A\n" (ssort [4; 3; 2; 6; 1; 8; 2])
