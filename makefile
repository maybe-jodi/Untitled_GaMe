.PHONY: Untitled_GaMe.cs

all: run

Untitled_GaMe.exe: Untitled_GaMe.cs
    @gmcs Untitled_GaMe.cs 

clean:
    @rm -f Untitled_GaMe.exe

run: Untitled_GaMe.exe
    @mono Untitled_GaMe.exe
