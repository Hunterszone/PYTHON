example = [1, 2, -2, 0, 0, 5, -5]
 
n = len(example)
 
for i in range(0, n):
    for j in range(i + 1, n):
        x = example[i]
        y = example[j]
        if x + y == 0:
            print(x,y)
