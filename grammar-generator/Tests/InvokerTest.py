import subprocess
import unittest
from CLI.Invoker import Invoker

# Mocked subprocess communication handle.
class MockedHandle:
	def __init__(self, command):
		self.command = command
	
	def communicate(self):
		if self.command == "PAUSE":
			return ('Please wait...', '')
		else:
			return ('', '')

	def poll(self):
		return 0

# Mocked subprocess API.
class MockedSubprocessAPI:
	def __init__(self):
		self.commands = []
		self.PIPE = 0

	def Popen(self, command, stdout, stderr):
		self.commands.append(command)
		return MockedHandle(command)

	def getLastCommandExecuted(self):
		return self.commands[len(self.commands) - 1]

# Command line invoker test case.
class TestClass(unittest.TestCase):
	def setUp(self):
		self.invoker = Invoker(MockedSubprocessAPI())

	def test_command_line_object_existance(self):		
		assert self.invoker.subprocess != None, "Subprocess API object inside Invoker doesn't exist."

	def test_command_invoke(self):
		self.invoker.executeCommand("PAUSE")
		assert 	self.invoker.subprocess.getLastCommandExecuted() == "PAUSE"

	def test_invoke_command_with_argument(self):
		self.invoker.executeCommandWithParams("PAUSE", "a")
		assert self.invoker.subprocess.getLastCommandExecuted() == "PAUSE a"

	def test_invoke_command_with_many_arguments(self):
		self.invoker.executeCommandWithParams("PAUSE", "a", "b", "c")
		assert 	self.invoker.subprocess.getLastCommandExecuted() == "PAUSE a b c"

	def test_invoke_command_and_redirect_stdout(self):
		result = self.invoker.executeCommand("PAUSE")
		assert result["stdout"] == 'Please wait...', "Module cannot redirect stdout stream."