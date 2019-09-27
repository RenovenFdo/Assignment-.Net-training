var forms = document.getElementById("forms")
var form=document.createElement("form")
form.setAttribute('action','method')
forms.appendChild(form)

var head=document.createElement("h1")
head.setAttribute("style","align-text:center")
head.innerHTML="Login form"
head.setAttribute('class','h1')
form.appendChild(head)

var lbreak =document.createElement("br")
form.appendChild(lbreak)
var lbreak =document.createElement("br")
form.appendChild(lbreak)

var l1=document.createElement("label")
l1.setAttribute('for','user')
l1.innerHTML="Username"
form.appendChild(l1)

var lbreak =document.createElement("br")
form.appendChild(lbreak)
var lbreak =document.createElement("br")
form.appendChild(lbreak)

var inputt = document.createElement("INPUT")
inputt.setAttribute('type','text')
inputt.setAttribute('name','user')
inputt.setAttribute("class","u1")
form.appendChild(inputt)

var lbreak =document.createElement("br")
form.appendChild(lbreak)
var lbreak =document.createElement("br")
form.appendChild(lbreak)

var l2=document.createElement("label")
l2.setAttribute('for','pass')
l2.innerHTML="Password"
form.appendChild(l2)

var lbreak =document.createElement("br")
 form.appendChild(lbreak)
 var lbreak =document.createElement("br")
form.appendChild(lbreak)

var input1 = document.createElement("INPUT")
input1.setAttribute('type','password')
input1.setAttribute('name','pass')
input1.setAttribute('class','p1')
form.appendChild(input1)

var lbreak =document.createElement("br")
 form.appendChild(lbreak)
 var lbreak =document.createElement("br")
form.appendChild(lbreak)

var l3=document.createElement("label")
l3.setAttribute('for','gmail')
l3.innerHTML="E-mail"
form.appendChild(l3)

var lbreak =document.createElement("br")
 form.appendChild(lbreak)
 var lbreak =document.createElement("br")
form.appendChild(lbreak)

var input2 = document.createElement("INPUT")
input2.setAttribute('type','email')
input2.setAttribute('name','gmail')
input2.setAttribute('class','e1')
form.appendChild(input2)

var lbreak =document.createElement("br")
 form.appendChild(lbreak)
 var lbreak =document.createElement("br")
form.appendChild(lbreak)

var input3 = document.createElement("INPUT")
input3.setAttribute('type','submit')
input3.setAttribute('value','Login')
input3.setAttribute('class','sub')
form.appendChild(input3)