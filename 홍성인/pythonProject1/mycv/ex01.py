import cv2

def doA():
    myimg = cv2.imread("dog.jpg")
    cv2.imshow("img",myimg)
    a = cv2.waitKey(0)
    print('a = ',a)