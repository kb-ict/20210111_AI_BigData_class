function callThreeTime(callback)
{
    for(let i=0; i<3;i++)
    {
        callback(i) // 매개변수로 받은 함수 호출
    }
}
function print(i)
{
    console.log(`${i}번쨰 함수 호출`)
}
callThreeTime(print) // 함수 명을 넣은 것
console.log()
callThreeTime//매개변수에 함수를 통째로 그대로 넣은것 
(
    function(i)
    {
        console.log(`${i}번째 함수 호출`)
    }
)

