const { complex } = require('mathjs')

const conjuga = (numar) =>{
    let n = complex(numar)
    n.im *= -1
    return n.toString()
}
const transpune = (m)=> m.map((_, i) => m.map(v => v[i]));

const compara = (m1,m2)=>JSON.stringify(m1)==JSON.stringify(m2);

let matrice = [
    [5, '0+2i'],
    ['0-2i', 4],
]
// Uniformizez inputul
for(let i=0;i<matrice.length;i++)
    for(let j=0;j<matrice[i].length;j++)
        matrice[i][j]=complex(matrice[i][j]).toString();

//Copiez matricea a doua
let m2 = JSON.parse(JSON.stringify(matrice))

//conjug fiecare element
for(let i=0;i<matrice.length;i++)
    for(let j=0;j<matrice[i].length;j++){
        m2[i][j] = conjuga(matrice[i][j])
    }

//Transpun matricea a doua
m2 = transpune(m2);
console.log(JSON.stringify(matrice));
console.log(JSON.stringify(m2));

console.log(compara(matrice,m2) ? 'Este o matrice este Hermitică' : 'NU este o matrice este Hermitică');
