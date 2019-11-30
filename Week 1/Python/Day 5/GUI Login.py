from tkinter import *
import pymysql

class main():
    def submit(self):
        self.email = a1.get()
        self.password = b1.get()
        window.destroy()
        db = pymysql.connect("localhost", "root", "", "test")
        cursor = db.cursor()
        cursor.execute("""Select EMAIL, PASSWORD from DETAILS""")
        rows = cursor.fetchall()
        for i in rows:
            if(i[0]==self.email and i[1]==self.password):
                print("Successful Login")
                return
        else:
            print("Invalid Credentials")
        db.close()


window = Tk()
window.title("Login")
var = IntVar()
var1 = IntVar()
var2 = IntVar()
m = main()

frame1 = Frame(window)
a = Label(frame1 ,text = "Email-id:", width = 25, anchor = 'w')
a1 = Entry(frame1, bd=1)

frame2 = Frame(window)
b = Label(frame2 ,text = "Password:", width = 25, anchor = 'w')
b1 = Entry(frame2, bd=1)

frame3 = Frame(window)
button = Button(frame3, text = "Submit", command = m.submit)

frame1.pack()
a.pack(side = LEFT)
a1.pack(side = RIGHT)
frame2.pack()
b.pack(side = LEFT)
b1.pack(side = RIGHT)
frame3.pack()
button.pack(side=BOTTOM)

window.mainloop()