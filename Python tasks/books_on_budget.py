def on_budget(books, budget):
 
    books = sorted(books)
    sum_books = sum(books)
    sum_ = sum(books)
    result = {"books_on_budget":0,
              "loan": 0,
             }
    
    for book in books:
        if sum_ > book:
            result["books_on_budget"] += 1
            sum_ -= book
    if budget >= sum_books :
        return result
    elif budget  < sum_books:
        result["loan"] =  sum_books - budget
        return result
 
 
 
books = [0, 10, 100, 5, 3, 8, 25]
budget = 35
 
print(on_budget(books, budget))
