numbers = [2, -2, 5, -5, 0, 10]

n = len(numbers)

for i in range(0, n):
    for j in range(i + 1, n):
        x = numbers[i]
        y = numbers[j]
            
        if x + y == 0:
            print(x, y)
        
