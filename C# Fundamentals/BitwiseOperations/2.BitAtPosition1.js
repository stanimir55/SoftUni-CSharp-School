function solve (number) {
    let shiftefNumber = number >> 1;

    let result = shiftefNumber & 1;

    console.log(result)
}

solve(51)