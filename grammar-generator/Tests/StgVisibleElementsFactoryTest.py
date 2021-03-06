import unittest
from Elements.STG.Factories.StgVisibleElementsFactory import StgVisibleElementsFactory

class TestClass(unittest.TestCase):
	def setUp(self):
		self.factory = StgVisibleElementsFactory()

	def test_for_creating_elements(self):
		parameter = self.factory.create("DateParameters", { "SimpleVisibledColumn" : "" }, {})
		assert parameter.getType() == "Standard", "Factory doesn't create elements by name."

	def test_for_template_resolver_in_created_element(self):
		parameter = self.factory.create("DateParameters", { "SimpleVisibledColumn": "" }, {})
		assert parameter.templateResolver != None, "Element doesn't have template resolver."		

	def test_for_resolving_element(self):
		parameter = self.factory.create(
			"DateParameters", 
			{
				"DateTypeFilteringColumn": "",
				"SimpleVisibledColumn": "${ModuleName}"
			}, 
			{
				"ModuleName": "INJECTED VALUE"
			})
		
		assert parameter.resolve() == "INJECTED VALUE", "Resolving doesn't work."	