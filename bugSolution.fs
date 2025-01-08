let mutable x = 10
let mutable y = 20

let swap x y = 
    let temp = x
    x <- y
    y <- temp

swap &x &y // Pass by reference using & operator
printf "%d %d" x y //This will print 20 20 as expected

//Alternatively, return modified values:

let mutable a = 10
let mutable b = 20

let swap2 () = 
    let temp = a
    a <- b
    b <- temp
    (a,b) // Return the tuple of the modified values

let (a,b) = swap2()
printf "%d %d" a b //This will print 20 10