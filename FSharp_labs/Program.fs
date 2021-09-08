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
      let words = splitText s|>Array.toList
      let result = List.sortBy (fun (x:string) -> x.Length) words
      printf "The shortest word is: %s" result.[0]
let text = System.IO.File.ReadAllText("/Users/nikita/Desktop/Всякая маковская хрень/ФП/lab2.txt",Encoding.UTF8)
 
//lab2 text

let lab3 =
      let array = [|1;2;3;4;5;6;7;8;9|]
      for i in 0 .. array.Length - 1  do
            if array.[i] % 2 > 0 then
                  Array.set array i (array.[i]+10)
      printf "%A" array     
//lab3

Console.ReadKey() |> ignore