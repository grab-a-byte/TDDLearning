namespace StringCalculator

open System

type StringCalculator() =
    member self.Add (input : string) =       
        let newlineReplacedInput = input.Replace("\n", ",")
        match newlineReplacedInput with
            | "" -> 0
            | _ -> self.ParseCommaSeperatedInteger(newlineReplacedInput)

    member private self.ParseCommaSeperatedInteger(input : string) =
        input.Split(',') 
        |> Array.map Convert.ToInt32 
        |> Array.sum