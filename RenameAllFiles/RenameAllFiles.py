import os
from tkinter import filedialog
from tkinter import *
from ttkbootstrap import scrolled


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
        self.Frame = scrolled.ScrolledFrame(self)
        self.Frame.place(x=20,y=80)
        self.Files = []
        self.GetFiles()
        self.mainloop()

    def GetFiles(self):
        for i in range(len(self.listOfFiles)):
            self.Files.append(Checkbutton(
                self.Frame, text=self.listOfFiles[i].split("\\")[-1]))
            self.Files[i].place(x=10, y=10+20*i)
        print(len(self.listOfFiles))
        self.update()


a = app()
