from tkinter import *
from tkinter import ttk
from tkinter import filedialog
from tkinter import scrolledtext
#from tkmessageBox import *

def notdone():  
    showerror('Not implemented', 'Not yet available') 

def openfile():
    return filedialog.askopenfilename()

def savefile():
    return filedialog.asksaveasfilename()

def scroll():
    master = Tk()

    scrollbar = Scrollbar(master)
    scrollbar.pack(side=RIGHT, fill=Y)

    listbox = Listbox(master, yscrollcommand=scrollbar.set)
    for i in range(1000):
        listbox.insert(END, "Case No: " + str(i))
    listbox.pack(side=LEFT, fill=BOTH)
    master.title("Table of contents")


    scrollbar.config(command=listbox.yview)

    mainloop()

def makemenu(parent):
    menubar = Frame(parent)                        
    menubar.pack(side=TOP, fill=X)

    
    fbutton = Menubutton(menubar, text='File', underline=0)
    fbutton.pack(side=LEFT)
    file = Menu(fbutton)
    file.add_command(label='Save...',  command=savefile,     underline=0)
    file.add_command(label='Open...', command=openfile,     underline=0)
    file.add_command(label='Scroll...', command=scroll,     underline=0)
    file.add_command(label='Quit',    command=lambda:exit(), underline=0)
    fbutton.config(menu=file)

    ebutton = Menubutton(menubar, text='Edit', underline=0)
    ebutton.pack(side=LEFT)
    edit = Menu(ebutton, tearoff=0)
    edit.add_command(label='Cut',     command=lambda: parent.event_generate("<<Cut>>"), underline=0)
    edit.add_command(label='Paste',   command=lambda: parent.event_generate("<<Paste>>"), underline=0)
    edit.add_separator()
    ebutton.config(menu=edit)

    submenu = Menu(edit, tearoff=0)
    submenu.add_command(label='Spam', command=parent.quit, underline=0)
    submenu.add_command(label='Eggs', command=notdone,     underline=0)
    edit.add_cascade(label='Stuff',   menu=submenu,        underline=0)
    return menubar


if __name__ == '__main__':
    root = Tk()                   
    root.title('Menu example')        
    makemenu(root)                 
    msg = Label(root, text='Frame menu basics', font=("Arial", 14)) 
    msg.pack(expand=YES, fill=BOTH)
    msg.config(relief=GROOVE, width=100, height=30, bg='red')

root.mainloop()
