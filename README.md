# Uninitialized Property Access in C#

This repository demonstrates a common, yet often subtle, error in C#: accessing a property before it's been assigned a value.  The example shows how accessing the `MyProperty` within the `MyMethod` function without prior initialization can lead to unexpected results or exceptions.

## Problem

In C#, class properties have a default value if not initialized. However, relying on this default value can sometimes lead to unexpected behavior, especially when the property is expected to hold a specific value before method execution. The code in `bug.cs` showcases this scenario. 

## Solution

The solution (`bugSolution.cs`) addresses this by explicitly assigning an initial value to the `MyProperty` either in the constructor or before using it within the `MyMethod` function. This ensures that `MyProperty` always has a defined value during method execution and prevents unpredictable results.