import re
from CLI.Invoker import Invoker

class RequirementsDetector:
	def __init__(self, subprocessAPI):
		self.invoker = Invoker(subprocessAPI)

	def isJavaRuntimeEnvironmentPresent(self):
		result = self.invoker.executeCommandWithParams('java', '-version')
		return result["ReturnCode"] == 0