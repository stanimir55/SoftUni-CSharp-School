function solve(number, possition){
    let sheftedNumber = number >> possition

    let result = sheftedNumber & 1;

    console.log(result);
}

solve(111, 8)