def neighb_pairs(numbers):

  numbers = list(numbers)
  
  n = len(numbers)
   
  for i in range(0, n):
      for j in range(i + 1, n):
          x = numbers[i]
          y = numbers[j]
          if x + y == 0:
              print(x,y)
  return("Pairs counted!")
  
print(neighb_pairs([1, 2, -2, 0, 0, 5, -5]))