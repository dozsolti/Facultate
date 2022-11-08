const { det } = require('mathjs')

let matrice = [
    [3, 0, 0],
    [1, 2, 0],
    [2, 0, 1],
]
/*let matrice = [
    [1, 2],
    [2, 4]
]*/
const P2 = (m) => {
    let b = m[0][0] + m[1][1];
    let c = det(m);
    return { a: 1, b: -b, c }
}

const P3 = (m) => {
    let b = m[0][0] + m[1][1] + m[2][2];
    let c =
        det([
            [m[0][0], m[0][1]],
            [m[1][0], m[1][1]],
        ]) +
        det([
            [m[0][0], m[0][2]],
            [m[2][0], m[2][2]],
        ]) +
        det([
            [m[1][1], m[1][2]],
            [m[2][1], m[2][2]],
        ]);
    let d = det(m);
    return { a: -1, b: -b, c, d: -d }
}

const Executa = () => {
    if (matrice.length == 2) {
        let { a, b, c } = P2(matrice);
        console.log(`Polinomul este: (${a})x^2 + (${b})*x + (${c})`)

        let delta = b * b - 4 * a * c;
        if (delta > 0) {
            let x1 = (-b + Math.sqrt(delta)) / (2 * a);
            let x2 = (-b - Math.sqrt(delta)) / (2 * a);
            return (`x1 = ${x1}, x2 = ${x2}`);
        }
        else if (delta == 0)
            return `x = ${-b / (2 * a)}`;
        else
            return "x1 si x2 sunt complexe";
    }
    else if (matrice.length == 3) {
        let { a, b, c, d } = P3(matrice);
        console.log(`Polinomul este: (${a})x^3 + (${b})*x^2 + (${c})*x + (${d})`)

        let delta = 18 * a * b * c * d - 4 * b * b * b * d + b * b * c * c - 4 * a * c * c * c - 27 * a * a * d * d;
        let d0 = b * b - 3 * a * c;
        let d1 = 2 * b * b * b - 9 * a * b * c + 27 * a * a * d;

        if (delta > 0) {
            let x1 = -b / (3 * a);

            let r2 = (1 / 2) * (2 * b * b * b - 9 * a * b * c + 27 * a * a * d + Math.sqrt(Math.pow((2 * b * b * b - 9 * a * b * c + 27 * a * a * d), 2) - 4 * Math.pow((b * b - 3 * a * c), 3)));
            let x2 = (-1 / (3 * a)) * Math.pow(r2, (1 / 3));

            let r3 = (1 / 2) * (2 * b * b * b - 9 * a * b * c + 27 * a * a * d - Math.sqrt(Math.pow((2 * b * b * b - 9 * a * b * c + 27 * a * a * d), 2) - 4 * Math.pow((b * b - 3 * a * c), 3)));
            let x3 = (-1 / (3 * a)) * Math.pow(r3, (1 / 3));

            return `x1 = ${x1}, x2 = ${x2}, x3 = ${x3}`;
        }
        else if (delta == 0) {
            if (d0 == 0) {
                return `x = ${-b / (3 * a)}`;
            }
            else {
                let x1 = (9 * a * d - b * c) / (2 * d0);
                let x2 = (4 * a * b * c - 9 * a * a * d - b * b * b) / (a * d0);
                return `x1 = ${x1}, x2 = ${x2}`;
            }
        }
        else {
            return "x1 este real si x2,x3 sunt complexe"
        }
    }
}
console.log(Executa());