import unittest
from Generator import Generator

from IO.DirectorySniffer import DirectorySniffer

class TestClass(unittest.TestCase):
	def setUp(self):
		self.generator = Generator()

	def test_which_checks_existance_of_output_path(self):		
		assert self.generator.OutputPath != None, "Invalid output path inside Generator class."

	def test_which_checks_existance_of_output_filename(self):				
		assert self.generator.OutputFileName != None, "Invalid output filename inside Generator class."		

	def test_which_checks_existance_of_output_patterns(self):		
		assert len(self.generator.Output) == 2, "Missing output patterns."
		assert self.generator.Output["G"][0] == ".g", "Missing output patterns."
		assert self.generator.Output["STG"][0] == ".stg", "Missing output patterns."

	def test_which_checks_existance_of_dictionaries(self):
		assert self.generator.modules != None, "Missing modules dictionary."
		assert self.generator.parts != None, "Missing partial templates dictionary."
		assert self.generator.base != None, "Missing base templates dictionary."

	def test_which_splits_path_to_filename(self):
		assert self.generator.onlyFileName('Fake/Path/To/FileName.withExt') == 'FileName'

	def test_which_prepares_dictionaries(self):
		self.generator.fillDictionaries()

		assert len(self.generator.modules) > 0, "Modules were not filled properly."
		assert len(self.generator.parts) > 0, "Parts were not filled properly."
		assert len(self.generator.base) > 0, "Base files were not filled properly."

	def test_which_parses_and_validates_each_module_file(self):
		self.generator.fillDictionaries()
		self.generator.parseAndValidateModules()

		assert len(self.generator.ModulesObjects) > 0, "Modules can't be validated and parsed."

	def test_which_checks_error_existance_after_validation(self):
		self.generator.modules["Test"] = "{ '";

		try:
			self.generator.parseAndValidateModules()
			self.fail("AttributeError wasn't thrown by parseAndValidateModules")
		except AttributeError:
			pass
	
	def test_which_checks_console_existance(self):
		assert self.generator.console != None, "Console object doesn't exist."

	def test_which_checks_writers_existance(self):
		assert self.generator.Output["G"][1] != None, "Grammar file writer doesn't exist."
		assert self.generator.Output["STG"][1] != None, "Templates file writer doesn't exist."

	def test_which_checks_operation_writing_files(self):
		self.generator.saveAllFiles()
		assert len(DirectorySniffer(self.generator.OutputPath).sniff("*.*g")) == 2

	def test_for_veryfing_environment(self):
		assert self.generator.detector.isJavaRuntimeEnvironmentPresent() == True, "JRE is missing."
		assert self.generator.detector != None, "Detector wasn't present in Generator module."
		
	def test_for_input_filename_getter(self):
		fileName = self.generator.OutputFileName + ".g"
		assert self.generator.getInputFileName() == fileName, "Invalid input filename."

	def test_ANTLR_invoker_parameters(self):
		parameters = self.generator.getToolParameters()
		
		assert parameters[0] == '-cp', "Missing invoke parameter for JAR archive."
		assert parameters[2] == 'org.antlr.Tool', "Missing start class parameter."
		assert parameters[-3] == '-fo', "Missing force output path."

	def test_ANTLR_error_formatter(self):
		value = self.generator.getToolErrorMessage({ "stderr" : "TEST VALUE" })
		assert value.find("TEST VALUE") != -1, "Missing stderr in ANTLR error report."