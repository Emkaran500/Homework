print("Create a program to monitor the students.")

def StudentsApp(StudentsListForApp):
    print("1. Show students \n2. Add new Student \n3. Delete Student \n4. Class Info \n5. Exit")
    num=int(input("Input what do you want to do: "))
    print("\n")
    if num==1:
        StIndex=1
        for index in StudentsListForApp:
            print(str(StIndex)+". "+index[0]+"\n")
            StIndex+=1
        return StudentsApp(StudentsListForApp)
    if num==2:
        age="age="
        addSt1=input("Input the student you want to add: ")
        print("\n")
        res=addSt1.isalpha()
        if res==True:
            res=addSt1[0].isupper()
            if res==True:
                addSt2=input("Input age of the student: ")
                print("\n")
                if addSt2.isalpha()==False and int(addSt2)>0 and int(addSt2)<=120:
                    addSt1=[addSt1]
                    addSt2=age+addSt2
                    StudentsListForApp.append(addSt1)
                    addSt1.append(addSt2)
                    return StudentsApp(StudentsListForApp)
                else:
                    print("ERROR \n")
                    return StudentsApp(StudentsListForApp)
            else:
                print("ERROR \n")
                return StudentsApp(StudentsListForApp)
        else:
            print("ERROR \n")
            return StudentsApp(StudentsListForApp)
    if num==3:
        delete=int(input("Input the number of the student you want to delete: "))
        print("\n")
        if delete>len(StudentsListForApp):
            print("ERROR \n")
            return StudentsApp(StudentsListForApp)
        else:
            StudentsListForApp.pop(delete-1)
            print("\n")
            return StudentsApp(StudentsListForApp)
    if num==4:
        StIndex=1
        for index in StudentsListForApp:
            for info in index:
                print(str(StIndex)+". "+ info +"\n")
            StIndex+=1
        return StudentsApp(StudentsListForApp)
    if num==5:
        return StudentsListForApp


StudentsList=[["Emil","age=20"],["Sadiq", "age=19"],["Elnur", "age=34"],["Aydin", "age=25"],["Asima", "age=17"]]
StudentsApp(StudentsListForApp=StudentsList)