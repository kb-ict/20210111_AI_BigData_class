const rawInput = Number(prompt("태어난 해를 입력",''))
const y= rawInput%10
const year=rawInput%12

let r
switch(y){
    case 0: r='갑'; break;
    case 1: r='을'; break;
    case 2: r='병'; break;
    case 3: r='정'; break;
    case 4: r='무'; break;
    case 5: r='기'; break;
    case 6: r='경'; break;
    case 7: r='신'; break;
    case 8: r='임'; break;
    case 9: r='계'
}

let dd 
switch(year){
    case 0: dd='신'; break;
    case 1: dd='유'; break;
    case 2: dd='술'; break;
    case 3: dd='해'; break;
    case 4: dd='자'; break;
    case 5: dd='축'; break;
    case 6: dd='인'; break;
    case 7: dd='묘'; break;
    case 8: dd='진'; break;
    case 9: dd='사'; break;
    case 10: dd='오'; break;
    case 11: dd='미'; break;
    case 12: dd='신'; break;
}
console.log(`${rawInput}년은 ${r}${dd}년 입니다.`)