name1 = input("first name: ")
name2 = input("second name: ")
name3 = input("third name: ")
BirthYear = input("birth year: ")
ThisYear = input("this year: ")
 
age1 = {}
age1 = int(ThisYear) - int(BirthYear)
 
person = {"first name": str(name1),
          "second name":str(name2),
          "third name":str(name3),
          "birth year":int(BirthYear),
          "this year":int(ThisYear),
          "age": str(age1)
          }
 
print(person)
