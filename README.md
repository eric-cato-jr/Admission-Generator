# Admission Generator

This project is a C# application that evaluates admission decisions based on a student's GPA and admission test score. The program applies predefined acceptance criteria and displays whether the applicant is accepted or rejected. It also maintains running totals of accepted and rejected applicants.

## Features
- Admission decision logic based on GPA and test score thresholds
- Conditional evaluation using multiple acceptance rules
- Running totals for accepted and rejected applicants
- Button-driven admission evaluation
- Clear on-screen decision output

## Admission Logic
An applicant is **accepted** if either of the following conditions are met:
- GPA is **greater than or equal to 3.0** and test score is **greater than or equal to 60**
- GPA is **below 3.0** and test score is **greater than or equal to 80**

If neither condition is met, the applicant is **rejected**.

## Technologies Used
- C#
- .NET Windows Forms
- Visual Studio

## Code
The application demonstrates conditional logic, counters, and decision-based program flow using a graphical user interface.

## Output
The screenshot below demonstrates an admission decision and the running totals for accepted and rejected applicants.
