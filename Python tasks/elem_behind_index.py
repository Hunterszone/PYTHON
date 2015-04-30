def count_item():
    
    index = input("Enter index in range: ")
    index = int(index)
    
    list_1 = [1, 2, 3, 4, 5, 6]    
 
    n = len(list_1)
    
    elem = list_1[index]
    
    for index in range(0, n):
        
        return "Element is: " + str(elem)
    
print(count_item())
