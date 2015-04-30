from random import randint
 
n = input("Enter sides: ")
n = int(n)
 
a = randint(1, n)
print("First throw: " + str(a))
 
b = randint(1, n)
print("Second throw: " + str(b))
 
print("Sum: " + str(a + b))
