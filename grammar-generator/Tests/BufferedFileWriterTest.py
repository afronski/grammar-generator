import os
import unittest
from IO.BufferedFileWriter import BufferedFileWriter
from IO.FileReader import FileReader

# Buffered file writer test case.
class TestClass(unittest.TestCase):
	def setUp(self):
		self.testsDataDirectory = "TestsData/BufferedFileWriterTest"
		self.writer = BufferedFileWriter(self.testsDataDirectory)
		self.reader = FileReader()

	def test_which_handles_ending_slash_or_backslash(self):
		endingSlashWriter = BufferedFileWriter('/test/test/')		
		assert endingSlashWriter.directory == 'test/test', 'Directory path for file writter has ending slashes.'

	def test_which_saves_empty_file_into_the_specified_place(self):
		fileName = "emptyFileTest"
		self.writer.saveWithFileName(fileName);

		content = self.reader.getContent(os.path.join(self.testsDataDirectory, fileName))
		assert content == "", "Empty string read from file (without exceptions)."

	def test_which_saves_empty_file_with_invalid_ending_slash(self):
		fileName = "/emptyFileTest/"
		self.writer.saveWithFileName(fileName);

		content = self.reader.getContent(os.path.join(self.testsDataDirectory, fileName.strip('/')))
		assert content == "", "Empty string read from file (without exceptions)."		

	def test_which_handles_pushing_data_into_buffer(self):		
		value = 'Test data value'

		self.writer.pushData(value)
		assert self.writer.buffer == value, "Buffer wasn't filled properly."

	def test_which_handles_pushing_data_with_EOLs_into_buffer(self):
		value = 'Test data value\r\n\t\r\nTest Data Value'

		self.writer.pushData(value)
		assert self.writer.buffer == value, "Buffer wasn't filled properly."

	def test_which_handles_appending_into_buffer(self):
		self.writer.pushData('A')
		self.writer.pushData('B')
		self.writer.pushData('C')

		assert self.writer.buffer == 'ABC', "Buffer wasn't adjusted for appending data."

	def test_which_handles_saving_data_from_buffer(self):
		fileName = 'filledFileTest'
		value = 'ABC'

		self.writer.pushData(value)
		self.writer.saveWithFileName(fileName)

		content = self.reader.getContent(os.path.join(self.testsDataDirectory, fileName))
		assert content == value, "Buffered Writer wasn't adjusted for saving data."

	def test_which_handles_saving_data_with_EOL_characters(self):
		fileName = 'filledFileWithEOLsTest'
		value = 'A\r\nB\r\nC'

		self.writer.pushData(value)
		self.writer.saveWithFileName(fileName)

		content = self.reader.getContent(os.path.join(self.testsDataDirectory, fileName))
		assert content == value, "Buffered Writer wasn't adjusted for saving data with EOLs."
		
	def test_which_handles_appending_data_into_file(self):
		fileName = 'fileForAppendingTest'

		self.writer.pushData('A')
		self.writer.saveWithFileName(fileName)
		self.writer.pushData('B')
		self.writer.saveWithFileName(fileName)
		self.writer.pushData('C')
		self.writer.saveWithFileName(fileName)		

		content = self.reader.getContent(os.path.join(self.testsDataDirectory, fileName))
		assert content == 'ABC', "Buffered Writer wasn't adjusted for appending into file."