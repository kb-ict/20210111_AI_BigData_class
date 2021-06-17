 //charAt()이해하기
//  let ex="hyj"
//  let one=ex.charAt(0)
//  let two=ex.charAt(1)
//  let three=ex.charAt(2)
//  console.log(ex)
//  console.log(one)
//  console.log(two)
//  console.log(three)
 
 let start="1"
 for(let i=0;i<20;i++)
 {
     console.log((Number(i)+1)+"번 째: "+ start)
     let end=''//누적 변수
     let num=start.charAt(0)//읽을 숫자
     let count=0//읽을 숫자의 개수
     for(let j=0; j<start.length;j++)
     {
         if(num != start.charAt(j))
         {
            end=end+num+count
            count=1
            num=start.charAt(j)
         }
         else
            count++
     }
     end= end+num+count;
     start=end;
 }