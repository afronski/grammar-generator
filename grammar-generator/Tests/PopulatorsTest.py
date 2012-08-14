import unittest
from Elements.G.Populators.OnlyEntriesPopulator import OnlyEntriesPopulator
from Elements.G.Populators.ParameterListPopulator import ParameterListPopulator

class TestClass(unittest.TestCase):
	def setUpEntriesPopulator(self, name, templates = { "Name" : "" }, settings = {}):
		self.entriesPopulator = OnlyEntriesPopulator(name, templates, settings)

	def setUpParameterListPopulator(self, 
									name,
									templates = { "Name" : "" },
									settings = { "ModulePrefix" : "" }):
		self.listPopulator = ParameterListPopulator(name, templates, settings)

	def test_for_entries_only_populator(self):
		self.setUpEntriesPopulator("Name")
		assert self.entriesPopulator.getType() == "CreateEntriesOnly", "Invalid type for entries populator."

	def test_for_entries_population(self):
		self.setUpEntriesPopulator(
			"Name_Name_Template-Test", 
			{ 
				"Template-Test" : "${Temp}_${Test}:\n${Test}\n;"
			},
			{ 
				"ModuleLongName" : "",
				"ModuleShortName" : "",
				"ModulePrefix" : "",
				"Template" : 
				{
					"A" :
					{
						"Name" : "",
						"Temp" : "users",
						"Test" : "A"
					}
				}
			})
		
		assert self.entriesPopulator.populate() == "users_A:\nA\n;", "Invalid template resolving"
		
	def test_for_many_entries_population(self):
		self.setUpEntriesPopulator(
			"Name_Name_Template-Test", 
			{ 
				"Template-Test" : "${Temp}_${Test}:\n${Test}\n;"
			},
			{ 
				"ModuleLongName" : "",
				"ModuleShortName" : "",	
				"ModulePrefix" : "",		
				"Template" : 
				{
					"A" :
					{
						"Name" : "",
						"Temp" : "users",
						"Test" : "A"
					},
					"B" :
					{
						"Name" : "",
						"Temp" : "users",
						"Test" : "B"
					}					
				}
			})
		
		assert self.entriesPopulator.populate() == "users_A:\nA\n;,\nusers_B:\nB\n;"

	def test_for_missing_template_for_entries_population(self):
		try:
			self.setUpEntriesPopulator(
				"Name_Name_Template-Test", 
				{ 
					"OtherTemplate" : ""
				}, 
				{ 
					"Module" : {}
				})									

			self.fail("No exception for missing template in dictionary.")
		except AttributeError:
			pass

	def test_for_simple_creation_list_populator(self):
		self.setUpParameterListPopulator("Name-Test")
		assert self.listPopulator.getType() == "CreateParametersListWithName", "Invalid type name."

	def test_for_param_list_population(self):
		self.setUpParameterListPopulator(
			"Name_Name_TemplateParameters-Test", 
			{ 
				"TemplateParameters" : "${Temp}_${Test}:\n${Test}"
			},
			{ 
				"ModuleLongName" : "",
				"ModuleShortName" : "",			
				"ModulePrefix" : "users",
				"TemplateParameters" : 
				{
					"A" :
					{
						"Name" : "",
						"Temp" : "users",
						"Test" : "A"
					}
				}
			})
		
		assert self.listPopulator.populate() == "users_test:\nusers_A:\nA\n;", "Invalid template resolving"

	def test_for_many_param_list_population(self):
		self.setUpParameterListPopulator(
			"Name_Name_TemplateParameters-Test", 
			{ 
				"TemplateParameters" : "${Temp}_${Test}:\n${Test}"
			},
			{ 
				"ModuleLongName" : "",
				"ModuleShortName" : "",			
				"ModulePrefix" : "users",
				"TemplateParameters" : 
				{
					"A" :
					{
						"Name" : "",
						"Temp" : "users",
						"Test" : "A"
					},
					"B" :
					{
						"Name" : "",
						"Temp" : "users",
						"Test" : "B"
					}					
				}
			})
		
		assert self.listPopulator.populate() == "users_test:\nusers_A:\nA|\nusers_B:\nB\n;"