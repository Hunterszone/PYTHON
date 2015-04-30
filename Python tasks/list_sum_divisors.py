def sum_divisors(number):
    
    empty = []
 
    divisor = 1
    
    if number == 0:
        return "Result is: " + str(number)
    if number < 0:
        return "N must be a posstive num!"
 
    while divisor <= number:
    
        divisor += 1
 
        if number % divisor == 0:
            empty += [divisor]
   
    list_div = [1] + empty
 
    sum_div = sum(list_div)
 
    return "\n" + "List of divisors: " + str(list_div) + "\n\n" + "Sum of divisors in list: " + str(sum_div)
 
print(sum_divisors(25))
