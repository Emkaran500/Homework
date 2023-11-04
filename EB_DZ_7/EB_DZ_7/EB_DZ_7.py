print("1. Create a function that will display all even numbers from 0 to x. \n")

def EvenNum(num):
    add=0
    while num>=0 and add!=num+1:
        if num>0:
            if add%2==0:
                print(add)
                add+=1
                continue
            else:
                add+=1
    while num<0 and add!=num-1:
        if num<0:
            if add%2==0:
                print(add)
                add-=1
                continue
            else:
                add-=1
    print("\n")

num=int(input("Input your number: "))
EvenNum(num)

print("2. Create a function that will display all odd numbers from 0 to x. \n")

def OddNum(num):
    add=0
    while num>=0 and add!=num+1:
        if num>0:
            if add%2!=0:
                print(add)
                add+=1
                continue
            else:
                add+=1
    while num<0 and add!=num-1:
        if num<0:
            if add%2!=0:
                print(add)
                add-=1
                continue
            else:
                add-=1
    print("\n")

OddNum(num=int(input("Input your number: ")))

print("3. Create a function that will display all prime numbers from x to 0. \n")

def PrimeNum(num):
    add=num
    while add!=1:
        ret=add-1
        while ret!=0:
            if add%ret!=0:
                ret-=1
                continue
            elif ret==1:
                print(add)
                add-=1
                break
            else:
                add-=1
                break

PrimeNum(num=int(input("Input your number: ")))

print("4. Create a function that will display a pyramid of entered lenght")

def Pyra(lenght):
    star="*"
    add=0
    add1=-lenght
    while lenght>=0 and add!=lenght+1:
        print(f"{star*add}")
        add+=1
    while lenght<0 and add1!=0:
        print(f"{star*add1}")
        add1-=1
    print("\n")

Pyra(lenght=int(input("Input your lenght: ")))

print("5. Create a function that will display a triangle of entered lenght")

def Trio(lenght):
    dollar="$"
    space=" "
    add=lenght
    add1=0
    while lenght>=0 and add!=0:
        if add1%2==1:
            print(f"{space*(add)}{dollar*add1}")
            add-=1
            add1+=1
        else:
            add1+=1
    while lenght<0 and add!=0:
        print(f"{space*(add1)}{dollar*((2*(-add))-1)}")
        add+=1
        add1+=1

Trio(lenght=int(input("Input your lenght: ")))