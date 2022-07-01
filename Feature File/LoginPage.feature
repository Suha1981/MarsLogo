Feature: Login 

I would like to test the login page

@tag1
Scenario: Login to website
    When User Launch the website
	And  Click on Signin button
	When User enter Login details 
	And Click on login button
	Then should be alble to login successfully.
	
	
Scenario: Invalid Login details 
         When User lunch the application
	     And  Click on signin button
	     When User login with emailId "suhanishu29@gmail.com"
	     And  click on login button
	     Then  should be not login 

Scenario:  Invalid password  
         When User lunch the application
	     And  Click on signin  link
	     When User login with <emailId> and <password>
	     And  click the login button
	     Then should be not login 

		 Examples: 
	| emailId                    | password |
	| suhanishu29@gamil.com      | suha4455 |
	| hasini4455@gmail.com       | 123456   |




