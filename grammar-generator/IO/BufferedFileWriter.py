import os

class BufferedFileWriter:
	def __init__(self, directory):
		self.directory = directory.strip('/')
		self.buffer = ''

	def saveWithFileName(self, fileName):
		fileName = fileName.strip('/')

		self.outputStream = open(os.path.join(self.directory, fileName), "w")
		self.outputStream.write(self.buffer)
		self.outputStream.close()

	def pushData(self, dataString):
		self.buffer += dataString