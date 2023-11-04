print("1. Create a function with 2 arguments first of which will return number of repeats in the second.")
def Repeat(text, search):
    return text.count(search)

print(Repeat(text=input("Input the text: "), search=input("Input the searchable letters: ")))
print("\n")

print("2. Create a function that will show if the variable is a number.")
def Verify(var):
    return var.isdecimal()

print(Verify(var=input("Input numbers or letters: ")))
print("\n")

print("3. Create a function that will ask the user to type in text until it will end with \".\"")
def Ending(text):
    if text.endswith("."):
        return "Thank you."
    else:
        return Ending(text=input("Input the text that ends with \".\": "))

print(Ending(text=input("Input the text that ends with \".\": ")))