class Invoker:
	def __init__(self, subprocessAPI):
		self.subprocess = subprocessAPI

	def executeCommand(self, commandString):
		handle = self.subprocess.Popen( commandString,
										stdout = self.subprocess.PIPE,
										stderr = self.subprocess.PIPE)
		output, errors = handle.communicate()
		returnCode = handle.poll()

		return { "stdout" : output, "stderr" : errors, "ReturnCode" : returnCode }

	def executeCommandWithParams(self, commandString, *args):
		effectiveCommand = "%s " % commandString
		effectiveCommand += ' '.join(args)

		return self.executeCommand(effectiveCommand)
