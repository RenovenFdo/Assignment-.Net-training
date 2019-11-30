List=[
      {"pid":1,"name":"Nokia 1100","cost":1500,"brand":"Nokia","category":"Electronics","rating":5,"discount":60},
      {"pid":2,"name":"Samsung A6","cost":15000,"brand":"Samsung","category":"Electronics","rating":3,"discount":40},
      {"pid":3,"name":"LG Washing Machine","cost":12000,"brand":"Nokia","category":"Home Appliance","rating":4,"discount":70},
      {"pid":4,"name":"T-shirt","cost":800,"brand":"Puma","category":"Fashion","rating":2,"discount":80},
      {"pid":5,"name":"Jeans","cost":1200,"brand":"Nike","category":"Fashion","rating":2,"discount":20},
      {"pid":6,"name":"Sofa","cost":20000,"brand":"Oaktree","category":"Furniture","rating":3,"discount":40}
]


task=int(input("Enter 1 to sort price low to high\nEnter 2 to sort price high to low\nEnter 3 to sort rating high to low\nEnter 4 to sort discount low to high\nEnter 5 to sort price high to low\n"))
List2=[{"sort1":"cost","boolean":False},{"sort1":"cost","boolean":True},{"sort1":"rating","boolean":False},{"sort1":"discount","boolean":False},{"sort1":"discount","boolean":True}]
option=List2[task-1]
List.sort(key=lambda el:el[option["sort1"]],reverse=option["boolean"])

print("The order of products based in your selection")
for i in List:
    print("Name:{name}  Price:Rs.{cost}  Brand:{brand}  Rating:{rating}  Discount:{discount}".format(**i))

task=int(input("Enter 1 for brand\nEnter 2 for category\nEnter 3 for name\n"))
List2=["brand","category","name"]
string1=input("Enter {0} name".format(List2[task-1])).lower()
list1=filter(lambda el:el[List2[task-1]]==string1,List)
print("Products of {0} {1}".format(List2[task-1],string1))
for i in list1:
    print("Name:{name}  Price:Rs.{cost}  Brand:{brand}  Rating:{rating}  Discount:{discount}".format(**i))
