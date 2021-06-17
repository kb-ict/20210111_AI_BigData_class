function master(name, age)
{
    // name= typeof(name) == undefined? name:'한이진'
    // age= typeof(age) == undefined? age:26
    name= name || '한이진'
    age= age || 26

    console.log("hello "+name+'님')
    console.log('당신의 나이는 '+age+'세 입니다.')
}
master()
master("제니")
master("로제", 25)