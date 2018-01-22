def head(list1, list2):  
    
    if len(list1) != len(list2):
        return False
    
    i = 0
    
    for elem in list1:
        
        if list1[i] != list2[i]:
            return False, elem    
        
        i += 1
        
    return True, elem

        
 
print(head(["4", "2", "3"], ["1", "2", "3"]))
