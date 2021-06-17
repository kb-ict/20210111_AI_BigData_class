function sample()
{
    console.log(arguments)
    for(let i=0;i<arguments.length;i++){
        console.log(`${arguments[i]}`)
    }
    
}
//arguments ...대신 사용한 가변 매개변수
sample(1)
sample(1,2)
sample(1,2,3)
sample(1,2,3,4)
