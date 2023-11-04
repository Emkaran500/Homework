import random
print("Welcome to \"The Millionaire!\"")
print("The game \"Millionaire\" consists of 5 questions.")
print("1 question = 1000$  \n2 question = 10000$ \n3 question = 100000$ \n4 question = 500000$ \n5 question = 1000000$")
fireproof=int(input("Please choose your fireproof question 1/2/3/4 "))
print("\n")
print("___________________________________________________________________________________________________________")
questions=0
helpFriend=0
helpAud=0
helpHalf=0
if fireproof==1:
    prize=1000
elif fireproof==2:
    prize=10000
elif fireproof==3:
    prize=100000
elif fireproof==4:
    prize=500000
q1="a. Paris   b. Rome   c. Moscow   d. Baku \n"
q2="a. USSR   b. USA   c. UAE   d. UK \n"
q3="a. Proxima Centauri   b. Sun   c. Polar   d. Earendel \n"
q4="a. North America   b. South America   c. China   d. India \n"
q5="a. Yellow   b. White   c. Green   d. Black \n"
while True:
    if questions==0:
        print("The first city in history to achieve 1 million population? \n")
        print(q1)
        if helpFriend==0:
            print("You still have help of your friend! Just type \"1\" if you want his help! \n")
        if helpAud==0:
            print("You still have help of the audience! Just type \"2\" if you want their help! \n")
        if helpHalf==0:
            print("You can choose 50/50! Just type \"3\" if you want this help! \n")
        answer=input()
        if answer=="1" and helpFriend==0:
            print("___________________________________________________________________________________________________________")
            helpFriend+=1
            askFriend=random.randint(0,100)
            if askFriend>=20 and askFriend<=100:
                print("Hi friend! I think the correct answer is b! \n")
                continue
            elif askFriend<20:
                if helpHalf==0:
                    rand=random.randint(1,3)
                    if rand=="1":
                        print("Hi friend! I think the correct answer is a! \n")
                        continue
                    elif rand=="2":
                        print("Hi friend! I think the correct answer is c! \n")
                        continue
                    elif rand=="3":
                        print("Hi friend! I think the correct answer is d! \n")
                        continue
                elif helpHalf==1:
                    print(f"Hi friend! I think the correct answer is {askHalfAdd}! \n")
        elif answer=="2" and helpAud==0:
            print("___________________________________________________________________________________________________________")
            if helpHalf==1:
                helpAud+=1
                askAud1=random.randint(50,100)
                askAud2=random.randint(100-askAud1,100-askAud1)
                if askHalfAdd=="a":
                    print("The percent of audience that thinks the answer is correct...")
                    print(f"{askHalfAdd}={askAud2}   b={askAud1} \n")
                elif askHalfAdd=="c" or askHalfAdd=="d":
                    print("The percent of audience that thinks the answer is correct...")
                    print(f"b={askAud1}   {askHalfAdd}={askAud2} \n")
            elif helpHalf==0:
                helpAud+=1
                askAud1=random.randint(50,100)
                askAud2=random.randint(0,100-askAud1)
                askAud3=random.randint(0,100-askAud1-askAud2)
                askAud4=random.randint(100-askAud1-askAud2-askAud3,100-askAud1-askAud2-askAud3)
                a=random.randint(0,100)
                b=random.randint(0,100)
                c=random.randint(0,100)
                if a>=b and a>=c:
                    a=askAud2
                    if b>=c:
                        b=askAud3
                        c=askAud4
                    else:
                        c=askAud3
                        b=askAud4
                elif a<b and a>=c:
                    a=askAud3
                    if b>=c:
                        b=askAud2
                        c=askAud4
                    else:
                        c=askAud2
                        b=askAud4
                elif a<b and a<c:
                    a=askAud4
                    if b>=c:
                        b=askAud2
                        c=askAud3
                    else:
                        c=askAud2
                        b=askAud3
                print("The percent of audience that thinks the answer is correct...")
                print(f"a={a} b={askAud1} c={b} d={c} \n")
        elif answer=="3" and helpHalf==0:
            print("___________________________________________________________________________________________________________")
            helpHalf+=1
            askHalf=random.randint(1,3)
            if askHalf==1:
                askHalf="a. Paris"
                askHalfAdd="a"
            elif askHalf==2:
                askHalf=="c. Moscow"
                askHalfAdd="c"
            elif askHalf==3:
                askHalf="d. Baku"
                askHalfAdd="d"
            if askHalf=="a. Paris":
                q1=f"{askHalf}   b. Rome \n"
            elif askHalf=="c. Moscow" or askHalf=="d. Baku":
                q1=f"b. Rome   {askHalf} \n"
        elif answer=="a" or answer=="c" or answer=="d":
            print("Wow, you lost on question one! Better luck next time!")
            break
        elif answer=="b":
            print("You are correct! To the next question! \n")
            print("___________________________________________________________________________________________________________")
            questions+=1
            continue
        else:
            print("I don't understand anything you do... Well bad for you!")
            break
    elif questions==1:
        print("The next question is...")
        print("What country was the first to sent sattelite into space? \n")
        print(q2)
        if helpFriend==0:
            print("You still have help of your friend! Just type \"1\" if you want his help! \n")
        if helpAud==0:
            print("You still have help of the audience! Just type \"2\" if you want their help! \n")
        if helpHalf==0:
            print("You can choose 50/50! Just type \"3\" if you want this help! \n")
        answer=input()
        if answer=="1" and helpFriend==0:
            print("___________________________________________________________________________________________________________")
            helpFriend+=1
            askFriend=random.randint(0,100)
            if askFriend>=40 and askFriend<=100:
                print("Hi friend! I think the correct answer is a! \n")
                continue
            elif askFriend<=40:
                if helpHalf==0:
                    rand=random.randint(1,3)
                    if rand=="1":
                        print("Hi friend! I think the correct answer is b! \n")
                        continue
                    elif rand=="2":
                        print("Hi friend! I think the correct answer is c! \n")
                        continue
                    elif rand=="3":
                        print("Hi friend! I think the correct answer is d! \n")
                        continue
                elif helpHalf==1:
                    print(f"Hi friend! I think the correct answer is {askHalfAdd}! \n")
        elif answer=="2" and helpAud==0:
            print("___________________________________________________________________________________________________________")
            if helpHalf==1:
                helpAud+=1
                askAud1=random.randint(50,100)
                askAud2=random.randint(100-askAud1,100-askAud1)
                print("The percent of audience that thinks the answer is correct...")
                print(f"a={askAud1}   {askHalfAdd}={askAud2} \n")
            elif helpHalf==0:
                helpAud+=1
                askAud1=random.randint(45,100)
                askAud2=random.randint(0,100-askAud1)
                askAud3=random.randint(0,100-askAud1-askAud2)
                askAud4=random.randint(100-askAud1-askAud2-askAud3,100-askAud1-askAud2-askAud3)
                a=random.randint(0,100)
                b=random.randint(0,100)
                c=random.randint(0,100)
                if a>=b and a>=c:
                    a=askAud2
                    if b>=c:
                        b=askAud3
                        c=askAud4
                    else:
                        c=askAud3
                        b=askAud4
                elif a<b and a>=c:
                    a=askAud3
                    if b>=c:
                        b=askAud2
                        c=askAud4
                    else:
                        c=askAud2
                        b=askAud4
                elif a<b and a<c:
                    a=askAud4
                    if b>=c:
                        b=askAud2
                        c=askAud3
                    else:
                        c=askAud2
                        b=askAud3
                print("The percent of audience that thinks the answer is correct...")
                print(f"a={askAud1} b={a} c={b} d={c} \n")
        elif answer=="3" and helpHalf==0:
            print("___________________________________________________________________________________________________________")
            helpHalf+=1
            askHalf=random.randint(1,3)
            if askHalf==1:
                askHalf="b. USA"
                askHalfAdd="b"
            elif askHalf==2:
                askHalf=="c. UAE"
                askHalfAdd="c"
            elif askHalf==3:
                askHalf="d. UK"
                askHalfAdd="d"
                q1=f"a. USSR   {askHalf} \n"
        elif answer=="b" or answer=="c" or answer=="d":
            if fireproof<=questions:
                print(f"Sorry, wrong answer! But you still got {prize}$!")
                break
            else:
                print("Wrong! Better luck next time!")
                break
        elif answer=="a":
            print("You are correct! To the next question! \n")
            print("___________________________________________________________________________________________________________")
            questions+=1
            continue
        else:
            print("I don't understand anything you do... Well bad for you!")
            break
    elif questions==2:
        print("The next question is...")
        print("What do we call the closest star to the Earth? \n")
        print(q3)
        if helpFriend==0:
            print("You still have help of your friend! Just type \"1\" if you want his help! \n")
        if helpAud==0:
            print("You still have help of the audience! Just type \"2\" if you want their help! \n")
        if helpHalf==0:
            print("You can choose 50/50! Just type \"3\" if you want this help! \n")
        answer=input()
        if answer=="1" and helpFriend==0:
            print("___________________________________________________________________________________________________________")
            helpFriend+=1
            askFriend=random.randint(0,100)
            if askFriend>=55 and askFriend<=100:
                print("Hi friend! I think the correct answer is b! \n")
                continue
            elif askFriend<=55:
                if helpHalf==0:
                    rand=random.randint(1,3)
                    if rand=="1":
                        print("Hi friend! I think the correct answer is a! \n")
                        continue
                    elif rand=="2":
                        print("Hi friend! I think the correct answer is c! \n")
                        continue
                    elif rand=="3":
                        print("Hi friend! I think the correct answer is d! \n")
                        continue
                elif helpHalf==1:
                    print(f"Hi friend! I think the correct answer is {askHalfAdd}! \n")
        elif answer=="2" and helpAud==0:
            print("___________________________________________________________________________________________________________")
            if helpHalf==1:
                helpAud+=1
                askAud1=random.randint(50,100)
                askAud2=random.randint(100-askAud1,100-askAud1)
                if askHalfAdd=="a":
                    print("The percent of audience that thinks the answer is correct...")
                    print(f"{askHalfAdd}={askAud2}   b={askAud1} \n")
                elif askHalfAdd=="c" or askHalfAdd=="d":
                    print("The percent of audience that thinks the answer is correct...")
                    print(f"b={askAud1}   {askHalfAdd}={askAud2} \n")
            elif helpHalf==0:
                helpAud+=1
                askAud1=random.randint(40,100)
                askAud2=random.randint(0,100-askAud1)
                askAud3=random.randint(0,100-askAud1-askAud2)
                askAud4=random.randint(100-askAud1-askAud2-askAud3,100-askAud1-askAud2-askAud3)
                a=random.randint(0,100)
                b=random.randint(0,100)
                c=random.randint(0,100)
                if a>=b and a>=c:
                    a=askAud2
                    if b>=c:
                        b=askAud3
                        c=askAud4
                    else:
                        c=askAud3
                        b=askAud4
                elif a<b and a>=c:
                    a=askAud3
                    if b>=c:
                        b=askAud2
                        c=askAud4
                    else:
                        c=askAud2
                        b=askAud4
                elif a<b and a<c:
                    a=askAud4
                    if b>=c:
                        b=askAud2
                        c=askAud3
                    else:
                        c=askAud2
                        b=askAud3
                print("The percent of audience that thinks the answer is correct...")
                print(f"a={a} b={askAud1} c={b} d={c} \n")
        elif answer=="3" and helpHalf==0:
            print("___________________________________________________________________________________________________________")
            helpHalf+=1
            askHalf=random.randint(1,3)
            if askHalf==1:
                askHalf="a. Proxima Centauri"
                askHalfAdd="a"
            elif askHalf==2:
                askHalf=="c. Polar"
                askHalfAdd="c"
            elif askHalf==3:
                askHalf="d. Earandel"
                askHalfAdd="d"
            if askHalf=="a. Proxima Centauri":
                q1=f"{askHalf}   b. Sun \n"
            elif askHalf=="c. Polar" or askHalf=="d. Earandel":
                q1=f"b. Sun   {askHalf} \n"
        elif answer=="a" or answer=="c" or answer=="d":
            if fireproof<=questions:
                print(f"Sorry, wrong answer! But you still got {prize}$!")
                break
            else:
                print("Wrong! Better luck next time!")
                break
        elif answer=="b":
            print("You are correct! To the next question! \n")
            print("___________________________________________________________________________________________________________")
            questions+=1
            continue
        else:
            print("I don't understand anything you do... Well bad for you!")
            break
    elif questions==3:
        print("The next question is...")
        print("What part of the world Columbus tried to make his way to? \n")
        print(q4)
        if helpFriend==0:
            print("You still have help of your friend! Just type \"1\" if you want his help! \n")
        if helpAud==0:
            print("You still have help of the audience! Just type \"2\" if you want their help! \n")
        if helpHalf==0:
            print("You can choose 50/50! Just type \"3\" if you want this help! \n")
        answer=input()
        if answer=="1" and helpFriend==0:
            print("___________________________________________________________________________________________________________")
            helpFriend+=1
            askFriend=random.randint(0,100)
            if askFriend>=65 and askFriend<=100:
                print("Hi friend! I think the correct answer is d! \n")
                continue
            elif askFriend<=65:
                if helpHalf==0:
                    rand=random.randint(1,3)
                    if rand=="1":
                        print("Hi friend! I think the correct answer is a! \n")
                        continue
                    elif rand=="2":
                        print("Hi friend! I think the correct answer is b! \n")
                        continue
                    elif rand=="3":
                        print("Hi friend! I think the correct answer is c! \n")
                        continue
                elif helpHalf==1:
                    print(f"Hi friend! I think the correct answer is {askHalfAdd}! \n")
        elif answer=="2" and helpAud==0:
            print("___________________________________________________________________________________________________________")
            if helpHalf==1:
                helpAud+=1
                askAud1=random.randint(50,100)
                askAud2=random.randint(100-askAud1,100-askAud1)
                print("The percent of audience that thinks the answer is correct...")
                print(f"{askHalfAdd}={askAud2}   d={askAud1} \n")
            elif helpHalf==0:
                helpAud+=1
                askAud1=random.randint(30,100)
                askAud2=random.randint(0,100-askAud1)
                askAud3=random.randint(0,100-askAud1-askAud2)
                askAud4=random.randint(100-askAud1-askAud2-askAud3,100-askAud1-askAud2-askAud3)
                a=random.randint(0,100)
                b=random.randint(0,100)
                c=random.randint(0,100)
                if a>=b and a>=c:
                    a=askAud2
                    if b>=c:
                        b=askAud3
                        c=askAud4
                    else:
                        c=askAud3
                        b=askAud4
                elif a<b and a>=c:
                    a=askAud3
                    if b>=c:
                        b=askAud2
                        c=askAud4
                    else:
                        c=askAud2
                        b=askAud4
                elif a<b and a<c:
                    a=askAud4
                    if b>=c:
                        b=askAud2
                        c=askAud3
                    else:
                        c=askAud2
                        b=askAud3
                print("The percent of audience that thinks the answer is correct...")
                print(f"a={a} b={b} c={c} d={askAud1} \n")
        elif answer=="3" and helpHalf==0:
            print("___________________________________________________________________________________________________________")
            helpHalf+=1
            askHalf=random.randint(1,3)
            if askHalf==1:
                askHalf="a. North America"
                askHalfAdd="a"
            elif askHalf==2:
                askHalf=="b. South America"
                askHalfAdd="b"
            elif askHalf==3:
                askHalf="c. China"
                askHalfAdd="c"
                q1=f"{askHalf}   d. India \n"
        elif answer=="a" or answer=="b" or answer=="c":
            if fireproof<=questions:
                print(f"Sorry, wrong answer! But you still got {prize}$!")
                break
            else:
                print("Wrong! Better luck next time!")
                break
        elif answer=="d":
            print("You are correct! To the next question! \n")
            print("___________________________________________________________________________________________________________")
            questions+=1
            continue
        else:
            print("I don't understand anything you do... Well bad for you!")
            break
    elif questions==4:
        print("The next question is...")
        print("What colour is Shrek's skin? \n")
        print(q5)
        if helpFriend==0:
            print("You still have help of your friend! Just type \"1\" if you want his help! \n")
        if helpAud==0:
            print("You still have help of the audience! Just type \"2\" if you want their help! \n")
        if helpHalf==0:
            print("You can choose 50/50! Just type \"3\" if you want this help! \n")
        answer=input()
        if answer=="1" and helpFriend==0:
            print("___________________________________________________________________________________________________________")
            helpFriend+=1
            askFriend=random.randint(0,100)
            if askFriend>=70 and askFriend<=100:
                print("Hi friend! I think the correct answer is c! \n")
                continue
            elif askFriend<=70:
                if helpHalf==0:
                    rand=random.randint(1,3)
                    if rand=="1":
                        print("Hi friend! I think the correct answer is a! \n")
                        continue
                    elif rand=="2":
                        print("Hi friend! I think the correct answer is b! \n")
                        continue
                    elif rand=="3":
                        print("Hi friend! I think the correct answer is d! \n")
                        continue
                elif helpHalf==1:
                    print(f"Hi friend! I think the correct answer is {askHalfAdd}! \n")
        elif answer=="2" and helpAud==0:
            print("___________________________________________________________________________________________________________")
            if helpHalf==1:
                helpAud+=1
                askAud1=random.randint(50,100)
                askAud2=random.randint(100-askAud1,100-askAud1)
                if askHalfAdd=="a" or askHalfAdd=="b":
                    print("The percent of audience that thinks the answer is correct...")
                    print(f"{askHalfAdd}={askAud2}   c={askAud1} \n")
                elif askHalfAdd=="d":
                    print("The percent of audience that thinks the answer is correct...")
                    print(f"c={askAud1}   {askHalfAdd}={askAud2} \n")
            elif helpHalf==0:
                helpAud+=1
                askAud1=random.randint(20,100)
                askAud2=random.randint(0,100-askAud1)
                askAud3=random.randint(0,100-askAud1-askAud2)
                askAud4=random.randint(100-askAud1-askAud2-askAud3,100-askAud1-askAud2-askAud3)
                a=random.randint(0,100)
                b=random.randint(0,100)
                c=random.randint(0,100)
                if a>=b and a>=c:
                    a=askAud2
                    if b>=c:
                        b=askAud3
                        c=askAud4
                    else:
                        c=askAud3
                        b=askAud4
                elif a<b and a>=c:
                    a=askAud3
                    if b>=c:
                        b=askAud2
                        c=askAud4
                    else:
                        c=askAud2
                        b=askAud4
                elif a<b and a<c:
                    a=askAud4
                    if b>=c:
                        b=askAud2
                        c=askAud3
                    else:
                        c=askAud2
                        b=askAud3
                print("The percent of audience that thinks the answer is correct...")
                print(f"a={a} b={b} c={askAud1} d={c} \n")
        elif answer=="3" and helpHalf==0:
            print("___________________________________________________________________________________________________________")
            helpHalf+=1
            askHalf=random.randint(1,3)
            if askHalf==1:
                askHalf="a. Yellow"
                askHalfAdd="a"
            elif askHalf==2:
                askHalf=="b. White"
                askHalfAdd="b"
            elif askHalf==3:
                askHalf="d. Black"
                askHalfAdd="d"
            if askHalf=="a. Yellow" or askHalf=="b. White":
                q1=f"{askHalf}   c. Green \n"
            elif askHalf=="d. Black":
                q1=f"c. Green   {askHalf} \n"
        elif answer=="a" or answer=="b" or answer=="d":
            if fireproof<=questions:
                print(f"Sorry, wrong answer! But you still got {prize}$!")
                break
            else:
                print("Wrong! Better luck next time!")
                break
        elif answer=="c":
            print("CONGRATULATIONS! You have won \"The Millioner\" game!")
            print(f"Your prize is 1000000$!")
            print("___________________________________________________________________________________________________________")
            break
        else:
            print("I don't understand anything you do... Well bad for you!")
            break