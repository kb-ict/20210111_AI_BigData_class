const todos = ['우유구매','메일확인','요가']
for (const i in todos)
{
    console.log(`${Number(i)+1}번째 할 일: ${todos[i]}`)
}
console.log()

for(const work of todos)
{
    console.log(work)
}
console.log()
for(let i =0; i<todos.length; i++)
{
    console.log("할 일: "+ todos[i])
}