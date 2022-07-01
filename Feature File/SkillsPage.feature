Feature: SkillsPage

I would like to test the Skills page

@tag1
Scenario:  add New Skills
	When  User on Skills page
	And User click on Skills page
	When User click on add New Language button
	And User enter the new skill
	When User click on dropdown to select the new Skill
	And User select new skill from dropdown
	Then click on add button

	