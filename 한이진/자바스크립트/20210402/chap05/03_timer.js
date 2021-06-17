setTimeout(()=>{
    console.log('1초뒤 실행함!')
}, 1*1000) //1000ms(=1초)뒤 실행

let count=0
setInterval(()=>{
    console.log('1초마다 실행함'+count)
    count++
},1*1000)

setTimeout(()=>{
    console.log('5초뒤 꺼짐')
    clearInterval(id)
},5*1000) //1000ms(=5초)뒤 실행