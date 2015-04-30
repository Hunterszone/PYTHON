def money(income, outcome):
    
    income = list(income)
    
    outcome = list(outcome)
    
    result = sum(income) - sum(outcome)
    
    return result
    
 
print(money([10], [10]))
    
