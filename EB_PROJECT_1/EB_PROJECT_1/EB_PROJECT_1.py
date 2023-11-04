import random
print("Welcome to \"The Millionaire!\"")
print("The game \"Millionaire\" consists of 7 questions.")
print("1 question = 1000$  \n2 question = 5000$ \n3 question = 10000$ \n4 question = 100000$ \n5 question = 250000$ \n6 question = 500000$ \n7 question = 1000000$")
fireproof=int(input("Please choose your fireproof question 1/2/3/4/5/6 "))
print("\n")
print("___________________________________________________________________________________________________________")

solutions=0
helpFriend=False
helpAud=False
helpHalf=False

if fireproof==1:
    prize=1000
elif fireproof==2:
    prize=5000
elif fireproof==3:
    prize=10000
elif fireproof==4:
    prize=100000
elif fireproof==5:
    prize=250000
elif fireproof==6:
    prize=500000

q1_q="The first city in history to achieve 1 million population? \n"
q1_a1="Rome"
q1_a2="Paris"
q1_a3="Moscow"
q1_a4="Baku"
q1_right="Rome"

q2_q="What country was the first to sent sattelite into space? \n"
q2_a1="USSR"
q2_a2="USA"
q2_a3="UAE"
q2_a4="UK"
q2_right="USSR"

q3_q="What do we call the closest star to the Earth? \n"
q3_a1="Sun"
q3_a2="Proxima Centauri"
q3_a3="Polar"
q3_a4="Earendel"
q3_right="Sun"

q4_q="What part of the world Columbus tried to make his way to? \n"
q4_a1="India"
q4_a2="China"
q4_a3="North America"
q4_a4="South America"
q4_right="India"

q5_q="What colour is Shrek's skin? \n"
q5_a1="Green"
q5_a2="White"
q5_a3="Black"
q5_a4="Yellow"
q5_right="Green"

q6_q="Which chemical element was named after underground evil gnome?"
q6_a1="Cobalt"
q6_a2="Hafnium"
q6_a3="Beryllium"
q6_a4="Tellurium"
q6_right="Cobalt"

q7_q="Which type of cavalry could fight both in the saddle and on foot?"
q7_a1="Dragoons"
q7_a2="Lancers"
q7_a3="Cuirassiers"
q7_a4="Hussars"
q7_right="Dragoons"

q1=[q1_q, q1_right, q1_a1, q1_a2, q1_a3, q1_a4]
q2=[q2_q, q2_right, q2_a1, q2_a2, q2_a3, q2_a4]
q3=[q3_q, q3_right, q3_a1, q3_a2, q3_a3, q3_a4]
q4=[q4_q, q4_right, q4_a1, q4_a2, q4_a3, q4_a4]
q5=[q5_q, q5_right, q5_a1, q5_a2, q5_a3, q5_a4]
q6=[q6_q, q6_right, q6_a1, q6_a2, q6_a3, q6_a4]
q7=[q7_q, q7_right, q7_a1, q7_a2, q7_a3, q7_a4]

qVar=0

def AppQuestion(helpFriend,helpAud,helpHalf,solutions):
    if solutions==0:
        qVar=q1
    elif solutions==1:
        qVar=q2
    elif solutions==2:
        qVar=q3
    elif solutions==3:
        qVar=q4
    elif solutions==4:
        qVar=q5
    elif solutions==5:
        qVar=q6
    elif solutions==6:
        qVar=q7

    def RandomForAnswers():
        for x in qVar:
            y=qVar.index(x)
            if y>=2:
                tmp=0
                if len(qVar)==6:
                    rand=random.randint(0,100)
                    if rand<=25:
                        tmp=qVar[2]
                        qVar[2]=qVar[y]
                        qVar[y]=tmp
                    elif rand<=50:
                        tmp=qVar[3]
                        qVar[3]=qVar[y]
                        qVar[y]=tmp
                    elif rand<=75:
                        tmp=qVar[4]
                        qVar[4]=qVar[y]
                        qVar[y]=tmp
                    elif rand<=100:
                        tmp=qVar[5]
                        qVar[5]=qVar[y]
                        qVar[y]=tmp
                else:
                    rand=random.randint(0,50)
                    if rand<=25:
                        tmp=qVar[2]
                        qVar[2]=qVar[y]
                        qVar[y]=tmp
                    elif rand<=50:
                        tmp=qVar[3]
                        qVar[3]=qVar[y]
                        qVar[y]=tmp
            else:
                continue
            
    RandomForAnswers()
    index=-1
    for question in qVar:
        if index>=1:
            print(str(index)+". "+question)
            index+=1
        elif index==-1:
            print(question)
            index+=1
        else:
            index+=1
    print("\n")
    if helpFriend==False:
            print("You still have help of your friend! Just type \"f\" if you want his help! \n")
    if helpAud==False:
            print("You still have help of the audience! Just type \"a\" if you want their help! \n")
    if helpHalf==False:
            print("You can choose 50/50! Just type \"h\" if you want this help! \n")
    answer=input()
    if answer=="f" and helpFriend==False:
        print("___________________________________________________________________________________________________________")
        helpFriend=True
        if helpHalf==False:
            askFriend=random.randint(0,100)
            while True:
                if askFriend>=40 and askFriend<=100:
                    print(f"Hi friend! I think the correct answer is {qVar[1]}! \n")
                    return AppQuestion(helpFriend,helpAud,helpHalf,solutions)
                else:
                    if helpHalf==0:
                        rand=random.randint(1,3)
                    if rand==1 and qVar[1]!=qVar[2]:
                        print(f"Hi friend! I think the correct answer is {qVar[2]}! \n")
                        return AppQuestion(helpFriend,helpAud,helpHalf,solutions)
                    elif rand==2 and qVar[1]!=qVar[3]:
                        print(f"Hi friend! I think the correct answer is {qVar[3]}! \n")
                        return AppQuestion(helpFriend,helpAud,helpHalf,solutions)
                    elif rand==3 and qVar[1]!=qVar[4]:
                        print(f"Hi friend! I think the correct answer is {qVar[4]}! \n")
                        return AppQuestion(helpFriend,helpAud,helpHalf,solutions)
                    else:
                        continue
        else:
            askFriend=random.randint(0,50)
            if askFriend>=30 and askFriend<=50:
                print(f"Hi friend! I think the correct answer is {qVar[1]}! \n")
                return AppQuestion(helpFriend,helpAud,helpHalf,solutions)
            else:
                if qVar[1]!=qVar[2]:
                    print(f"Hi friend! I think the correct answer is {qVar[2]}! \n")
                elif qVar[1]!=qVar[3]:
                    print(f"Hi friend! I think the correct answer is {qVar[3]}! \n")

    elif answer=="a" and helpAud==False:
        print("___________________________________________________________________________________________________________")
        helpAud=True
        if helpHalf==False:
            askAud1=random.randint(40,100)
            askAud2=random.randint(0,100-askAud1)
            askAud3=random.randint(0,100-askAud1-askAud2)
            askAud4=random.randint(100-askAud1-askAud2-askAud3,100-askAud1-askAud2-askAud3)
            identificator1=False
            identificator2=False
            tmp=qVar[1]
            qVar.pop(1)
            print("The percent of audience that thinks the answer is correct...")
            for x in qVar:
                while True:
                    a=random.randint(0,100)
                    b=random.randint(0,100)
                    c=random.randint(0,100)
                    y=qVar.index(x)
                    if y>=1:
                        if qVar[y]==tmp:
                            print(qVar[y]+": "+str(askAud1)+"%")
                            break
                        else:
                            if a>=b and a>=c and identificator1==False:
                                print(qVar[y]+": "+str(askAud2)+"%")
                                identificator1=True
                                break
                            elif b>a and b>=c and identificator2==False:
                                print(qVar[y]+": "+str(askAud3)+"%")
                                identificator2=True
                                break
                            elif c>a and c>b:
                                print(qVar[y]+": "+str(askAud4)+"%")
                                break
                            else:
                                continue
                    else:
                        break
            qVar.insert(1,tmp)
            print("\n")
            return AppQuestion(helpFriend,helpAud,helpHalf,solutions)
        else:
            askAud1=random.randint(50,100)
            askAud2=random.randint(100-askAud1,100-askAud1)
            tmp=qVar[1]
            qVar.pop(1)
            print("The percent of audience that thinks the answer is correct...")
            for x in qVar:
                while True:
                    y=qVar.index(x)
                    if y>=1:
                        if qVar[y]==tmp:
                            print(qVar[y]+": "+str(askAud1)+"%")
                            break
                        else:
                            print(qVar[y]+": "+str(askAud2)+"%")
                            break
                    else:
                        break
            qVar.insert(1,tmp)
            print("\n")
            return AppQuestion(helpFriend,helpAud,helpHalf,solutions)
            
    elif answer=="h" and helpHalf==False:
        print("___________________________________________________________________________________________________________")
        helpHalf=True
        while len(qVar)>4:
            rand=random.randint(2,len(qVar)-1)
            if qVar[rand]==qVar[1]:
                continue
            else:
                qVar.pop(rand)
        return AppQuestion(helpFriend,helpAud,helpHalf,solutions)
    elif answer=="1" and qVar[1]==qVar[2]:
        solutions+=1
        if solutions==7:
            print("CONGRATULATIONS! YOU HAVE WON 1000000$!")
        else:
            print("You are correct! To the next question! \n")
            return AppQuestion(helpFriend,helpAud,helpHalf,solutions)
    elif answer=="2" and qVar[1]==qVar[3]:
        solutions+=1
        if solutions==7:
            print("CONGRATULATIONS! YOU HAVE WON 1000000$!")
        else:
            print("You are correct! To the next question! \n")
            return AppQuestion(helpFriend,helpAud,helpHalf,solutions)
    elif answer=="3" and qVar[1]==qVar[4]:
        solutions+=1
        if solutions==7:
            print("CONGRATULATIONS! YOU HAVE WON 1000000$!")
        else:
            print("You are correct! To the next question! \n")
            return AppQuestion(helpFriend,helpAud,helpHalf,solutions)
    elif answer=="4" and qVar[1]==qVar[5]:
        solutions+=1
        if solutions==7:
            print("CONGRATULATIONS! YOU HAVE WON 1000000$!")
        else:
            print("You are correct! To the next question! \n")
            return AppQuestion(helpFriend,helpAud,helpHalf,solutions)
    else:
        if fireproof<=solutions:
            print(f"Wrong! Sorry, your prize is {prize}$! Congratz!")
        else:
            print("Wrong! Better luck next time!")

try:
    AppQuestion(helpFriend,helpAud,helpHalf,solutions)
except:
    AppQuestion(helpFriend,helpAud,helpHalf,solutions)