def contains_digi(nummy, digit):
 
    nummy = int(nummy)
 
    number = 0
 
    for num in [nummy]:
    
        number += num
    
    print(number)
 
    digit = int(digit)
    
    print(digit)
 
    if str(digit) in str(number):
        return True
    else:
        return False
 
print(contains_digi(123456, 8))
