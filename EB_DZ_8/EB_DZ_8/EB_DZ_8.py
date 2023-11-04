print("1. Create a function that will display the amount of prime numbers in radius from 0 to x.")
def PrimeNum(num):
    add=num
    count=0
    while add!=1:
        ret=add-1
        while ret!=0:
            if add%ret!=0:
                ret-=1
                continue
            elif ret==1:
                count+=1
                add-=1
                break
            else:
                add-=1
                break
    print(f"The amount of prime numbers is {count}. \n")

PrimeNum(num=int(input("Input your number: ")))

print("2. Create a function that returns a factorial of a inputted number through recursion.")
def Factorial(num):
    if num>=1:
        return num*Factorial(num-1)
    elif num==0:
        return 1
    else:
        return "Not defined"

print(Factorial(num=int(input("Input your number: "))))
print("\n")

print("3. Create a function that returns all even numbers from 0 to x through recursion.")
def EvenNum(num, add):
    if add<=num:
        if add%2==0:
            print(add)
            return EvenNum(num, add+1)
        else:
            return EvenNum(num, add+1)

EvenNum(num=int(input("Input your number: ")), add=0)