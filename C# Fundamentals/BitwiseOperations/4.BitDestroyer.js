function solve(number, possition) {
    let mask = 1 << possition;
    mask = ~mask;

    let result = number & mask;

    console.log(result)
}

solve(231, 2)