# Infix to Postfix Conversion and Postfix Evaluation

This project is a simple implementation of infix-to-postfix conversion and postfix expression evaluation in C#. The program includes methods to handle operator precedence and evaluate arithmetic expressions using a stack-based approach.

## Features

1. **Infix to Postfix Conversion**
   - Converts an infix expression to its postfix equivalent.
   - Handles operator precedence and parentheses.
   - Supports operators: `+`, `-`, `*`, `/`, and `()`.

2. **Postfix Expression Evaluation**
   - Evaluates a postfix arithmetic expression.
   - Supports basic arithmetic operations: addition, subtraction, multiplication, and division.

## Code Structure

- **`InfixToPostfix` Method:**
  Converts an infix expression (e.g., `A+B*C/D-F+H`) to a postfix expression (e.g., `ABC*D/+F-H+`).

- **`PostfixCalculation` Method:**
  Evaluates a postfix expression (e.g., `121+-`) and outputs the result.

- **Stack Operations:**
  - `Push`: Adds an element to the stack.
  - `Pop`: Removes the top element from the stack and returns it.
  - `Peek`: Returns the top element without removing it.
  - `StackCount`: Returns the number of elements in the stack.

## Usage

### Prerequisites
- .NET Core SDK installed on your system.

### Running the Program
1. Clone or download this repository.
2. Open the project in your preferred IDE (e.g., Visual Studio or VS Code).
3. Build and run the project.

The main method currently executes the `PostfixCalculation` method. You can switch to `InfixToPostfix` by replacing the call to `PostfixCalculation` in the `Main` method.

### Input and Output
- **Infix Expression Conversion:**
  - Input: `A+B*C/D-F+H`
  - Output: Postfix expression (e.g., `ABC*D/+F-H+`)

- **Postfix Expression Evaluation:**
  - Input: `121+-`
  - Output: Calculated result (e.g., `2`)

## Customization

You can modify the following sections to fit your use case:

1. **Infix Expression:** Update the `infix` string in the `InfixToPostfix` method.
2. **Postfix Expression:** Update the `postfix` string in the `PostfixCalculation` method.

## Limitations

- Assumes valid input expressions.
- Does not handle variables or more complex mathematical functions.
- No error handling for division by zero or stack overflow.

## Example

**Infix to Postfix Conversion:**
```plaintext
Input:  A+B*C/D-F+H
Output: ABC*D/+F-H+
```

**Postfix Expression Evaluation:**
```plaintext
Input:  121+-
Output: 2
```

## License
This project is licensed under the MIT License.

---

Feel free to experiment and extend the functionality!

