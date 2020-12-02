print("Dano: y(x)= Ln(d)/|B^2-a^2|Sin(c)");


d = float(input("d = "))
b = float(input("b = "))
a = float(input("a = "))
c = float(input("c = "))



if b == 0 and a == 0 or c == 0 or c == 180 or d < 0:
    print ("Function no exist")
else:
    print ("Function exist")

            