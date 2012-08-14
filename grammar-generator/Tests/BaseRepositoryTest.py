import unittest
from Repositories.BaseRepository import BaseRepository

class TestClass(unittest.TestCase):
	def setUp(self):
		self.repository = BaseRepository()

	def test_which_checks_existance_of_directory_constant(self):
		assert self.repository.BaseDirectory != None, "BaseRepository doesn't have constant path to base files."

	def test_which_loads_all_files_from_directory(self):
		files = self.repository.loadAll()
		assert len(files) > 0, "PartsRepository can't load all files from directory."		