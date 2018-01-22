def divisors(number):
 
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
 
    for elem in list_div:
        if len(list_div) % 2 != 0 or len(list_div) == 2 or len(list_div) == - 2:
                return True, list_div
            
        else:
            return False, list_div
        
    
print(divisors(111))
