import unittest
from IO.DirectorySniffer import DirectorySniffer

# Directory sniffer test case.
class TestClass(unittest.TestCase):
	def setUp(self):
		self.sniffer = DirectorySniffer("TestsData/SimpleDirectorySnifferTest")

	def test_which_loads_all_files_from_directory(self):
		files = self.sniffer.sniff("*.test")
		assert len(files) == 1, "DirectorySniffer cannot find any files in specified place."

	def test_sniff_without_path_only_extension_and_filename(self):
		files = self.sniffer.bareSniff("*.test")
		assert files[0].find("TestsData") == -1, "DirectorySniffer cannot find only bare filename without paths."

	def test_sniff_without_path_and_extension_only_filename(self):
		files = self.sniffer.sniffOnlyNames("*.test")
		assert files[0].find(".test") == -1, "DirectorySniffer cannot find only bare filename without paths and ext."

	def test_which_loads_all_files_from_nested_directories(self):
		files = self.sniffer.sniffOnlyNames("*.test2")
		assert len(files) == 2, "DirectorySniffer cannot find any files in nested dirs."
		assert files[1].find("Nested") != -1, "DirectorySniffer cannot find any files in nested dirs."