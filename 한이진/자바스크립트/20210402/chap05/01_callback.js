function callthreetimes(callback)// 함수를 정의(선언)
{
    for(let i=0; i<3; i++)
    callback(i)
}
function print(i) // 함수를 정의(선언)
{
    console.log(i+" 번째")
}
// 두개 결과 같다
callthreetimes(print)

callthreetimes( //함수를 호출한 것
    function(i){
        console.log(i+"번째")
    }
)