def second_largest(numbers):
 
    numbers = list(numbers)
    
    for number in numbers:
      number = max(numbers)
      if number == max(numbers):
        numbers.remove(number)
        for number1 in numbers:
          if number1 == max(numbers):
            return number1
     
        
print(second_largest([1,2,3,4,5,6,7,8]))