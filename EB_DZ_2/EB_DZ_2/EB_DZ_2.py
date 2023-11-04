print("1. Polzovatel vvodit trexznachnoye chislo Konsol vozvrashaet otvet vvide (Your height is ... m ... sm).")
height=int(input())
m=str(height//100)
sm=str(height%100)
print("Your height is "+m+" m "+sm+" sm.")

print("2. Polzovatel vvodit snachala summu potom kurs. Na konsol vixodit denejniy ekvivalent po ukazannomu kursu.")
money=float(input())
exchange=float(input())
money=str(money*exchange)
print("Denejniy ekvivalent: "+money+".")

print("3. Polzovatel vvodit snachala chislo potom procent ot chisla kotoriy nujno budet nayti.")
number=float(input())
percent=float(input())/100
number=str(number*percent)
print("Procent ot chisla raven: "+number+".")