import os
from tkinter import Tk, filedialog, Label, Entry, Button, Frame, Scrollbar, Canvas, X, Y, BOTTOM, RIGHT, BOTH, IntVar, Checkbutton

class app(Tk):
    def __init__(self):
        self.Directory = filedialog.askdirectory()
        self.listOfFiles = os.listdir(self.Directory)
        super().__init__()
        self.geometry("800x400")
        self.title("Rename All Files in A Folder")
        
        Label(self, text="Choose Files Extension:").place(x=20, y=20)
        self.Extension = Entry(self)
        self.Extension.place(x=20, y=50)
        self.Filter = Button(self, text="Filter")
        self.Filter.place(x=150, y=50)
        
        self.Frame = Frame(self, width=760, height=250, bg="black")
        self.Frame.place(x=20, y=80)
        
        self.Canvas = Canvas(self.Frame, width=760, height=250)
        self.Canvas.pack(side="left", fill="both", expand=True)
        
        self.HScroll = Scrollbar(self.Frame, orient="horizontal", command=self.Canvas.xview)
        self.HScroll.pack(side=BOTTOM, fill=X)
        self.VScroll = Scrollbar(self.Frame, orient="vertical", command=self.Canvas.yview)
        self.VScroll.pack(side=RIGHT, fill=Y)
        
        self.Canvas.configure(xscrollcommand=self.HScroll.set, yscrollcommand=self.VScroll.set)
        self.Canvas.create_window((0, 0), window=self.Frame, anchor="nw")
        
        self.Files = []
        self.GetFiles()
        
        self.AddCheckbuttons()
        
        self.mainloop()
    
    def AddCheckbuttons(self):
        for i, file in enumerate(self.Files):
            var = IntVar()
            checkbutton = Checkbutton(self.Frame, text=file, variable=var)
            checkbutton.pack(anchor="w")
            
            # Adjust the y-coordinate of the checkbutton's position within the canvas
            self.Canvas.create_window((10, i*30), window=checkbutton, anchor="nw", tags="checkbutton")
        
        # Update the scroll region of the canvas to include all checkbuttons
        self.Canvas.update_idletasks()  # Update the canvas to calculate the size
        bbox = self.Canvas.bbox("checkbutton")  # Get the bounding box of the checkbuttons
        self.Canvas.configure(scrollregion=bbox)
    
    def GetFiles(self):
        # Your implementation to get the list of files
        # Here, I'm just using a dummy list for demonstration
        self.Files = ['file1.txt', 'file2.txt', 'file3.txt']

app()