import numpy as np

def ex02_doA():
    np1= np.arange(8)
    np2 = np1*3
    print('np1= ',np1)
    print(np2)

def ex02_doB():
    np1= np.arange(0,8).reshape(2,4)
    np2 = np.arange(0,8).reshape(2,4)
    np3 = np.concatenate([np1, np2],axis=0)
    np4= np.arange(0,4).reshape(4,1)
    print(np1)
    print(np2)
    print(np3)
    print(np4)

def ex02_doC():
    np1= np.arange(16).reshape(4,4)
    print(np1)
    np2= np1 <10
    print(np2)
    np3= np.arange(16).reshape(4,4)
    np3[np2]=100
    print(np3)
