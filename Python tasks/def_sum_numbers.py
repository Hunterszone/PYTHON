def sums(number):
    
    number = int(number)
 
    sum_numbers = (number*(number+1)) / 2
    sum_numbers = int(sum_numbers)
 
    if number > 0:

        return sum_numbers

print(sums(10))
