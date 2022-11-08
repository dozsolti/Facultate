const { det } = require('mathjs')

const Main = (a, b, c, d, e) => {
    console.log(`f(x)= ${a}x^4 + ${b}x^3 + ${c}x^2+ ${d}x + ${e}`)
    console.log(`f'(x)= ${4 * a}x^3 + ${3 * b}x^2 + ${2 * c}x + ${d}`)


    let R = [
        [a, b, c, d, e, 0, 0],
        [0, a, b, c, d, e, 0],
        [0, 0, a, b, c, d, e],
        [4 * a, 3 * b, 2 * c, d, 0, 0, 0],
        [0, 4 * a, 3 * b, 2 * c, d, 0, 0],
        [0, 0, 4 * a, 3 * b, 2 * c, d, 0],
        [0, 0, 0, 4 * a, 3 * b, 2 * c, d],
    ]

    console.log("R = ")
    for (let i = 0; i < R.length; i++)
        console.log(R[i]);

    let detR = -det(R);
    console.log("R(f, f') = " + detR);

    let D = Math.pow(-1, 4 * (4 - 1) / 2) * detR / a;
    console.log("Discriminantul polinomului f: D(f) = " + D);

    if (!ePatrat(D)) {
        if (e > 1)
            console.log("Gf = S4");
        else
            console.log("Gf = conjugatul lui B'4 = { e, t1, t2, t3, s, t1s, t2s, t3s }");
    }
    else {
        if (e> 1)
            console.log("Gf = A4");
        else
            console.log("Gf = B4 (Klein)");
    }
}
let ePatrat = (n) => {
    for (let i = 0; i < Math.sqrt(n) + 1; i++)
        if (i * i == n)
            return true;
    return false;
}

Main(1,0,0,0,1)