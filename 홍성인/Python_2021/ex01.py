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