import numpy as np

def doA():
    np1= np.arrange(4) #0~3���� numpy�迭 ����
    np2= np.zeros((4,4),dtype=float)# 0���� �ʱ�ȭ 2���� �迭 4�d4�� flost�� ����
    np3= np.ones((3,3), dtype=str) # 1�� �ʱ�ȭ 3�� 3�� ���ڿ��� ����

    np4= np.random.randint(0,10,(2,2))# 0~9���� 2��2��
    np5= np.random.normal(0,1,(3,3)) #0~1���� ǥ�����Ը� ��� �迭
    print(np1)
    print(np2)
    print(np3)
    print(np4)
    print(np5)

def doB():
    np1 =np.array([1,2])
    np2 = np.array([3,4])
    np3 = np1+np2
    np4 = np.concatenate(np1,np2)
    print(np3)
    print(np4)
    print(np3.shape)
    print(np4.shape)
    
    np5 = np.random.randint(0,10,(3,3))
    print(np5.shape)