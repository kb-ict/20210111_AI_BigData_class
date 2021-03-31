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

function _20210331_01() {
    //
    const todos = ['우유 구매', '업무', '필라테스'];
    console.log(todos.length);
    todos.push('공부하기');
    console.log(todos.length);
    todos.push('연습하기');
    console.log(todos.length);
    console.log(todos);
}

function _20210331_02() {
    //
    const fruits = ['사과', '배', '바나나'];
    fruits[10] = '귤';
    console.log(fruits);
}

function _20210331_03() {
    //
    const itemB = ['사과', '배', '바나나'];
    const index = itemB.indexOf('바나나');
    console.log(itemB);
    itemB.splice(index, 1);
    console.log(itemB);
}

function _20210331_04() {
    //
    const 자리 = ['이재문', '신용원', '박상준', '도현우'];
    console.log(자리);
    자리.splice(2, 0, '이기정');
    console.log(자리);
}

function printAsterisk01() {
    //
    let str = '';
    for (let i = 0; i < 10; i++) {
        for (let j = 0; j < i; j++) {
            str += '*';
        }
        for (let j = 10; j > i; j--) {
            str += ' ';
        }
        str += '\n';
    }
    console.log(str);
}
function printAsterisk02() {
    //
    let str = '';
    for (let i = 0; i < 10; i++) {
        for (let j = 10; j > i; j--) {
            str += ' ';
        }
        for (let j = 0; j < i; j++) {
            str += '*';
        }
        str += '\n';
    }
    console.log(str);
}
function printAsterisk03() {
    //
    let str = '';
    for (let i = 0; i < 10; i++) {
        for (let j = 0; j < i; j++) {
            str += ' ';
        }
        for (let j = 10; j > i; j--) {
            str += '*';
        }
        str += '\n';
    }
    console.log(str);
}
function printAsterisk04() {
    //
    let str = '';
    for (let i = 0; i < 10; i++) {
        for (let j = 10; j > i; j--) {
            str += '*';
        }
        for (let j = 0; j < i; j++) {
            str += ' ';
        }
        str += '\n';
    }
    console.log(str);
}
function printAsteriskPyramid() {
    let str = '';
    for (let i = 0; i < 10; i++) {
        for (let j = 10; j > i; j--) {
            str += ' ';
        }
        for (let j = 0; j < i; j++) {
            str += '**';
        }
        str += '\n';
    }
    console.log(str);
}
function printAsteriskReverseTriangle() {
    let str = '';
    for (let i = 0; i < 10; i++) {
        for (let j = 0; j < i; j++) {
            str += ' ';
        }
        for (let j = 10; j > i; j--) {
            str += '**';
        }
        for (let j = 0; j < i; j++) {
            str += ' ';
        }
        str += '\n';
    }
    console.log(str);
}
function printAsteriskDiamond() {
    let str = '';
    for (let i = 0; i < 10; i++) {
        for (let j = 10; j > i; j--) {
            str += ' ';
        }
        for (let j = 0; j < i; j++) {
            str += '**';
        }
        str += '\n';
    }
    for (let i = 0; i < 10; i++) {
        for (let j = 0; j < i; j++) {
            str += ' ';
        }
        for (let j = 10; j > i; j--) {
            str += '**';
        }
        for (let j = 0; j < i; j++) {
            str += ' ';
        }
        str += '\n';
    }
    console.log(str);
}
function _20210331_quiz01() {
    //5개의 숫자를 입력받은 뒤 가장 작은 수와 가장 큰 수를 출력하는 프로그램을 작성하시오.
    let numbers = [];
    for (let i = 0; i < 5; i++) {
        numbers[i] = prompt('[' + (i + 1) + ']번째 숫자 입력', 5 * (i + 1));
    }
    let max = 0;
    let min = 0;
    console.log(numbers);
    for (let i = 0; i < numbers.length; i++) {
        max = (Number(numbers[i]) > Number(max)) ? numbers[i] : max;
        min = (Number(numbers[i]) < Number(min)) ? numbers[i] : min;
    }
    console.log('max = ' + max + '\nmin = ' + min);
}
function _20210331_quiz02(k) {
    //아래의 규칙을 따르는 수열의 20번째 숫자를 프로그램을 만들어 찾으시오.
    /*
    1, 11, 12, 1121, 122111, 112213
    첫 번째 수열 : 1
    두 번째 수열 : 1이 1개 = 11
    세 번째 수열 : 1이 2개 = 12
    네 번째 수열 1이 1개, 2가 1개 = 1121
    다섯 번째 수열 : 1이 2개, 2가 1개, 1이 1개 = 122111
    여섯 번째 수열 : 1이 1개, 2가 2개 1이 3개 = 112213 */

    let seq = ['1'];// 시작
    let cnt = 0;
    let temp;
    let pushedStr = '';
    for (let i = 0; i < k - 1; i++) {
        // k회 반복
        temp = String(seq[i])[0];
        for (let pointer = 0; pointer < String(seq[i]).length; pointer++) {
            if (pointer != 0 && temp == String(seq[i])[pointer])
                continue;
            temp = String(seq[i])[pointer];
            for (let j = pointer; j < seq[i]; j++) {
                if (temp == seq[i][j])
                    cnt++;
                else
                    break;
            }
            pushedStr += String(temp) + String(cnt);
            cnt = 0;
        }
        seq.push(pushedStr);
        pushedStr = '';
    }
    console.log(seq);
    console.log(seq[k - 1]);
}

function _20210331_quiz03() {
    // 별찍기
    // 첫번째줄 별.공백 순
    // 두번째줄 공백.별 순
    let k = prompt('숫자 입력', 5);
    let str = '';
    for (let i = 0; i < k; i++) {
        for (let j = 0; j < k; j++) {
            if (j % 2 == 0)
                str += '*';
            else
                str += ' ';
        }
        str += '\n';
        for (let j = 0; j < k; j++) {
            if (j % 2 == 0)
                str += ' ';
            else
                str += '*';
        }
        str += '\n\n';// 구분이 쉽게 crlf 하나 더 넣음
    }
    console.log(str);
}