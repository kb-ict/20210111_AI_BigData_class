let product=
{
    제품명: '망고',  //키(속성): 값
    유형 : '당절임',
    원산지: '필리핀'
}

console.log(product)
console.log(product.제품명)
console.log(product.유형)
console.log(product.원산지)

let student_hyj=
{
    name: '한이진',
    phone: 123455,
    '가장 좋아하는 사람': ['김경숙', '한영석'],
    '가장 좋아하는 음식': '다좋앙',
    eat: function(food){
        console.log(food+"냠냠냠")
    },
    number : [1,2,3,4,5],
    introduce: function(){console.log('내 이름은'+ this.name+'입니다.')}
}
console.log(student_hyj)
console.log()
console.log(student_hyj.name)
console.log(student_hyj.phone)
console.log(student_hyj["가장 좋아하는 사람"])
console.log(student_hyj["가장 좋아하는 음식"])
student_hyj.eat('회')
console.log(student_hyj.number)
student_hyj.introduce()

student_hyj.newFunc=()=>{console.log('배열처럼 뒤늦게 추가하는 거 됩니다')}
student_hyj.newFunc()
student_hyj.직업='학생'
console.log(student_hyj.직업)
//키(속성)을 지우기 가능
delete student_hyj.phone

console.log(student_hyj)

const 한빛 =
{
    name:'혼자 공부하는 파이썬',
    price: 18000,
    publisher:'한빛미디어'
}
console.log("한빛미디어 책!"+한빛.name)
console.log(한빛.name+"가격은 "+한빛.price)
console.log()

let 대환장파티=
{
    배열: [
        ()=>{console.log('ㅋㅋ')},
        student_hyj,
        [1,2,4],
        {이름: '제니', 나이: 26}
        ],
        한빛
}



