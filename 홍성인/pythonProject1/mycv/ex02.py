import cv2

def doA():
    dog = cv2.imread("dog.jpg")
    cv2.imshow("dog",dog)
    cv2.waitKey(0)

    roi = dog[0:200,0:200]
    cv2.imshow("roi",roi)
    cv2.waitKey(0)