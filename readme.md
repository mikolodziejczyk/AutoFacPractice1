You have AutoFacPractice1 (exe) and AutoFacPractice1.BL (dll with all the business logic).
The code simulates the following: (1) IUserSource with the concrete implementations (AdUserSource, FileUserSource) provides user list - an array of strings. (2) MainProcessor creates an UserProcessor instance for each user (string) and calls Process() in UserProcessor . (3) UserProcessor takes CompanyParser to extract a substring from the user and displays something.

Refactor the code to use AutoFac.

1. Add the AutoFac nuget package (to which project?)
2. Quick start
	a. add starter template for AutoFac in the console program
	b. register all types from BL as themserves
	c. register AdUserSource as IUserSource
	d. run the application
3. MainProcessor creates UserProcessor instances manually, using new in Process(). Refactor MainProcessor to take an abstract factory of UserProcessor as the constructor parameter and then, in Process(), use this factory to create instances.
Add backing field and a null check with VS.
4. Registering manually and overriding
	a. register AnotherCompanyParser as itself manually.
	b. register AnotherCompanyParser as CompanyParser
5. Configure AutoFac to provide CompanyParser instances with a custom delegate - return new AnotherCompanyParser()
6. Registering existing instances (you have an existing instance of a component and you want to supply it when a specific type is requested) - how to - overview.
7. Make AnotherCompanyParser singleton
	a. Scenario: You have a library, how can you create a singleton (e.g. with some cached data) without manual singleton registration - overview
8. Creating specific delegate factories - replace the default delegate factory with a custom one for a specific type
	a. create AnotherUserProcessor, inside accept CompanyParser in the constructor, pass it to the base constructor
	b. register AnotherUserProcessor as UserProcessor, check if works, then revert
	c. register the whole delegate factory to create AnotherUserProcessor with manually injected CompanyParser (i.e. register the whole delegate factory in AutoFac, not only the type to provide); revert
9. Delegate factories that accept parameters:
	a. Currently, the UserProcessor takes user (string) in the Process method. Refactor UserProcessor so that it accepts a string in constructor rather than in the Process() and keeps it in a class field; use VS to generate the field and null/whitespace check.
	b. refactor AnotherUserProcessor accordingly; use the base constructor; adjust member access level
	c. refactor MainProcessor so that it accepts delegate factory with the delegate that takes a parameter (userName), refactor the Process method accordingly.
10. Delegate factories with multiple parameters of the same type
	a. Refactor UserProcessor so that it takes also another string parameter, prefix (add the backing field, etc.) so that we have:
	public UserProcessor(CompanyParser companyParser, string userName, string prefix)
	Write this prefix somewhere in the Process()
	b. What is the problem with Func<string, string, UserProcessor> delegate factory?
	c. Create the factory delegate type in UserProcessor
    d. Get this delegate type injected in the MainProcessor, use any value for prefix, test
11. How to get an object injected when we don't know when it will be used (if at all) and it is expensive to create - overview
 
You have MyMvcApplication. There is the Repositories.MyRepository class, it is instantiated in HomeController, as the myRepository property.
The repository is used in the About method.

1. Enable AutoFac for MyMvcApplication
    a. add the required nuget packages
    b. add the required startup code
2. Refactor HomeController so that it takes MyRepository as the constructor parameter, keep the existing field.
   Configure AutoFac to provide MyRepository, test (/Home/About)
   Configure MyRepository to be a singleton, test (the id in the repository should not increase in the consecutive calls)