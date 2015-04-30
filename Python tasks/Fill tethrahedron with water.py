# Function definition of tetrahedron
def fill_tetrahedron(num: int) -> float:
    V = float
    a = int
    a = num
    
    V = (((2**(1/2))*(a**3))/12)/1000
    return V
 
edge = input("Enter edge in cm:")
num = int(edge)
 
# call function and print result
print(fill_tetrahedron(num))
