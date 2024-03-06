# Exception

### How are exceptions represented in code?

Exceptions are represented in code as **Objects**, which means they're an instance of a class.

### Common scenarios that require exception handling include:

- User input: Exceptions can occur when code processes user input. For example, exceptions occur when the input value is in the wrong format or out of range.

- Data processing and computations: Exceptions can occur when code performs data calculations or conversions. For example, exceptions occur when code attempts to divide by zero, cast to an unsupported type, or assign a value that's out of range.

- File input/output operations: Exceptions can occur when code reads from or writes to a file. For example, exceptions occur when the file doesn't exist, the program doesn't have permission to access the file, or the file is in use by another process.

- Database operations: Exceptions can occur when code interacts with a database. For example, exceptions occur when the database connection is lost, a syntax error occurs in a SQL statement, or a constraint violation occurs.

- Network communication: Exceptions can occur when code communicates over a network. For example, exceptions occur when the network connection is lost, a timeout occurs, or the remote server returns an error.

- Other external resources: Exceptions can occur when code communicates with other external resources. Web Services, REST APIs, or third-party libraries, can throw exceptions for various reasons. For example, exceptions occur due to network connections issues, malformed data, etc.

### Exception handling in a C# application is generally implemented using one or more of the following patterns:

- The try-catch pattern consists of a try block followed by one or more catch clauses. Each catch block is used to specify handlers for different exceptions.
- The try-finally pattern consists of a try block followed by a finally block. Typically, the statements of a finally block run when control leaves a try statement.
- The try-catch-finally pattern implements all three types of exception handling blocks. A common scenario for the try-catch-finally pattern is when resources are obtained and used in a try block, exceptional circumstances are managed in a catch block, and the resources are released or otherwise managed in the finally block.

### Workflow

```C#
try
{
    // Step 1: code execution begins
    try
    {
        // Step 2: an exception occurs here
    }
    finally
    {
        // Step 4: the system executes the finally code block associated with the try statement where the exception occurred
    }

}
catch // Step 3: the system finds a catch clause that can handle the exception
{
   // Step 5: the system transfers control to the first line of the catch code block
}
```

Once an Exception was raised, it will search for **_catch_** block upwards if no catch block in same level. However, each level's **_finally_** will be executed first before going to the upper level.

If no catch block founded, the program terminated and raise the Error.
