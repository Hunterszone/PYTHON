# Function definition of tetrahedron
def fill_tetrahedron(num: int) -> float:
    V = float
    a = int
    a = num
    
    V = (((2**(1/2))*(a**3))/12)/1000
    return V
 
def tetrahedron_filled(tets_list, volume: int) -> int:
    number_tets = 0
    tets = sorted(tets_list)
    vol = volume
    
    for tet in tets:       
        vol_index = fill_tetrahedron(tet)
        print([tet], vol_index)
        if  vol_index < vol:
            vol = vol - vol_index
            number_tets += 1
            
    return number_tets
 
# in list we have edge length of a regular tetrahedron
a = tetrahedron_filled([100,20,30], 10)
print(a)
