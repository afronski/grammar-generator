import unittest
from IO.FileReader import FileReader

# File reader test case.
class TestClass(unittest.TestCase):
	def setUp(self):
		self.reader = FileReader()

	def test_which_load_whole_file_to_string(self):
		content = self.reader.getContent("TestsData/FileReaderTest/SimpleFile.test")
		assert content == "Sample content from test file", "Read content from file."

	def test_which_load_whole_file_to_string_with_many_lines(self):
		content = self.reader.getContent("TestsData/FileReaderTest/SimpleFileWithEOLs.test")
		assert content == "Sample\nSample\n\nSample", "Read content with many lines."