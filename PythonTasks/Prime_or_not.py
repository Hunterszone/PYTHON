n = input ("Enter num ")
n = int(n)

if  n != 0 and n % 2 != 0:
    print ("Is prime")
    n = n + 1
elif n == 2 or n == -2:
    print ("Is prime")
else:
    print ("Is NOT prime")
    
