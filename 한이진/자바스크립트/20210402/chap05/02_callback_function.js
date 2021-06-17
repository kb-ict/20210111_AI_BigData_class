//배열에 대해서 제공되는 함수 3가지
//forEach, map, filter
//모두 콜백함수를 이용
let numbers= [273,52,103,32,57]

//forEach: 배열의 각각의 요소에 접근하게 해주는 메소드(함수)
//배열 내부의 요소를 사용해서 콜백함수를 호출


numbers.forEach(function(value, index, array){//보통 'array는 생략
    console.log(`${index}번째 요소 : ${value}`)
})


// numbers=numbers.map(function(value,index,array){
//     return value*2 // 새로운 배열을 생성하여 numbers에 대입
// })
// const power = function(value,index,array)
// {
//     return value*value
// }
function power(value,index,array)
{
    return value*value
}

numbers=numbers.map(power)
console.log(numbers)
numbers.forEach(console.log)

//filter
//map이랑 마찬가지로, 특정 조건을 만족하는 녀셕만 추려내서 새로운 배열을 생성
const number2=[0,1,2,3,4,5]
const eventNumbers= number2.filter(function(value)
{
    return value%2===0
})
console.log("원본: "+ number2)
console.log("새로운 배열: "+eventNumbers)

//화살표 함수(람다식 함수) function(){} = () =>{}
const arrowFunc=(value) => value%2===0
const eventNumbers2=number2.filter(arrowFunc)
console.log("원본: "+ number2)
console.log("새로운 배열: "+eventNumbers2)

//연속적으로 사용가능
let numberEx=[0,1,2,3,4,5,6,7,8,9]
numbers.filter((value)=> value % 2===0).forEach((value)=>{console.log(value)})