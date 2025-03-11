module CS220.Quiz1.Program

open CS220.Quiz1.Math

[<EntryPoint>]
let main _args =
  printfn "You can test your program by directly modifying Program.fs"
  printfn "Or, you can change the unit tests in the `tests` directory."
  printfn "---"
  collatz 10 |> printfn "# of steps to reach one = %d"
  0
