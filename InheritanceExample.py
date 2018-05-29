class Person:
  
  def __init__(self, text, amount):
  
   self.sometext = text
   self.someamount = amount
    
  def Money(self):
    return self.sometext + self.someamount
  
class Frauder(Person):
  
  def __init__(self, text, amount, case):
    
    Person.__init__(self, text, amount)
    self.somecase = case
  
  def Fraud(self):
    return self.Money() + self.somecase
    
class Cop(Frauder):
  
  def __init__(self, text, amount, case, jail):
    
    Frauder.__init__(self, text, amount, case)
    self.somejail = jail
  
  def Jail(self):
    return y.Fraud() + self.somejail

x = Person("I have " , str(123))
y = Frauder("You have " , str(123), " - got stolen")
z = Cop("I have " , str(123), " stolen", " => go to jail!")

print("Normal person says: ", x.Money())
print("Frauder says: ", y.Fraud())
print("The cop says: ", z.Jail())
