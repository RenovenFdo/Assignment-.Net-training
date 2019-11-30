import re,os
mobile=int(input("Enter a 10 digit mobile number"))
expression="^[0-9]{10}$"
match=re.findall(expression,str(mobile))
if match:
   print("Mobile number registered successfully")
else:
   print("Invalid mobile number")