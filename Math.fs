module CS220.Quiz1.Math

open System

/// Modify the function `collatz` in such a way that the function takes in a
/// 32-bit integer, and returns the number of steps it takes to reach 1 in the
/// Collatz sequence.


// overflow was the problem. -1에서 loop 돈다.

let f n =
  if n % 2UL = 0UL then n / 2UL
  else 3UL * n + 1UL


let collatz n =
  // let rec subcol n steps =
  //   if n = 1 then steps
  //   else if n % 2 = 0 then subcol (n / 2) (steps + 1)
  //   else subcol (3 * n + 1) (steps + 1)
  // subcol n 0

  let rec iter cnt n =
    let result = f n 
    printfn "%d" result
   
    if result = 1UL then cnt
    else iter (cnt + 1) result
  iter 1 (uint64 n)