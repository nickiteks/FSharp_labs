open System
open System.Text
open System.Text.Unicode

let lab1(number: int) =   
      let mutable sum = 0
      for i in 1..number do
            if i % 4 = 0  then
                  sum <- sum + i
                  printfn "Number %i Sum = %i" i sum
      printf "Result: %i" sum
            
//lab1(100)
let splitText (s:string) = s.Split(" ,:-.!?;()\t\r\n".ToCharArray(), System.StringSplitOptions.RemoveEmptyEntries)

let lab2(s:string) =
      let words = splitText s
      let mutable minWord = string(words.GetValue(1))
      for i in words do
            if i.Length < minWord.Length then minWord <- i
      printf "The shortest word is: %s" minWord
let text = System.IO.File.ReadAllText("/Users/nikita/Desktop/Всякая маковская хрень/ФП/lab2.txt",Encoding.UTF8)
 
lab2 text

Console.ReadKey() |> ignore