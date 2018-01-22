def extensions(list1):
 
    file_name = 'test.avi'
 
    for extension in list1:
    
        if file_name.endswith(extension):
 

            return True, file_name

    return False, file_name

print(extensions(['.mp3','.avi']))
