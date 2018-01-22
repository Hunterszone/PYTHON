numbers = [1,2,3,4,5]
 
n = len(numbers)
 
a = 1
 
a += 1
 
prime = (a ** 2) + 1
 
for i in range(0, n):
    for j in range(i, n):
        x = numbers[i]
        y = numbers[j]
       
        if (x + y) is prime:
            print(x, y)
