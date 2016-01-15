Feature: Search an item in TradeMe using a keyword
	In order to sell posted items quickly (business value)
	As a potential buyer (user of the feature)
	I need an easy search function that allows to search by keywords(feature)

@SmokeTest
@Browser:Chrome

Scenario: Search specific keyword
	Given I have navigated to TradeMe search page
	When I enter an Iphone keyword
	Then the result set should match the keyword I entered
