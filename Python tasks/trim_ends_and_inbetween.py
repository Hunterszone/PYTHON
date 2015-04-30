string = "            Hey                 Boy       !          "
 
trimmed = string.strip().replace("  ", "").replace(" !", "!")
 
print(trimmed)
