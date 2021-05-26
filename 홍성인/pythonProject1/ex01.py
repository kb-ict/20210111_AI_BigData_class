import numpy as np


class Ex01:
    def __init__(self):
        print("init")

    def doA(self):
        np1 = np.arrange(0,10)
        np.save("np1",np1)

    def doLoad(self):
        np1 = np.load("np1.npy")
        return np1

    def doSaves(self):
        np1 = np.arrange(0,10)
        np2 = np.random.randint(0,10,(1,5))
        np.savez("np1.npz",arr1=np1,arr2=np2)

    def doloads(self):
        data = np.load("np1.npz")
        print(data["arr1"])
        print(data["arr2"])