List=[]
class Product:
    def __init__(self,pid,name,cost,brand,category,rating,discount):
        self.pid=pid
        self.name=name
        self.cost=cost
        self.brand=brand
        self.category=category
        self.rating=rating
        self.discount=discount
        List.append(self)

    def choices(self,task):
        List2=[[self.cost,False],[self.cost,True],[self.rating,True],[self.discount,True],
               [self.discount,False]]
        return List2[task-1]

    def choicef(self,task):
        List2=[self.brand,self.category,self.name]
        return List2[task-1]
        
    def __str__(self):
        return "Name:"+str(self.name) +"    "+"Cost: Rs."+str(self.cost) +"    "+"Brand: "+self.brand +"    "+"Rating: "+str(self.rating)+"    "+"Discount: "+str(self.discount)+"%"
    
p1=Product(1,"Nokia 1100",1500,"Nokia","Electronics",5,50)
p2=Product(2,"Samsung A6",15000,"Samsung","Electronics",3,40)
p3=Product(3,"LG Washing Machine",12000,"LG","Home Appliance",4,70)
p4=Product(4,"T-shirt",800,"Puma","Fashion",2,80)
p5=Product(5,"Jeans",1200,"Nike","Fashion",2,20)
p6=Product(6,"Sofa",20000,"Oaktree","Furniture",3,40)

task=int(input("Enter 1 to sort price low to high\nEnter 2 to sort price high to low\nEnter 3 to sort rating high to low\nEnter 4 to sort discount low to high\nEnter 5 to sort price high to low\n"))
    
List3=[False,True,True,True,False]
List.sort(key=lambda el:el.choices(task)[0],reverse=List3[task-1])
print("The order of products based on your selection")
for i in List:
    print(i)

task=int(input("Enter 1 to filter by brand\nEnter 2 to filter by category\nEnter 3 to filter by name\n"))

List2=["Brand","Category","Product"]
string1=input("Enter {0} name".format(List2[task-1])).capitalize()

list1=filter(lambda el:el.choicef(task)==string1,List)
print("Products of {0} {1}".format(List2[task-1],string1))
for i in list1:
    print(i)

