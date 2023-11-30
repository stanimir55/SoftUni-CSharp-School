function solve(number, digit){
    let counter = 0;
     while (number > 0) {
         let remaider = number % 2;
         number = Math.floor(number / 2);

         if (remaider === digit) {
            counter++;
         }
     }

     console.log(counter)
}

solve(20, 0)