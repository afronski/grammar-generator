import unittest
from Content.JsonContent import JsonContent

# JSON validator test case.
class TestClass(unittest.TestCase):
	def test_validation_passed(self):		
		validator = JsonContent('{ "test" : "simple JSON" }')
		result = validator.validate()		
		assert result == True, 'Validation not passed - broken validation'

	def test_validation_passed_but_more_complicated(self):
		validator = JsonContent('{ "test" : true, "test": 1, "T1": { "a" : 2.0 }, "T2" : [ "2"] }')
		result = validator.validate()
		assert result == True, 'Validation not passed - broken validation'

	def test_validation_failed(self):
		validator = JsonContent('{ "')
		result = validator.validate()
		assert result == False, "Validation passed but shouldn't - broken validation"

	def test_validation_failed_but_more_subtle(self):
		validator = JsonContent("{ 'test' : 'test' }")
		result = validator.validate()
		assert result == False, "Validation passed but shouldn't - broken validation"

	def test_which_returns_parsed_object(self):
		parser = JsonContent('{ "test" : "simple JSON" }')
		builtObject = parser.parse()

		assert builtObject["test"] == 'simple JSON', "JSON content cannot be parsed."

	def test_which_returns_none_in_response_to_invalid_object(self):
		parser = JsonContent('{ " ')
		builtObject = parser.parse()

		assert builtObject == None, "JSON content cannot be parsed."		