from random import randint
 
dices = input("Number of dices: ")
 
n = input("Enter sides: ")
n = int(n)
 
player_one = input("Player 1: ")
player_two = input("Player 2: ")
player_three = input("Player 3: ")
 
points_pl_one = randint(1, n)
print(str(player_one) + " throws: " + str(points_pl_one))
 
points_pl_two = randint(1, n)
print(str(player_two) + " throws: " + str(points_pl_two))
 
points_pl_three = randint(1, n)
print(str(player_three) + " throws: " + str(points_pl_three))
 
if points_pl_one > points_pl_two and points_pl_one > points_pl_three:
    print(str(player_one) + " wins")
elif points_pl_one < points_pl_two and points_pl_two > points_pl_three:
    print(str(player_two) + " wins")
else:
    print(str(player_three) + " wins")
