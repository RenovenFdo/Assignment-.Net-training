size=int(input("Enter number of lines for pattern "))
string=input("Enter a word for pattern")
fact=int(input("Enter a number to find factorial "))
fib=int(input("Enter length of fibonacci series"))
result=1
data=range(1, size+1)
fb=[0, 1]
for i in data:
    print("*"*i)
  
for i in data:
    print("*"*(size+1-i))
        
for i in data:
    print(" "*(i-1)+"*"*(size+1-i))

for i in data:
     print(" "*(size-i+1)+"*"*i)

for i in data:
     print(" "*(size-i)+"* "*i+" "*(size-i))
              
for i in range(0, len(string)):
    print(" "*(len(string)-i-1), string[0:i+1])

for i in range(1, fact+1):
    result=result*i

print("Factorial = ", result)
for i in range(2, fib):
    fb.append(fb[i-1]+fb[i-2])
    
print("Fibbonaci Series ", fb)



