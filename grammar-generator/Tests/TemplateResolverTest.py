import unittest
from Content.TemplateResolver import TemplateResolver

class TestClass(unittest.TestCase):	
	def test_which_handles_resolving_simple_template(self):
		templatesRepository = { "SampleTemplate" : 'Simple ${test}' }
		resolver = TemplateResolver(templatesRepository, "SampleTemplate")

		data = {}
		data["test"] = "TEST!"
		content = resolver.fill(data)

		assert content == 'Simple TEST!', "Template wasn't resolved properly."
		
	def test_which_handles_inproper_data_dictionary_without_some_parameters(self):
		templatesRepository = { "SampleTemplate" : '${first} ${second} ${third}' }
		resolver = TemplateResolver(templatesRepository, "SampleTemplate")

		data = {}
		data["first"] = "FIRST"
		data["third"] = "THIRD"
		content = resolver.fill(data)

		assert content == "FIRST ${second} THIRD", "Template wasn't resolved properly."