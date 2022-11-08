let a = [
    [1, 1, -1],
    [3, -2, 2],
    [2, 3, -2]
]
let b = [0, 5, 2];
let x = (new Array(a.length)).fill(0);

const print = ()=> console.log( a.map((eq,i)=>eq.map((n,j)=> `(${n})*x${j+1}`).join(' + ')+' = '+b[i]) )
console.log("Initial:")
print();

for (let k = 0; k < a.length - 1; k++) {
    
    if (a[k][k] != 0) {

        let p = a[k][k];
        for (let j = k; j < a[k].length; j++)
            a[k][j] /= p;
        b[k] /= p;

        for (let i = k + 1; i < a.length; i++) {
            for (let j = k + 1; j < a[k].length; j++)
                a[i][j] -= a[k][j] * a[i][k];
            b[i] -= b[k] * a[i][k];
            a[i][k] -= a[k][k] * a[i][k];
        }

        console.log("k="+k)
        print();
    }
    else {
        console.log("Problem, nu se poarte imparti cu zero!!");
    }
}

for (let k = a.length - 1; k >= 0; k--) {
    let s = 0;
    for (let i = k + 1; i < a[k].length; i++)
        s += a[k][i] * x[i];
    x[k] = (b[k] - s) / a[k][k];
}
console.log("Rezultatele sunt:", JSON.stringify(x.map((_,i)=> `x${i+1} = ${_}`),null,2))


