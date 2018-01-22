class BinaryError(Exception):
    def __str__(self):
        return "Not a valid binary number!"
 
def bin2dec():
    
    input_string = input("Input_binary: ")
    input_string = str(input_string)
    
    r = 0
    
    for character in input_string:
        if character == '0':
            r = r * 2
    
        elif character == '1':
            r = r * 2 + 1
    
        else:
            raise BinaryError()
    
    return "The decimal is: " + str(r)
 
print(bin2dec())
