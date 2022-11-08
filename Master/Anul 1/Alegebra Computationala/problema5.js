const { det } = require('mathjs')

const Main = (a, b, c, d) => {
    console.log(`f(x)= ${a}x^3 + ${b}x^2 + ${c}x+ ${d}`)
    console.log(`f'(x)= ${3 * a}x^2 + ${2 * b}x + ${c}x`)


    let R = [
        [a, b, c, d, 0],
        [0, a, b, c, d],
        [3 * a, 2 * b, c, 0, 0],
        [0, 3 * a, 2 * b, c, 0],
        [0, 0, 3 * a, 2 * b, c],
    ]

    console.log("R = ")
    for (let i = 0; i < R.length; i++)
        console.log(R[i]);

    let detR = det(R);
    console.log("R(f, f') = " + detR);

    let D = Math.pow(-1, 3 * (3 - 1) / 2) * detR / a;
    console.log("Discriminantul polinomului f: D(f) = " + D);

    if (ePatrat(D))
        console.log("Gf = A3");
    else
        console.log("Gf = S3");
}
let ePatrat = (n) => {
    for (let i = 0; i < Math.sqrt(n) + 1; i++)
        if (i * i == n)
            return true;
    return false;
}

Main(1, 0, -1, 1)