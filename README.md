# F# Mutable Variable Scope and Unexpected Behavior

This repository demonstrates a subtle but common issue in F# related to the scoping of mutable variables and their behavior when passed to functions.

The `bug.fs` file contains code that showcases the unexpected behavior.  The `bugSolution.fs` file provides a corrected approach. The key difference is in how mutable variables are handled to ensure the changes within the function are properly reflected outside it. 

## Problem Description

In F#, mutable variables are passed by reference. However, the way mutable variables are accessed within a function can lead to unexpected results if care isn't taken. The `bug.fs` file shows an example where the same logic is implemented in two different ways. In one example, the swap operation correctly updates the variables, while in the other, it doesn't. 

## Solution

The `bugSolution.fs` file presents a correct way to achieve the intended mutable variable modification.