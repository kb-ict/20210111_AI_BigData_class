const func= function()
{
    console.log("hello1")
    console.log("hello2")
}
func()

function func2()
{
    console.log("hello3")
}
func2()

function func3(param)
{
    console.log(param)
}
func3([1,2,3,4])
func3("1234")
func3(1234)
//매개변수 받고, 리턴값 주는 것 가능
function f(x)
{
    return x*x
}
console.log(f(10))