# from csvrw import doRead, doWrite
# from mysqlrw import selectMember, insertMember
# from daegudb import read_csv_write_mysql
from flask import Flask

app = Flask(__name__)

@app.route("/")
def index():
    return "Seize the day"

if __name__ == '__main__':
    app.run(host="127.0.0.1",debug=True)
    # read_csv_write_mysql()
    # doWrite()
    # doRead()
    # insertMember()
    # selectMember()

# ctrl+ alt + shift + l 자동정렬