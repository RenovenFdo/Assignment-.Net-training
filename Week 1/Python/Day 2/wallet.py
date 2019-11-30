def createwallet(balance, user, upin):
    def deposit(amt, pin):
        if upin != pin:
            print("You have entered a wrong pin")
            return
        nonlocal balance
        balance += amt
        print("Deposited amount= ", amt, " ", user, " your balance is ", balance)

    def withdraw(amt, pin):
        if upin != pin:
            print("You have entered a wrong pin")
            return
        nonlocal balance
        if balance > amt:
            balance -= amt
            print("Withdrawn amount= ", amt, " ", user, " your balance is ", balance)
        else:
            print(user, " you don't have sufficient balance")

    def showbalance(pin):
        if upin != pin:
            print("You have entered a wrong pin")
            return
        print(user, " your balance is ", balance)

    def transfer(amt, user, pin):
        if upin != pin:
            print("You have entered a wrong pin")
            return
        nonlocal balance
        balance -= amt
        print("Rs.", amt, " is transferred from your account")
        user["deposit"](amt, pin)

    return {"deposit": deposit, "withdraw": withdraw, "showbalance": showbalance, "transfer": transfer}


user1 = createwallet(1000, "Renoven", 4343)
user2 = createwallet(2000, "Kakashi", 3434)
user3 = createwallet(3000, "Itachi", 1919)
user1["deposit"](100, 4343)
user1["withdraw"](400, 1111)
user1["deposit"](500, 4343)
user1["showbalance"](4343)
user2["deposit"](100, 3434)
user2["withdraw"](4000, 3434)
user2["deposit"](500, 8788)
user2["showbalance"](3434)
user3["deposit"](100, 1919)
user3["withdraw"](400, 1919)
user3["deposit"](500, 7676)
user3["showbalance"](1919)
user3["transfer"](500, user1, 1919)
user1["showbalance"](4444)
user3["showbalance"](1919)
