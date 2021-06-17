import numpy as np
#from ex01 import doA,doB,doC,doD
#from ex02 import ex02_doA,ex02_doB,ex02_doC
from e01 import test

def print_hi(name):
    print(f'Hi, {name}')
    mylist=[1,2,3]
    mylist_np= np.array(mylist)
    mylist_np2= np.array(mylist)
    print(mylist_np.size)
    print(mylist_np.dtype)
    print(mylist_np[2])

if __name__ == '__main__':
    test()
