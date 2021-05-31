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

@app.route("/upload",methods=['POST'])
def upload():
    image = request.files['file']
    image.save(f"static/{image.filename}")
    print(image.filename)

    npimage = cv2.imread(f"static/{image.filename}")
    #npimage[0:100,0:100]=[0,0,0]
    roi = npimage[0:100,100:200]
    npimage[0:100,0:100] = roi
    npimage[:,:,2]=0

    npimagename = f"static/np{image.filename}"
    cv2.imwrite(npimagename,npimage) #numpy 배열에 이미지화 저장

    return render_template("print.html",image=image.filename,npimage=npimagename)

app.run(host="127.0.0.1",port=5000);