Feature: LanguagePage

I would like to test the login page

@tag1
Scenario:  add new Language
	When  User on Language page
	And User click on Language page
	When User click on add new Language button
	And User enter the new Language
	When User click on dropdown to select the new Language
	And User select new Language from dropdown
	Then click on add button
