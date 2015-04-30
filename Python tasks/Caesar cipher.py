def caesar_encrypt(string: str, n: int) -> str:
    st = ""
    ascii_lower_a = 97 # a=97, b=98 ...
    ascii_upper_A = 65 # A=65, B=66 ...
    
    for ch in string:
        #encrypt only alphabetical characters
        if ch.isalpha():
            if ch.islower():
                st = st + chr((ord(ch)-ascii_lower_a+n)%26+ascii_lower_a)
            else:
                st = st + chr((ord(ch)-ascii_upper_A+n)%26+ascii_upper_A)
        else:
            st = st + ch
            
    return st
 
s = input("Enter string for encryption:")
s = str(s)
n = input("Enter cipher:")
n = int(n)
print("Result:",caesar_encrypt(s, n))
