import sys

class Console:
	def __init__(self, output, name):
		self.separator = "*"
		self.separatorLength = 40

		self.step = 1

		self.name = name

		self.tabsLength = 2
		self.defaultTabs = "\t" * self.tabsLength

		self.output = output

	def printMessage(self, message):
		self.output.write(sys.stdout.fileno(), message)

	def printLine(self, message):
		self.output.write(sys.stdout.fileno(), message)
		self.output.write(sys.stdout.fileno(), "\n")
	
	def increaseIndent(self):
		self.tabsLength += 1
		self.defaultTabs = "\t" * self.tabsLength

	def decreaseIndent(self):
		if self.tabsLength > 0:
			self.tabsLength -= 1

		self.defaultTabs = "\t" * self.tabsLength		

	def writeWithIndent(self, message):
		self.printLine("%s%s" % (self.defaultTabs, message))

	def writeError(self, errorMessage):
		self.writeWithIndent(errorMessage)

	def writeStep(self, message):
		self.printLine("%s[%s]\t%s" % (self.defaultTabs, '{:>2}'.format(self.step), message))
		self.step += 1

	def writeSeparatorLine(self):
		self.printLine(self.separator * self.separatorLength)

	def writeStartHeader(self):
		self.writeSeparatorLine()
		self.printLine("\t%s - START" % (self.name))

	def writeEndHeader(self):	
		self.printLine("\t%s - END" % (self.name))
		self.writeSeparatorLine()