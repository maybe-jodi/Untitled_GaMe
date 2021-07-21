import time
s = 19
S = 19

print("Hello! Welcome to Untitled_GaMe! My name is Clyde.")
time.sleep(2.0)
print("It's only polite to tell me your name, so what is it?")
print("Your name is: ", end ='')
name = input()
time.sleep(3.0)
print("So your name is " + name + "? Cool.")
time.sleep(3.0)
print("You wake up in a strange apartment, with no recollection of past events.")
time.sleep(2.5)
print("Do you want to go downstairs or explore the apartment?")
time.sleep(2.5)
print("Input S to stay, and N to go downstairs.")
des1 = input()
if(des1 == "S"):
    print("You look around. You find a knife covered in blood. You take it, and go downstairs.")
else:
    print("You go downstairs.")
time.sleep(2.5)
print("Oh hello!" + name + "! You finally woke up!")
print("What is it dear? You look like you've seen a ghost!")
time.sleep(3.0)
print("You don't know who I am? I'm Ada, the innkeeper. You come here every Saturday to spend the day with me!")
time.sleep(3.2)
