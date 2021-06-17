let output=''
for(let i=1; i<15;i++)
{
    // 공백 출력
    for(let j=15; j>i;j--)
        output+=' '
    // * 출력
    for(let k=0;k<2*i-1; k++) //i가 1일때 2*1-1= '*'이 1
        output+='*'           //i가 2일때 2*2-1= '*'이 3...
                
    output += '\n'
}
console.log(output)