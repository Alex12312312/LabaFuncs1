
let rec sumNumbers a cN n =
    if (cN - n) = 0 then a
    else
        printf "(%d - %d * %d) = %d \n" a (cN - n) cN (int64(a) - int64(cN - n) * int64(cN))
        (int64(a) - int64(cN - n) * int64(cN)) * (sumNumbers a cN (n + 1))


printfn "Результат: %d" (sumNumbers (int(System.Console.ReadLine())) (int(System.Console.ReadLine())) 0)