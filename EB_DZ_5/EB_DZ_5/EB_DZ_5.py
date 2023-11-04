import random
radius1=int(input("Input left limit of the radius: "))
radius2=int(input("Input right limit of the radius: "))
numConfirmed=0
print(f"Input your number in the radius from {radius1} to {radius2}: ")
num=int(input())
while True:
    if num<=radius2 and num>=radius1:
        thought=random.randint(radius1,radius2)
        if radius1==radius2:
            print(f"This cannot be anything but {radius1}!")
            break
        print(f"Is {thought} your number? </>/=")
        resolution=input()
        if resolution=="<":
            radius2=thought-1
            continue
        elif resolution==">":
            radius1=thought+1
            continue
        elif resolution=="=":
            print("I got you!")
            break
    else:
        print("ERROR, why did you do this?")
        break