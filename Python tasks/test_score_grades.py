a = input("Score_test = ")
a = int(a)
 
if a in range(0, 101):
    if a in range(0, 51):
        print("E grade")
    if a in range(51, 61):
        print("D grade")
    if a in range(61, 71):
        print("C grade")
    if a in range(71, 81):
        print("B grade")
    if a in range(81, 100):
        print("A grade")
    if a == 100:
        print("A+ grade")
