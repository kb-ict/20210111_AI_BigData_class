import numpy as np

from flask import Flask,render_template,request
import cv2

from ex01 import Ex01

app = Flask(__name__)

@app.route("/")
def home():
    return render_template("index.html")

'''
    templates 폴더에 html 파일들을 넣고
    static 폴더에 image파일이나 js,css 등을 넣는다
'''

@app.route("/imgprint",methods=["POST","GET"])
def imgprint():
    file = request.files['file']
    filename = f"static/{file.filename}"
    file.save(filename)

    img = cv2.imread(filename)
    img[100:200,100:200] = [0,0,0]
    img[300:350,300:350] = [255,255,255]
    ar = img[50:100,50:100]
    img[0:50,0:50] = ar;
    chfile = f"static/np{file.filename}"
    cv2.imwrite(chfile,img)

    img1 = cv2.imread(filename)
    expand = cv2.resize(img1, None, fx=1.3, fy=1.3, interpolation=cv2.INTER_CUBIC)
    exfile = f"static/ex{file.filename}"
    cv2.imwrite(exfile,expand)

    img1 = cv2.imread(filename)
    shrink = cv2.resize(img1,None,fx=0.3,fy=0.3,interpolation=cv2.INTER_CUBIC)
    shfile = f"static/sh{file.filename}"
    cv2.imwrite(shfile,shrink)

    img1 = cv2.imread(filename)
    m = np.float32([[1,0,50],[0,1,100]])
    mimg = cv2.warpAffine(img1,m,(300,300))
    mfile = f"static/im{file.filename}"
    cv2.imwrite(mfile,mimg)

    img1 = cv2.imread(filename)
    m = cv2.getRotationMatrix2D((150,150),90,0.5)
    animg = cv2.warpAffine(img1,m,(300,300))
    anfile = f"static/an{file.filename}"
    cv2.imwrite(anfile,animg)

    return render_template("print.html",orifile=filename,chfile=chfile,exfile=exfile,shfile=shfile,mfile=mfile,anfile=anfile)

# @app.route("/upload",methods=['POST'])
# def upload():
#     image = request.files['file']
#     image.save(f"static/{image.filename}")
#     print(image.filename)
#
#     npimage = cv2.imread(f"static/{image.filename}")
#     #npimage[0:100,0:100]=[0,0,0]
#     roi = npimage[0:100,100:200]
#     npimage[0:100,0:100] = roi
#     npimage[:,:,2]=0
#
#     npimagename = f"static/np{image.filename}"
#     cv2.imwrite(npimagename,npimage) #numpy 배열에 이미지화 저장
#
#     return render_template("print.html",image=image.filename,npimage=npimagename)
#
app.run(host="127.0.0.1",port=5001);