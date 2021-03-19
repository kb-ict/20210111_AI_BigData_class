function OrientalZodiac(input) {
    // 십이간지
    // let year = Number(prompt('태어난 연도를 입력하세요.', 1989));
    let year = Number(input);
    let z = year % 12;
    let ret;
    switch (z) {
        case 0:
            ret = '신';
            break;
        case 1:
            ret = '유';
            break;
        case 2:
            ret = '술';
            break;
        case 3:
            ret = '해';
            break;
        case 4:
            ret = '자';
            break;
        case 5:
            ret = '축';
            break;
        case 6:
            ret = '인';
            break;
        case 7:
            ret = '묘';
            break;
        case 8:
            ret = '진';
            break;
        case 9:
            ret = '사';
            break;
        case 10:
            ret = '오';
            break;
        case 11:
            ret = '미';
            break;
    }
    return ret;
}

function SexagenaryCycle(year) {
    // 60갑자
    // 갑을병정무기경신임계
    // 자축인묘진사오미신유술해
    let ret;
    // 1989 기사
    let twelve = OrientalZodiac(year);// 사
    let ten_zod = '경,신,임,계,갑,을,병,정,무,기'.split(',');

    ret = `${year}년은 ${ten_zod[year % 10]}${twelve}의 해다.`;
    return ret;
}

function Zodiac2Image(year) {
    // let input = OrientalZodiac(year);
    // let zod = '신,유,술,해,자,축,인,묘,진,사,오,미'.split(',');
    // var str = `res/${zod.indexOf(input)}.png`;
    var str = `res/${year % 12}.png`;
    return str;
}

function ArrTest() {
    let arr = [1, 2, 3, 4];
    console.log('arr.length = ' + arr.length);
    arr.forEach(element => {
        console.log(element);
    });

    // 배열 인덱스 제일 뒤에 추가하기
    arr.push(5);
    console.log('arr.length = ' + arr.length);
    arr.forEach(element => {
        console.log(element);
    });

    // 특정 위치에 값 추가하기
    console.log('내가 원하는 위치에도 바로 값을 입력할 수 있다.');
    arr[9] = '내가 원하는 위치에도 바로 값을 입력할 수 있다.';
    console.log('arr.length = ' + arr.length);
    arr.forEach(element => {
        console.log(element);
    });

    // 특정 인덱스 제거하기
    arr.splice(2, 1);
    console.log('arr.splice(2,1) 입력.')
    console.log('arr.length = ' + arr.length);
    arr.forEach(element => {
        console.log(element);
    });

    // 특정 값 제거하기
    var idx = arr.indexOf('내가 원하는 위치에도 바로 값을 입력할 수 있다.');
    arr.splice(idx, 1);
    console.log('arr.length = ' + arr.length);
    arr.forEach(element => {
        console.log(element);
    });

    // splice를 활용하여 사이에 값 추가하기
    arr.splice(1, 0, 1.5);
    console.log('arr.length = ' + arr.length);
    arr.forEach(element => {
        console.log(element);
    });
}

function ForLoop() {
    const names = ['똘기', '떵이', '호치', '새촘이', '드라고', '요롱이', '마초', '미미', '몽키', '키키', '강다리', '찡찡이'];
    // for in
    console.log('>> for in: indexs');
    for (var idx in names) {
        console.log('names[idx] = ' + names[idx]);
    }
    console.log('>> for of: values');
    // for of
    for (var name of names) {
        console.log('name = ' + name);
    }
    // for
    console.log('>> for');
    for (var i = 0; i < names.length; i++) {
        console.log(names[i]);
    }
}
function Quiz01() {
    // 1부터 100까지의 양의 정수 중 3의 배수만 더한 값 출력
    let sum = 0;
    for (var i = 1; i <= 100; i++) {
        if (i % 3 == 0)
            sum += (i);
    }
    return sum;
}
function Quiz02() {
    // 숫자를 입력받아 분과 초로 값 표시
    // ex) 입력 124, 출력 2분 4초
    let input = prompt('초(양의 정수)를 입력하시오', 3600);
    let hh = parseInt(input / 3600);
    let mm = parseInt((input % 3600) / 60);
    let ss = (input % 3600) % 60;
    return `${hh}시간 ${mm}분 ${ss}초`;
}