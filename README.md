# CSharpTypeComparerTest
How fast can different data types in different list types be compared?

## What it does!
- Generating 100 objects with all common data types in c#
- Fill objects with randomized data
- Initialize common lists and fill these with the generated objects
- Run the test and compare all objects with the same data types and save the ellapsed time in miliseconds
  - In Mainthread
  - In Single Threaded Tasks
  - In Multithreaded Tasklist
- Write all results in a csv file (location: C:\Users\Default\Documents\TestResult.csv)

## Why?
It shows which data type can perform with best results in comparing operations.

## How?
Just download the repository and build the project.
You have to run it as administrator because of access rights to the output folder.
