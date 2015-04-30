import math
 
def fact_digits(number):
    
    total_sum = 0
 
    while number != 0:
    
        digit = number % 10
        total_sum += digit
        number = number // 10
 
    a = math.factorial(total_sum - digit)
    b = math.factorial(digit)
 
    sum_fact = a + b
    
    return sum_fact
 
print("Sum_factorial of digits in number: " + str(fact_digits(13)))
