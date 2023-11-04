print("1. Po defoltu peremennoy \"var\" zadayotsya nekotoroye znacheniye, proveryayetsya yavlayetsya ona int ili net."+"\n")
var=150
if type(var)==int:
    print("it is integer."+"\n")
if type(var)!=int:
    print("it is not integer."+"\n")

print("2. V programme zarezervirovanni 3 valuti i ix kursi. Polzovatel vvodit kol-vo deneg i pered polzovatelem stavitsya vopros v kakuyu valutu skonvertirovat dengi."+"\n")
USD=0
AZN=0
RUB=0
USDtoAZN=1.7
USDtoRUB=58.09
AZNtoRUB=34.1706
money=float(input("Type in the amount of money: "))
choice=input("Choose the currency: USD/AZN/RUB ")
if choice=="USD":
   USD=money
   choice1=input("Choose the currency you want your money to be converted to: AZN/RUB ")
   if choice1=="AZN":
       USD=USD*USDtoAZN
       print(f"New value of money is {USD} AZN."+"\n")
   if choice1=="RUB":
       USD=USD*USDtoRUB
       print(f"New value of money is {USD} RUB."+"\n")
if choice=="AZN":
    AZN=money
    choice1=input("Choose the currency you want your money to be converted to: USD/RUB ")
    if choice1=="USD":
        AZN=AZN/USDtoAZN
        print(f"New value of money is {AZN} USD."+"\n")
    if choice1=="RUB":
        AZN=AZN*AZNtoRUB
        print(f"New value of money is {AZN} RUB."+"\n")
if choice=="RUB":
    RUB=money
    choice1=input("Choose the currency you want your money to be converted to: USD/AZN ")
    if choice1=="USD":
        RUB=RUB/USDtoRUB
        print(f"New value of money is {RUB} USD."+"\n")
    if choice1=="AZN":
        RUB=RUB/AZNtoRUB
        print(f"New value of money is {RUB} AZN."+"\n")

print("3. Polzovatel vvodit chislo. Esli eto chislo naxoditsya v diapazone ot 1 do 100 - vivesti na ekran sootvetstvuyusheye soobsheniye."+"\n")
number=float(input("Input your number in range from 0 to 100: "))
if number>=0:
    if number<=100:
        print("Success! Your number is in range from 0 to 100.")
    if number>100:
        print("Your number is greater than 100.")
if number<0:
    print("Your number is less than 0.")