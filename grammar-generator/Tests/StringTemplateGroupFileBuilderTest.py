import unittest
from Builders.StringTemplateGroupFileBuilder import StringTemplateGroupFileBuilder

# Mocked console.
class MockedConsole:
	def __init__(self):
		self.indent = 2

	def increaseIndent(self):
		self.indent += 1

	def decreaseIndent(self):
		self.indent -= 1

	def writeWithIndent(self, message):
		pass		

# Mocked file writer.
class MockedFileWriter:
	def __init__(self, directory):
		self.buffer = ''

	def pushData(self, dataString):
		self.buffer += dataString

	def saveWithFileName(self, fileName):
		pass

class TestClass(unittest.TestCase):
	def setUpBuilder(self, modules, templates, base):
		self.builder = 	StringTemplateGroupFileBuilder(
							MockedFileWriter(''), 
							modules, 
							templates, 
							base, 
							MockedConsole()
						)

	def test_for_pushing_base_state_to_writer(self):
		self.setUpBuilder({}, {}, 'START VALUE')
		assert self.builder.writer.buffer == 'START VALUE', "Base wasn't passed into writer on start."

	def test_exception_about_missing_prefix(self):
		self.setUpBuilder(
			{
				"ValidModule": 
				{ 
					"DateParameters" : { "DateParameter" : { "ModuleName" : "INJECTED" } } 
				}
			},
			{},
			'START VALUE'
		)

		try:
			self.builder.generate()
			self.fail("Not thrown EnvironmentError about missing 'ModulePrefix' attribute.")
		except EnvironmentError:
			pass

	def test_for_simple_generation(self):
		self.setUpBuilder(			
			{
				"ValidModule": 
				{ 
					"ModulePrefix" : "prefix",
					"DateParameters" : { "DateParameter" : { "ModuleName" : "INJECTED" } } 
				}
			},
			{ 
				"DateTypeFilteringColumn": "${ModuleName} VALUE\n",
				"SimpleVisibledColumn": "${ModuleName} VALUE\n",
				"SortingColumn": "${ModuleName} VALUE\n" 
			}, 
			'START'
		)
		
		self.builder.generate()

		assert self.builder.factoriesAndResults["Filtering"][0][0].resolve() == 'INJECTED VALUE\n'
		assert self.builder.factoriesAndResults["Visible"][0][0].resolve() == 'INJECTED VALUE\n'
		assert self.builder.factoriesAndResults["Sorting"][0][0].resolve() == 'INJECTED VALUE\n'

	def test_for_column_ID_generation(self):
		self.setUpBuilder(			
			{
				"ValidModule": 
				{ 
					"ModulePrefix" : "prefix",
					"DateParameters" : 
					{ 
						"DateParameter" : { "ModuleName" : "INJECTED", "ColumnNameForID" : "VALUE" } 
					} 
				}
			},
			{ 
				"DateTypeFilteringColumn": "${ModuleName} ${ColumnNameForID}\n",
				"VisibledColumnWithID": "${ModuleName} ${ColumnNameForID}\n",
				"SortingColumnWithID": "${ModuleName} ${ColumnNameForID}\n" 
			}, 
			'START'
		)
		
		self.builder.generate()

		assert self.builder.factoriesAndResults["Filtering"][0][0].resolve() == 'INJECTED VALUE\n'
		assert self.builder.factoriesAndResults["Visible"][0][0].resolve() == 'INJECTED VALUE\n'
		assert self.builder.factoriesAndResults["Sorting"][0][0].resolve() == 'INJECTED VALUE\n'

	def test_for_specified_columns_generation(self):
		self.setUpBuilder(			
			{
				"ValidModule": 
				{ 
					"ModulePrefix" : "prefix",
					"DateParameters" : 
					{ 
						"DateParameter" : 
						{ 
							"ModuleName" : "INJECTED", 
							"VisibleColumnName" : "VISIBLE",
							"SortingColumnName" : "SORTING"
						} 
					} 
				}
			},
			{ 
				"DateTypeFilteringColumn": "${ModuleName} VALUE\n",
				"SpecifiedVisibledColumn": "${ModuleName} ${VisibleColumnName}\n",
				"SpecifiedSortingColumn": "${ModuleName} ${SortingColumnName}\n" 
			}, 
			'START'
		)
		
		startIndent = self.builder.console.indent
		self.builder.generate()

		assert self.builder.factoriesAndResults["Filtering"][0][0].resolve() == 'INJECTED VALUE\n'
		assert self.builder.factoriesAndResults["Visible"][0][0].resolve() == 'INJECTED VISIBLE\n'
		assert self.builder.factoriesAndResults["Sorting"][0][0].resolve() == 'INJECTED SORTING\n'

		assert self.builder.console.indent == startIndent, "Indentation balance is broken."