﻿using EmployeeWage;
Console.WriteLine("Welcome to Employee Wage Computation program");
IEmployeeWageForCompany details = new Wages();
details.compute("IBM", 30,18,80);
details.compute("TATA", 35, 25, 115);