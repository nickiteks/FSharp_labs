open System

let main(number: int) =   
      let mutable sum = 0
      for i in 1..number do
            if i % 3 > 0 && i % 5 = 0  then
                  sum <- sum + i
                  printfn "Number %i Sum = %i" i sum
      printf "Result: %i" sum
            
main(100)

Console.ReadKey() |> ignore