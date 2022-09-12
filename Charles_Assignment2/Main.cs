// See https://aka.ms/new-console-template for more information

using Charles_Assignment2;

Employee employee;
View v = new View();
mainGo();

void mainGo()
{
    string fName;
    string lName;
    double sales;

    //gather information
    v.welcome();
    v.pleaseEnter("your first name");
    fName = v.inString();
    v.pleaseEnter("your last name");
    lName = v.inString();
    v.pleaseEnter("your sales for the month");
    sales = Double.Parse(v.inString());

    //create employee
    employee = new Employee(fName,lName,sales);

    //calculations
    calculate();

    //output
    v.printString(employee.formattedOutput());
    v.inString();
}

void calculate()
{
    employee.calcCommission();
    employee.calcFedTax();
    employee.calcSocialTax();
    employee.calcRetirement();
}