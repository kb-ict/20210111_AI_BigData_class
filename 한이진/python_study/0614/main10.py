import cv2
import numpy as np

img=cv2.imread("static/gray_image.jpg",cv2.IMREAD_GRAYSCALE)

cv2.imshow("img",img)

images = []

ret, ts1 = cv2.threshold(img, 127, 255, cv2.THRESH_BINARY)
ret, ts2 = cv2.threshold(img, 127, 255, cv2.THRESH_BINARY_INV)
ret, ts3 = cv2.threshold(img, 127, 255, cv2.THRESH_TRUNC)
ret, ts4 = cv2.threshold(img, 127, 255, cv2.THRESH_TOZERO)
ret, ts5 = cv2.threshold(img, 127, 255, cv2.THRESH_TOZERO_INV)

images.append(ts1)
images.append(ts2)
images.append(ts3)
images.append(ts4)
images.append(ts5)

np_images = np.array(images)
print(np_images.size)

# try:
#     for index,im in enumerate(images):
#         cv2.imshow(str(index),im)
#         cv2.waitKey(1000)
# except Exception as e:
#     print(e)

himg=cv2.imread("static/hand_writing_image.jpg",cv2.IMREAD_GRAYSCALE)
th1= cv2.adaptiveThreshold(himg,255,cv2.ADAPTIVE_THRESH_MEAN_C,cv2.THRESH_BINARY,21,3)
th2= cv2.adaptiveThreshold(himg,255,cv2.ADAPTIVE_THRESH_GAUSSIAN_C,cv2.THRESH_BINARY,21,3)
images.append(th1)
images.append(th2)

for index,img in enumerate(images):
    cv2.imshow(str(index),img)
    cv2.waitKey(1000)

cv2.waitKey(0)
