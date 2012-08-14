import unittest

from Elements.G.Factories.SectionTransformerFactory import SectionTransformerFactory

class TestClass(unittest.TestCase):
	def setUp(self):
		self.factory = SectionTransformerFactory()

	def createDefaultFactory(self,
							 name,
							 templates = { "Test" : "", "SectionName" : "" }, 
							 modules = { "Test" : { "ModuleLongName" : "",
													"ModuleShortName" : "", 
													"ModulePrefix" : "", 
													"SectionName" : { "A" : {"Name" : ""} } } }):
		self.element = self.factory.create(name, templates, modules)

	def test_for_creating_transformers_by_section_name(self):
		self.createDefaultFactory("ForEachModule_CreateEntriesOnly_SectionName")
		assert self.element.getType() == "ForEachModuleTransformer", "Invalid type name for section."
		assert self.element.getName() == "SectionName", "Invalid name for specified section."

		self.createDefaultFactory("ForEachModule_CreateParametersListWithName_SectionName")
		assert self.element.getType() == "ForEachModuleTransformer", "Invalid type name for section."
		assert self.element.getName() == "SectionName", "Invalid name for specified section."

	def test_for_raising_exception_when_section_name_is_invalid(self):
		try:
			self.createDefaultFactory("SectionName")			
			self.fail("Missing AttributeError for section name.")
		except AttributeError:
			pass

	def test_for_creating_populator(self):
		self.createDefaultFactory("ForEachModule_CreateEntriesOnly_SectionName")
		self.element.build("Test")

		assert self.element.populator != None, "Missing Populator object."
		assert self.element.populator.getType() == "CreateEntriesOnly", "Invalid type populator object."
		assert self.element.populator.separator != None, "Missing separator."

		self.createDefaultFactory("ForEachModule_CreateParametersListWithName_SectionName-Test")
		self.element.build("Test")

		assert self.element.populator != None, "Missing Populator object."
		assert self.element.populator.getType() == "CreateParametersListWithName", "Invalid populator object."
		assert self.element.populator.separator != None, "Missing separator."