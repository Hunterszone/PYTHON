def count_zero_pairs(numbers):
    
    n = len(numbers)
    
    for i in range(0, n):
        for j in range(i, n):
            x = numbers[i]
            y = numbers[j]
            
            x + y == 0
            
            
        return x and y   


print(count_zero_pairs([0, 2, -2, 5, 10]))
        
