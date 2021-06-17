// let output=''

// for(let i=0; i<10; i++)
// {
//     for(let j=0;j<i;j++)
//     {
//         output+='*'
//     }
//     output += '\n'
// }
// console.log(output)
let out=''
for(let i=1; i<10; i++)
{
    for(let j=0; j<10-i; j++)
    {
        out+=' '
    }
    for(let j=0; j<i;i++)
    {
        out+='*'
    }
    out+='\n'
}

console.log(out)