def prime_pair(numbers, prime):
  
  numbers = list(numbers)
   
  n = len(numbers)
   
   
  for i in range(0, n):
    for j in range(i, n):
      x = numbers[i]
      y = numbers[j]
     
      if (x + y) is prime:
        return x, y

print(prime_pair([1,2,3,4,5], 7))