import sys

def add(x, y):
    return x + y

def subtract(x, y):
    return x - y

def multiply(x, y):
    return x * y

def divide(x, y):
    if y == 0:
        return "Cannot divide by zero!"
    return x / y

def modulus(x, y):
    return x % y

if __name__ == "__main__":
    operation = sys.argv[1]
    num1 = float(sys.argv[2])
    num2 = float(sys.argv[3])
    
    if operation == "+":
        print(add(num1, num2))
    elif operation == "-":
        print(subtract(num1, num2))
    elif operation == "*":
        print(multiply(num1, num2))
    elif operation == "/":
        print(divide(num1, num2))
    elif operation == "%":
        print(modulus(num1, num2))
    else:
        print("Invalid operation!")

