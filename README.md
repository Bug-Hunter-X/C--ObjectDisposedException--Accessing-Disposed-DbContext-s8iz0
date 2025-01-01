# C# ObjectDisposedException: Accessing Disposed DbContext

This repository demonstrates a common error in C# applications where a DbContext or other disposable object is accessed after it has been disposed of. This leads to an ObjectDisposedException.  The example shows how to avoid this issue.

## Bug Description:

The `bug.cs` file contains code that attempts to access a DbContext instance after the `using` block, which disposes of the context. This causes an `ObjectDisposedException`.

## Solution:

The `bugSolution.cs` file provides a solution by performing all database operations within the `using` block or by storing the necessary data before the context is disposed.