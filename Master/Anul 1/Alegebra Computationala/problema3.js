const readline = require('readline');

const rl = readline.createInterface({
    input: process.stdin,
    output: process.stdout
});
let x= '13'
console.log(x)
console.log(+x)
console.log(x+0)
/*rl.question('Cat sa fie n?\n', n => {

    
    rl.question('Introduceti un element: ', a => {

        n=0+n;
        a=+a;
        if(a>=n){
            console.log("Elementul este din afara multimii");
            return;
        }else{

            let ord = CalculeazaOrdinul(n, a);
            if(ord == -1)
                console.log("Ordinul este infinit")
            else
                console.log(`\n\nOrdinul lui a=${a} in grupul (Z ${n} ,*) este: ${ord}\nPentru ca este ${a}^${ord}=${Math.pow(a,ord)}%${n}=${Math.pow(a,ord)%n}`);
            rl.close();
        }
    });
});

const CalculeazaOrdinul = (n, a) => {
    const e = 1;
    let m = 1;
    while (Math.pow(a, m) % n != e){
        m++;
        if(m>=n)
            return -1;
    }
    return m
}*/