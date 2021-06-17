import numpy as np
from numpy.core.arrayprint import array_str
from numpy.core.defchararray import array
def test():
    # 균일한 간격으로 데이터 생성
    array = np.linspace(0, 10, 3)
    print(array,'\n')

    array = np.linspace(0, 10, 5)
    print(array,'\n')

    # 난수의 재연 (실행마다 결과 동일)
    np.random.seed(7)
    print(np.random.randint(0,10, (2, 3)),'\n')

    # 배열 객체 복사
    array1 = np.arange(0, 10)
    array2= array1.copy()
    print(array2, '\n')

    # 중복된 원소 제거
    array = np.array([1, 1, 2, 3, 3, 1])
    print(np.unique(array))