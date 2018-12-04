module internal Utils

open System

let EnsureWithinLimits l1 l2 value =
    let lowLimit = min l1 l2
    let highLimit = max l1 l2
    if value < lowLimit then
        lowLimit
    else
        if value > highLimit then
            highLimit
        else
            value

let EnsureAtLeast l1 value =
    if value<l1 then
        l1
    else
        value

let (|LT|_|) limit i =
    if i<limit then 
        Some(i)
    else 
        None

let (|GT|_|) limit i =
    if i>limit then 
        Some(i)
    else 
        None


let (|BETWEEN|_|) low high i =
    if i>low && i<high then
        Some(i)
    else
        None

let RoundAwayFromZero (x:float) =
    Math.Round(x, MidpointRounding.AwayFromZero)