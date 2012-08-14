import unittest
from Elements.STG.Factories.StgFilteringElementsFactory import StgFilteringElementsFactory

class TestClass(unittest.TestCase):
	def setUp(self):
		self.factory = StgFilteringElementsFactory()

	def test_for_creating_elements(self):
		parameter = self.factory.create("DateParameters", {"DateTypeFilteringColumn" : ''}, {})
		assert parameter.getType() == "Date", "Factory doesn't create elements by name."

		parameter = self.factory.create("StringParameters", {"FilteringColumn" : ''}, {})
		assert parameter.getType() == "Standard", "Factory doesn't create elements by name."		

		parameter = self.factory.create("NoneName", {}, {})
		assert parameter == None, "Factory doesn't create elements by name."

	def test_for_template_resolver_in_created_element(self):
		parameter = self.factory.create("DateParameters", {"DateTypeFilteringColumn": ""}, {})
		assert parameter.templateResolver != None, "Element doesn't have template resolver."		

	def test_for_resolving_element(self):
		parameter = self.factory.create(
			"DateParameters", 
			{
				"DateTypeFilteringColumn": "${ModuleName}"
			}, 
			{
				"ModuleName": "INJECTED VALUE"
			})
		
		assert parameter.resolve() == "INJECTED VALUE", "Resolving doesn't work."		
