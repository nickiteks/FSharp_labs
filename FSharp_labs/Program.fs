open System
open System.Text
open System.Text.Unicode

let lab1(number: int) =   
      [1..number]
      |>List.filter(fun x -> x % 4  = 0)
      |>List.sumBy(int)
      |>printf "%i"
            
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