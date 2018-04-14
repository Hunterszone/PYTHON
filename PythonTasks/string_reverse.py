def str_reverse(string):
    
    result = ""
    
    n = len(string)
    
    for index in range(0, n):
 
        ch = string[index]
 
        result = ch + result
 
        
    return result
    
print(str_reverse("JUICE"))
