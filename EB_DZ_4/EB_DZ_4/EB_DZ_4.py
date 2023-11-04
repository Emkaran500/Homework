print("1. Calculate the factorial of number.")
num=int(input("Input your number: "))
result=1
if num>=0:
    while num>0:
        result*=num
        num=num-1
    if num==0:
        print(f"Factorial of your number is '{result}'")
else:
    print("Your factorial cannot be calculated.")

print("2. Calculate the sum of all numbers before your number including your number.")
num1=int(input("Input your number: "))
result1=0
if num1>0:
    while num1!=0:
        result1+=num1
        num1=num1-1
elif num1==0:
    print(f"The sum of your number is '{result1}'")
else:
    while num1!=0:
        result1+=num1
        num1=num1+1
print(f"The sum of your number is '{result1}'")

print("3. Input first number and display all numbers before first number that are multiples of the second number.")
chislo1=int(input("Input first number: "))
chislo2=int(input("Input second number: "))
addon=1
if chislo2==0:
    print("You cannot divide by 0!")
else:
    while addon<=chislo1:
        if addon%chislo2==0:
            print(f"{addon}")
            addon=addon+1
        else:
            addon=addon+1

print("4. User inputs his nickname and password, if it is incorrect he should have an option to try again.")
nickname=input("Input your nickname: ")
password=input("Input your password: ")
if nickname=="step_guest" and password=="guest8877":
    print("You are in!")
else:
    while nickname!="step_guest" and password!="guest8877":
        print("Your nickname or password is incorrect. Would you like to try again? y/n")
        invalid=input()
        if invalid=="y":
            nickname=input("Input your nickname: ")
            password=input("Input your password: ")
            continue
        elif invalid=="n":
            print("Goodbye!")
            break
        else:
            print("ERROR")
            continue
    if nickname=="step_guest" and password=="guest8877":
        print("You are in!")