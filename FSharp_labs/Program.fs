open System
open System.Text
open System.Text.Unicode

[<AbstractClass>]
type Person(name) = 
    member val Name = name with get,set
 
type Patient(name) = 
    inherit Person(name)
    
type Doctor(name) =
    inherit Person(name)
    
    
let patient1 = Patient("Bob")
let Doctor1 = Doctor("Nikita")

let addDoctor =
    printf "doctor %s " Doctor1.Name
    printf "work with "
    printf "patient %s" patient1.Name