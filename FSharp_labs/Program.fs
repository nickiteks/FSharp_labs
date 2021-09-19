open System
open System.IO
open System.Text
open System.Text.Unicode

let files = [
      "/Users/nikita/Desktop/files/file1.txt"
      "/Users/nikita/Desktop/files/file2.txt"
      "/Users/nikita/Desktop/files/file3.txt"
      "/Users/nikita/Desktop/files/file4.txt"
      "/Users/nikita/Desktop/files/file5.txt"
]


let splitText (s:string) = s.Split(" ,:-.!?;()\t\r\n".ToCharArray(), System.StringSplitOptions.RemoveEmptyEntries)

let lab2 file =
      async{
            let s = System.IO.File.ReadAllText(file,Encoding.UTF8)
            let words = splitText s|>Array.toList
            let result = List.sortBy (fun (x:string) -> x.Length) words
            printf " %s " result.[0]
      }
      

files
|>List.map lab2
|>Async.Parallel
|>Async.RunSynchronously
|> ignore