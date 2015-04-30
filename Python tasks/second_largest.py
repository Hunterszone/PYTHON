def second_largest(numbers):
 
    numbers = list(numbers)
    
    for number in numbers:
        number = max(numbers)
        
    for number1 in numbers:
        number1 = min(numbers)
        
    if number == number1 or len(numbers) == 1:
        
        return False
    
    else:
        
        return number1
        
print(second_largest([1,3,3]))
