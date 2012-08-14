import subprocess
import unittest

from Environment.RequirementsDetector import RequirementsDetector

class TestClass(unittest.TestCase):
	def test_check_JRE_existance_for_this_machine(self):
		detector = RequirementsDetector(subprocess)
		result = detector.isJavaRuntimeEnvironmentPresent()

		assert result == True, "This machine doesn't have JRE."