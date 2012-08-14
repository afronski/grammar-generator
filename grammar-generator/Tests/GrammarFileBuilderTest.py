import unittest

from Tests.StringTemplateGroupFileBuilderTest import MockedFileWriter
from Tests.StringTemplateGroupFileBuilderTest import MockedConsole
from Builders.GrammarFileBuilder import GrammarFileBuilder

class TestClass(unittest.TestCase):
	def iterateMatches(self, text, validMatches):
		i = 0
		for match in self.builder.findAllSections(text):
			assert match.group(1) == validMatches[i], "Invalid match for findAllSections algorithm."
			i += 1

		assert len(validMatches) == i, "Invalid count of matches found."

	def setUpBuilder(self, modules = '', templates = '', base = ''):
		self.builder =  GrammarFileBuilder(
							MockedFileWriter(''), 
							modules, 
							templates, 
							base, 
							MockedConsole()
						)

	def test_simple_test_for_simple_creation(self):
		self.setUpBuilder('', '', 'PASSED VALUE')

		assert self.builder != None, "You can't create Grammar file builder."

	def test_for_generating(self):
		self.builder =  GrammarFileBuilder(
							MockedFileWriter(''), 
							{ "Users" :
								{ 
									"ModuleLongName" : "",
									"ModuleShortName" : "",								
									"ModulePrefix" : "users",
									"Template" : 
									{
										"A" :
										{
											"Name" : "",
											"Value" : "VALUE",
											"Test" : "A"
										}
									}
								}
							}, 
							{ 
								"Template-Test" : "${Value}_${Test}:\n${Test}"
							}, 
							"#ForEachModule_CreateEntriesOnly_Template-Test",
							MockedConsole()
						)
		
		self.builder.generate()
		
		generatedValue = "VALUE_A:\nA"
		assert self.builder.writer.buffer == generatedValue, "Invalid value generated."

	def test_for_generating_many_sections(self):
		self.builder =  GrammarFileBuilder(
							MockedFileWriter(''), 
							{ 
								"Users" :
								{ 
									"ModuleLongName" : "",
									"ModuleShortName" : "",								
									"ModulePrefix" : "users",
									"T" : 
									{
										"A" :
										{
											"Name" : "",
											"Value" : "VALUE",
											"Test" : "A"
										}
									}
								}
							}, 
							{ 
								"T-T" : "${Value}_${Test}:\n${Test}"
							}, 
							"#ForEachModule_CreateEntriesOnly_T-T AAA #ForEachModule_CreateEntriesOnly_T-T",
							MockedConsole()
						)
		
		self.builder.generate()
		
		generatedValue = "VALUE_A:\nA AAA VALUE_A:\nA"
		assert self.builder.writer.buffer == generatedValue, "Invalid value generated."		

	def test_for_catching_replacement_sections(self):
		self.setUpBuilder()
		self.iterateMatches("#SectionName", [ "SectionName" ])		

	def test_for_invalid_catching_replacement_sections(self):
		self.setUpBuilder()
		for match in self.builder.findAllSections("SectionName"):
			self.fail("Invalid match found.")

	def test_for_catching_replacement_more_complicated_section_names(self):
		self.setUpBuilder()
		self.iterateMatches("#ForEachModule_CreateEntriesOnly_Template-Test", 
							[ 
								"ForEachModule_CreateEntriesOnly_Template-Test"
							])
		self.iterateMatches("#a1_1 #b2_2", [ "a1_1", "b2_2" ])
		self.iterateMatches("asdf\n#QWERTYUIOPasdfghjkl1234567890_-ZXCVBnm\nasadf", 
							[ 
								"QWERTYUIOPasdfghjkl1234567890_-ZXCVBnm" 
							])

	def test_for_saving_data_only_on_end(self):
		value = 'PASSED VALUE'
		self.setUpBuilder('', '', value)
		assert self.builder.writer.buffer == "", "Buffer wasn't empty on start."

		self.builder.generate()
		assert self.builder.writer.buffer == value, "Buffer wasn't empty on start."