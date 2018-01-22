n = input("Enter num: ")
n = int(n)
 
n % 2 != 0
 
if n % 2 == 0:
    
    print(False)
    
 
def first_row():
    
    result = ""
    
    asterisk = "* "
    
    stars = len(asterisk) - 1
    
    for index in range(stars, n + 1):
        result += asterisk
        
        
    
    return result
  
print(first_row())
 
 
def second_row():
    
    result = ""
    
    dot = "."
 
    asterisk = " *"
    
    stars = len(asterisk)
    
    dots = len(dot) - 1
 
    for index in range(stars, n):
        result += dot + asterisk + dot         
    
        y = result.replace("..", "").replace(". *", ".*").center(13)
    
    return y
    
print(second_row())
 
 
def third_row():
    
    result = ""
    
    dot = "."
 
    asterisk = "  * "
    
    stars = len(asterisk)
    
    dots = len(dot) - 1
 
    
    for index in range(stars, n):
        result += dot + asterisk + dot         
        y = result.replace("..", "").replace(".", "..").replace("  ", " ").replace("  ", " ").replace(". *", ".*").replace("* .", "*.").center(13)
 
    if n <= 5:
        return asterisk.replace("  * ", "")
    else:
        return y
    
print(third_row())
 
 
def fixed():
    
    result = ""
    
    dot = "."
 
    asterisk = "*"
    
    stars = len(asterisk)
    
    dots = len(dot) - 1
 
    result += dot + asterisk + dot         
    
    y = result.replace("..", "").replace(".", "...").replace("  ", "").replace(" ", "").strip().center(13)
    
   
         
    return y
    
print(fixed())
 
 
def mirror_third_row():
    
    result = ""
    
    dot = "."
 
    asterisk = "  * "
    
    stars = len(asterisk)
    
    dots = len(dot) - 1
 
    for index in range(stars, n):
        result += dot + asterisk + dot         
        y = result.replace("..", "").replace(".", "..").replace("  ", " ").replace("  ", " ").replace(". *", ".*").replace("* .", "*.").center(13)
 
    if n <= 5:
        return asterisk.replace("  * ", "")
    else:
        return y
    
print(mirror_third_row())
 
 
def mirror_second_row():
    
    result = ""
    
    dot = "."
 
    asterisk = " *"
    
    stars = len(asterisk)
    
    dots = len(dot) - 1
 
    
    for index in range(stars, n):
        result += dot + asterisk + dot         
    
        y = result.replace("..", "").replace(". *", ".*").center(13)
 
         
    return y
    
print(mirror_second_row())
 
 
def mirror_first_row():
    
    result = ""
 
    asterisk = "* "
    
    stars = len(asterisk) - 1
    
    for index in range(stars, n + 1):
        result += asterisk      
     
    return result
    
print(mirror_first_row())
