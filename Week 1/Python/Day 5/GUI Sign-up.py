from tkinter import *
import pymysql


class main():

    def table(self):
        db = pymysql.connect("localhost", "root", "", "test")
        cursor = db.cursor()
        cursor.execute("""CREATE TABLE DETAILS(
                            NAME  CHAR(30) NOT NULL,
                            EMAIL CHAR(30) NOT NULL,
                            PASSWORD CHAR(30) NOT NULL,
                            GENDER CHAR(6) NOT NULL,
                            JAVA CHAR(10) NOT NULL,
                            PYTHON CHAR(10) NOT NULL)""")

    def submit(self):
        #main.table(self)
        self.name = a1.get()
        self.email = b1.get()
        self.password = e1.get()
        self.gender = "Male" if var.get() == 0 else "Female"
        self.java = "Yes" if var1.get() == 1 else "No"
        self.python = "Yes" if var2.get() == 1 else "No"
        window.destroy()
        db = pymysql.connect("localhost", "root", "", "test")
        cursor = db.cursor()

        cursor.execute("""INSERT INTO DETAILS
                    (NAME, EMAIL, PASSWORD, GENDER, JAVA, PYTHON)
                    VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')""".format(self.name, self.email, self.password, self.gender, self.java, self.python))
        db.commit()
        db.close()


window = Tk()
window.title("Sign-up")
var = IntVar()
var1 = IntVar()
var2 = IntVar()
m = main()

frame1 = Frame(window)
a = Label(frame1 ,text = "Name:", width = 25, anchor = 'w')
a1 = Entry(frame1, bd=1)

frame2 = Frame(window)
b = Label(frame2 ,text = "Email-Id:", width = 25, anchor = 'w')
b1 = Entry(frame2, bd=1)

frame6 = Frame(window)
e = Label(frame6 ,text = "Password:", width = 25, anchor = 'w')
e1 = Entry(frame6, bd=1, show="*")

frame3 = Frame(window)
c = Label(frame3, text= "Gender:", width = 25, anchor = 'w')
c1 = Radiobutton(frame3, text = "Male",variable = var,value = 0)
c2 = Radiobutton(frame3, text = "Female",variable = var,value = 1)

frame4 = Frame(window)
d = Label(frame4, text= "Technology:", width = 25, anchor = 'w')
d1 = Checkbutton(frame4, text = "Java", variable = var1, onvalue = 1, offvalue = 0)
d2 = Checkbutton(frame4, text = "Python", variable = var2, onvalue = 1, offvalue = 0)

frame5 = Frame(window)
button = Button(frame5, text = "Submit", command = m.submit)

frame1.pack()
a.pack(side = LEFT)
a1.pack(side = RIGHT)
name = a1.get()
frame2.pack()
b.pack(side = LEFT)
b1.pack(side = RIGHT)
frame6.pack()
e.pack(side = LEFT)
e1.pack(side = RIGHT)
frame3.pack()
c.pack(side = LEFT)
c1.pack(side = LEFT)
c2.pack(side = RIGHT)
frame4.pack()
d.pack(side = LEFT)
d1.pack(side = LEFT)
d2.pack(side = RIGHT)
frame5.pack()
button.pack(side=BOTTOM)

window.mainloop()