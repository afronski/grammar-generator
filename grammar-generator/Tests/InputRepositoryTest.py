import unittest
from Repositories.InputRepository import InputRepository

class TestClass(unittest.TestCase):
	def setUp(self):
		self.repository = InputRepository()

	def test_which_checks_existance_of_directory_constant(self):
		assert self.repository.InputDirectory != None, "Repository doesn't have constant path to input files."

	def test_which_loads_all_files_from_directory(self):
		files = self.repository.loadAll()
		assert len(files) > 0, "InputRepository can't load all files from directory."