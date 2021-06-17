// for(let i=0; i<5;i++)
// {
//     let input= Number(prompt('숫자입력',''))
//     array[i]=input
// }
const arr=[1,2,3,4,5]
// let min=0
// let max=0
let min=arr[0]
for(let i=0; i<arr.length;i++)
{
    
    let min= arr[i]
    let n= arr[i]
    if(min>arr[i])
        min=arr[i]

    else if(n<arr[i])
        n=arr[i]
}

console.log(min)
console.log(n)


