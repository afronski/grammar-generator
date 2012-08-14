import unittest
from Repositories.PartsRepository import PartsRepository

class TestClass(unittest.TestCase):
	def setUp(self):
		self.repository = PartsRepository()

	def test_which_checks_existance_of_directory_constant(self):		
		assert self.repository.PartsDirectory != None, "PartsRepository doesn't have constant path to parts."

	def test_which_loads_all_files_from_directory(self):
		files = self.repository.loadAll()
		assert len(files) > 0, "PartsRepository can't load all files from directory."