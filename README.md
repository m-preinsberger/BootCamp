# CS BootCamp
- BootCamp is where legends are made

## Overview

This program checks if the brackets in a given string are balanced and correctly ordered. It supports round `()`, square `[]`, and curly `{}` brackets, ensuring that every opening bracket has a corresponding closing bracket in the right order.

### Code Explanation

#### Main Method:
- The `Main` method serves as the entry point of the program.
- It initializes the input string: `"(s{s}s[klkljsdf]sd)"`.
- It calls the `CheckBracketsSyntax` method to check if the brackets are balanced.
- The result (`true` or `false`) is printed to the console based on whether the brackets are balanced.

#### CheckBracketsSyntax Method:
- This method takes a string and verifies that the brackets are properly balanced.
- A **Stack** is used to store opening brackets, following the **Last In, First Out (LIFO)** principle.
- The program loops through each character of the input string:
  - When it encounters an opening bracket (`(`, `[`, `{`), it pushes it onto the stack.
  - For closing brackets (`)`, `]`, `}`), the stack is checked to see if the top element matches the correct opening bracket.
  - If the brackets don’t match or the stack is empty when a closing bracket is found, the method returns `false`.
- If the loop completes and the stack is empty, it means all opening brackets had matching closing brackets, and the method returns `true`.

### C# Concepts Used

#### Stack Data Structure:
- The **Stack** is perfect for this problem since brackets need to be closed in reverse order from how they were opened.
- It allows for efficient checking of matching brackets.

#### Switch Statement:
- The **switch** statement handles different types of brackets (`()`, `[]`, `{}`). This makes the code more readable and avoids multiple `if-else` blocks.

#### Conditionals:
- **If statements** are used to check if the current closing bracket matches the top of the stack.
- If a mismatch is found, the method returns `false` immediately.

#### Encapsulation:
- The method `CheckBracketsSyntax` is marked `private`, limiting its access to within the `Program` class, an example of **encapsulation**.

#### Loops:
- A **foreach** loop is used to iterate over each character in the string.

#### Boolean Logic:
- The method returns a boolean (`true` or `false`) based on whether the brackets are balanced, using simple logical conditions.

### How to Run the Program
1. Clone or download the repository.
2. Open the project in a C# IDE (like Visual Studio).
3. Run the program, and it will output `true` if the brackets are balanced or `false` if they are not.

### Example Input/Output:
- Input: `"(s{s}s[klkljsdf]sd)"`
- Output: `True`
